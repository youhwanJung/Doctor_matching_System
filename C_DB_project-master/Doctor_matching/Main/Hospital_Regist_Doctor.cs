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
    public partial class Hospital_Regist_Doctor : Form
    {
        decimal PK;
        DBconn2 db = new DBconn2();
        public Hospital_Regist_Doctor(decimal PK)
        {
            InitializeComponent();
            this.PK = PK;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Hospital_Main_Form hospital_main_form = new Hospital_Main_Form(PK);
            hospital_main_form.Show();
            this.Hide();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {

            string name = name_txt.Text;
            string carrer = career_txt.Text + "년";
            string phone_num = phone_num_txt.Text;
            string e_mail = email_txt.Text;
            string department = department_combo.Text;
            string note = significant_txt.Text;
            decimal good_count = 0;

            db.InsertDoctorInfo(name, carrer, phone_num, e_mail, department, note, good_count, PK);
            MessageBox.Show("의사가 등록되었습니다!");
            this.Hide();

        }
    }
}
