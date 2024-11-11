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
    public partial class Department_Explain : Form
    {
        public Department_Explain()
        {
            InitializeComponent();
            DBconn db = new DBconn();
            List<Department> departmentList = new List<Department>();
            departmentList = db.GetAllDepartments();
            foreach (Department department in departmentList)
            {
                department_view.Rows.Add(department.DepartmentName, department.DepartmentDescription);
            }
            /*
            department_view.Rows.Add();
            department_view.Rows[0].Cells[0].Value = "가정의학과";
            department_view.Rows[0].Cells[1].Value = "블라블라블라블라블라블라블라블라블라블라블라블라블라" +
                "블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라" +
                "블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블" +
                "라블라블라블라블라블라블라블라블라블라";
            */
        }

        private void Department_Explain_Load(object sender, EventArgs e)
        {

        }
    }
}
