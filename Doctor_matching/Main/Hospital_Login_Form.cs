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
    public partial class Hospital_Login_Form : Form
    {
        DBconn2 db = new DBconn2();
        public Hospital_Login_Form()
        {
            InitializeComponent();
        }

        private void join_membership_btn_Click(object sender, EventArgs e)
        {
            Hospital_Join_Membership_Form hospital_join_membership_form = new Hospital_Join_Membership_Form();
            hospital_join_membership_form.ShowDialog();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string id = id_txt.Text;
            string pass = pass_txt.Text;

            if (db.check_id_pass(id, pass)) {
                decimal PK = db.get_hospital_pk(id, pass);
                if(db.CheckPrimaryKeyExists(PK))
                {
                    Hospital_Main_Form hospital_main_form = new Hospital_Main_Form(PK);
                    hospital_main_form.Show();
                    this.Hide();
                }
                else
                {
                    Console.WriteLine(PK);
                    Hospital_Info_Save_Form hospital_info_save_form = new Hospital_Info_Save_Form(PK);
                    hospital_info_save_form.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("아이디 및 비밀번호가 존재하지 않습니다.");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Slect_Login_Form slect_login_form = new Slect_Login_Form();
            slect_login_form.Show();
            this.Hide();
        }
    }
}
