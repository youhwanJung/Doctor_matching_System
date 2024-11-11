
namespace Main
{
    partial class Reservation_Form
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
            this.am_pm_combo = new System.Windows.Forms.ComboBox();
            this.hours_combo = new System.Windows.Forms.ComboBox();
            this.minutes_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reservation_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.year_combo = new System.Windows.Forms.ComboBox();
            this.month_combo = new System.Windows.Forms.ComboBox();
            this.day_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // am_pm_combo
            // 
            this.am_pm_combo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.am_pm_combo.FormattingEnabled = true;
            this.am_pm_combo.Items.AddRange(new object[] {
            "오전",
            "오후"});
            this.am_pm_combo.Location = new System.Drawing.Point(50, 90);
            this.am_pm_combo.Name = "am_pm_combo";
            this.am_pm_combo.Size = new System.Drawing.Size(79, 24);
            this.am_pm_combo.TabIndex = 0;
            // 
            // hours_combo
            // 
            this.hours_combo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hours_combo.FormattingEnabled = true;
            this.hours_combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.hours_combo.Location = new System.Drawing.Point(150, 90);
            this.hours_combo.Name = "hours_combo";
            this.hours_combo.Size = new System.Drawing.Size(79, 24);
            this.hours_combo.TabIndex = 1;
            // 
            // minutes_txt
            // 
            this.minutes_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minutes_txt.Location = new System.Drawing.Point(263, 88);
            this.minutes_txt.Name = "minutes_txt";
            this.minutes_txt.Size = new System.Drawing.Size(100, 26);
            this.minutes_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(235, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "시";
            // 
            // reservation_btn
            // 
            this.reservation_btn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservation_btn.Location = new System.Drawing.Point(400, 42);
            this.reservation_btn.Name = "reservation_btn";
            this.reservation_btn.Size = new System.Drawing.Size(102, 74);
            this.reservation_btn.TabIndex = 5;
            this.reservation_btn.Text = "예약하기";
            this.reservation_btn.UseVisualStyleBackColor = true;
            this.reservation_btn.Click += new System.EventHandler(this.reservation_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(369, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "분";
            // 
            // year_combo
            // 
            this.year_combo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.year_combo.FormattingEnabled = true;
            this.year_combo.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026"});
            this.year_combo.Location = new System.Drawing.Point(50, 42);
            this.year_combo.Name = "year_combo";
            this.year_combo.Size = new System.Drawing.Size(79, 24);
            this.year_combo.TabIndex = 7;
            // 
            // month_combo
            // 
            this.month_combo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.month_combo.FormattingEnabled = true;
            this.month_combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.month_combo.Location = new System.Drawing.Point(163, 42);
            this.month_combo.Name = "month_combo";
            this.month_combo.Size = new System.Drawing.Size(79, 24);
            this.month_combo.TabIndex = 8;
            // 
            // day_combo
            // 
            this.day_combo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day_combo.FormattingEnabled = true;
            this.day_combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.day_combo.Location = new System.Drawing.Point(276, 42);
            this.day_combo.Name = "day_combo";
            this.day_combo.Size = new System.Drawing.Size(79, 24);
            this.day_combo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(135, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "년";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(248, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "월";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(361, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "일";
            // 
            // Reservation_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(554, 151);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.day_combo);
            this.Controls.Add(this.month_combo);
            this.Controls.Add(this.year_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reservation_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minutes_txt);
            this.Controls.Add(this.hours_combo);
            this.Controls.Add(this.am_pm_combo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reservation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox am_pm_combo;
        private System.Windows.Forms.ComboBox hours_combo;
        private System.Windows.Forms.TextBox minutes_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reservation_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox year_combo;
        private System.Windows.Forms.ComboBox month_combo;
        private System.Windows.Forms.ComboBox day_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}