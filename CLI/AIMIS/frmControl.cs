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
    public partial class frmControl : Form
    {
        public gbVariables gbvars;
        public EventHandler ClearTrails;
        public tkui MainUIclass;

        public frmControl()
        {
            InitializeComponent();
        }

        private void rbNoTrails_CheckedChanged(object sender, EventArgs e)
        {
            gbvars.ShowTrails = !rbNoTrails.Checked;
            gbvars.ShortTrails = rbShortTrails.Checked;
        }

        private void btnClearTrails_Click(object sender, EventArgs e)
        {
            MainUIclass.ClearTrails();
        }

        private void rkbSpeed_Scroll(object sender, EventArgs e)
        {
            MainUIclass.SimulationSpeed = rkbSpeed.Value;
        }
    }
}
