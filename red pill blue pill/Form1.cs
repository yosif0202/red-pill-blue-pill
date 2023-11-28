using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace red_pill_blue_pill
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

        private void button1_Click(object sender, EventArgs e)
        {
            jediview2 jediview2 = new jediview2();
            jediview2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sithview1 sithview1 = new sithview1();  
            sithview1.Show();
            Hide();
        }
    }
}
