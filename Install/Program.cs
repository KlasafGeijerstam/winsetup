using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Install
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "/winsetup.exe"))
            {
                File.Copy("winsetup.exe", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "/winsetup.exe");
                File.Copy("Fizzler.dll", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "/Fizzler.dll");
                File.Copy("Fizzler.Systems.HtmlAgilityPack.dll", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "/Fizzler.Systems.HtmlAgilityPack.dll");
                File.Copy("HtmlAgilityPack.dll", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "/HtmlAgilityPack.dll");
                if (!File.Exists("init.txt"))
                    File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "init.txt").Close();
            }

        }
    }
}
