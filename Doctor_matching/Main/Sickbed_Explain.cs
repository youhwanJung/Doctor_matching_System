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
    public partial class Sickbed_Explain : Form
    {
        public Sickbed_Explain()
        {
            InitializeComponent();
            List<Bed> bedList = new List<Bed>();
            DBconn db = new DBconn();
            bedList = db.GetAllBeds();

            foreach (Bed bed in bedList)
            {
                sickbed_view.Rows.Add(bed.BedName, bed.BedDescription);
            }
            /*
            sickbed_view.Rows.Add();
            sickbed_view.Rows[0].Cells[0].Value = "일반병상";
            sickbed_view.Rows[0].Cells[1].Value = "블라블라블라블라블라블라블라블라블라블라블라블라블라" +
                "블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라" +
                "블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블라블" +
                "라블라블라블라블라블라블라블라블라블라";
            */
        }

        private void Sickbed_Explain_Load(object sender, EventArgs e)
        {

        }
    }
}
