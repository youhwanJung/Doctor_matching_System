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
    public partial class Patient_Join_Membership_Form : Form

    {
        private DBconn db;
        public Patient_Join_Membership_Form()
        {
            InitializeComponent();
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            db = new DBconn();
            string id = id_txt.Text;
            string pass = pass_txt.Text;
            string pass_check = check_pass_txt.Text;

            if(pass == pass_check)
            {
                if(db.patient_join_membership(id, pass))
                {
                    MessageBox.Show("회원가입이 완료되었습니다!");
                    Slect_Login_Form select_login_form = new Slect_Login_Form();
                    select_login_form.Show();
                    this.Close();
                   
                }else
                {
                    MessageBox.Show("아이디가 중복됩니다, 아이디와 비밀번호를 입력해주세요");
                }
            }else
            {
                MessageBox.Show("비밀번호가 일치 하지 않습니다.");
            }
        }

        private void Patient_Join_Membership_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
