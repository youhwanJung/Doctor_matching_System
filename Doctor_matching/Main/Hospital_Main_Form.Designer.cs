
namespace Main
{
    partial class Hospital_Main_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.message_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.register_doctor_view = new System.Windows.Forms.DataGridView();
            this.register_btn = new System.Windows.Forms.Button();
            this.chagne_info_btn = new System.Windows.Forms.Button();
            this.patient_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.want_docter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.want_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.want_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceept = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profile = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.career = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coment_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.like_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.register_cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.message_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.register_doctor_view)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.refresh_btn);
            this.groupBox1.Controls.Add(this.message_view);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.register_doctor_view);
            this.groupBox1.Controls.Add(this.register_btn);
            this.groupBox1.Controls.Add(this.chagne_info_btn);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1527, 755);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "부천대병원 환영합니다";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(705, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "메세지";
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(491, 45);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(145, 42);
            this.refresh_btn.TabIndex = 5;
            this.refresh_btn.Text = "새로고침";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // message_view
            // 
            this.message_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.message_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patient_name,
            this.age,
            this.want_docter,
            this.want_day,
            this.want_time,
            this.aceept,
            this.cancel,
            this.Column1});
            this.message_view.Location = new System.Drawing.Point(709, 57);
            this.message_view.Name = "message_view";
            this.message_view.RowTemplate.Height = 37;
            this.message_view.Size = new System.Drawing.Size(795, 679);
            this.message_view.TabIndex = 4;
            this.message_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.message_view_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(15, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "현재 등록한 의사 목록";
            // 
            // register_doctor_view
            // 
            this.register_doctor_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.register_doctor_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.register_doctor_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.register_doctor_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profile,
            this.name,
            this.career,
            this.coment_num,
            this.like_num,
            this.register_cancel});
            this.register_doctor_view.Location = new System.Drawing.Point(19, 156);
            this.register_doctor_view.Name = "register_doctor_view";
            this.register_doctor_view.RowTemplate.Height = 37;
            this.register_doctor_view.Size = new System.Drawing.Size(617, 585);
            this.register_doctor_view.TabIndex = 2;
            this.register_doctor_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.register_doctor_view_CellContentClick);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(255, 45);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(145, 42);
            this.register_btn.TabIndex = 1;
            this.register_btn.Text = "의사 등록";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // chagne_info_btn
            // 
            this.chagne_info_btn.Location = new System.Drawing.Point(19, 45);
            this.chagne_info_btn.Name = "chagne_info_btn";
            this.chagne_info_btn.Size = new System.Drawing.Size(145, 42);
            this.chagne_info_btn.TabIndex = 0;
            this.chagne_info_btn.Text = "병원 정보 변경";
            this.chagne_info_btn.UseVisualStyleBackColor = true;
            this.chagne_info_btn.Click += new System.EventHandler(this.chagne_info_btn_Click);
            // 
            // patient_name
            // 
            this.patient_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.patient_name.HeaderText = "환자이름";
            this.patient_name.Name = "patient_name";
            this.patient_name.Width = 97;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.age.HeaderText = "나이";
            this.age.Name = "age";
            this.age.Width = 65;
            // 
            // want_docter
            // 
            this.want_docter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.want_docter.HeaderText = "희망의사";
            this.want_docter.Name = "want_docter";
            this.want_docter.Width = 97;
            // 
            // want_day
            // 
            this.want_day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.want_day.HeaderText = "희망날짜";
            this.want_day.Name = "want_day";
            this.want_day.Width = 97;
            // 
            // want_time
            // 
            this.want_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.want_time.HeaderText = "희망시간";
            this.want_time.Name = "want_time";
            this.want_time.Width = 97;
            // 
            // aceept
            // 
            this.aceept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aceept.HeaderText = "수락";
            this.aceept.Name = "aceept";
            this.aceept.Width = 46;
            // 
            // cancel
            // 
            this.cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cancel.HeaderText = "취소";
            this.cancel.Name = "cancel";
            this.cancel.Width = 46;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "예약 정보";
            this.Column1.Name = "Column1";
            // 
            // profile
            // 
            this.profile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.profile.HeaderText = "프로필";
            this.profile.Name = "profile";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "이름";
            this.name.Name = "name";
            // 
            // career
            // 
            this.career.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.career.HeaderText = "경력";
            this.career.Name = "career";
            // 
            // coment_num
            // 
            this.coment_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coment_num.HeaderText = "진료과";
            this.coment_num.Name = "coment_num";
            // 
            // like_num
            // 
            this.like_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.like_num.HeaderText = "추천수";
            this.like_num.Name = "like_num";
            // 
            // register_cancel
            // 
            this.register_cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.register_cancel.HeaderText = "등록해제";
            this.register_cancel.Name = "register_cancel";
            this.register_cancel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.register_cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Hospital_Main_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1559, 771);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Hospital_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital_Main_Form";
            this.Load += new System.EventHandler(this.Hospital_Main_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.message_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.register_doctor_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button chagne_info_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.DataGridView register_doctor_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.DataGridView message_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn want_docter;
        private System.Windows.Forms.DataGridViewTextBoxColumn want_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn want_time;
        private System.Windows.Forms.DataGridViewButtonColumn aceept;
        private System.Windows.Forms.DataGridViewButtonColumn cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn career;
        private System.Windows.Forms.DataGridViewTextBoxColumn coment_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn like_num;
        private System.Windows.Forms.DataGridViewButtonColumn register_cancel;
    }
}