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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 window8 = new Form8();
            window8.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 window11 = new Form11();
            window11.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form13 window13 = new Form13();
            window13.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 window15 = new Form15();
            window15.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form17 window17 = new Form17();
            window17.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form19 window19 = new Form19();
            window19.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form20 window20 = new Form20();
            window20.Show();
        }
    }
}
