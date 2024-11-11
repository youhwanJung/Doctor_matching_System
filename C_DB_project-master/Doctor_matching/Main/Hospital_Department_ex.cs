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
    public partial class Hospital_Department_ex : Form
    {
        public Hospital_Department_ex(DepartmentData departmentdata)
        {
            if (departmentdata != null)
            {
                InitializeComponent();
                department_name.TextAlign = ContentAlignment.MiddleCenter;
                department_name.Text = departmentdata.DepartmentName;
                department_ex.Text = departmentdata.DepartmentDescription;

                StartPosition = FormStartPosition.CenterScreen;

                FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            else
            {
                Console.WriteLine("아무것도 안들어있음");
            }
        }
    }
}
