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
    public partial class Search_Hospital_Form : Form
    {
        string hospital_name;
        DBconn db = new DBconn();
        public Search_Hospital_Form()
        {
            InitializeComponent();
        }

        private void Search_Hospital_Form_Load(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            hospital_name = hospital_name_txt.Text;
            decimal hospital_PK = db.GetHospitalPKByName(hospital_name);
            if (hospital_PK != -1)
            {
                Patient_Hospital_Info_Form patient_hospital_info_form = new Patient_Hospital_Info_Form(hospital_PK);
                patient_hospital_info_form.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("찾으시려는 병원이 없습니다.!");
            }
        }
    }
}
