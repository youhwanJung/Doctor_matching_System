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
    public partial class Hospital_Change_Info_Form : Form
    {
        DBconn2 db = new DBconn2();
        HospitalInfo hospitalInfo;
        HospitalLocation hospitalLocation;
        decimal PK;
        string image_path;
        public Hospital_Change_Info_Form(decimal PK)
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
            this.PK = PK;
            hospitalInfo = db.GetHospitalInfo(PK);
            hospitalLocation = db.GetHospitalLocation(PK);
            
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {

            hospitalInfo.HospitalName = name_txt.Text;
            hospitalLocation.FirstLocation = first_location_combo.Text;
            hospitalLocation.SecondLocation = second_location_combo.Text;
            hospitalLocation.DetailedLocation = third_location_combo.Text;
            hospitalInfo.HospitalDivision = hospital_division_combo.Text;
            hospitalInfo.HospitalSpecialNotes = significant_txt.Text;
            hospitalInfo.HospitalPhoneNumber = decimal.Parse(phone_num_txt.Text);
            hospitalInfo.HospitalDoctorCount = decimal.Parse(doctor_num_txt.Text);
            hospitalInfo.HospitalEmail = e_mail_txt.Text;

            db.UpdateHospitalInfoAndLocation(PK, hospitalInfo, hospitalLocation);

            MessageBox.Show("변경이 완료되었습니다.");
            Hospital_Main_Form hospital_main_form = new Hospital_Main_Form(PK);
            hospital_main_form.Show();
            this.Hide();
        }

        private void have_department_btn_Click(object sender, EventArgs e)
        {
            Hospital_Change_Department_Form hospital_change_department_form = new Hospital_Change_Department_Form(PK);
            hospital_change_department_form.ShowDialog();
           
        }

        private void have_sickbed_btn_Click(object sender, EventArgs e)
        {
            Hospital_Change_Sickbed_Form hospital_change_sickbed_form = new Hospital_Change_Sickbed_Form(PK);
            hospital_change_sickbed_form.ShowDialog();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Hospital_Main_Form hospital_main_form = new Hospital_Main_Form(PK);
            hospital_main_form.Show();
            this.Hide();
        }

        private void Hospital_Change_Info_Form_Load(object sender, EventArgs e)
        {
            byte[] imageBytes = hospitalInfo.HospitalMapImage;
            Image image;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                image = Image.FromStream(ms);
            }

            hospital_map_img.Image = image;
            name_txt.Text = hospitalInfo.HospitalName;
            first_location_combo.Text = hospitalLocation.FirstLocation;
            second_location_combo.Text = hospitalLocation.SecondLocation;
            third_location_combo.Text = hospitalLocation.DetailedLocation;
            hospital_division_combo.Text = hospitalInfo.HospitalDivision;
            significant_txt.Text = hospitalInfo.HospitalSpecialNotes;
            phone_num_txt.Text = "0" + hospitalInfo.HospitalPhoneNumber.ToString();
            doctor_num_txt.Text = hospitalInfo.HospitalDoctorCount.ToString();
            e_mail_txt.Text = hospitalInfo.HospitalEmail;
        }

        private void first_location_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            second_location_combo.Items.Clear();

            string selectedRegion = first_location_combo.SelectedItem.ToString();


            if (selectedRegion == "서울특별시")
            {
                // 서울시 선택 시
                second_location_combo.Items.Add("종로구");
                second_location_combo.Items.Add("중구");
                second_location_combo.Items.Add("용산구");
                second_location_combo.Items.Add("성동구");
                second_location_combo.Items.Add("광진구");
                second_location_combo.Items.Add("동내문구");
                second_location_combo.Items.Add("중랑구");
                second_location_combo.Items.Add("성북구");
                second_location_combo.Items.Add("강북구");
                second_location_combo.Items.Add("도봉구");
                second_location_combo.Items.Add("노원구");
                second_location_combo.Items.Add("은평구");
                second_location_combo.Items.Add("서대문구");
                second_location_combo.Items.Add("마포구");
                second_location_combo.Items.Add("양천구");
                second_location_combo.Items.Add("강서구");
                second_location_combo.Items.Add("구로구");
                second_location_combo.Items.Add("금천구");
                second_location_combo.Items.Add("영등포구");
                second_location_combo.Items.Add("동작구");
                second_location_combo.Items.Add("서초구");
                second_location_combo.Items.Add("강남구");
                second_location_combo.Items.Add("송파구");
                second_location_combo.Items.Add("강동구");

                // 다른 서울시 관련 구를 추가하세요
            }
            else if (selectedRegion == "경기도")
            {
                // 경기도 선택 시
                second_location_combo.Items.Add("수원시");
                second_location_combo.Items.Add("성남시");
                second_location_combo.Items.Add("의정부시");
                second_location_combo.Items.Add("안양시");
                second_location_combo.Items.Add("부천시");
                second_location_combo.Items.Add("광명시");
                second_location_combo.Items.Add("동두천시");
                second_location_combo.Items.Add("평택시");
                second_location_combo.Items.Add("안산시");
                second_location_combo.Items.Add("고양시");
                second_location_combo.Items.Add("과천시");
                second_location_combo.Items.Add("구리시");
                second_location_combo.Items.Add("남양주시");
                second_location_combo.Items.Add("오산시");
                second_location_combo.Items.Add("시흥시");
                second_location_combo.Items.Add("군포시");
                second_location_combo.Items.Add("의왕시");
                second_location_combo.Items.Add("하남시");
                second_location_combo.Items.Add("용인시");
                second_location_combo.Items.Add("파주시");
                second_location_combo.Items.Add("이천시");
                second_location_combo.Items.Add("안성시");
                second_location_combo.Items.Add("김포시");
                second_location_combo.Items.Add("화성시");
                second_location_combo.Items.Add("광주시");
                second_location_combo.Items.Add("양주시");
                second_location_combo.Items.Add("포천시");
                second_location_combo.Items.Add("여수시");
                second_location_combo.Items.Add("연천군");
                second_location_combo.Items.Add("가평군");
                second_location_combo.Items.Add("양평군");
            }
            else if (selectedRegion == "부산광역시")
            {
                second_location_combo.Items.Add("중구");
                second_location_combo.Items.Add("서구");
                second_location_combo.Items.Add("동구");
                second_location_combo.Items.Add("영동구");
                second_location_combo.Items.Add("부산진구");
                second_location_combo.Items.Add("동래구");
                second_location_combo.Items.Add("남구");
                second_location_combo.Items.Add("북구");
                second_location_combo.Items.Add("강서구");
                second_location_combo.Items.Add("해운대구");
                second_location_combo.Items.Add("서하구");
                second_location_combo.Items.Add("금정구");
                second_location_combo.Items.Add("영제구");
                second_location_combo.Items.Add("수영구");
                second_location_combo.Items.Add("사상구");

            }
            else if (selectedRegion == "대구광역시")
            {
                second_location_combo.Items.Add("중구");
                second_location_combo.Items.Add("동구");
                second_location_combo.Items.Add("서구");
                second_location_combo.Items.Add("남구");
                second_location_combo.Items.Add("북구");
                second_location_combo.Items.Add("수성구");
                second_location_combo.Items.Add("달서구");
                second_location_combo.Items.Add("달성군");
                second_location_combo.Items.Add("군위군");
            }
            else if (selectedRegion == "인천광역시")
            {
                second_location_combo.Items.Add("중구");
                second_location_combo.Items.Add("동구");
                second_location_combo.Items.Add("미주홀구");
                second_location_combo.Items.Add("연수구");
                second_location_combo.Items.Add("남동구");
                second_location_combo.Items.Add("부평구");
                second_location_combo.Items.Add("계양구");
                second_location_combo.Items.Add("서구");
                second_location_combo.Items.Add("강화군");
                second_location_combo.Items.Add("옹진군");
            }
            else if (selectedRegion == "울산광역시")
            {
                second_location_combo.Items.Add("동구");
                second_location_combo.Items.Add("서구");
                second_location_combo.Items.Add("남구");
                second_location_combo.Items.Add("북구");
                second_location_combo.Items.Add("광산구");
            }
            else if (selectedRegion == "대전광역시")
            {
                second_location_combo.Items.Add("동구");
                second_location_combo.Items.Add("중구");
                second_location_combo.Items.Add("서구");
                second_location_combo.Items.Add("유성구");
                second_location_combo.Items.Add("대덕구");
            }
            else if (selectedRegion == "대전광역시")
            {
                second_location_combo.Items.Add("중구");
                second_location_combo.Items.Add("남구");
                second_location_combo.Items.Add("동구");
                second_location_combo.Items.Add("북구");
                second_location_combo.Items.Add("을주군");
            }
            else if (selectedRegion == "세종특별자치시")
            {
                second_location_combo.Items.Add("None");
            }
            else if (selectedRegion == "강원특별자치도")
            {
                second_location_combo.Items.Add("춘천시");
                second_location_combo.Items.Add("원주시");
                second_location_combo.Items.Add("강릉시");
                second_location_combo.Items.Add("동해시");
                second_location_combo.Items.Add("태백시");
                second_location_combo.Items.Add("속초시");
                second_location_combo.Items.Add("삼척시");
                second_location_combo.Items.Add("홍천군");
                second_location_combo.Items.Add("횡성군");
                second_location_combo.Items.Add("영월군");
                second_location_combo.Items.Add("평창군");
                second_location_combo.Items.Add("정선군");
                second_location_combo.Items.Add("철원군");
                second_location_combo.Items.Add("화천군");
                second_location_combo.Items.Add("양구군");
                second_location_combo.Items.Add("인제군");
                second_location_combo.Items.Add("고성군");
            }
            else if (selectedRegion == "충천북도")
            {
                second_location_combo.Items.Add("청주시");
                second_location_combo.Items.Add("충주시");
                second_location_combo.Items.Add("제천시");
                second_location_combo.Items.Add("보은군");
                second_location_combo.Items.Add("육천군");
                second_location_combo.Items.Add("영동군");
                second_location_combo.Items.Add("중평군");
                second_location_combo.Items.Add("진천군");
                second_location_combo.Items.Add("괴산군");
                second_location_combo.Items.Add("음성군");
                second_location_combo.Items.Add("단양군");
            }
            else if (selectedRegion == "충청남도")
            {
                second_location_combo.Items.Add("천안시");
                second_location_combo.Items.Add("공주시");
                second_location_combo.Items.Add("보령시");
                second_location_combo.Items.Add("아산시");
                second_location_combo.Items.Add("서산시");
                second_location_combo.Items.Add("논산시");
                second_location_combo.Items.Add("계룡시");
                second_location_combo.Items.Add("당진시");
                second_location_combo.Items.Add("금산군");
                second_location_combo.Items.Add("부여군");
                second_location_combo.Items.Add("서천군");
                second_location_combo.Items.Add("청양군");
                second_location_combo.Items.Add("홍성군");
                second_location_combo.Items.Add("예산군");
                second_location_combo.Items.Add("태안군");
            }
            else if (selectedRegion == "전라북도")
            {
                second_location_combo.Items.Add("전주시");
                second_location_combo.Items.Add("군산시");
                second_location_combo.Items.Add("익산시");
                second_location_combo.Items.Add("정읍시");
                second_location_combo.Items.Add("남원시");
                second_location_combo.Items.Add("김제시");
                second_location_combo.Items.Add("완주군");
                second_location_combo.Items.Add("진안군");
                second_location_combo.Items.Add("무주군");
                second_location_combo.Items.Add("장수군");
                second_location_combo.Items.Add("임실군");
                second_location_combo.Items.Add("순창군");
                second_location_combo.Items.Add("고창군");
                second_location_combo.Items.Add("부안군");
            }
            else if (selectedRegion == "전라남도")
            {
                second_location_combo.Items.Add("목포시");
                second_location_combo.Items.Add("여수시");
                second_location_combo.Items.Add("순천시");
                second_location_combo.Items.Add("나주시");
                second_location_combo.Items.Add("광양시");
                second_location_combo.Items.Add("담양군");
                second_location_combo.Items.Add("곡선군");
                second_location_combo.Items.Add("구례군");
                second_location_combo.Items.Add("고흥군");
                second_location_combo.Items.Add("보성군");
                second_location_combo.Items.Add("화순군");
                second_location_combo.Items.Add("장흥군");
                second_location_combo.Items.Add("강진군");
                second_location_combo.Items.Add("해남군");
                second_location_combo.Items.Add("영암군");
                second_location_combo.Items.Add("무안군");
                second_location_combo.Items.Add("함평군");
                second_location_combo.Items.Add("영광군");
                second_location_combo.Items.Add("장성군");
                second_location_combo.Items.Add("완도군");
                second_location_combo.Items.Add("진도군");
                second_location_combo.Items.Add("신안군");
            }
            else if (selectedRegion == "경상북도")
            {
                second_location_combo.Items.Add("포항시");
                second_location_combo.Items.Add("경주시");
                second_location_combo.Items.Add("김천시");
                second_location_combo.Items.Add("안동시");
                second_location_combo.Items.Add("구미시");
                second_location_combo.Items.Add("영주시");
                second_location_combo.Items.Add("영천시");
                second_location_combo.Items.Add("상주시");
                second_location_combo.Items.Add("문경시");
                second_location_combo.Items.Add("경상시");
                second_location_combo.Items.Add("의성군");
                second_location_combo.Items.Add("청송군");
                second_location_combo.Items.Add("영양군");
                second_location_combo.Items.Add("영덕군");
                second_location_combo.Items.Add("청도군");
                second_location_combo.Items.Add("고령군");
                second_location_combo.Items.Add("성주군");
                second_location_combo.Items.Add("칠곡군");
                second_location_combo.Items.Add("예천군");
                second_location_combo.Items.Add("봉화군");
                second_location_combo.Items.Add("을진군");
                second_location_combo.Items.Add("울릉군");
            }
            else if (selectedRegion == "경상남도")
            {
                second_location_combo.Items.Add("창원시");
                second_location_combo.Items.Add("진주시");
                second_location_combo.Items.Add("통영시");
                second_location_combo.Items.Add("사천시");
                second_location_combo.Items.Add("김해시");
                second_location_combo.Items.Add("밀양시");
                second_location_combo.Items.Add("거제시");
                second_location_combo.Items.Add("양산시");
                second_location_combo.Items.Add("의령군");
                second_location_combo.Items.Add("함안군");
                second_location_combo.Items.Add("창녕군");
                second_location_combo.Items.Add("고성군");
                second_location_combo.Items.Add("남해군");
                second_location_combo.Items.Add("하동군");
                second_location_combo.Items.Add("산청군");
                second_location_combo.Items.Add("함양군");
                second_location_combo.Items.Add("거창군");
                second_location_combo.Items.Add("합천군");
            }
            else if (selectedRegion == "제주특별자치도")
            {
                second_location_combo.Items.Add("제주시");
                second_location_combo.Items.Add("서귀포시");
            }
        }

        private void map_picture_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "이미지를 선택하세요";
                openFileDialog.Filter = "이미지 파일 (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|모든 파일 (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.image_path = openFileDialog.FileName; // 선택된 파일의 경로를 가져옴
                    byte[] imageBytes = File.ReadAllBytes(image_path);
                    Console.WriteLine(this.image_path);

                    Image image;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        image = Image.FromStream(ms);
                    }

                    // PictureBox에 이미지 할당
                    hospital_map_img.Image = image;

                    // PictureBox 다시 그리기
                    hospital_map_img.Refresh();

                    // 데이터베이스 업데이트
                    db.UpdateHospitalMapImage(PK, imageBytes);
                }
            }
        }
        public string ShowFileOpenDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "파일 오픈 예제창";
            ofd.FileName = "test";
            ofd.Filter = "모든 파일 (*.*) | *.*";

            //파일 오픈창 로드
            DialogResult dr = ofd.ShowDialog();

            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {
                //File명과 확장자를 가지고 온다.
                string fileName = ofd.SafeFileName;
                //File경로와 File명을 모두 가지고 온다.
                string fileFullName = ofd.FileName;
                //File경로만 가지고 온다.
                string filePath = fileFullName.Replace(fileName, "");

                //출력 예제용 로직
                //label1.Text = "File Name  : " + fileName;
                //label2.Text = "Full Name  : " + fileFullName;
                //label3.Text = "File Path  : " + filePath;
                //File경로 + 파일명 리턴
                return fileFullName;
            }
            //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
            else if (dr == DialogResult.Cancel)
            {
                return "";
            }

            return "";
        }
    }
}
