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
    public partial class Hospital_Change_Department_Form : Form
    {
        DBconn2 db = new DBconn2();
        decimal PK;
        public Hospital_Change_Department_Form(decimal PK)
        {
            InitializeComponent();
            this.Hide();
            this.PK = PK;
            List<decimal> departmentSerialNumbers = db.GetDepartmentSerialNumbersForHospital(PK);

            Console.WriteLine($"Hospital {PK} has the following Department Serial Numbers:");

            foreach (decimal departmentSerialNumber in departmentSerialNumbers)
            {
                Console.WriteLine(departmentSerialNumber);
            }

            
            List<CheckBox> checkboxes = new List<CheckBox>
           { department_1, department_2, department_3, department_4, department_5, department_6,
             department_7, department_8, department_9, department_10, department_11, department_12,
             department_13, department_14, department_15, department_16, department_17, department_18
            };

            foreach (CheckBox checkbox in checkboxes)
            {
                // 각 체크박스의 Tag 속성에서 Primary Key 값을 가져옵니다.
                if (checkbox.Tag != null && decimal.TryParse(checkbox.Tag.ToString(), out decimal departmentSerialNumber))
                {
                    // 만약 가져온 Primary Key 값이 리스트에 포함되어 있다면 체크박스를 체크합니다.
                    checkbox.Checked = departmentSerialNumbers.Contains(departmentSerialNumber);
                }
            }

        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            List<CheckBox> checkboxes = new List<CheckBox>
           { department_1, department_2, department_3, department_4, department_5, department_6,
             department_7, department_8, department_9, department_10, department_11, department_12,
             department_13, department_14, department_15, department_16, department_17, department_18
            };
            List<CheckBox> checkedCheckboxes = checkboxes.Where(cb => cb.Checked).ToList();

            db.delete_department(PK); //다삭제했다가
            db.SaveHospitalDepartments(PK, checkedCheckboxes); //다시 체크되어있는걸로 설정

            MessageBox.Show("변경이 완료되었습니다!");
            this.Hide();


        }
    }
}
