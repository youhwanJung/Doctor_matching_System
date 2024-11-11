
namespace Main
{
    partial class Hospital_sicbed_ex
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
            this.sickbed_name = new System.Windows.Forms.Label();
            this.sickbed_ex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sickbed_name
            // 
            this.sickbed_name.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sickbed_name.Location = new System.Drawing.Point(80, 18);
            this.sickbed_name.Name = "sickbed_name";
            this.sickbed_name.Size = new System.Drawing.Size(438, 78);
            this.sickbed_name.TabIndex = 0;
            this.sickbed_name.Text = "label1";
            // 
            // sickbed_ex
            // 
            this.sickbed_ex.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sickbed_ex.Location = new System.Drawing.Point(21, 105);
            this.sickbed_ex.Name = "sickbed_ex";
            this.sickbed_ex.Size = new System.Drawing.Size(555, 180);
            this.sickbed_ex.TabIndex = 1;
            this.sickbed_ex.Text = "label2";
            // 
            // Hospital_sicbed_ex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 316);
            this.Controls.Add(this.sickbed_ex);
            this.Controls.Add(this.sickbed_name);
            this.Name = "Hospital_sicbed_ex";
            this.Text = "Hospital_sicbed_ex";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label sickbed_name;
        private System.Windows.Forms.Label sickbed_ex;
    }
}