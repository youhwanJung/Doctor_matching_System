﻿using System;
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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form24_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1150, 600);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form25 window25 = new Form25();
            window25.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form26 window26 = new Form26();
            window26.Show();
        }
    }
}
