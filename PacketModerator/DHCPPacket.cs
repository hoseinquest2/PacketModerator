using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketModerator
{
    class DHCPPacket : Packet
    {

        
        public DHCPPacket()
        {
            var x = PacketDotNet.IpPacket.RandomPacket(PacketDotNet.IpVersion.IPv4);


        }


    }
}
