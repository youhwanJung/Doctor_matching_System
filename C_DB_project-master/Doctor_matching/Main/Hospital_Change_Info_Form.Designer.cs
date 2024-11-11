
namespace Main
{
    partial class Hospital_Change_Info_Form
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
            this.e_mail_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.complete_btn = new System.Windows.Forms.Button();
            this.map_picture_btn = new System.Windows.Forms.Button();
            this.hospital_map_img = new System.Windows.Forms.PictureBox();
            this.have_sickbed_btn = new System.Windows.Forms.Button();
            this.have_department_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.doctor_num_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hospital_division_combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phone_num_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.third_location_combo = new System.Windows.Forms.TextBox();
            this.second_location_combo = new System.Windows.Forms.ComboBox();
            this.first_location_combo = new System.Windows.Forms.ComboBox();
            this.significant_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_map_img)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.e_mail_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.back_btn);
            this.groupBox1.Controls.Add(this.complete_btn);
            this.groupBox1.Controls.Add(this.map_picture_btn);
            this.groupBox1.Controls.Add(this.hospital_map_img);
            this.groupBox1.Controls.Add(this.have_sickbed_btn);
            this.groupBox1.Controls.Add(this.have_department_btn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.doctor_num_txt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.hospital_division_combo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.phone_num_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.third_location_combo);
            this.groupBox1.Controls.Add(this.second_location_combo);
            this.groupBox1.Controls.Add(this.first_location_combo);
            this.groupBox1.Controls.Add(this.significant_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 605);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "정보를 변경해주세요";
            // 
            // e_mail_txt
            // 
            this.e_mail_txt.Location = new System.Drawing.Point(113, 488);
            this.e_mail_txt.Name = "e_mail_txt";
            this.e_mail_txt.Size = new System.Drawing.Size(177, 26);
            this.e_mail_txt.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "E_mail :";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(909, 25);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(98, 37);
            this.back_btn.TabIndex = 34;
            this.back_btn.Text = "뒤로가기";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // complete_btn
            // 
            this.complete_btn.Location = new System.Drawing.Point(438, 524);
            this.complete_btn.Name = "complete_btn";
            this.complete_btn.Size = new System.Drawing.Size(158, 57);
            this.complete_btn.TabIndex = 5;
            this.complete_btn.Text = "변경 완료";
            this.complete_btn.UseVisualStyleBackColor = true;
            this.complete_btn.Click += new System.EventHandler(this.complete_btn_Click);
            // 
            // map_picture_btn
            // 
            this.map_picture_btn.Location = new System.Drawing.Point(758, 460);
            this.map_picture_btn.Name = "map_picture_btn";
            this.map_picture_btn.Size = new System.Drawing.Size(156, 47);
            this.map_picture_btn.TabIndex = 33;
            this.map_picture_btn.Text = "지도 그림 설정";
            this.map_picture_btn.UseVisualStyleBackColor = true;
            this.map_picture_btn.Click += new System.EventHandler(this.map_picture_btn_Click);
            // 
            // hospital_map_img
            // 
            this.hospital_map_img.Image = global::Main.Properties.Resources.hospital_location;
            this.hospital_map_img.Location = new System.Drawing.Point(657, 159);
            this.hospital_map_img.Name = "hospital_map_img";
            this.hospital_map_img.Size = new System.Drawing.Size(350, 291);
            this.hospital_map_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hospital_map_img.TabIndex = 32;
            this.hospital_map_img.TabStop = false;
            // 
            // have_sickbed_btn
            // 
            this.have_sickbed_btn.Location = new System.Drawing.Point(851, 83);
            this.have_sickbed_btn.Name = "have_sickbed_btn";
            this.have_sickbed_btn.Size = new System.Drawing.Size(156, 47);
            this.have_sickbed_btn.TabIndex = 31;
            this.have_sickbed_btn.Text = "보유 병상 설정";
            this.have_sickbed_btn.UseVisualStyleBackColor = true;
            this.have_sickbed_btn.Click += new System.EventHandler(this.have_sickbed_btn_Click);
            // 
            // have_department_btn
            // 
            this.have_department_btn.Location = new System.Drawing.Point(657, 83);
            this.have_department_btn.Name = "have_department_btn";
            this.have_department_btn.Size = new System.Drawing.Size(156, 47);
            this.have_department_btn.TabIndex = 30;
            this.have_department_btn.Text = "보유 진료과 설정";
            this.have_department_btn.UseVisualStyleBackColor = true;
            this.have_department_btn.Click += new System.EventHandler(this.have_department_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "명";
            // 
            // doctor_num_txt
            // 
            this.doctor_num_txt.Location = new System.Drawing.Point(113, 436);
            this.doctor_num_txt.Name = "doctor_num_txt";
            this.doctor_num_txt.Size = new System.Drawing.Size(177, 26);
            this.doctor_num_txt.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "의사 수 :";
            // 
            // hospital_division_combo
            // 
            this.hospital_division_combo.FormattingEnabled = true;
            this.hospital_division_combo.Items.AddRange(new object[] {
            "상급종합병원",
            "종합병원",
            "병원",
            "요양병원",
            "의원",
            "치과병원",
            "치과의원",
            "조산원",
            "한방병원",
            "한의원",
            "보건의료원",
            "보건소",
            "보건지소",
            "보건진료소",
            "약국"});
            this.hospital_division_combo.Location = new System.Drawing.Point(123, 158);
            this.hospital_division_combo.Name = "hospital_division_combo";
            this.hospital_division_combo.Size = new System.Drawing.Size(189, 24);
            this.hospital_division_combo.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "병원구분 :";
            // 
            // phone_num_txt
            // 
            this.phone_num_txt.Location = new System.Drawing.Point(123, 379);
            this.phone_num_txt.Name = "phone_num_txt";
            this.phone_num_txt.Size = new System.Drawing.Size(256, 26);
            this.phone_num_txt.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "전화번호 :";
            // 
            // third_location_combo
            // 
            this.third_location_combo.Location = new System.Drawing.Point(400, 104);
            this.third_location_combo.Name = "third_location_combo";
            this.third_location_combo.Size = new System.Drawing.Size(196, 26);
            this.third_location_combo.TabIndex = 16;
            // 
            // second_location_combo
            // 
            this.second_location_combo.FormattingEnabled = true;
            this.second_location_combo.Location = new System.Drawing.Point(258, 106);
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
            this.first_location_combo.Location = new System.Drawing.Point(92, 106);
            this.first_location_combo.Name = "first_location_combo";
            this.first_location_combo.Size = new System.Drawing.Size(157, 24);
            this.first_location_combo.TabIndex = 14;
            this.first_location_combo.SelectedIndexChanged += new System.EventHandler(this.first_location_combo_SelectedIndexChanged);
            // 
            // significant_txt
            // 
            this.significant_txt.Location = new System.Drawing.Point(123, 210);
            this.significant_txt.Multiline = true;
            this.significant_txt.Name = "significant_txt";
            this.significant_txt.Size = new System.Drawing.Size(446, 144);
            this.significant_txt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "특이사항 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "위치 :";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(123, 59);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(175, 26);
            this.name_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "병원이름 :";
            // 
            // Hospital_Change_Info_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1051, 628);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Hospital_Change_Info_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital_Change_Info_Form";
            this.Load += new System.EventHandler(this.Hospital_Change_Info_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_map_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button map_picture_btn;
        private System.Windows.Forms.Button have_sickbed_btn;
        private System.Windows.Forms.Button have_department_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox doctor_num_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox hospital_division_combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone_num_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox third_location_combo;
        private System.Windows.Forms.ComboBox second_location_combo;
        private System.Windows.Forms.ComboBox first_location_combo;
        private System.Windows.Forms.TextBox significant_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button complete_btn;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox e_mail_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox hospital_map_img;
    }
}