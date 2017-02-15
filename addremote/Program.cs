using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace addremote
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
                return;
            var arr = args[1].Split(';');
            if(args[0] == "add")
            {

                XmlDocument document = new XmlDocument();
                document.Load("rem.html");
                var node = document.CreateElement("rem");

                node.SetAttribute("uid", arr[2]);
                node.SetAttribute("friendly", arr[0] + ";" + arr[1]);

                node.SetAttribute("moveMouse", "false");
                node.SetAttribute("mouseIntensity", "0");
                node.SetAttribute("mouseInterval", "0");
                node.SetAttribute("randomKeys", "false");
                node.SetAttribute("keyInterval", "0");
                document.DocumentElement.FirstChild.AppendChild(node);
                document.Save("rem.html");

            }
            else if(args[0] == "rorder")
            {
                try
                {
                    XmlDocument document = new XmlDocument();
                    document.Load("rem.html");
                    XmlNode toRem = null;

                    foreach (XmlNode n in document.DocumentElement.FirstChild.ChildNodes)
                    {
                        if(n.Attributes["uid"].Value == arr[0])
                            foreach (XmlNode sn in n.ChildNodes)
                            {
                                if (sn.Attributes["oid"].Value == arr[1])
                                {
                                    toRem = sn;
                                    break;
                                }
                            }
                        if(toRem != null)
                        {
                            n.RemoveChild(toRem);
                            break;
                        }

                    }
                    document.Save("rem.html");
                }
                catch (Exception)
                {
  
                }
            }
        }
    }
}
