
namespace Main
{
    partial class Doctor_Detail_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_Detail_Form));
            this.doctor_detail_box = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.doctor_coment_view = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conntent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.good_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.good = new System.Windows.Forms.DataGridViewButtonColumn();
            this.write_coment_btn = new System.Windows.Forms.Button();
            this.reservation_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.favorites_btn = new System.Windows.Forms.Button();
            this.recommend_btn = new System.Windows.Forms.Button();
            this.hospital_detail_btn = new System.Windows.Forms.Button();
            this.introduce_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.phone_num_label = new System.Windows.Forms.Label();
            this.department_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hospital_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.doctor_image = new System.Windows.Forms.PictureBox();
            this.doctor_detail_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_coment_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_image)).BeginInit();
            this.SuspendLayout();
            // 
            // doctor_detail_box
            // 
            this.doctor_detail_box.Controls.Add(this.button1);
            this.doctor_detail_box.Controls.Add(this.doctor_coment_view);
            this.doctor_detail_box.Controls.Add(this.write_coment_btn);
            this.doctor_detail_box.Controls.Add(this.reservation_btn);
            this.doctor_detail_box.Controls.Add(this.back_btn);
            this.doctor_detail_box.Controls.Add(this.favorites_btn);
            this.doctor_detail_box.Controls.Add(this.recommend_btn);
            this.doctor_detail_box.Controls.Add(this.hospital_detail_btn);
            this.doctor_detail_box.Controls.Add(this.introduce_label);
            this.doctor_detail_box.Controls.Add(this.email_label);
            this.doctor_detail_box.Controls.Add(this.phone_num_label);
            this.doctor_detail_box.Controls.Add(this.department_label);
            this.doctor_detail_box.Controls.Add(this.label7);
            this.doctor_detail_box.Controls.Add(this.label6);
            this.doctor_detail_box.Controls.Add(this.label5);
            this.doctor_detail_box.Controls.Add(this.hospital_label);
            this.doctor_detail_box.Controls.Add(this.label3);
            this.doctor_detail_box.Controls.Add(this.label2);
            this.doctor_detail_box.Controls.Add(this.name_label);
            this.doctor_detail_box.Controls.Add(this.doctor_image);
            this.doctor_detail_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_detail_box.Location = new System.Drawing.Point(30, 12);
            this.doctor_detail_box.Name = "doctor_detail_box";
            this.doctor_detail_box.Size = new System.Drawing.Size(1158, 792);
            this.doctor_detail_box.TabIndex = 5;
            this.doctor_detail_box.TabStop = false;
            this.doctor_detail_box.Text = "의사정보";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(832, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "새로고침";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctor_coment_view
            // 
            this.doctor_coment_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctor_coment_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.conntent,
            this.good_num,
            this.good});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.doctor_coment_view.DefaultCellStyle = dataGridViewCellStyle10;
            this.doctor_coment_view.Location = new System.Drawing.Point(16, 359);
            this.doctor_coment_view.Name = "doctor_coment_view";
            this.doctor_coment_view.RowTemplate.Height = 37;
            this.doctor_coment_view.Size = new System.Drawing.Size(1068, 427);
            this.doctor_coment_view.TabIndex = 18;
            this.doctor_coment_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctor_coment_view_CellContentClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle6;
            this.name.HeaderText = "작성자";
            this.name.Name = "name";
            this.name.Width = 80;
            // 
            // conntent
            // 
            this.conntent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.conntent.DefaultCellStyle = dataGridViewCellStyle7;
            this.conntent.HeaderText = "댓글내용";
            this.conntent.Name = "conntent";
            // 
            // good_num
            // 
            this.good_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.good_num.DefaultCellStyle = dataGridViewCellStyle8;
            this.good_num.HeaderText = "추천수";
            this.good_num.Name = "good_num";
            this.good_num.Width = 80;
            // 
            // good
            // 
            this.good.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.good.DefaultCellStyle = dataGridViewCellStyle9;
            this.good.HeaderText = "추천하기";
            this.good.Name = "good";
            this.good.Width = 76;
            // 
            // write_coment_btn
            // 
            this.write_coment_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.write_coment_btn.Location = new System.Drawing.Point(967, 307);
            this.write_coment_btn.Name = "write_coment_btn";
            this.write_coment_btn.Size = new System.Drawing.Size(117, 43);
            this.write_coment_btn.TabIndex = 17;
            this.write_coment_btn.Text = "댓글쓰기";
            this.write_coment_btn.UseVisualStyleBackColor = true;
            this.write_coment_btn.Click += new System.EventHandler(this.write_coment_btn_Click);
            // 
            // reservation_btn
            // 
            this.reservation_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_btn.Location = new System.Drawing.Point(808, 103);
            this.reservation_btn.Name = "reservation_btn";
            this.reservation_btn.Size = new System.Drawing.Size(276, 152);
            this.reservation_btn.TabIndex = 16;
            this.reservation_btn.Text = "예약하기";
            this.reservation_btn.UseVisualStyleBackColor = true;
            this.reservation_btn.Click += new System.EventHandler(this.reservation_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(924, 28);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(160, 38);
            this.back_btn.TabIndex = 15;
            this.back_btn.Text = "뒤로가기";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // favorites_btn
            // 
            this.favorites_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorites_btn.Location = new System.Drawing.Point(713, 28);
            this.favorites_btn.Name = "favorites_btn";
            this.favorites_btn.Size = new System.Drawing.Size(160, 38);
            this.favorites_btn.TabIndex = 14;
            this.favorites_btn.Text = "즐겨찾기";
            this.favorites_btn.UseVisualStyleBackColor = true;
            this.favorites_btn.Click += new System.EventHandler(this.favorites_btn_Click);
            // 
            // recommend_btn
            // 
            this.recommend_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommend_btn.Location = new System.Drawing.Point(506, 28);
            this.recommend_btn.Name = "recommend_btn";
            this.recommend_btn.Size = new System.Drawing.Size(160, 38);
            this.recommend_btn.TabIndex = 13;
            this.recommend_btn.Text = "추천하기";
            this.recommend_btn.UseVisualStyleBackColor = true;
            this.recommend_btn.Click += new System.EventHandler(this.recommend_btn_Click);
            // 
            // hospital_detail_btn
            // 
            this.hospital_detail_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospital_detail_btn.Location = new System.Drawing.Point(293, 28);
            this.hospital_detail_btn.Name = "hospital_detail_btn";
            this.hospital_detail_btn.Size = new System.Drawing.Size(160, 38);
            this.hospital_detail_btn.TabIndex = 12;
            this.hospital_detail_btn.Text = "병원상세보기";
            this.hospital_detail_btn.UseVisualStyleBackColor = true;
            this.hospital_detail_btn.Click += new System.EventHandler(this.hospital_detail_btn_Click);
            // 
            // introduce_label
            // 
            this.introduce_label.AutoSize = true;
            this.introduce_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.introduce_label.Location = new System.Drawing.Point(311, 284);
            this.introduce_label.Name = "introduce_label";
            this.introduce_label.Size = new System.Drawing.Size(21, 19);
            this.introduce_label.TabIndex = 11;
            this.introduce_label.Text = "\"\"";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.email_label.Location = new System.Drawing.Point(324, 236);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(21, 19);
            this.email_label.TabIndex = 10;
            this.email_label.Text = "\"\"";
            // 
            // phone_num_label
            // 
            this.phone_num_label.AutoSize = true;
            this.phone_num_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phone_num_label.Location = new System.Drawing.Point(349, 191);
            this.phone_num_label.Name = "phone_num_label";
            this.phone_num_label.Size = new System.Drawing.Size(21, 19);
            this.phone_num_label.TabIndex = 9;
            this.phone_num_label.Text = "\"\"";
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.department_label.Location = new System.Drawing.Point(374, 149);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(21, 19);
            this.department_label.TabIndex = 8;
            this.department_label.Text = "\"\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(246, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "소개 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(246, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "E_Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(246, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "전화번호 :";
            // 
            // hospital_label
            // 
            this.hospital_label.AutoSize = true;
            this.hospital_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hospital_label.Location = new System.Drawing.Point(349, 103);
            this.hospital_label.Name = "hospital_label";
            this.hospital_label.Size = new System.Drawing.Size(21, 19);
            this.hospital_label.TabIndex = 4;
            this.hospital_label.Text = "\"\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(246, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "주요 진료과 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(246, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "소속병원 :";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_label.Location = new System.Drawing.Point(89, 319);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(21, 19);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "\"\"";
            // 
            // doctor_image
            // 
            this.doctor_image.Image = global::Main.Properties.Resources.doctor_original;
            this.doctor_image.InitialImage = ((System.Drawing.Image)(resources.GetObject("doctor_image.InitialImage")));
            this.doctor_image.Location = new System.Drawing.Point(16, 103);
            this.doctor_image.Name = "doctor_image";
            this.doctor_image.Size = new System.Drawing.Size(200, 200);
            this.doctor_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doctor_image.TabIndex = 0;
            this.doctor_image.TabStop = false;
            // 
            // Doctor_Detail_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1213, 816);
            this.Controls.Add(this.doctor_detail_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Doctor_Detail_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor_Detail_Form";
            this.Load += new System.EventHandler(this.Doctor_Detail_Form_Load);
            this.doctor_detail_box.ResumeLayout(false);
            this.doctor_detail_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_coment_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox doctor_detail_box;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox doctor_image;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hospital_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label introduce_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phone_num_label;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button hospital_detail_btn;
        private System.Windows.Forms.Button recommend_btn;
        private System.Windows.Forms.Button reservation_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button write_coment_btn;
        private System.Windows.Forms.DataGridView doctor_coment_view;
        private System.Windows.Forms.Button favorites_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn conntent;
        private System.Windows.Forms.DataGridViewTextBoxColumn good_num;
        private System.Windows.Forms.DataGridViewButtonColumn good;
        private System.Windows.Forms.Button button1;
    }
}