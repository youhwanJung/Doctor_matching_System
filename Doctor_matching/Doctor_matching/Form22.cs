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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("진료과 저장 완료!");
            Form21 window21 = new Form21();
            window21.Show();
            this.Hide();

        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
