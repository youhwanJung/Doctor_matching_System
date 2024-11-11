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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();

            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "홍길동";
            dataGridView1.Rows[0].Cells[1].Value = "진료하는게 불친절해요 ㅠ";
            dataGridView1.Rows[0].Cells[2].Value = "6";
            dataGridView1.Rows[0].Cells[3].Value = "추천";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[1].Cells[0].Value = "동길동";
            dataGridView1.Rows[1].Cells[1].Value = "좋아요! 앞으로도 자주 이 의사한테 맡길 것 같아요!";
            dataGridView1.Rows[1].Cells[2].Value = "7";
            dataGridView1.Rows[1].Cells[3].Value = "추천";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[2].Cells[0].Value = "홍길홍";
            dataGridView1.Rows[2].Cells[1].Value = "신이 내린 의사가 아닐까요??";
            dataGridView1.Rows[2].Cells[2].Value = "7";
            dataGridView1.Rows[2].Cells[3].Value = "추천";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[3].Cells[0].Value = "홍동길";
            dataGridView1.Rows[3].Cells[1].Value = "이사람 의료사고 났다고 하던데 진짜인가요?";
            dataGridView1.Rows[3].Cells[2].Value = "7";
            dataGridView1.Rows[3].Cells[3].Value = "추천";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[4].Cells[0].Value = "길동홍";
            dataGridView1.Rows[4].Cells[1].Value = "이사람 너무 무섭게 생겼어요ㅠㅠㅠㅠㅠㅠㅠ";
            dataGridView1.Rows[4].Cells[2].Value = "10";
            dataGridView1.Rows[4].Cells[3].Value = "추천";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[5].Cells[0].Value = "홍홍홍";
            dataGridView1.Rows[5].Cells[1].Value = "홍박사님을 아세연~";
            dataGridView1.Rows[5].Cells[2].Value = "10";
            dataGridView1.Rows[5].Cells[3].Value = "추천";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[6].Cells[0].Value = "길길길";
            dataGridView1.Rows[6].Cells[1].Value = "이 시대의 최고의 의사! 정말 추천드립니다.";
            dataGridView1.Rows[6].Cells[2].Value = "2";
            dataGridView1.Rows[6].Cells[3].Value = "추천";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 window8 = new Form8();
            window8.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 window10 = new Form10();
            window10.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("즐겨찾기 되셨습니다!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form14 window14 = new Form14();
            window14.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("추천하셨습니다!");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form16 window16 = new Form16();
            window16.Show();
            this.Hide();
        }
    }
}
