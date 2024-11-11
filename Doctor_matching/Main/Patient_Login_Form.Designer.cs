
namespace Main
{
    partial class Patient_Login_Form
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
            this.join_membership_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.back_btn);
            this.groupBox1.Controls.Add(this.join_membership_btn);
            this.groupBox1.Controls.Add(this.login_btn);
            this.groupBox1.Controls.Add(this.pass_txt);
            this.groupBox1.Controls.Add(this.id_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(26, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "환자 로그인";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(316, 200);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(129, 35);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "뒤로가기";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // join_membership_btn
            // 
            this.join_membership_btn.Location = new System.Drawing.Point(67, 200);
            this.join_membership_btn.Name = "join_membership_btn";
            this.join_membership_btn.Size = new System.Drawing.Size(129, 35);
            this.join_membership_btn.TabIndex = 5;
            this.join_membership_btn.Text = "회원가입";
            this.join_membership_btn.UseVisualStyleBackColor = true;
            this.join_membership_btn.Click += new System.EventHandler(this.join_membership_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(352, 67);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(93, 73);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "접속";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(152, 114);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(175, 26);
            this.pass_txt.TabIndex = 3;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(152, 67);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(175, 26);
            this.id_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디 :";
            // 
            // Patient_Login_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(554, 331);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Patient_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Login_Form";
            this.Load += new System.EventHandler(this.Patient_Login_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button join_membership_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
    }
}