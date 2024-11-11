
namespace Main
{
    partial class Patient_Reservation_Inquiry_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.patient_reservation_view = new System.Windows.Forms.DataGridView();
            this.profile = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resercation_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservation_screening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resercation_cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_reservation_view)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.back_btn);
            this.groupBox1.Controls.Add(this.refresh_btn);
            this.groupBox1.Controls.Add(this.patient_reservation_view);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1392, 616);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "예약확인";
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.back_btn.Location = new System.Drawing.Point(1254, 22);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(115, 36);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "뒤로가기";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refresh_btn.Location = new System.Drawing.Point(1117, 22);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(115, 36);
            this.refresh_btn.TabIndex = 2;
            this.refresh_btn.Text = "새로고침";
            this.refresh_btn.UseVisualStyleBackColor = true;
            // 
            // patient_reservation_view
            // 
            this.patient_reservation_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patient_reservation_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patient_reservation_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.patient_reservation_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patient_reservation_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profile,
            this.name,
            this.document,
            this.date,
            this.resercation_time,
            this.reservation_screening,
            this.resercation_cancel,
            this.Column1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patient_reservation_view.DefaultCellStyle = dataGridViewCellStyle4;
            this.patient_reservation_view.Location = new System.Drawing.Point(23, 73);
            this.patient_reservation_view.Name = "patient_reservation_view";
            this.patient_reservation_view.RowTemplate.Height = 37;
            this.patient_reservation_view.Size = new System.Drawing.Size(1347, 537);
            this.patient_reservation_view.TabIndex = 1;
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
            this.name.Width = 72;
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
            this.resercation_time.Width = 110;
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
            // Column1
            // 
            this.Column1.HeaderText = "예약 확인";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Patient_Reservation_Inquiry_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1429, 645);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient_Reservation_Inquiry_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Reservation_Inquiry_Form";
            this.Load += new System.EventHandler(this.Patient_Reservation_Inquiry_Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patient_reservation_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.DataGridView patient_reservation_view;
        private System.Windows.Forms.DataGridViewImageColumn profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn document;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn resercation_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservation_screening;
        private System.Windows.Forms.DataGridViewButtonColumn resercation_cancel;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}