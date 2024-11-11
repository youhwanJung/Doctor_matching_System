
namespace Layout_test
{
    partial class Patient_Join_Membership_Form
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
            this.pass_check_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.join_membership_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pass_check_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.join_membership_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pass_txt);
            this.groupBox1.Controls.Add(this.id_txt);
            this.groupBox1.Location = new System.Drawing.Point(41, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(330, 226);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "환자 회원가입";
            // 
            // pass_check_txt
            // 
            this.pass_check_txt.Location = new System.Drawing.Point(117, 132);
            this.pass_check_txt.Margin = new System.Windows.Forms.Padding(2);
            this.pass_check_txt.Name = "pass_check_txt";
            this.pass_check_txt.Size = new System.Drawing.Size(156, 21);
            this.pass_check_txt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "비밀번호 확인";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "아이디";
            // 
            // join_membership_btn
            // 
            this.join_membership_btn.Location = new System.Drawing.Point(104, 176);
            this.join_membership_btn.Margin = new System.Windows.Forms.Padding(2);
            this.join_membership_btn.Name = "join_membership_btn";
            this.join_membership_btn.Size = new System.Drawing.Size(101, 28);
            this.join_membership_btn.TabIndex = 5;
            this.join_membership_btn.Text = "회원가입";
            this.join_membership_btn.UseVisualStyleBackColor = true;
            this.join_membership_btn.Click += new System.EventHandler(this.join_membership_btn_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호";
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(117, 88);
            this.pass_txt.Margin = new System.Windows.Forms.Padding(2);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(156, 21);
            this.pass_txt.TabIndex = 1;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(117, 50);
            this.id_txt.Margin = new System.Windows.Forms.Padding(2);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(156, 21);
            this.id_txt.TabIndex = 0;
            // 
            // Patient_Join_Membership_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 301);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient_Join_Membership_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Join_Membership_Form";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pass_check_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button join_membership_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.TextBox id_txt;
    }
}