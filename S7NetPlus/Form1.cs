using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S7NetPlus
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaticClass.IP_Address = textBox1.Text;
            StaticClass.plc.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaticClass.plc.Close();
        }
    }
}
