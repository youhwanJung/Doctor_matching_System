
namespace Main
{
    partial class Hospital_Department_ex
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
            this.department_name = new System.Windows.Forms.Label();
            this.department_ex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // department_name
            // 
            this.department_name.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.department_name.Location = new System.Drawing.Point(89, 9);
            this.department_name.Name = "department_name";
            this.department_name.Size = new System.Drawing.Size(438, 78);
            this.department_name.TabIndex = 0;
            this.department_name.Text = "신경과";
            // 
            // department_ex
            // 
            this.department_ex.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.department_ex.Location = new System.Drawing.Point(24, 97);
            this.department_ex.Name = "department_ex";
            this.department_ex.Size = new System.Drawing.Size(555, 180);
            this.department_ex.TabIndex = 1;
            this.department_ex.Text = "label1";
            // 
            // Hospital_Department_ex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 316);
            this.Controls.Add(this.department_ex);
            this.Controls.Add(this.department_name);
            this.Name = "Hospital_Department_ex";
            this.Text = "Hospital_Department_ex";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label department_name;
        private System.Windows.Forms.Label department_ex;
    }
}