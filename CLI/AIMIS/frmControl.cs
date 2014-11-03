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
            //gbvars.NewObjectMass = 5;
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

        private void cboNewMass_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cboNewMass_TextChanged(object sender, EventArgs e)
        {
            float Mass = 0;
            if(float.TryParse(cboNewMass.Text, out Mass )) {
                gbvars.NewObjectMass = Mass;
            }
            else
            {
                MessageBox.Show("Please enter a valid mass", "Invalid mass", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnNewSim_Click(object sender, EventArgs e)
        {
            gbvars.NewObjectMass = 5f;
            gbvars.ShowTrails = true;
            gbvars.ShortTrails = true;

            tkui TKUI = new tkui();
            TKUI.gbvars = gbvars;
            MainUIclass = TKUI;

            System.Threading.Thread newthr = new System.Threading.Thread(TKUI.Main);
            newthr.Start();
        }
    }
}
