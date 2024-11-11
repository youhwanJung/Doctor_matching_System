
namespace Main
{
    partial class Patient_Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Main_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.patient_main_box = new System.Windows.Forms.GroupBox();
            this.matching_btn = new System.Windows.Forms.Button();
            this.search_hospital_btn = new System.Windows.Forms.Button();
            this.change_info_btn = new System.Windows.Forms.Button();
            this.user_name_label = new System.Windows.Forms.Label();
            this.department_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_image = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.department_explain_btn = new System.Windows.Forms.Button();
            this.sickbed_explain_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.patient_reservation_view = new System.Windows.Forms.DataGridView();
            this.profile = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resercation_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservation_screening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resercation_cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reservation_check = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.facorites_doctor_detail_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.patient_main_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_image)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_reservation_view)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // patient_main_box
            // 
            this.patient_main_box.Controls.Add(this.matching_btn);
            this.patient_main_box.Controls.Add(this.search_hospital_btn);
            this.patient_main_box.Controls.Add(this.change_info_btn);
            this.patient_main_box.Controls.Add(this.user_name_label);
            this.patient_main_box.Controls.Add(this.department_label);
            this.patient_main_box.Controls.Add(this.label1);
            this.patient_main_box.Controls.Add(this.user_image);
            this.patient_main_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_main_box.Location = new System.Drawing.Point(22, 72);
            this.patient_main_box.Name = "patient_main_box";
            this.patient_main_box.Size = new System.Drawing.Size(433, 320);
            this.patient_main_box.TabIndex = 4;
            this.patient_main_box.TabStop = false;
            this.patient_main_box.Text = "정유환님 환영합니다!";
            this.patient_main_box.Enter += new System.EventHandler(this.patient_main_box_Enter);
            // 
            // matching_btn
            // 
            this.matching_btn.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.matching_btn.Location = new System.Drawing.Point(225, 96);
            this.matching_btn.Name = "matching_btn";
            this.matching_btn.Size = new System.Drawing.Size(160, 79);
            this.matching_btn.TabIndex = 13;
            this.matching_btn.Text = "매칭하기";
            this.matching_btn.UseVisualStyleBackColor = true;
            this.matching_btn.Click += new System.EventHandler(this.matching_btn_Click);
            // 
            // search_hospital_btn
            // 
            this.search_hospital_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_hospital_btn.Location = new System.Drawing.Point(225, 51);
            this.search_hospital_btn.Name = "search_hospital_btn";
            this.search_hospital_btn.Size = new System.Drawing.Size(160, 38);
            this.search_hospital_btn.TabIndex = 11;
            this.search_hospital_btn.Text = "병원찾기";
            this.search_hospital_btn.UseVisualStyleBackColor = true;
            this.search_hospital_btn.Click += new System.EventHandler(this.search_hospital_btn_Click);
            // 
            // change_info_btn
            // 
            this.change_info_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_info_btn.Location = new System.Drawing.Point(59, 197);
            this.change_info_btn.Name = "change_info_btn";
            this.change_info_btn.Size = new System.Drawing.Size(117, 29);
            this.change_info_btn.TabIndex = 8;
            this.change_info_btn.Text = "개인정보 변경";
            this.change_info_btn.UseVisualStyleBackColor = true;
            this.change_info_btn.Click += new System.EventHandler(this.change_info_btn_Click);
            // 
            // user_name_label
            // 
            this.user_name_label.AutoSize = true;
            this.user_name_label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_name_label.Location = new System.Drawing.Point(83, 178);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(72, 16);
            this.user_name_label.TabIndex = 7;
            this.user_name_label.Text = "정유환님";
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.department_label.Location = new System.Drawing.Point(232, 248);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(23, 19);
            this.department_label.TabIndex = 3;
            this.department_label.Text = "\"\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(41, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "현재 설정한 진료과 :";
            // 
            // user_image
            // 
            this.user_image.Image = global::Main.Properties.Resources.user_default_image;
            this.user_image.InitialImage = ((System.Drawing.Image)(resources.GetObject("user_image.InitialImage")));
            this.user_image.Location = new System.Drawing.Point(34, 51);
            this.user_image.Name = "user_image";
            this.user_image.Size = new System.Drawing.Size(162, 124);
            this.user_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_image.TabIndex = 0;
            this.user_image.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.department_explain_btn);
            this.groupBox2.Controls.Add(this.sickbed_explain_btn);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(42, 573);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 207);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "도움말";
            // 
            // department_explain_btn
            // 
            this.department_explain_btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.department_explain_btn.Location = new System.Drawing.Point(57, 60);
            this.department_explain_btn.Name = "department_explain_btn";
            this.department_explain_btn.Size = new System.Drawing.Size(284, 38);
            this.department_explain_btn.TabIndex = 15;
            this.department_explain_btn.Text = "자세한 진료과 설명";
            this.department_explain_btn.UseVisualStyleBackColor = true;
            this.department_explain_btn.Click += new System.EventHandler(this.department_explain_btn_Click);
            // 
            // sickbed_explain_btn
            // 
            this.sickbed_explain_btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sickbed_explain_btn.Location = new System.Drawing.Point(57, 137);
            this.sickbed_explain_btn.Name = "sickbed_explain_btn";
            this.sickbed_explain_btn.Size = new System.Drawing.Size(284, 38);
            this.sickbed_explain_btn.TabIndex = 14;
            this.sickbed_explain_btn.Text = "병상 종류와 기능 설명";
            this.sickbed_explain_btn.UseVisualStyleBackColor = true;
            this.sickbed_explain_btn.Click += new System.EventHandler(this.sickbed_explain_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.patient_reservation_view);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(489, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 434);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "예약 조회 현황입니다!";
            // 
            // patient_reservation_view
            // 
            this.patient_reservation_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patient_reservation_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.patient_reservation_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patient_reservation_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profile,
            this.name,
            this.document,
            this.date,
            this.resercation_time,
            this.reservation_screening,
            this.resercation_cancel,
            this.reservation_check});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patient_reservation_view.DefaultCellStyle = dataGridViewCellStyle1;
            this.patient_reservation_view.Location = new System.Drawing.Point(23, 40);
            this.patient_reservation_view.Name = "patient_reservation_view";
            this.patient_reservation_view.RowTemplate.Height = 37;
            this.patient_reservation_view.Size = new System.Drawing.Size(1314, 359);
            this.patient_reservation_view.TabIndex = 2;
            this.patient_reservation_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patient_reservation_view_CellContentClick);
            // 
            // profile
            // 
            this.profile.HeaderText = "의사프로필";
            this.profile.Image = global::Main.Properties.Resources.datagridview_doctor;
            this.profile.Name = "profile";
            this.profile.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "이름";
            this.name.Name = "name";
            this.name.Width = 65;
            // 
            // document
            // 
            this.document.HeaderText = "진료과";
            this.document.Name = "document";
            this.document.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "예약날짜";
            this.date.Name = "date";
            // 
            // resercation_time
            // 
            this.resercation_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.resercation_time.HeaderText = "예약시간";
            this.resercation_time.Name = "resercation_time";
            this.resercation_time.ReadOnly = true;
            this.resercation_time.Width = 95;
            // 
            // reservation_screening
            // 
            this.reservation_screening.HeaderText = "예약심사";
            this.reservation_screening.Name = "reservation_screening";
            this.reservation_screening.ReadOnly = true;
            // 
            // resercation_cancel
            // 
            this.resercation_cancel.HeaderText = "예약취소";
            this.resercation_cancel.Name = "resercation_cancel";
            this.resercation_cancel.ReadOnly = true;
            this.resercation_cancel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.resercation_cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // reservation_check
            // 
            this.reservation_check.HeaderText = "예약 확인";
            this.reservation_check.Name = "reservation_check";
            this.reservation_check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reservation_check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.facorites_doctor_detail_btn);
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(603, 482);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1122, 377);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "즐겨찾기 현황입니다!";
            // 
            // facorites_doctor_detail_btn
            // 
            this.facorites_doctor_detail_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.facorites_doctor_detail_btn.Location = new System.Drawing.Point(980, 42);
            this.facorites_doctor_detail_btn.Name = "facorites_doctor_detail_btn";
            this.facorites_doctor_detail_btn.Size = new System.Drawing.Size(115, 102);
            this.facorites_doctor_detail_btn.TabIndex = 6;
            this.facorites_doctor_detail_btn.Text = "상세보기";
            this.facorites_doctor_detail_btn.UseVisualStyleBackColor = true;
            this.facorites_doctor_detail_btn.Click += new System.EventHandler(this.facorites_doctor_detail_btn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(938, 322);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Patient_Main_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1886, 919);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.patient_main_box);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Main_Form";
            this.Load += new System.EventHandler(this.Patient_Main_Form_Load);
            this.patient_main_box.ResumeLayout(false);
            this.patient_main_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_image)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patient_reservation_view)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox patient_main_box;
        private System.Windows.Forms.PictureBox user_image;
        private System.Windows.Forms.Button change_info_btn;
        private System.Windows.Forms.Label user_name_label;
        private System.Windows.Forms.Button search_hospital_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sickbed_explain_btn;
        private System.Windows.Forms.Button matching_btn;
        private System.Windows.Forms.Button department_explain_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView patient_reservation_view;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button facorites_doctor_detail_btn;
        private System.Windows.Forms.DataGridViewImageColumn profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn document;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn resercation_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservation_screening;
        private System.Windows.Forms.DataGridViewButtonColumn resercation_cancel;
        private System.Windows.Forms.DataGridViewButtonColumn reservation_check;
    }
}