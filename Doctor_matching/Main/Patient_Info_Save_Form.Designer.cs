
namespace Main
{
    partial class Patient_Info_Save_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.department_combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.third_location_txt = new System.Windows.Forms.TextBox();
            this.second_location_combo = new System.Windows.Forms.ComboBox();
            this.first_location_combo = new System.Windows.Forms.ComboBox();
            this.significant_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.women_radio = new System.Windows.Forms.RadioButton();
            this.men_radio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.complete_btn = new System.Windows.Forms.Button();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.age_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.phone_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.department_combo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.third_location_txt);
            this.groupBox1.Controls.Add(this.second_location_combo);
            this.groupBox1.Controls.Add(this.first_location_combo);
            this.groupBox1.Controls.Add(this.significant_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.women_radio);
            this.groupBox1.Controls.Add(this.men_radio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.email_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.complete_btn);
            this.groupBox1.Controls.Add(this.name_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 636);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "정보를  작성해 주세요";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "살";
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(92, 148);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(93, 26);
            this.age_txt.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "나이 :";
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(123, 232);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(256, 26);
            this.phone_txt.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "전화번호 :";
            // 
            // department_combo
            // 
            this.department_combo.FormattingEnabled = true;
            this.department_combo.Items.AddRange(new object[] {
            "가정의학과",
            "내과",
            "마취통증학과",
            "산부인과",
            "소아청소년과",
            "신경과",
            "신경외과",
            "심장내과",
            "영상의학과",
            "외과",
            "응급의학과",
            "정형외과",
            "재활의학과",
            "진단검사의학과",
            "심장혈관흉부외과",
            "피부 및 비뇨기과(원내의원)",
            "치과",
            "안과(원내의원)"});
            this.department_combo.Location = new System.Drawing.Point(161, 187);
            this.department_combo.Name = "department_combo";
            this.department_combo.Size = new System.Drawing.Size(185, 24);
            this.department_combo.TabIndex = 20;
            this.department_combo.SelectedIndexChanged += new System.EventHandler(this.department_combo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "원하는 진료과 :";
            // 
            // third_location_txt
            // 
            this.third_location_txt.Location = new System.Drawing.Point(402, 322);
            this.third_location_txt.Name = "third_location_txt";
            this.third_location_txt.Size = new System.Drawing.Size(196, 26);
            this.third_location_txt.TabIndex = 16;
            // 
            // second_location_combo
            // 
            this.second_location_combo.FormattingEnabled = true;
            this.second_location_combo.Location = new System.Drawing.Point(258, 322);
            this.second_location_combo.Name = "second_location_combo";
            this.second_location_combo.Size = new System.Drawing.Size(121, 24);
            this.second_location_combo.TabIndex = 15;
            // 
            // first_location_combo
            // 
            this.first_location_combo.FormattingEnabled = true;
            this.first_location_combo.Items.AddRange(new object[] {
            "서울특별시",
            "부산광역시",
            "대구광역시",
            "인천광역시",
            "광주광역시",
            "대전광역시",
            "울산광역시",
            "세종특별자치시",
            "경기도",
            "강원특별자치도",
            "충천북도",
            "전라남도",
            "경상북도",
            "경상남도",
            "제주특별자치도"});
            this.first_location_combo.Location = new System.Drawing.Point(92, 322);
            this.first_location_combo.Name = "first_location_combo";
            this.first_location_combo.Size = new System.Drawing.Size(157, 24);
            this.first_location_combo.TabIndex = 14;
            this.first_location_combo.SelectedIndexChanged += new System.EventHandler(this.first_location_combo_SelectedIndexChanged);
            // 
            // significant_txt
            // 
            this.significant_txt.Location = new System.Drawing.Point(132, 372);
            this.significant_txt.Multiline = true;
            this.significant_txt.Name = "significant_txt";
            this.significant_txt.Size = new System.Drawing.Size(446, 144);
            this.significant_txt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "특이사항 :";
            // 
            // women_radio
            // 
            this.women_radio.AutoSize = true;
            this.women_radio.Location = new System.Drawing.Point(166, 108);
            this.women_radio.Name = "women_radio";
            this.women_radio.Size = new System.Drawing.Size(58, 20);
            this.women_radio.TabIndex = 11;
            this.women_radio.TabStop = true;
            this.women_radio.Text = "여자";
            this.women_radio.UseVisualStyleBackColor = true;
            // 
            // men_radio
            // 
            this.men_radio.AutoSize = true;
            this.men_radio.Location = new System.Drawing.Point(92, 108);
            this.men_radio.Name = "men_radio";
            this.men_radio.Size = new System.Drawing.Size(58, 20);
            this.men_radio.TabIndex = 10;
            this.men_radio.TabStop = true;
            this.men_radio.Text = "남자";
            this.men_radio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "성별 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "E_Mail :";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(106, 274);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(273, 26);
            this.email_txt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "위치 :";
            // 
            // complete_btn
            // 
            this.complete_btn.Location = new System.Drawing.Point(239, 554);
            this.complete_btn.Name = "complete_btn";
            this.complete_btn.Size = new System.Drawing.Size(158, 57);
            this.complete_btn.TabIndex = 5;
            this.complete_btn.Text = "작성 완료";
            this.complete_btn.UseVisualStyleBackColor = true;
            this.complete_btn.Click += new System.EventHandler(this.complete_btn_Click);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(90, 59);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(175, 26);
            this.name_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 :";
            // 
            // Patient_Info_Save_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(704, 683);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient_Info_Save_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Info_Save_Form";
            this.Load += new System.EventHandler(this.Patient_Info_Save_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button complete_btn;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton women_radio;
        private System.Windows.Forms.RadioButton men_radio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox significant_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox third_location_txt;
        private System.Windows.Forms.ComboBox second_location_combo;
        private System.Windows.Forms.ComboBox first_location_combo;
        private System.Windows.Forms.ComboBox department_combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.Label label8;
    }
}