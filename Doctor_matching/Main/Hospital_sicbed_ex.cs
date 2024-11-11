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
    public partial class Hospital_sicbed_ex : Form
    {
        public Hospital_sicbed_ex(BedData sicbed_data)
        {
            InitializeComponent();
            sickbed_name.TextAlign = ContentAlignment.MiddleCenter;
            sickbed_name.Text = sicbed_data.BedName;
            sickbed_ex.Text = sicbed_data.BedDescription;

            StartPosition = FormStartPosition.CenterScreen;

            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
