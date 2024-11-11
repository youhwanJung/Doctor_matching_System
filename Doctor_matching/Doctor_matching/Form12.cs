using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_matching
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 window7 = new Form11();
            window7.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 window10 = new Form10();
            window10.Show();
        }
    }
}
