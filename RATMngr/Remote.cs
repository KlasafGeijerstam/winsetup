using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RATMngr
{
    class Remote
    {
        public Remote(Guid iD, string friendlyName)
        {
            ID = iD;
            FriendlyName = friendlyName;
        }

        public override string ToString()
        {
            return FriendlyName;
        }

        public Guid ID { get; set; }
        public string FriendlyName { get; set; }
        public bool MoveMouse { get; set; }
        public int MouseIntensity { get; set; }
        public int MouseInterval { get; set; }
        public bool RandomKeys { get; set; }
        public int KeyInterval { get; set; }
    }
}
