using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;//ADO.Net 개체 참조
using System.Data; //DataSet 개체 참조
using System.Windows.Forms; //MessageBox 개체 참조

namespace Main
{
    public partial class Hospital_Main_Form : Form
    {
        HospitalInfo hospitalInfo;
        decimal PK;
        DBconn2 db2;
        DBconn db;
        List<HospitalReservationData> reservationList;
        List<HospitalDoctorInfo> hospital_doctors;

        public Hospital_Main_Form(decimal PK)
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
            this.PK = PK;
            db = new DBconn();
            db2 = new DBconn2();
            reservationList = db.GetReservationData(PK); //여기에 PK값 넣어주기
            hospital_doctors = db.GetDoctorsForHospital(PK); //여기에 PK값 넣어주기
            Image doctor_image = Properties.Resources.datagridview_doctor;
            hospitalInfo = db2.GetHospitalInfo(PK);
        }

        private void Hospital_Main_Form_Load(object sender, EventArgs e)
        {
            groupBox1.Text = hospitalInfo.HospitalName + " 환영합니다!";

            foreach (var reservation in reservationList)
            {
                int rowIndex = message_view.Rows.Add();
                message_view.Rows[rowIndex].Tag = reservation.RegisterSerialNumber;

                message_view.Rows[rowIndex].Cells[0].Value = reservation.PatientName;
                message_view.Rows[rowIndex].Cells[1].Value = reservation.PatientAge.ToString();
                message_view.Rows[rowIndex].Cells[2].Value = reservation.DoctorName;
                message_view.Rows[rowIndex].Cells[3].Value = reservation.DesiredDate;
                message_view.Rows[rowIndex].Cells[4].Value = reservation.DesiredTime;
                message_view.Rows[rowIndex].Cells[5].Value = "수락하기";
                message_view.Rows[rowIndex].Cells[6].Value = "취소하기";
                message_view.Rows[rowIndex].Cells[7].Value = reservation.Reservation_Statment;
            }

            Image doctor_image = Properties.Resources.datagridview_doctor;
            foreach (HospitalDoctorInfo doctor in hospital_doctors)
            {
                int rowIndex = register_doctor_view.Rows.Add();
                register_doctor_view.Rows[rowIndex].Cells[0].Value = doctor_image; // 이미지 설정
                register_doctor_view.Rows[rowIndex].Cells[1].Value = doctor.DoctorName;
                register_doctor_view.Rows[rowIndex].Cells[2].Value = doctor.DoctorExperience;
                register_doctor_view.Rows[rowIndex].Cells[3].Value = doctor.DoctorPrimaryDepartment;
                register_doctor_view.Rows[rowIndex].Cells[4].Value = doctor.DoctorRecommendationCount;
                register_doctor_view.Rows[rowIndex].Cells[5].Value = "등록해제";
                register_doctor_view.Rows[rowIndex].Tag = doctor.DoctorSerialNumber; // 의사 시리얼 넘버를 Tag로 저장
            }


        }

