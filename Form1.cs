using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace phoneapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.name = txtName.Text;
            c.number = txtnum.Text;
            string next = Serialization.serialize(c);
            File.WriteAllText("C:\\PHONEAPP\\Sereal.xml", next);
            MessageBox.Show("Saved");
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
