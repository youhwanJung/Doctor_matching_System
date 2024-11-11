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
    public partial class Hospital_Save_Department_Form : Form
    {
        private DBconn2 db = new DBconn2();
        private decimal PK;
        public Hospital_Save_Department_Form(decimal PK)
        {
            this.PK = PK;
            InitializeComponent();
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("진료과 설정을 완료했습니다.");
            this.Hide();
            List<CheckBox> checkboxes = new List<CheckBox>
           { department_1, department_2, department_3, department_4, department_5, department_6,
             department_7, department_8, department_9, department_10, department_11, department_12,
             department_13, department_14, department_15, department_16, department_17, department_18
            };
            List<CheckBox> checkedCheckboxes = checkboxes.Where(cb => cb.Checked).ToList();
            foreach (CheckBox checkBox in checkedCheckboxes)
            {
                Console.WriteLine($"Text: {checkBox.Text}, Tag: {checkBox.Tag}");
            }
            db.SaveHospitalDepartments(PK, checkedCheckboxes);

        }

        private void Hospital_Save_Department_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
