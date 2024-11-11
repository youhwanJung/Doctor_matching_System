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
    public partial class Patient_Login_Form : Form
    {
        private decimal PK;
        private DBconn db;
        public Patient_Login_Form()
        {
            InitializeComponent();
            db = new DBconn();
        }

        private void join_membership_btn_Click(object sender, EventArgs e)
        {
            Patient_Join_Membership_Form patient_join_membership_form = new Patient_Join_Membership_Form();
            patient_join_membership_form.ShowDialog();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            String id = id_txt.Text;
            String pass = pass_txt.Text;

            
            if(db.patient_login(id, pass))
            {
                decimal PK = db.get_patient_pk(id, pass);


                if(db.before_login_check(PK))
                {
                    Console.WriteLine("환자 정보 저장 기록이 있습니다.");
                    MessageBox.Show("로그인에 성공하셨습니다!");
                    Patient_Main_Form patient_main_form = new Patient_Main_Form(PK);
                    patient_main_form.Show();
                    this.Close();
                }
                else
                {
                    Console.WriteLine("환자 정보 저장 기록이 없습니다.");
                    MessageBox.Show("로그인에 성공하셨습니다!");
                    Patient_Info_Save_Form patient_info_save_form = new Patient_Info_Save_Form(PK);
                    patient_info_save_form.Show();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("로그인에 실패하셨습니다! 로그인,비밀번호를 다시 입력해주세요");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Slect_Login_Form slect_login_form = new Slect_Login_Form();
            slect_login_form.Show();
            this.Close();
        }

        private void Patient_Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
