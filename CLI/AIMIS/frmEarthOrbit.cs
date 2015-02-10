using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AIMIS
{
    public partial class frmEarthOrbit : Form
    {
        public gbVariables gbvars;
        public tkui MainUIclass;
        public System.Threading.Thread thMainUI;

        public frmEarthOrbit()
        {
            InitializeComponent();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            MainUIclass.NewPlanet(5f, 0f, (float)nmHeight.Value, (float)nmSpeed.Value / 10, 0f);
        }

        private void frmEarthOrbit_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MainUIclass.lstPlanets.RemoveRange(1, MainUIclass.lstPlanets.Count - 1);
        }
    }
}
