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
    public partial class Patient_Favorites_Doctor_Detail_Form : Form
    {
        private DoctorData select_doctor;
        private decimal PK;
        private List<CommentData> comment = new List<CommentData>();
        private DBconn db;
        public Patient_Favorites_Doctor_Detail_Form(decimal PK, DoctorData doctordata)
        {
            this.select_doctor = doctordata;
            this.PK = PK;
            db = new DBconn();
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();

        }

        private void recommend_btn_Click(object sender, EventArgs e)
        {
            db.UP_COUNT(select_doctor.DoctorSerialNumber);
            MessageBox.Show("추천하셨습니다!");
        }

        private void favorites_cancel_btn_Click(object sender, EventArgs e)
        {
            db.delete_favorite(this.PK, select_doctor.DoctorSerialNumber);
            MessageBox.Show("즐겨찾기 해지되셨습니다!");

        }

        private void reservation_btn_Click(object sender, EventArgs e)
        {
            Reservation_Form reservation_form = new Reservation_Form(this.PK, select_doctor.DoctorSerialNumber);
            reservation_form.ShowDialog();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

            Patient_Main_Form patient_main_form = new Patient_Main_Form(this.PK);
            patient_main_form.Show();
            this.Hide();
        }

        private void Patient_Favorites_Doctor_Detail_Form_Load(object sender, EventArgs e)
        {

            hospital_label.Text = select_doctor.HospitalName;
            department_label.Text = select_doctor.DoctorDepartment;
            phone_num_label.Text = select_doctor.DoctorPhoneNum;
            email_label.Text = select_doctor.DoctorEmail;
            introduce_label.Text = select_doctor.DoctorIntroduce;
            name_label.Text = select_doctor.DoctorName;

            comment = db.Show_DoctorComment(select_doctor.DoctorSerialNumber);
            foreach (CommentData commentData in comment)
            {
                int rowIndex = doctor_coment_view.Rows.Add();
                doctor_coment_view.Rows[rowIndex].Tag = commentData; // CommentData 객체를 Tag 속성에 저장
                doctor_coment_view.Rows[rowIndex].Cells["name"].Value = commentData.PatientName; // 이미지 설정
                doctor_coment_view.Rows[rowIndex].Cells["content"].Value = commentData.CommentContent;
                doctor_coment_view.Rows[rowIndex].Cells["good_num"].Value = commentData.CommentRecommendationCount;
                doctor_coment_view.Rows[rowIndex].Cells["good"].Value = "추천";
            }
        }

        private void write_coment_btn_Click(object sender, EventArgs e)
        {
            Coment_Write_Form coment_write_form = new Coment_Write_Form(this.PK, this.select_doctor);
            coment_write_form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctor_coment_view.Rows.Clear();
            comment = db.Show_DoctorComment(select_doctor.DoctorSerialNumber);
            foreach (CommentData commentData in comment)
            {
                int rowIndex = doctor_coment_view.Rows.Add();
                doctor_coment_view.Rows[rowIndex].Tag = commentData; // CommentData 객체를 Tag 속성에 저장
                doctor_coment_view.Rows[rowIndex].Cells["name"].Value = commentData.PatientName; // 이미지 설정
                doctor_coment_view.Rows[rowIndex].Cells["content"].Value = commentData.CommentContent;
                doctor_coment_view.Rows[rowIndex].Cells["good_num"].Value = commentData.CommentRecommendationCount;
                doctor_coment_view.Rows[rowIndex].Cells["good"].Value = "추천";
            }
        }

        private void doctor_coment_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == doctor_coment_view.Columns["good"].Index)
            {
                CommentData clickedComment = (CommentData)doctor_coment_view.Rows[e.RowIndex].Tag; // 
                clickedComment.CommentRecommendationCount++; // 추천 수 증가

                // 여기서 데이터베이스에 반영하는 코드를 추가해야 합니다.
                db.Up_comment_num(clickedComment.Comment_PK, clickedComment.CommentRecommendationCount);

                // DataGridView 업데이트
                LoadComments();
            }
        }
        private void LoadComments()
        {
            // DataGridView 클리어
            doctor_coment_view.Rows.Clear();

            // 새로운 데이터 추가
            comment = db.Show_DoctorComment(select_doctor.DoctorSerialNumber);
            foreach (CommentData commentData in comment)
            {
                int rowIndex = doctor_coment_view.Rows.Add();
                doctor_coment_view.Rows[rowIndex].Tag = commentData; // CommentData 객체를 Tag 속성에 저장
                doctor_coment_view.Rows[rowIndex].Cells["name"].Value = commentData.PatientName; // 이미지 설정
                doctor_coment_view.Rows[rowIndex].Cells["content"].Value = commentData.CommentContent;
                doctor_coment_view.Rows[rowIndex].Cells["good_num"].Value = commentData.CommentRecommendationCount;
                doctor_coment_view.Rows[rowIndex].Cells["good"].Value = "추천";
            }
        }

        private void hospital_detail_btn_Click(object sender, EventArgs e)
        {
            Pationt_Favorit_Hospital hospital_info_form = new Pationt_Favorit_Hospital(this.PK, this.select_doctor);
            Console.WriteLine();
            hospital_info_form.Show();
            this.Hide();
        }
    }
}
