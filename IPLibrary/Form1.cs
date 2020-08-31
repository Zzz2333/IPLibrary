using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strIp = textBox1.Text.Trim();

            IPHelper seeker = new IPHelper();
            IPLocation location = seeker.GetIpLocation(IPAddress.Parse(strIp));

            textBox2.Text = location.Country + location.Zone;
        }
    }
}
