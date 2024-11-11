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
    public partial class Maching_Result_Form : Form
    {
        DBconn db = new DBconn();
        private decimal PK;
        private List<DoctorData> DoctorDataList;
        private DoctorData select_doctor;

        public Maching_Result_Form(decimal PK, List<DoctorData> DoctorDataList)
        {
            this.PK = PK;
            this.DoctorDataList = DoctorDataList;
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void Matching_Result_Form_Load(object sender, EventArgs e)
        {

            //생성자에서 의사 데이터 리스트 받아와서 테이블에 적용
            Image doctor_image = Properties.Resources.datagridview_doctor;
            groupBox1.Text = DoctorDataList[0].DoctorDepartment + " 매칭 결과입니다.";
            foreach (DoctorData doctorData in DoctorDataList)
            {
                int rowIndex = serch_doctor_result_view.Rows.Add();
                serch_doctor_result_view.Rows[rowIndex].Tag = doctorData; // DoctorData 객체를 Tag 속성에 저장
                serch_doctor_result_view.Rows[rowIndex].Cells["profile"].Value = doctor_image; // 이미지 설정
                serch_doctor_result_view.Rows[rowIndex].Cells["name"].Value = doctorData.DoctorName;
                serch_doctor_result_view.Rows[rowIndex].Cells["hospital"].Value = doctorData.DoctorHospital;
                serch_doctor_result_view.Rows[rowIndex].Cells["career_year"].Value = doctorData.DoctorExp;
                serch_doctor_result_view.Rows[rowIndex].Cells["like_num"].Value = doctorData.DoctorRecoment;
                serch_doctor_result_view.Rows[rowIndex].Cells["e_mail"].Value = doctorData.DoctorEmail;

            }

        }
        private void serch_doctor_result_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Console.WriteLine($"Clicked Row Index: {e.RowIndex}");
                this.select_doctor = serch_doctor_result_view.Rows[e.RowIndex].Tag as DoctorData;
                if (select_doctor != null)
                {
                    Console.WriteLine(select_doctor.DoctorName);
                }
                else
                {
                    Console.WriteLine("Tag에 저장된 객체가 DoctorData 형식이 아닙니다.");
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Patient_Main_Form patient_main_form = new Patient_Main_Form(this.PK);
            patient_main_form.Show();
            this.Hide();
        }

        private void doctor_detail_btn_Click(object sender, EventArgs e)
        {
            if (select_doctor != null)
            {
                Doctor_Detail_Form doctor_detail_form = new Doctor_Detail_Form(this.PK, this.select_doctor,this.DoctorDataList); //저장한 객체를 다음 폼에 뿌려줌
                doctor_detail_form.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("선택한 의사가 없습니다.");
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serch_doctor_result_view.Rows.Clear();
            foreach (DoctorData doctorData in DoctorDataList)
            {
                Image doctor_image = Properties.Resources.datagridview_doctor;
                int rowIndex = serch_doctor_result_view.Rows.Add();
                serch_doctor_result_view.Rows[rowIndex].Tag = doctorData; // DoctorData 객체를 Tag 속성에 저장
                serch_doctor_result_view.Rows[rowIndex].Cells["profile"].Value = doctor_image; // 이미지 설정
                serch_doctor_result_view.Rows[rowIndex].Cells["name"].Value = doctorData.DoctorName;
                serch_doctor_result_view.Rows[rowIndex].Cells["hospital"].Value = doctorData.DoctorHospital;
                serch_doctor_result_view.Rows[rowIndex].Cells["career_year"].Value = doctorData.DoctorExp;
                serch_doctor_result_view.Rows[rowIndex].Cells["like_num"].Value = doctorData.DoctorRecoment;
                serch_doctor_result_view.Rows[rowIndex].Cells["e_mail"].Value = doctorData.DoctorEmail;

            }
        }

        private void serch_doctor_result_view_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            if (serch_doctor_result_view.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.Ascending)
            {
                serch_doctor_result_view.Sort(serch_doctor_result_view.Columns[columnIndex], ListSortDirection.Descending);
            }
            else
            {
                serch_doctor_result_view.Sort(serch_doctor_result_view.Columns[columnIndex], ListSortDirection.Ascending);
            }
        }
    }
}
