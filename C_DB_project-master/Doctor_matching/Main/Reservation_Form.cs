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
    public partial class Reservation_Form : Form
    {
        
        private DBconn db = new DBconn();
        private decimal PatientPK;
        private decimal DoctorPK;
        public Reservation_Form(decimal PatientPK, decimal DoctorPK)
        {
            InitializeComponent();
            this.PatientPK = PatientPK;
            this.DoctorPK = DoctorPK;
        }

        private void reservation_btn_Click(object sender, EventArgs e)
        {
            string year = year_combo.SelectedItem.ToString();
            string month = month_combo.SelectedItem.ToString();
            string day = day_combo.SelectedItem.ToString();

            string date = year + "년 " + month + "월 " + day + "일";
 
            string am_pm = am_pm_combo.SelectedItem.ToString();
            string houre = hours_combo.SelectedItem.ToString();
            string minutes = minutes_txt.Text;

            string time = am_pm + " " + houre + "시 " + minutes + "분";

            db.input_reservation(PatientPK, DoctorPK, date, time);
            MessageBox.Show("예약하셨습니다");
            this.Hide();
        }
    }
}
