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
    public partial class Hospital_Save_Sickbed_Form : Form
    {
        decimal PK;
        DBconn2 db = new DBconn2();
        public Hospital_Save_Sickbed_Form(decimal PK)
        {
            InitializeComponent();
            this.PK = PK;
        }

        private void Hospital_Save_Sickbed_Form_Load(object sender, EventArgs e)
        {

        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
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

            MessageBox.Show("병상 설정이 완료되었습니다.");
            this.Hide();
        }
    }
}
