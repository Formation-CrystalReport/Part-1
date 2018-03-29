using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basicsofcrystalreport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrystalRepport.CrystalReport_HelloWord cr = new CrystalRepport.CrystalReport_HelloWord();
            CryReport.ReportSource = null;
            CryReport.ReportSource = cr;


        }
    }
}
