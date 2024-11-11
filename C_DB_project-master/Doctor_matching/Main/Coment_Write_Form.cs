using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Coment_Write_Form : Form
    {
        private Doctor_Detail_Form update;
        private DBconn db;
        private DoctorData select_doctor;
        private decimal PK;

        public Coment_Write_Form(decimal PK, DoctorData select_doctor)
        {
            InitializeComponent();
            db = new DBconn();
            this.PK = PK;
            this.select_doctor = select_doctor;
        }

        private void Coment_Write_Form_Load(object sender, EventArgs e)
        {

        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            
            decimal DoctorPK = select_doctor.DoctorSerialNumber;
            decimal PatientPK = PK;
            string comment = coment_txt.Text;
            db.input_comment(PatientPK, DoctorPK, comment);
            MessageBox.Show("댓글이 작성되었습니다!");
            this.Hide();
        }
    }
}
