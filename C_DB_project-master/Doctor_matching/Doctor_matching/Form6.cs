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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            string selectedRegion = comboBox2.SelectedItem.ToString();


            if (selectedRegion == "서울특별시")
            {
                // 서울시 선택 시
                comboBox3.Items.Add("종로구");
                comboBox3.Items.Add("중구");
                comboBox3.Items.Add("용산구");
                comboBox3.Items.Add("성동구");
                comboBox3.Items.Add("광진구");
                comboBox3.Items.Add("동내문구");
                comboBox3.Items.Add("중랑구");
                comboBox3.Items.Add("성북구");
                comboBox3.Items.Add("강북구");
                comboBox3.Items.Add("도봉구");
                comboBox3.Items.Add("노원구");
                comboBox3.Items.Add("은평구");
                comboBox3.Items.Add("서대문구");
                comboBox3.Items.Add("마포구");
                comboBox3.Items.Add("양천구");
                comboBox3.Items.Add("강서구");
                comboBox3.Items.Add("구로구");
                comboBox3.Items.Add("금천구");
                comboBox3.Items.Add("영등포구");
                comboBox3.Items.Add("동작구");
                comboBox3.Items.Add("서초구");
                comboBox3.Items.Add("강남구");
                comboBox3.Items.Add("송파구");
                comboBox3.Items.Add("강동구");

                // 다른 서울시 관련 구를 추가하세요
            }
            else if (selectedRegion == "경기도")
            {
                // 경기도 선택 시
                comboBox3.Items.Add("수원시");
                comboBox3.Items.Add("성남시");
                comboBox3.Items.Add("의정부시");
                comboBox3.Items.Add("안양시");
                comboBox3.Items.Add("부천시");
                comboBox3.Items.Add("광명시");
                comboBox3.Items.Add("동두천시");
                comboBox3.Items.Add("평택시");
                comboBox3.Items.Add("안산시");
                comboBox3.Items.Add("고양시");
                comboBox3.Items.Add("과천시");
                comboBox3.Items.Add("구리시");
                comboBox3.Items.Add("남양주시");
                comboBox3.Items.Add("오산시");
                comboBox3.Items.Add("시흥시");
                comboBox3.Items.Add("군포시");
                comboBox3.Items.Add("의왕시");
                comboBox3.Items.Add("하남시");
                comboBox3.Items.Add("용인시");
                comboBox3.Items.Add("파주시");
                comboBox3.Items.Add("이천시");
                comboBox3.Items.Add("안성시");
                comboBox3.Items.Add("김포시");
                comboBox3.Items.Add("화성시");
                comboBox3.Items.Add("광주시");
                comboBox3.Items.Add("양주시");
                comboBox3.Items.Add("포천시");
                comboBox3.Items.Add("여수시");
                comboBox3.Items.Add("연천군");
                comboBox3.Items.Add("가평군");
                comboBox3.Items.Add("양평군");

                // 다른 경기도 관련 시 또는 군을 추가하세요
            }



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 window7 = new Form7();
            window7.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
