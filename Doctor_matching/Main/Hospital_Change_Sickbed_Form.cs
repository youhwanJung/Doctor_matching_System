using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Hospital_Change_Sickbed_Form : Form
    {
        DBconn2 db = new DBconn2();
        decimal PK;
        public Hospital_Change_Sickbed_Form(decimal PK)
        {
            InitializeComponent();
            this.PK = PK;
            List<HospitalBed> hospitalBeds = db.GetHospitalBeds(PK);
            int bedIndex = 1; // 각 침대 종류에 대한 인덱스 변수

            foreach (HospitalBed bed in hospitalBeds)
            {
                // 텍스트 박스의 이름을 구성
                string textBoxName = $"sickbed_{bedIndex}_txt";

                // 텍스트 박스가 폼 안에서 어떻게 위치하는지에 따라 적절한 위치에 데이터 설정
                TextBox textBox = Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;

                if (textBox != null)
                {
                    textBox.Text = bed.BedQuantity.ToString();
                }

                bedIndex++;
            }


        }

        private void complete_btn_Click(object sender, EventArgs e)
        {

            db.delete_sickbed(PK);
            Dictionary<string, int> bedCounts = new Dictionary<string, int>();
            bedCounts["일반입원실"] = Convert.ToInt32(sickbed_1_txt.Text);
            bedCounts["중환자실"] = Convert.ToInt32(sickbed_2_txt.Text);
            bedCounts["정신과폐쇄실"] = Convert.ToInt32(sickbed_3_txt.Text);
            bedCounts["격리병실"] = Convert.ToInt32(sickbed_4_txt.Text);
            bedCounts["무균치료실"] = Convert.ToInt32(sickbed_5_txt.Text);
            bedCounts["분만실"] = Convert.ToInt32(sickbed_6_txt.Text);
            bedCounts["수술실"] = Convert.ToInt32(sickbed_7_txt.Text);
            bedCounts["응급실"] = Convert.ToInt32(sickbed_8_txt.Text);
            bedCounts["물리치료실"] = Convert.ToInt32(sickbed_9_txt.Text);
            db.SaveHospitalBeds(PK, bedCounts);
            MessageBox.Show("변경이 완료되었습니다!");
            this.Hide();
        }
    }
}
