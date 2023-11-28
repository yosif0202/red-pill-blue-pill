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
    public partial class jediview2 : Form
    {
        public jediview2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           bluelightsaberview bluelightsaberview = new bluelightsaberview();
            bluelightsaberview.Show();  
            Hide();
        }
    }
}
