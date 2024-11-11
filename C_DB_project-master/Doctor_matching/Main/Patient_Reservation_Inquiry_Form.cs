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
    public partial class Patient_Reservation_Inquiry_Form : Form
    {
        private decimal PK;
        private DBconn db = new DBconn();

        public Patient_Reservation_Inquiry_Form(decimal PK)
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
            this.PK = PK;
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
                patient_reservation_view.Rows[rowIndex].Cells["Column1"].Value = "예약 확인";
            }
        }

        private void Patient_Reservation_Inquiry_Form_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Patient_Main_Form patient_main_form = new Patient_Main_Form(this.PK);
            patient_main_form.Show();
            this.Hide();
        }

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
                    Console.WriteLine("예약이 취소되었습니다.");
                    db.CancelReservation(reservationData.ReservationSerialNumber);
                    patient_reservation_view.Rows.Clear();
                    RefreshReservationView();
                }
                else if (e.ColumnIndex == patient_reservation_view.Columns["Column1"].Index)
                {
                    if (selectedRow.Cells["Column1"].Value != null && selectedRow.Cells["Column1"].Value.ToString() == "예약 수락")
                    {
                        Console.WriteLine("예약이 확인되었습니다.");
                        db.ConfirmReservation(reservationData.ReservationSerialNumber);
                        patient_reservation_view.Rows.Clear();
                        RefreshReservationView();
                    }
                }
            }
        }
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
                patient_reservation_view.Rows[rowIndex].Cells["Column1"].Value = "예약 확인";
            }
        }
    }
}
