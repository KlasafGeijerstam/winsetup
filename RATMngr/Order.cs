using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RATMngr
{
    class Order
    {
        public static int MaxId { get; set; }
        public Order(int iD, string type, string data)
        {
            ID = iD;
            if (ID > MaxId)
                MaxId = ID;
            Type = type;
            Data = data;
        }

        public override string ToString()
        {
            return $"{ID};{Type};{Data}";
        }

        public int ID { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }
    }
}
