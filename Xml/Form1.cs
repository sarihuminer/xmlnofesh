using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Xml
{
    public partial class Form1 : Form
    {
        XDocument doc; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doc = XDocument.Load(ConfigurationManager.AppSettings["xmlFilePath"]);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {




            var v = doc.Descendants(VACATION).First(a => a.Attribute("id").Value == "0");
            textBox1.Text = v.Attribute("name").Value;
            textBox2.Text = v.Element(LOCATION).Value;
            textBox3.Text = v.Element(PRICE).Value;
            dataGridView1.DataSource = v.Element(ATRACTIONS).Elements(ATRACTION).Select(el => new { name =el.Value, cost = el.Attribute(PRICE).Value }).ToList();
            toolStrip1.Text = "שליפה תקינה !!";
        }
    }
}
