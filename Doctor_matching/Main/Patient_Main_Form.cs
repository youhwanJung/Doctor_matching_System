using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Main
{
    public partial class Patient_Main_Form : Form
    {
        private decimal PK;
        private DBconn db;
        private PatientData patient_data;
        private List<FavoriteDoctorData> favoriteDoctors;

        public Patient_Main_Form(decimal PK)
        {
            //환자 기본정보 설정
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
            this.PK = PK;
            db = new DBconn();
            patient_data = db.get_patient_data(PK);
            byte[] imageBytes = patient_data.PatientImage;
            string patient_name = patient_data.PatientName;
            department_label.Text = patient_data.PatientDepartment;
            user_name_label.Text = patient_name + "님";
            patient_main_box.Text = patient_name + "님 환영합니다!";
            Console.WriteLine(patient_data.PatientImage);

            //환자 이미지 설정
            Image image;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                image = Image.FromStream(ms);
            }

            // PictureBox에 이미지 할당
            user_image.Image = image;

            // PictureBox 다시 그리기
            user_image.Refresh();

            //환자 예약 조회
            List<ReservationData> reservations = db.GetPatientReservations(PK);
            Image doctor_image = Properties.Resources.datagridview_doctor;
            foreach (ReservationData Reservations in reservations)
            {
                int rowIndex = patient_reservation_view.Rows.Add();
                patient_reservation_view.Rows[rowIndex].Tag = Reservations; // ReservationData 객체를 Tag 속성에 저장
                patient_reservation_view.Rows[rowIndex].Cells["profile"].Value = doctor_image; // 이미지 설정
                patient_reservation_view.Rows[rowIndex].Cells["name"].Value = Reservations.DoctorName;
                patient_reservation_view.Rows[rowIndex].Cells["document"].Value = Reservations.DoctorPrimaryDepartment;
                patient_reservation_view.Rows[rowIndex].Cells["date"].Value = Reservations.DesiredReservationDate;
                patient_reservation_view.Rows[rowIndex].Cells["resercation_time"].Value = Reservations.DesiredReservationTime;
                patient_reservation_view.Rows[rowIndex].Cells["reservation_screening"].Value = Reservations.ReservationSuccessStatus;
                patient_reservation_view.Rows[rowIndex].Cells["resercation_cancel"].Value = "예약 취소";
                patient_reservation_view.Rows[rowIndex].Cells["reservation_check"].Value = "예약 확인";
            }


            //즐겨찾기 한 의사들
            favoriteDoctors = db.GetFavoriteDoctors(this.PK);
            listView1.View = View.Details; // 세부 정보 보기
            listView1.FullRowSelect = true; // 전체 행 선택
            listView1.GridLines = true; // 그리드 라인 표시

            listView1.Columns.Add("이름", 100);
            listView1.Columns.Add("병원", 100);
            listView1.Columns.Add("경력", 100);
            listView1.Columns.Add("추천 수", 100);
            listView1.Columns.Add("주진료과", 180);
            listView1.Columns.Add("E-mail", 360);

            foreach (FavoriteDoctorData favoriteDoctor in favoriteDoctors)
            {
                // ListViewItem을 생성하고 데이터를 설정합니다.
                ListViewItem item = new ListViewItem(favoriteDoctor.DoctorName);
                item.SubItems.Add(favoriteDoctor.HospitalSerialNumber.ToString());
                item.SubItems.Add(favoriteDoctor.DoctorExperience);
                item.SubItems.Add(favoriteDoctor.DoctorRecommendationCount.ToString());
                item.SubItems.Add(favoriteDoctor.DoctorPrimaryDepartment);
                item.SubItems.Add(favoriteDoctor.DoctorEmail);

                item.Tag = favoriteDoctor.DoctorSerialNumber;

                // ListView에 ListViewItem을 추가합니다.
                listView1.Items.Add(item);
            }

            // 리스트뷰를 업데이트하고 새로운 항목을 표시합니다.
            listView1.Update();
            listView1.Refresh();
        }

        private void Patient_Main_Form_Load(object sender, EventArgs e)
        {
            

        }

        private void matching_btn_Click(object sender, EventArgs e)
        {   
            List<decimal> list_doctor_PK = db.doctor_search(this.patient_data);
            if (list_doctor_PK.Count > 0)
            {
                List<DoctorData> DoctorDataList = db.GetDoctor_List(list_doctor_PK);
                foreach (DoctorData doctorData in DoctorDataList)
                {
                    Console.WriteLine("의사 번호: " + doctorData.DoctorSerialNumber);
                    Console.WriteLine("의사 이름: " + doctorData.DoctorName);
                    Console.WriteLine("의사 경력: " + doctorData.DoctorExp);
                    Console.WriteLine("의사 이메일: " + doctorData.DoctorEmail);
                    Console.WriteLine("의사 부서: " + doctorData.DoctorDepartment);
                    Console.WriteLine("의사 소개: " + doctorData.DoctorIntroduce);
                    Console.WriteLine("의사 추천 횟수: " + doctorData.DoctorRecoment);
                    Console.WriteLine("의사 소속 병원: " + doctorData.DoctorHospital);
                    Console.WriteLine("------------------------------");
                }
                Maching_Result_Form maching_result_form = new Maching_Result_Form(this.PK, DoctorDataList);
                maching_result_form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("현재 매칭에 맞는 의사가 없습니다.");
            }
        }

        private void favorites_btn_Click(object sender, EventArgs e)
        {

            Patient_Favorites_Form patient_favorites_Form = new Patient_Favorites_Form(this.PK);
            patient_favorites_Form.Show();
            this.Hide();
        }

        private void reservation_inquiry_btn_Click(object sender, EventArgs e)
        {
            Patient_Reservation_Inquiry_Form patient_reservation_inquiry_form = new Patient_Reservation_Inquiry_Form(this.PK);
            patient_reservation_inquiry_form.Show();
            this.Hide();
;        }

        private void change_info_btn_Click(object sender, EventArgs e)
        {
            Patient_Change_Info_Form patient_change_info_form = new Patient_Change_Info_Form(this.PK, this.patient_data);
            patient_change_info_form.Show();
            this.Hide();
        }

        private void search_hospital_btn_Click(object sender, EventArgs e) //의사 찾기
        {

            Search_Hospital_Form search_hospital_form = new Search_Hospital_Form();
            search_hospital_form.Show();

        }

        private void department_explain_btn_Click(object sender, EventArgs e)
        {
            Department_Explain department_explain = new Department_Explain();
            department_explain.Show();
        }

        private void sickbed_explain_btn_Click(object sender, EventArgs e)
        {
            Sickbed_Explain sickbed_explain = new Sickbed_Explain();
            sickbed_explain.Show();
        }

        private void explain_btn_Click(object sender, EventArgs e)
        {
            Manual manual = new Manual();
            manual.Show();
        }

        private void patient_main_box_Enter(object sender, EventArgs e)
        {

        }

        //예약 취소 버튼 이벤트 와 예약 확정 이벤트
        private void patient_reservation_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = patient_reservation_view.Rows[e.RowIndex];
                ReservationData reservationData = (ReservationData)selectedRow.Tag;

                if (e.ColumnIndex == patient_reservation_view.Columns["resercation_cancel"].Index)
                {
                    // 예약 취소 버튼 클릭
                    patient_reservation_view.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("예약이 취소되었습니다!");
                    db.CancelReservation(reservationData.ReservationSerialNumber);
                    patient_reservation_view.Rows.Clear();
                    RefreshReservationView();
                }
                else if (e.ColumnIndex == patient_reservation_view.Columns["reservation_check"].Index)
                {
                    if(reservationData.ReservationSuccessStatus == "예약 수락") {
                        Console.WriteLine("예약이 확인되었습니다.");
                        db.ConfirmReservation(reservationData.ReservationSerialNumber);
                        patient_reservation_view.Rows.Clear();
                        RefreshReservationView();
                        MessageBox.Show("예약이 확정됐습니다! 지정하신 날짜에 방문해 주세요!");
                    }
                    else if(reservationData.ReservationSuccessStatus == "심사 중")
                    {
                        MessageBox.Show("병원에서 아직 에약을 확인하지 못했습니다! 예약 수락이 되면 확인해주세요!");

                    }else if(reservationData.ReservationSuccessStatus == "예약 확정")
                    {
                        MessageBox.Show("예약이 확정됐습니다! 지정하신 날짜에 방문해 주세요!");
                    }
                }
            }
        }
        //View를 새로고침해주는 함수
        private void RefreshReservationView()
        {
            List<ReservationData> reservations = db.GetPatientReservations(PK);
            Image doctor_image = Properties.Resources.datagridview_doctor;

            foreach (ReservationData reservation in reservations)
            {
                int rowIndex = patient_reservation_view.Rows.Add();
                patient_reservation_view.Rows[rowIndex].Tag = reservation; // ReservationData 객체를 Tag 속성에 저장
                patient_reservation_view.Rows[rowIndex].Cells["profile"].Value = doctor_image; // 이미지 설정
                patient_reservation_view.Rows[rowIndex].Cells["name"].Value = reservation.DoctorName;
                patient_reservation_view.Rows[rowIndex].Cells["document"].Value = reservation.DoctorPrimaryDepartment;
                patient_reservation_view.Rows[rowIndex].Cells["date"].Value = reservation.DesiredReservationDate;
                patient_reservation_view.Rows[rowIndex].Cells["resercation_time"].Value = reservation.DesiredReservationTime;
                patient_reservation_view.Rows[rowIndex].Cells["reservation_screening"].Value = reservation.ReservationSuccessStatus;
                patient_reservation_view.Rows[rowIndex].Cells["resercation_cancel"].Value = "예약 취소";
                patient_reservation_view.Rows[rowIndex].Cells["reservation_check"].Value = "예약 확인";
            }
        }

        //즐겨찾기한 의사를 상세보는 기능
        private void facorites_doctor_detail_btn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // 첫 번째 선택된 항목 가져오기 (단일 선택 기준)
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // ListViewItem에서 Tag 속성을 이용하여 PK 값 가져오기
                decimal DoctorPK = Convert.ToDecimal(selectedItem.Tag);
                Console.WriteLine(DoctorPK);
                DoctorData doctorData = null;

                doctorData = db.GetDoctorInfo(DoctorPK);
                Console.WriteLine(doctorData.DoctorHospital);
                Patient_Favorites_Doctor_Detail_Form patient_Sfavorites_doctor_detail_form = new Patient_Favorites_Doctor_Detail_Form(this.PK, doctorData);
                patient_Sfavorites_doctor_detail_form.Show();
                this.Hide();
            }
        }
    }
}
