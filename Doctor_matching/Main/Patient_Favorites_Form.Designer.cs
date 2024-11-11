
namespace Main
{
    partial class Patient_Favorites_Form
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
            this.back_btn = new System.Windows.Forms.Button();
            this.facorites_doctor_detail_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.back_btn);
            this.groupBox1.Controls.Add(this.facorites_doctor_detail_btn);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 616);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "즐겨찾기";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.back_btn.Location = new System.Drawing.Point(858, 22);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(115, 36);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "뒤로가기";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // facorites_doctor_detail_btn
            // 
            this.facorites_doctor_detail_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.facorites_doctor_detail_btn.Location = new System.Drawing.Point(721, 22);
            this.facorites_doctor_detail_btn.Name = "facorites_doctor_detail_btn";
            this.facorites_doctor_detail_btn.Size = new System.Drawing.Size(115, 36);
            this.facorites_doctor_detail_btn.TabIndex = 2;
            this.facorites_doctor_detail_btn.Text = "상세보기";
            this.facorites_doctor_detail_btn.UseVisualStyleBackColor = true;
            this.facorites_doctor_detail_btn.Click += new System.EventHandler(this.facorites_doctor_detail_btn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(938, 511);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Patient_Favorites_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1047, 645);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient_Favorites_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_favorites_Form";
            this.Load += new System.EventHandler(this.Patient_Favorites_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button facorites_doctor_detail_btn;
        private System.Windows.Forms.ListView listView1;
    }
}