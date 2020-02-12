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
    public partial class AddVicationPlace : Form
    {
        XDocument doc;
        public AddVicationPlace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doc = XDocument.Load(ConfigurationManager.AppSettings["xmlFilePath"]);
            XElement elem = new XElement(Form1.VACATION, Form1.VACATION);
            var v = doc.Descendants(Form1.VACATION).Last().Attribute("id");

            elem.Add(new List<XAttribute> { new XAttribute("name", textBox1.Text), new XAttribute("id", v) });
            elem.Add(new XElement(LOCATION,))
           
            doc.Save(spath);
        }
    }
}
