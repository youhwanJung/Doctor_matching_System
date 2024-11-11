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
    public partial class Hospital_Join_Membership_Form : Form
    {
        public Hospital_Join_Membership_Form()
        {
            InitializeComponent();
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            String id = id_txt.Text;
            String pass = pass_txt.Text;
            String passconfirm = check_pass_txt.Text;
            DBconn2 db = new DBconn2();
            if (pass == passconfirm)
            {
                db.hospital_join_membership(id, pass);
                MessageBox.Show("회원가입이 완료되었습니다!");
                Slect_Login_Form select_login_form = new Slect_Login_Form();
                select_login_form.Show();
                this.Close();
            }
            else if (pass != passconfirm)
            {
                MessageBox.Show("비밀번호를 확인해주세요.");
            }
        }
    }
}
