
namespace Main
{
    partial class Maching_Result_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.doctor_detail_btn = new System.Windows.Forms.Button();
            this.serch_doctor_result_view = new System.Windows.Forms.DataGridView();
            this.profile = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.career_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.like_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serch_doctor_result_view)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.back_btn);
            this.groupBox1.Controls.Add(this.doctor_detail_btn);
            this.groupBox1.Controls.Add(this.serch_doctor_result_view);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1111, 632);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "\"\"";
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(923, 43);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(151, 46);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "뒤로가기";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // doctor_detail_btn
            // 
            this.doctor_detail_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_detail_btn.Location = new System.Drawing.Point(719, 43);
            this.doctor_detail_btn.Name = "doctor_detail_btn";
            this.doctor_detail_btn.Size = new System.Drawing.Size(151, 46);
            this.doctor_detail_btn.TabIndex = 2;
            this.doctor_detail_btn.Text = "상세보기";
            this.doctor_detail_btn.UseVisualStyleBackColor = true;
            this.doctor_detail_btn.Click += new System.EventHandler(this.doctor_detail_btn_Click);
            // 
            // serch_doctor_result_view
            // 
            this.serch_doctor_result_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serch_doctor_result_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serch_doctor_result_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.serch_doctor_result_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serch_doctor_result_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profile,
            this.name,
            this.hospital,
            this.career_year,
            this.e_mail,
            this.like_num});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serch_doctor_result_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.serch_doctor_result_view.Location = new System.Drawing.Point(33, 112);
            this.serch_doctor_result_view.Name = "serch_doctor_result_view";
            this.serch_doctor_result_view.RowTemplate.Height = 37;
            this.serch_doctor_result_view.Size = new System.Drawing.Size(1041, 514);
            this.serch_doctor_result_view.TabIndex = 0;
            this.serch_doctor_result_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serch_doctor_result_view_CellClick);
            this.serch_doctor_result_view.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.serch_doctor_result_view_ColumnHeaderMouseClick);
            // 
            // profile
            // 
            this.profile.HeaderText = "프로필";
            this.profile.Image = global::Main.Properties.Resources.datagridview_doctor;
            this.profile.Name = "profile";
            this.profile.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "이름";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // hospital
            // 
            this.hospital.HeaderText = "소속병원";
            this.hospital.Name = "hospital";
            this.hospital.ReadOnly = true;
            // 
            // career_year
            // 
            this.career_year.HeaderText = "경력";
            this.career_year.Name = "career_year";
            this.career_year.ReadOnly = true;
            // 
            // e_mail
            // 
            this.e_mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.e_mail.HeaderText = "E_mail";
            this.e_mail.Name = "e_mail";
            this.e_mail.ReadOnly = true;
            this.e_mail.Width = 102;
            // 
            // like_num
            // 
            this.like_num.HeaderText = "추천 수";
            this.like_num.Name = "like_num";
            this.like_num.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "프로필";
            this.dataGridViewImageColumn1.Image = global::Main.Properties.Resources.datagridview_doctor;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 166;
            // 
            // Maching_Result_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1150, 655);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Maching_Result_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matching_result_Form";
            this.Load += new System.EventHandler(this.Matching_Result_Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serch_doctor_result_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView serch_doctor_result_view;
        private System.Windows.Forms.Button doctor_detail_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn career_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn like_num;
    }
}