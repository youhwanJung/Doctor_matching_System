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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form28 window28 = new Form28();
            window28.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form27 window27 = new Form27();
            window27.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("정보가 수정되었습니다!");
            Form24 window24 = new Form24();
            window24.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 window24 = new Form24();
            window24.Show();
            this.Hide();
        }
    }
}
