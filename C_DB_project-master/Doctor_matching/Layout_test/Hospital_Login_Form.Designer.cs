
namespace Layout_test
{
    partial class Hospital_Login_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.join_membership_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.join_membership_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pass_txt);
            this.groupBox1.Controls.Add(this.login_btn);
            this.groupBox1.Controls.Add(this.id_txt);
            this.groupBox1.Location = new System.Drawing.Point(36, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(400, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "병원 로그인";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "아이디 :";
            // 
            // join_membership_btn
            // 
            this.join_membership_btn.Location = new System.Drawing.Point(16, 118);
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
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호 :";
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(90, 79);
            this.pass_txt.Margin = new System.Windows.Forms.Padding(2);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(156, 21);
            this.pass_txt.TabIndex = 1;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(262, 33);
            this.login_btn.Margin = new System.Windows.Forms.Padding(2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(83, 67);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "접속";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(90, 33);
            this.id_txt.Margin = new System.Windows.Forms.Padding(2);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(156, 21);
            this.id_txt.TabIndex = 0;
            // 
            // Hospital_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 251);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Hospital_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hospital_Login_Form";
            this.Load += new System.EventHandler(this.Hospital_Login_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button join_membership_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox id_txt;
    }
}