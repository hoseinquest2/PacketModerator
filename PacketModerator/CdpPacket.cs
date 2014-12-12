using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PacketModerator
{
    class CdpPacket : Packet
    {

       
        List<ushort> LengthOctets;
        List<ushort> LogicalLink;

        ushort[] PacketLength = new ushort[2];//(12-13)
        ushort[] VERSION_TTL = new ushort[2];//(22-23)

        List<TLV> TLVs = new List<TLV>();

        public int PacketDataLength
        {
            get
            {
                //2 byte for version_tlv and 2 for checksum
                int length = 4;
                length += LogicalLink.Count;
                foreach (TLV item in TLVs)
                    length += item.TotalLength;
                return length;
            }
        }

        public byte[] PacketBytes
        {
            get
            {
                byte[] packet = new byte[PacketDataLength + 14];//14 for ethernet

                for (int i = 0; i <= 5; i++)
                    packet[i] = BitConverter.GetBytes(DestinationMac[i])[0];

                for (int i = 6; i <= 11; i++)
                    packet[i] = BitConverter.GetBytes(SourceMac[i-6])[0];

                packet[12] = BitConverter.GetBytes(PacketDataLength)[1];
                packet[13] = BitConverter.GetBytes(PacketDataLength)[0];

                for (int i = 14; i <= 21; i++)
                    packet[i] = BitConverter.GetBytes(LogicalLink[i-14])[0];

                packet[22] = BitConverter.GetBytes(VERSION_TTL[0])[0];
                packet[23] = BitConverter.GetBytes(VERSION_TTL[1])[0];

                //25,24 for checksum
                packet[24] = 0;
                packet[25] = 0;

                List<byte> byteForChecksum = new  List<byte>();
                byteForChecksum.Add(packet[22]);
                byteForChecksum.Add(packet[23]);
                byteForChecksum.Add(packet[24]);
                byteForChecksum.Add(packet[25]);

                int LastIndex = 26;
                foreach (TLV item in TLVs)
                { 
                   int i;
                   var tlvBytes = item.TlvBytes;
                   for (i = LastIndex; i < tlvBytes.Count() + LastIndex; i++)
                   {
                       packet[i] = tlvBytes[i - LastIndex];
                       byteForChecksum.Add(packet[i]);
                   }
                      // 
                   LastIndex = i;
                }
                

                var checksum = PacketDotNet.Utils.ChecksumUtils.OnesComplementSum(byteForChecksum.ToArray());
                string hex = checksum.ToString("X");

                //if length od checksum less than 4
                if (hex.Length == 3)
                    hex = "0" + hex;
                else if(hex.Length ==2)
                    hex = "00" + hex;
                else if (hex.Length == 1)
                    hex = "000" + hex;

                packet[24] = StringToByteArray(hex.Substring(0, 2))[0];
                packet[25] = StringToByteArray(hex.Substring(2, 2))[0]; ;//CHECKSUM


                return packet;
            }
        }

        public CdpPacket() : base()
        {
            
            LengthOctets = new List<ushort>();


            //----------------------------------Destination MAC(0-5)
            DestinationMac = new List<ushort>();
            {
                DestinationMac.Add(0x01);
                DestinationMac.Add(0x00);
                DestinationMac.Add(0x0c);
                DestinationMac.Add(0xcc);
                DestinationMac.Add(0xcc);
                DestinationMac.Add(0xcc);

            };


            //----------------------------------Source MAC(6-11)
            SourceMac = new List<ushort>();
            {
                SourceMac.Add(0x00);
                SourceMac.Add(0x07);
                SourceMac.Add(0x85);
                SourceMac.Add(0x12);
                SourceMac.Add(0x34);
                SourceMac.Add(0x56);

            };



            //----------------------------------Logincal Link Layer(14-21)
            LogicalLink = new List<ushort>();
            {
                LogicalLink.Add(0xaa);
                LogicalLink.Add(0xaa);
                LogicalLink.Add(0x03);
                LogicalLink.Add(0x00);
                LogicalLink.Add(0x00);
                LogicalLink.Add(0x0c);
                LogicalLink.Add(0x20);
                LogicalLink.Add(0x00);
            };


            //---------------------------------Version_TTL
            VERSION_TTL[0] = 0x02;//CDP Version
            VERSION_TTL[1] = 0xb4;//TTL

        }


        //-------------------------Add TLV
        public void AddTLV(TLV tlv)
        {
            TLVs.Add(tlv);
        }
        public void AddTLV(CdpTypes type, String value)
        {
            TLVs.Add(new TLV(type, value));
        }


        public class TLV
        {

            CdpTypes TYPE;
            public int LENGTH, TotalLength;
            String VALUE;
            public List<ushort> ValueBytes = new List<ushort>();
            public List<ushort> TypeBytes = new List<ushort>();
            public List<ushort> TotalBytes = new List<ushort>();

            public byte[] TlvBytes 
            { 
                get 
                {
                    byte[] tlv = new byte[TotalLength];
                    tlv[0] = 0x00;//first of all types
                    tlv[1] = BitConverter.GetBytes(TypeBytes[1])[0];
                    tlv[2] = BitConverter.GetBytes(TotalLength)[1];
                    tlv[3] = BitConverter.GetBytes(TotalLength)[0];
                    for (int i = 0; i < ValueBytes.Count; i++)
                        tlv[i+4] = BitConverter.GetBytes(ValueBytes[i])[0];

                    return tlv;
                } 
            }

            public TLV(CdpTypes type, String value)
            {
                TYPE = type;
                VALUE = value;
                char[] chars = value.ToCharArray();
                foreach (char item in chars)
                {
                    string hexOutput = Convert.ToInt32(item).ToString("X");
                    ValueBytes.Add(ushort.Parse(hexOutput, System.Globalization.NumberStyles.HexNumber));
                }

                //
                TypeBytes.Add(0x00);
                TypeBytes.Add((ushort)type);
                LENGTH = chars.Count();
                TotalLength = LENGTH + 2 + 2;
            }


        }
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public enum CdpTypes : ushort
        {
            //   CDP_VERSION = 0x01,
            CDP_TYPE_DEVID = 0x0001,
            CDP_TYPE_ADDRESS = 0x0002,
            CDP_TYPE_PORTID = 0x0003,
            CDP_TYPE_CAPABILITY = 0x0004,
            CDP_TYPE_SOFTWARE_VERSION = 0x0005,
            CDP_TYPE_PLATFORM = 0x0006,
            CDP_TYPE_IPPREFIX = 0x0007,
            CDP_TYPE_PROTOCOL_HELLO = 0x0008,
            CDP_TYPE_VTP_MGMT_DOMAIN = 0x0009,
            CDP_TYPE_NATIVE_VLAN = 0x000A,
            CDP_TYPE_DUPLEX = 0x000B,
            CDP_TYPE_VOIP_VLAN_REPLY = 0x000E,
            CDP_TYPE_VOIP_VLAN_QUERY = 0x000F,
            CDP_TYPE_MTU = 0x0011,
            CDP_TYPE_TRUST_BITMAP = 0x0012,
            CDP_TYPE_UNTRUSTED_COS = 0x0013,
            CDP_TYPE_SYSTEM_NAME = 0x0014,
            CDP_TYPE_SYSTEM_OID = 0x0015,
            CDP_TYPE_MANAGEMENT_ADDR = 0x0016,
            CDP_TYPE_LOCATION = 0x0017,
            //CDP_CAP_LEVEL3_ROUTING = 0x01,
            //CDP_CAP_LEVEL2_TRANS_BRIDGE = 0x02,
            //CDP_CAP_LEVEL2_SROUTE_BRIDGE = 0x04,
            //CDP_CAP_LEVEL2_SWITCH = 0x08 /*w,thout STP */,
            //CDP_CAP_LEVEL3_ENABLE = 0x10,
            //CDP_CAP_NON_FORW_IGMP = 0x20,
            //CDP_CAP_LEVEL1 = 0x40,
            //CDP_TLV_TYPE = 0,
            //CDP_SMAC = 0,
            //CDP_DMAC = 1,
            //CDP_VER = 2,
            //CDP_TTL = 3,
            //CDP_CHECKSUM = 4,
            //CDP_TLV = 5
        }
    }
}
