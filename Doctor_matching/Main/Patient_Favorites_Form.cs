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
    public partial class Patient_Favorites_Form : Form
    {
        private decimal PK;
        private DBconn db;
        private List<FavoriteDoctorData> favoriteDoctors;
        public Patient_Favorites_Form(decimal PK)
        {
            this.PK = PK;
            this.FormClosed += (s, args) => Application.Exit();
            db = new DBconn();
            InitializeComponent();
        }

        private void Patient_Favorites_Form_Load(object sender, EventArgs e)
        {
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            Patient_Main_Form patient_main_form = new Patient_Main_Form(this.PK);
            patient_main_form.Show();
            this.Hide();
        }

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

                //Patient_Favorites_Doctor_Detail_Form patient_Sfavorites_doctor_detail_form = new Patient_Favorites_Doctor_Detail_Form(this.PK, doctorData, favoriteDoctors);
                //patient_Sfavorites_doctor_detail_form.Show();
                this.Hide();


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }
    }
}
