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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {


            dataGridView1.Rows.Add();
            Image doctor_image = Properties.Resources.doctor_ex2;
            dataGridView1.Rows[0].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            dataGridView1.Rows[0].Cells[1].Value = "정유환";
            dataGridView1.Rows[0].Cells[2].Value = "고려대병원";
            dataGridView1.Rows[0].Cells[3].Value = "3년";
            dataGridView1.Rows[0].Cells[4].Value = "10개";
            dataGridView1.Rows[0].Cells[5].Value = "20개";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[1].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            dataGridView1.Rows[1].Cells[1].Value = "남도현";
            dataGridView1.Rows[1].Cells[2].Value = "서울아산병원";
            dataGridView1.Rows[1].Cells[3].Value = "4년";
            dataGridView1.Rows[1].Cells[4].Value = "11개";
            dataGridView1.Rows[1].Cells[5].Value = "500개";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[2].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            dataGridView1.Rows[2].Cells[1].Value = "최지태";
            dataGridView1.Rows[2].Cells[2].Value = "삼성서울병원";
            dataGridView1.Rows[2].Cells[3].Value = "7년";
            dataGridView1.Rows[2].Cells[4].Value = "12개";
            dataGridView1.Rows[2].Cells[5].Value = "5030개";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[3].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            dataGridView1.Rows[3].Cells[1].Value = "집가고싶다";
            dataGridView1.Rows[3].Cells[2].Value = "가톨릭대서울성모병원";
            dataGridView1.Rows[3].Cells[3].Value = "1년";
            dataGridView1.Rows[3].Cells[4].Value = "13개";
            dataGridView1.Rows[3].Cells[5].Value = "530개";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 window7 = new Form7();
            window7.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 window9 = new Form9();
            window9.Show();
            this.Hide();
        }
    }
}
