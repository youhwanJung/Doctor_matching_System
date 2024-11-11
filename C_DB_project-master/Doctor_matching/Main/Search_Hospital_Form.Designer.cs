
namespace Main
{
    partial class Search_Hospital_Form
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
            this.search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hospital_name_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_btn.Location = new System.Drawing.Point(401, 35);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(102, 34);
            this.search_btn.TabIndex = 11;
            this.search_btn.Text = "찾기";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "병원이름 :";
            // 
            // hospital_name_txt
            // 
            this.hospital_name_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hospital_name_txt.Location = new System.Drawing.Point(112, 41);
            this.hospital_name_txt.Name = "hospital_name_txt";
            this.hospital_name_txt.Size = new System.Drawing.Size(283, 26);
            this.hospital_name_txt.TabIndex = 13;
            // 
            // Search_Hospital_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(515, 108);
            this.Controls.Add(this.hospital_name_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Search_Hospital_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_hospital_Form";
            this.Load += new System.EventHandler(this.Search_Hospital_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hospital_name_txt;
    }
}