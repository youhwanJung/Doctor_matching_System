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
    public partial class Hospital_Info_Form : Form
    {
        decimal Hospital_PK;
        DBconn db = new DBconn();
        private DoctorData select_doctor;
        private decimal PK;
        private List<DoctorData> DoctorDataList;

        public Hospital_Info_Form(decimal Hospital_PK, decimal PK, DoctorData select_doctor, List<DoctorData> DoctorDataList)
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
            this.Hospital_PK = Hospital_PK;

            this.select_doctor = select_doctor;
            this.PK = PK;
            this.DoctorDataList = DoctorDataList;

            decimal hospitalPK = Hospital_PK; //병원 pk

            HospitalData hospitalData = db.GetHospitalData(hospitalPK);
            List<DepartmentData> departmentList = db.GetDepartments(hospitalPK);
            List<BedData> bedList = db.GetHospitalBedInfo(hospitalPK);


            name_txt.Text = hospitalData.HospitalName;
            location_txt.Text = hospitalData.FirstLocation + " " + hospitalData.SecondLocation + " " + hospitalData.DetailedLocation;
            hospital_division_txt.Text = hospitalData.HospitalDivision;
            phone_num_txt.Text = "0" + hospitalData.HospitalPhoneNumber;
            e_mail_txt.Text = hospitalData.HospitalEmail;
            introduce_txt.Text = hospitalData.HospitalSpecialNotes;
                
            // 병원 진료과목 뿌려주기
            foreach (var department in departmentList)
            {
                int rowIndex = hospital_department_view.Rows.Add();
                hospital_department_view.Rows[rowIndex].Cells[0].Value = department.DepartmentName;
                hospital_department_view.Rows[rowIndex].Cells[1].Value = "보기";
                hospital_department_view.Rows[rowIndex].Tag = department.DepartmentSerialNumber;
            }

            foreach (var sickBedData in bedList)
            {
                int rowIndex = hospital_sickbed_view.Rows.Add();
                hospital_sickbed_view.Rows[rowIndex].Cells[0].Value = sickBedData.BedName;
                hospital_sickbed_view.Rows[rowIndex].Cells[1].Value = sickBedData.BedQuantity;
                hospital_sickbed_view.Rows[rowIndex].Cells[2].Value = "보기";
                hospital_sickbed_view.Rows[rowIndex].Tag = sickBedData.SickBedSerialNumber;
            }
        }

        
        private void back_btn_Click(object sender, EventArgs e)
        {
            Doctor_Detail_Form doctor_detail_form = new Doctor_Detail_Form(this.PK, this.select_doctor, this.DoctorDataList);
            doctor_detail_form.Show();
            this.Hide();
        }
        

        private void Hospital_Info_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void patient_main_box_Enter(object sender, EventArgs e)
        {

        }

        private void hospital_department_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0) // "보기" 버튼이 클릭된 경우
            {
                decimal departmentSerialNumber = (decimal)hospital_department_view.Rows[e.RowIndex].Tag;
                DepartmentData departmentData = db.GetDepartmentInfo(departmentSerialNumber);
                Console.WriteLine(departmentData.DepartmentName);
                Console.WriteLine(departmentData.DepartmentDescription);
                Hospital_Department_ex hospital_department_ex = new Hospital_Department_ex(departmentData);
                hospital_department_ex.ShowDialog();
               }
        }

        private void hospital_sickbed_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0) // "보기" button is clicked
            {
                decimal sickBedSerialNumber = (decimal)hospital_sickbed_view.Rows[e.RowIndex].Tag;
                BedData sickBedData = db.GetSickBedInfo(sickBedSerialNumber);

                Hospital_sicbed_ex sickBedInfoForm = new Hospital_sicbed_ex(sickBedData);
                // Show the form
                sickBedInfoForm.ShowDialog();
            }
        }
    }
}
