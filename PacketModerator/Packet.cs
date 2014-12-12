using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketModerator
{
    class Packet
    {
       protected List<ushort> DestinationMac;
        public List<ushort> SourceMac;

        public Packet()
        {
            DestinationMac = new List<ushort>();
            SourceMac = new List<ushort>();
        }
    }
}
