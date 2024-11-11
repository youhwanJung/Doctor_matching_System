
namespace Main
{
    partial class Hospital_Regist_Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital_Regist_Doctor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.career_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.department_combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.significant_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.phone_num_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.doctor_image = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_image)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.career_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.department_combo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.register_btn);
            this.groupBox1.Controls.Add(this.back_btn);
            this.groupBox1.Controls.Add(this.significant_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.email_txt);
            this.groupBox1.Controls.Add(this.phone_num_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.name_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.doctor_image);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 463);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "의사 등록";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "년";
            // 
            // career_txt
            // 
            this.career_txt.Location = new System.Drawing.Point(362, 77);
            this.career_txt.Name = "career_txt";
            this.career_txt.Size = new System.Drawing.Size(79, 26);
            this.career_txt.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "경력 :";
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
            "피부과",
            "치과",
            "안과(원내의원)"});
            this.department_combo.Location = new System.Drawing.Point(362, 212);
            this.department_combo.Name = "department_combo";
            this.department_combo.Size = new System.Drawing.Size(185, 24);
            this.department_combo.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "주 진료과 :";
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(340, 388);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(116, 41);
            this.register_btn.TabIndex = 32;
            this.register_btn.Text = "등록하기";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(692, 25);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(116, 41);
            this.back_btn.TabIndex = 31;
            this.back_btn.Text = "뒤로가기";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // significant_txt
            // 
            this.significant_txt.Location = new System.Drawing.Point(362, 259);
            this.significant_txt.Multiline = true;
            this.significant_txt.Name = "significant_txt";
            this.significant_txt.Size = new System.Drawing.Size(446, 92);
            this.significant_txt.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "간단 소개 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "E_Mail :";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(362, 166);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(273, 26);
            this.email_txt.TabIndex = 27;
            // 
            // phone_num_txt
            // 
            this.phone_num_txt.Location = new System.Drawing.Point(362, 116);
            this.phone_num_txt.Name = "phone_num_txt";
            this.phone_num_txt.Size = new System.Drawing.Size(256, 26);
            this.phone_num_txt.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "전화번호 :";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(362, 40);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(175, 26);
            this.name_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "이름 :";
            // 
            // doctor_image
            // 
            this.doctor_image.Image = global::Main.Properties.Resources.doctor_original;
            this.doctor_image.InitialImage = ((System.Drawing.Image)(resources.GetObject("doctor_image.InitialImage")));
            this.doctor_image.Location = new System.Drawing.Point(25, 104);
            this.doctor_image.Name = "doctor_image";
            this.doctor_image.Size = new System.Drawing.Size(200, 200);
            this.doctor_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doctor_image.TabIndex = 1;
            this.doctor_image.TabStop = false;
            // 
            // Hospital_Regist_Doctor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(852, 492);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Hospital_Regist_Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital_Regist_Doctor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox doctor_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox phone_num_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox significant_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox department_combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox career_txt;
        private System.Windows.Forms.Label label3;
    }
}