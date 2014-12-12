using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketModerator
{
    public class CDP
    {
        const ushort CDP_VERSION = 0x01;
        const ushort CDP_TYPE_DEVID = 0x0001;
        const ushort CDP_TYPE_ADDRESS = 0x0002;
        const ushort CDP_TYPE_PORTID = 0x0003;
        const ushort CDP_TYPE_CAPABILITY = 0x0004;
        const ushort CDP_TYPE_VERSION = 0x0005;
        const ushort CDP_TYPE_PLATFORM = 0x0006;
        const ushort CDP_TYPE_IPPREFIX = 0x0007;
        const ushort CDP_TYPE_PROTOCOL_HELLO = 0x0008;
        const ushort CDP_TYPE_VTP_MGMT_DOMAIN = 0x0009;
        const ushort CDP_TYPE_NATIVE_VLAN = 0x000A;
        const ushort CDP_TYPE_DUPLEX = 0x000B;
        const ushort CDP_TYPE_VOIP_VLAN_REPLY = 0x000E;
        const ushort CDP_TYPE_VOIP_VLAN_QUERY = 0x000F;
        const ushort CDP_TYPE_MTU = 0x0011;
        const ushort CDP_TYPE_TRUST_BITMAP = 0x0012;
        const ushort CDP_TYPE_UNTRUSTED_COS = 0x0013;
        const ushort CDP_TYPE_SYSTEM_NAME = 0x0014;
        const ushort CDP_TYPE_SYSTEM_OID = 0x0015;
        const ushort CDP_TYPE_MANAGEMENT_ADDR = 0x0016;
        const ushort CDP_TYPE_LOCATION = 0x0017;

        const ushort CDP_CAP_LEVEL3_ROUTING = 0x01;
        const ushort CDP_CAP_LEVEL2_TRANS_BRIDGE = 0x02;
        const ushort CDP_CAP_LEVEL2_SROUTE_BRIDGE = 0x04;
        const ushort CDP_CAP_LEVEL2_SWITCH = 0x08 /*w;thout STP */;
        const ushort CDP_CAP_LEVEL3_ENABLE = 0x10;
        const ushort CDP_CAP_NON_FORW_IGMP = 0x20;
        const ushort CDP_CAP_LEVEL1 = 0x40;
        const ushort CDP_TLV_TYPE = 0;
        const ushort CDP_SMAC = 0;
        const ushort CDP_DMAC = 1;
        const ushort CDP_VER = 2;
        const ushort CDP_TTL = 3;
        const ushort CDP_CHECKSUM = 4;
        const ushort CDP_TLV = 5;



        public string CalculateChecksum(string dataToCalculate)
        {
            byte[] byteToCalculate = Encoding.ASCII.GetBytes(dataToCalculate);
            int checksum = 0;
            foreach (byte chData in byteToCalculate)
            {
                checksum += chData;
            }
            checksum &= 0xff;
            return checksum.ToString("X2");
        }

        public static string CalculateChecksum(byte[] dataToCalculate)
        {
            byte[] byteToCalculate = dataToCalculate;
            int checksum = 0;
            foreach (byte chData in byteToCalculate)
            {
                checksum += chData;
            }
            checksum &= 0xffff;
            return checksum.ToString("X4");
        }

        public static byte ComputeAdditionChecksum(byte[] data)
        {
            byte sum = 0;
            unchecked // Let overflow occur without exceptions
            {
                foreach (byte b in data)
                {
                    sum += b;
                }
            }
            return sum;
        }

       
     

    }


}
