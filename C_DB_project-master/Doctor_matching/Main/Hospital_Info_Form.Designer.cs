
namespace Main
{
    partial class Hospital_Info_Form
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
            this.patient_main_box = new System.Windows.Forms.GroupBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.hospital_sickbed_view = new System.Windows.Forms.DataGridView();
            this.sickbed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sickbed_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sickbed_explain_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.hospital_department_view = new System.Windows.Forms.DataGridView();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_explain_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.introduce_txt = new System.Windows.Forms.Label();
            this.e_mail_txt = new System.Windows.Forms.Label();
            this.phone_num_txt = new System.Windows.Forms.Label();
            this.hospital_division_txt = new System.Windows.Forms.Label();
            this.location_txt = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.division_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patient_main_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_sickbed_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_department_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // patient_main_box
            // 
            this.patient_main_box.Controls.Add(this.back_btn);
            this.patient_main_box.Controls.Add(this.pictureBox1);
            this.patient_main_box.Controls.Add(this.label14);
            this.patient_main_box.Controls.Add(this.hospital_sickbed_view);
            this.patient_main_box.Controls.Add(this.label13);
            this.patient_main_box.Controls.Add(this.hospital_department_view);
            this.patient_main_box.Controls.Add(this.introduce_txt);
            this.patient_main_box.Controls.Add(this.e_mail_txt);
            this.patient_main_box.Controls.Add(this.phone_num_txt);
            this.patient_main_box.Controls.Add(this.hospital_division_txt);
            this.patient_main_box.Controls.Add(this.location_txt);
            this.patient_main_box.Controls.Add(this.name_txt);
            this.patient_main_box.Controls.Add(this.label7);
            this.patient_main_box.Controls.Add(this.label6);
            this.patient_main_box.Controls.Add(this.label4);
            this.patient_main_box.Controls.Add(this.division_label);
            this.patient_main_box.Controls.Add(this.label2);
            this.patient_main_box.Controls.Add(this.label1);
            this.patient_main_box.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.patient_main_box.Location = new System.Drawing.Point(12, 12);
            this.patient_main_box.Name = "patient_main_box";
            this.patient_main_box.Size = new System.Drawing.Size(1205, 897);
            this.patient_main_box.TabIndex = 5;
            this.patient_main_box.TabStop = false;
            this.patient_main_box.Text = "병원 정보";
            this.patient_main_box.Enter += new System.EventHandler(this.patient_main_box_Enter);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.back_btn.Location = new System.Drawing.Point(1020, 28);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(158, 48);
            this.back_btn.TabIndex = 21;
            this.back_btn.Text = "뒤로 가기";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(844, 420);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 19);
            this.label14.TabIndex = 19;
            this.label14.Text = "보유 병동";
            // 
            // hospital_sickbed_view
            // 
            this.hospital_sickbed_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hospital_sickbed_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sickbed,
            this.sickbed_num,
            this.sickbed_explain_btn});
            this.hospital_sickbed_view.Location = new System.Drawing.Point(692, 442);
            this.hospital_sickbed_view.Name = "hospital_sickbed_view";
            this.hospital_sickbed_view.ReadOnly = true;
            this.hospital_sickbed_view.RowTemplate.Height = 37;
            this.hospital_sickbed_view.Size = new System.Drawing.Size(437, 435);
            this.hospital_sickbed_view.TabIndex = 18;
            this.hospital_sickbed_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hospital_sickbed_view_CellContentClick);
            // 
            // sickbed
            // 
            this.sickbed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sickbed.HeaderText = "병동";
            this.sickbed.Name = "sickbed";
            this.sickbed.ReadOnly = true;
            // 
            // sickbed_num
            // 
            this.sickbed_num.HeaderText = "병동수";
            this.sickbed_num.Name = "sickbed_num";
            this.sickbed_num.ReadOnly = true;
            // 
            // sickbed_explain_btn
            // 
            this.sickbed_explain_btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sickbed_explain_btn.HeaderText = "설명보기";
            this.sickbed_explain_btn.Name = "sickbed_explain_btn";
            this.sickbed_explain_btn.ReadOnly = true;
            this.sickbed_explain_btn.Width = 91;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(224, 420);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 19);
            this.label13.TabIndex = 17;
            this.label13.Text = "보유 진료과";
            // 
            // hospital_department_view
            // 
            this.hospital_department_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hospital_department_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department,
            this.department_explain_btn});
            this.hospital_department_view.Location = new System.Drawing.Point(72, 442);
            this.hospital_department_view.Name = "hospital_department_view";
            this.hospital_department_view.ReadOnly = true;
            this.hospital_department_view.RowTemplate.Height = 37;
            this.hospital_department_view.Size = new System.Drawing.Size(437, 435);
            this.hospital_department_view.TabIndex = 16;
            this.hospital_department_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hospital_department_view_CellContentClick);
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department.HeaderText = "진료과";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // department_explain_btn
            // 
            this.department_explain_btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.department_explain_btn.HeaderText = "설명보기";
            this.department_explain_btn.Name = "department_explain_btn";
            this.department_explain_btn.ReadOnly = true;
            this.department_explain_btn.Width = 91;
            // 
            // introduce_txt
            // 
            this.introduce_txt.Location = new System.Drawing.Point(162, 315);
            this.introduce_txt.Name = "introduce_txt";
            this.introduce_txt.Size = new System.Drawing.Size(474, 67);
            this.introduce_txt.TabIndex = 15;
            this.introduce_txt.Text = "\"\"";
            // 
            // e_mail_txt
            // 
            this.e_mail_txt.AutoSize = true;
            this.e_mail_txt.Location = new System.Drawing.Point(171, 269);
            this.e_mail_txt.Name = "e_mail_txt";
            this.e_mail_txt.Size = new System.Drawing.Size(21, 19);
            this.e_mail_txt.TabIndex = 13;
            this.e_mail_txt.Text = "\"\"";
            // 
            // phone_num_txt
            // 
            this.phone_num_txt.AutoSize = true;
            this.phone_num_txt.Location = new System.Drawing.Point(200, 223);
            this.phone_num_txt.Name = "phone_num_txt";
            this.phone_num_txt.Size = new System.Drawing.Size(21, 19);
            this.phone_num_txt.TabIndex = 12;
            this.phone_num_txt.Text = "\"\"";
            // 
            // hospital_division_txt
            // 
            this.hospital_division_txt.AutoSize = true;
            this.hospital_division_txt.Location = new System.Drawing.Point(158, 181);
            this.hospital_division_txt.Name = "hospital_division_txt";
            this.hospital_division_txt.Size = new System.Drawing.Size(21, 19);
            this.hospital_division_txt.TabIndex = 11;
            this.hospital_division_txt.Text = "\"\"";
            // 
            // location_txt
            // 
            this.location_txt.AutoSize = true;
            this.location_txt.Location = new System.Drawing.Point(158, 139);
            this.location_txt.Name = "location_txt";
            this.location_txt.Size = new System.Drawing.Size(21, 19);
            this.location_txt.TabIndex = 10;
            this.location_txt.Text = "\"\"";
            // 
            // name_txt
            // 
            this.name_txt.AutoSize = true;
            this.name_txt.Location = new System.Drawing.Point(158, 95);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(21, 19);
            this.name_txt.TabIndex = 9;
            this.name_txt.Text = "\"\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(53, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "병원 E_mail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(53, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "병원 전화번호 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(53, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "병원 소개 :";
            // 
            // division_label
            // 
            this.division_label.AutoSize = true;
            this.division_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.division_label.Location = new System.Drawing.Point(53, 181);
            this.division_label.Name = "division_label";
            this.division_label.Size = new System.Drawing.Size(103, 19);
            this.division_label.TabIndex = 2;
            this.division_label.Text = "병원구분 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(53, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "병원주소 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(53, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "병원이름 :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Main.Properties.Resources.hospital_location;
            this.pictureBox1.Location = new System.Drawing.Point(692, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Hospital_Info_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1236, 915);
            this.Controls.Add(this.patient_main_box);
            this.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hospital_Info_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital_Info_Form";
            this.Load += new System.EventHandler(this.Hospital_Info_Form_Load);
            this.patient_main_box.ResumeLayout(false);
            this.patient_main_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_sickbed_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_department_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox patient_main_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label division_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView hospital_sickbed_view;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView hospital_department_view;
        private System.Windows.Forms.Label introduce_txt;
        private System.Windows.Forms.Label e_mail_txt;
        private System.Windows.Forms.Label phone_num_txt;
        private System.Windows.Forms.Label hospital_division_txt;
        private System.Windows.Forms.Label location_txt;
        private System.Windows.Forms.Label name_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sickbed;
        private System.Windows.Forms.DataGridViewTextBoxColumn sickbed_num;
        private System.Windows.Forms.DataGridViewButtonColumn sickbed_explain_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewButtonColumn department_explain_btn;
        private System.Windows.Forms.Button back_btn;
    }
}