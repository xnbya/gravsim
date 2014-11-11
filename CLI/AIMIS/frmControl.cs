/* AIMIS
Copyright (C) 2014 Alexis Enston
This program is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation; either version 2 of the License, or
(at your option) any later version.
This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details. */
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
            tkui TKUI = new tkui();
            TKUI.gbvars = gbvars;
            MainUIclass = TKUI;

            frmNewSim NewSimform = new frmNewSim();
            NewSimform.gbvars = gbvars;
            NewSimform.MainUIclass = MainUIclass;
            NewSimform.ShowDialog();            

        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            frmGraphs formgraph = new frmGraphs();
            formgraph.gbvars = gbvars;
            formgraph.Show();
        }

        private void frmControl_Load(object sender, EventArgs e)
        {

        }

    }
}
