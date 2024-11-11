using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout_test
{
    public partial class Patient_Info_Save_Form : Form
    {
        public Patient_Info_Save_Form()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }
        private void First_location_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Second_location_combo.Items.Clear();

            string selectedRegion = Second_location_combo.SelectedItem.ToString();


            if (selectedRegion == "서울특별시")
            {
                // 서울시 선택 시
                Second_location_combo.Items.Add("종로구");
                Second_location_combo.Items.Add("중구");
                Second_location_combo.Items.Add("용산구");
                Second_location_combo.Items.Add("성동구");
                Second_location_combo.Items.Add("광진구");
                Second_location_combo.Items.Add("동내문구");
                Second_location_combo.Items.Add("중랑구");
                Second_location_combo.Items.Add("성북구");
                Second_location_combo.Items.Add("강북구");
                Second_location_combo.Items.Add("도봉구");
                Second_location_combo.Items.Add("노원구");
                Second_location_combo.Items.Add("은평구");
                Second_location_combo.Items.Add("서대문구");
                Second_location_combo.Items.Add("마포구");
                Second_location_combo.Items.Add("양천구");
                Second_location_combo.Items.Add("강서구");
                Second_location_combo.Items.Add("구로구");
                Second_location_combo.Items.Add("금천구");
                Second_location_combo.Items.Add("영등포구");
                Second_location_combo.Items.Add("동작구");
                Second_location_combo.Items.Add("서초구");
                Second_location_combo.Items.Add("강남구");
                Second_location_combo.Items.Add("송파구");
                Second_location_combo.Items.Add("강동구");

                // 다른 서울시 관련 구를 추가하세요
            }
            else if (selectedRegion == "경기도")
            {
                // 경기도 선택 시
                Second_location_combo.Items.Add("수원시");
                Second_location_combo.Items.Add("성남시");
                Second_location_combo.Items.Add("의정부시");
                Second_location_combo.Items.Add("안양시");
                Second_location_combo.Items.Add("부천시");
                Second_location_combo.Items.Add("광명시");
                Second_location_combo.Items.Add("동두천시");
                Second_location_combo.Items.Add("평택시");
                Second_location_combo.Items.Add("안산시");
                Second_location_combo.Items.Add("고양시");
                Second_location_combo.Items.Add("과천시");
                Second_location_combo.Items.Add("구리시");
                Second_location_combo.Items.Add("남양주시");
                Second_location_combo.Items.Add("오산시");
                Second_location_combo.Items.Add("시흥시");
                Second_location_combo.Items.Add("군포시");
                Second_location_combo.Items.Add("의왕시");
                Second_location_combo.Items.Add("하남시");
                Second_location_combo.Items.Add("용인시");
                Second_location_combo.Items.Add("파주시");
                Second_location_combo.Items.Add("이천시");
                Second_location_combo.Items.Add("안성시");
                Second_location_combo.Items.Add("김포시");
                Second_location_combo.Items.Add("화성시");
                Second_location_combo.Items.Add("광주시");
                Second_location_combo.Items.Add("양주시");
                Second_location_combo.Items.Add("포천시");
                Second_location_combo.Items.Add("여수시");
                Second_location_combo.Items.Add("연천군");
                Second_location_combo.Items.Add("가평군");
                Second_location_combo.Items.Add("양평군");

                // 다른 경기도 관련 시 또는 군을 추가하세요
            }
            else if (selectedRegion == "부산광역시")
            {
                Second_location_combo.Items.Add("중구");
                Second_location_combo.Items.Add("서구");
                Second_location_combo.Items.Add("동구");
                Second_location_combo.Items.Add("영동구");
                Second_location_combo.Items.Add("부산진구");
                Second_location_combo.Items.Add("동래구");
                Second_location_combo.Items.Add("남구");
                Second_location_combo.Items.Add("북구");
                Second_location_combo.Items.Add("강서구");
                Second_location_combo.Items.Add("해운대구");
                Second_location_combo.Items.Add("서하구");
                Second_location_combo.Items.Add("금정구");
                Second_location_combo.Items.Add("영제구");
                Second_location_combo.Items.Add("수영구");
                Second_location_combo.Items.Add("사상구");

            }
            else if (selectedRegion == "대구광역시")
            {
                Second_location_combo.Items.Add("중구");
                Second_location_combo.Items.Add("동구");
                Second_location_combo.Items.Add("서구");
                Second_location_combo.Items.Add("남구");
                Second_location_combo.Items.Add("북구");
                Second_location_combo.Items.Add("수성구");
                Second_location_combo.Items.Add("달서구");
                Second_location_combo.Items.Add("달성군");
                Second_location_combo.Items.Add("군위군");
            }
            else if (selectedRegion == "대구광역시")
            {
                Second_location_combo.Items.Add("중구");
                Second_location_combo.Items.Add("동구");
                Second_location_combo.Items.Add("미주홀구");
                Second_location_combo.Items.Add("연수구");
                Second_location_combo.Items.Add("남동구");
                Second_location_combo.Items.Add("부평구");
                Second_location_combo.Items.Add("계양구");
                Second_location_combo.Items.Add("서구");
                Second_location_combo.Items.Add("강화군");
                Second_location_combo.Items.Add("옹진군");
            }
            else if (selectedRegion == "광주광역시")
            {
                Second_location_combo.Items.Add("동구");
                Second_location_combo.Items.Add("서구");
                Second_location_combo.Items.Add("남구");
                Second_location_combo.Items.Add("북구");
                Second_location_combo.Items.Add("광산구");
            }
            else if (selectedRegion == "대전광역시")
            {
                Second_location_combo.Items.Add("동구");
                Second_location_combo.Items.Add("중구");
                Second_location_combo.Items.Add("서구");
                Second_location_combo.Items.Add("유성구");
                Second_location_combo.Items.Add("대덕구");
            }
            else if (selectedRegion == "대전광역시")
            {
                Second_location_combo.Items.Add("중구");
                Second_location_combo.Items.Add("남구");
                Second_location_combo.Items.Add("동구");
                Second_location_combo.Items.Add("북구");
                Second_location_combo.Items.Add("을주군");
            }
            else if (selectedRegion == "세종특별자치시")
            {
                Second_location_combo.Items.Add("None");
            }
            else if (selectedRegion == "강원특별자치도")
            {
                Second_location_combo.Items.Add("춘천시");
                Second_location_combo.Items.Add("원주시");
                Second_location_combo.Items.Add("강릉시");
                Second_location_combo.Items.Add("동해시");
                Second_location_combo.Items.Add("태백시");
                Second_location_combo.Items.Add("속초시");
                Second_location_combo.Items.Add("삼척시");
                Second_location_combo.Items.Add("홍천군");
                Second_location_combo.Items.Add("횡성군");
                Second_location_combo.Items.Add("영월군");
                Second_location_combo.Items.Add("평창군");
                Second_location_combo.Items.Add("정선군");
                Second_location_combo.Items.Add("철원군");
                Second_location_combo.Items.Add("화천군");
                Second_location_combo.Items.Add("양구군");
                Second_location_combo.Items.Add("인제군");
                Second_location_combo.Items.Add("고성군");
            }
            else if (selectedRegion == "충청북도")
            {
                Second_location_combo.Items.Add("청주시");
                Second_location_combo.Items.Add("충주시");
                Second_location_combo.Items.Add("제천시");
                Second_location_combo.Items.Add("보은군");
                Second_location_combo.Items.Add("육천군");
                Second_location_combo.Items.Add("영동군");
                Second_location_combo.Items.Add("중평군");
                Second_location_combo.Items.Add("진천군");
                Second_location_combo.Items.Add("괴산군");
                Second_location_combo.Items.Add("음성군");
                Second_location_combo.Items.Add("단양군");
            }
            else if (selectedRegion == "충청남도")
            {
                Second_location_combo.Items.Add("천안시");
                Second_location_combo.Items.Add("공주시");
                Second_location_combo.Items.Add("보령시");
                Second_location_combo.Items.Add("아산시");
                Second_location_combo.Items.Add("서산시");
                Second_location_combo.Items.Add("논산시");
                Second_location_combo.Items.Add("계룡시");
                Second_location_combo.Items.Add("당진시");
                Second_location_combo.Items.Add("금산군");
                Second_location_combo.Items.Add("부여군");
                Second_location_combo.Items.Add("서천군");
                Second_location_combo.Items.Add("청양군");
                Second_location_combo.Items.Add("홍성군");
                Second_location_combo.Items.Add("예산군");
                Second_location_combo.Items.Add("태안군");
            }
            else if (selectedRegion == "전라북도")
            {
                Second_location_combo.Items.Add("전주시");
                Second_location_combo.Items.Add("군산시");
                Second_location_combo.Items.Add("익산시");
                Second_location_combo.Items.Add("정읍시");
                Second_location_combo.Items.Add("남원시");
                Second_location_combo.Items.Add("김제시");
                Second_location_combo.Items.Add("완주군");
                Second_location_combo.Items.Add("진안군");
                Second_location_combo.Items.Add("무주군");
                Second_location_combo.Items.Add("장수군");
                Second_location_combo.Items.Add("임실군");
                Second_location_combo.Items.Add("순창군");
                Second_location_combo.Items.Add("고창군");
                Second_location_combo.Items.Add("부안군");
            }
            else if (selectedRegion == "전라남도")
            {
                Second_location_combo.Items.Add("목포시");
                Second_location_combo.Items.Add("여수시");
                Second_location_combo.Items.Add("순천시");
                Second_location_combo.Items.Add("나주시");
                Second_location_combo.Items.Add("광양시");
                Second_location_combo.Items.Add("담양군");
                Second_location_combo.Items.Add("곡선군");
                Second_location_combo.Items.Add("구례군");
                Second_location_combo.Items.Add("고흥군");
                Second_location_combo.Items.Add("보성군");
                Second_location_combo.Items.Add("화순군");
                Second_location_combo.Items.Add("장흥군");
                Second_location_combo.Items.Add("강진군");
                Second_location_combo.Items.Add("해남군");
                Second_location_combo.Items.Add("영암군");
                Second_location_combo.Items.Add("무안군");
                Second_location_combo.Items.Add("함평군");
                Second_location_combo.Items.Add("영광군");
                Second_location_combo.Items.Add("장성군");
                Second_location_combo.Items.Add("완도군");
                Second_location_combo.Items.Add("진도군");
                Second_location_combo.Items.Add("신안군");
            }
            else if (selectedRegion == "경상북도")
            {
                Second_location_combo.Items.Add("포항시");
                Second_location_combo.Items.Add("경주시");
                Second_location_combo.Items.Add("김천시");
                Second_location_combo.Items.Add("안동시");
                Second_location_combo.Items.Add("구미시");
                Second_location_combo.Items.Add("영주시");
                Second_location_combo.Items.Add("영천시");
                Second_location_combo.Items.Add("상주시");
                Second_location_combo.Items.Add("문경시");
                Second_location_combo.Items.Add("경상시");
                Second_location_combo.Items.Add("의성군");
                Second_location_combo.Items.Add("청송군");
                Second_location_combo.Items.Add("영양군");
                Second_location_combo.Items.Add("영덕군");
                Second_location_combo.Items.Add("청도군");
                Second_location_combo.Items.Add("고령군");
                Second_location_combo.Items.Add("성주군");
                Second_location_combo.Items.Add("칠곡군");
                Second_location_combo.Items.Add("예천군");
                Second_location_combo.Items.Add("봉화군");
                Second_location_combo.Items.Add("을진군");
                Second_location_combo.Items.Add("울릉군");
            }
            else if (selectedRegion == "경상남도")
            {
                Second_location_combo.Items.Add("창원시");
                Second_location_combo.Items.Add("진주시");
                Second_location_combo.Items.Add("통영시");
                Second_location_combo.Items.Add("사천시");
                Second_location_combo.Items.Add("김해시");
                Second_location_combo.Items.Add("밀양시");
                Second_location_combo.Items.Add("거제시");
                Second_location_combo.Items.Add("양산시");
                Second_location_combo.Items.Add("의령군");
                Second_location_combo.Items.Add("함안군");
                Second_location_combo.Items.Add("창녕군");
                Second_location_combo.Items.Add("고성군");
                Second_location_combo.Items.Add("남해군");
                Second_location_combo.Items.Add("하동군");
                Second_location_combo.Items.Add("산청군");
                Second_location_combo.Items.Add("함양군");
                Second_location_combo.Items.Add("거창군");
                Second_location_combo.Items.Add("합천군");
            }
            else if (selectedRegion == "제주특별자치도")
            {
                Second_location_combo.Items.Add("제주시");
                Second_location_combo.Items.Add("서귀포시");
            }


        }

        private void Patient_Info_Save_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