        private void chagne_info_btn_Click(object sender, EventArgs e)
        {
            Hospital_Change_Info_Form hospital_change_info_form = new Hospital_Change_Info_Form(PK);
            hospital_change_info_form.Show();
            this.Hide();

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Hospital_Regist_Doctor hospital_regist_doctor = new Hospital_Regist_Doctor(PK);//여기에 PK값 넣어주기
            hospital_regist_doctor.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RemoveReservationFromGridView(int reservationSerialNumber)
        {
            // DataGridView에서 해당 예약 행을 삭제합니다.
            foreach (DataGridViewRow row in message_view.Rows)
            {
                if (row.Tag != null && Convert.ToInt32(row.Tag) == reservationSerialNumber)
                {
                    message_view.Rows.Remove(row);
                    break;
                }
            }
        }

        private void message_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int reservationSerialNumber = Convert.ToInt32(message_view.Rows[e.RowIndex].Tag);

                if (e.ColumnIndex == 5) // 수락하기 버튼 클릭
                {
                    db.AcceptReservation(reservationSerialNumber);
                    message_view.Rows.Clear();
                    LoadReservationData();
                }
                else if (e.ColumnIndex == 6) // 취소하기 버튼 클릭
                {
                    db.CancelReservation(reservationSerialNumber);
                    message_view.Rows.Clear();
                    LoadReservationData();
                }
            }
        }
        private void LoadReservationData()
        {
            List<HospitalReservationData> reservationList = db.GetReservationData(PK);

            foreach (var reservation in reservationList)
            {
                int rowIndex = message_view.Rows.Add();
                message_view.Rows[rowIndex].Tag = reservation.RegisterSerialNumber; // 태그에 Reservation Serial Number 설정
                message_view.Rows[rowIndex].Cells[0].Value = reservation.PatientName;
                message_view.Rows[rowIndex].Cells[1].Value = reservation.PatientAge;
                message_view.Rows[rowIndex].Cells[2].Value = reservation.DoctorName;
                message_view.Rows[rowIndex].Cells[3].Value = reservation.DesiredDate;
                message_view.Rows[rowIndex].Cells[4].Value = reservation.DesiredTime;
                message_view.Rows[rowIndex].Cells[5].Value = "수락하기";
                message_view.Rows[rowIndex].Cells[6].Value = "취소하기";
                message_view.Rows[rowIndex].Cells[7].Value = reservation.Reservation_Statment;
            }
        }
        private void LoadHospitalDoctorData()
        {
            List<HospitalDoctorInfo> docorList = db.GetDoctorsForHospital(PK);
            Image doctor_image = Properties.Resources.datagridview_doctor;
            foreach (HospitalDoctorInfo doctor in docorList)
            {
                int rowIndex = register_doctor_view.Rows.Add();
                register_doctor_view.Rows[rowIndex].Cells[0].Value = doctor_image; // 이미지 설정
                register_doctor_view.Rows[rowIndex].Cells[1].Value = doctor.DoctorName;
                register_doctor_view.Rows[rowIndex].Cells[2].Value = doctor.DoctorExperience;
                register_doctor_view.Rows[rowIndex].Cells[3].Value = doctor.DoctorPrimaryDepartment;
                register_doctor_view.Rows[rowIndex].Cells[4].Value = doctor.DoctorRecommendationCount;
                register_doctor_view.Rows[rowIndex].Cells[5].Value = "등록해제";
                register_doctor_view.Rows[rowIndex].Tag = doctor.DoctorSerialNumber; // 의사 시리얼 넘버를 Tag로 저장
            }
        }


        private void refresh_btn_Click(object sender, EventArgs e)
        {
            message_view.Rows.Clear();
            LoadReservationData();

            register_doctor_view.Rows.Clear();
            LoadHospitalDoctorData();
        }

        private void register_doctor_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == register_doctor_view.Columns["register_cancel"].Index)
            {
                decimal doctorSerialNumber = Convert.ToDecimal(register_doctor_view.Rows[e.RowIndex].Tag);

                // 의사 정보 삭제
                db.RemoveDoctor(doctorSerialNumber);

                // DataGridView 업데이트
                register_doctor_view.Rows.Clear();
                LoadDoctorDataForHospital(PK); // 여기에 해당하는 병원의 의사 데이터를 다시 불러오는 함수 호출
            }
        }
        public void LoadDoctorDataForHospital(decimal hospitalSerialNumber)
        {
            List<HospitalDoctorInfo> hospitalDoctors = db.GetDoctorsForHospital(hospitalSerialNumber);

            Image doctor_image = Properties.Resources.datagridview_doctor;

            // 기존 데이터 삭제
            register_doctor_view.Rows.Clear();

            // 새로운 데이터 추가
            foreach (HospitalDoctorInfo doctor in hospitalDoctors)
            {
                int rowIndex = register_doctor_view.Rows.Add();
                register_doctor_view.Rows[rowIndex].Cells[0].Value = doctor_image; // 이미지 설정
                register_doctor_view.Rows[rowIndex].Cells[1].Value = doctor.DoctorName;
                register_doctor_view.Rows[rowIndex].Cells[2].Value = doctor.DoctorExperience;
                register_doctor_view.Rows[rowIndex].Cells[3].Value = doctor.DoctorPrimaryDepartment;
                register_doctor_view.Rows[rowIndex].Cells[4].Value = doctor.DoctorRecommendationCount;
                register_doctor_view.Rows[rowIndex].Cells[5].Value = "등록해제";
                register_doctor_view.Rows[rowIndex].Tag = doctor.DoctorSerialNumber; // 의사 시리얼 넘버를 Tag로 저장
            }
        }
    }
 }
