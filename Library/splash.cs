using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }
        int counter;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 500)
            {
                timer1.Enabled = false;
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
    }
}
