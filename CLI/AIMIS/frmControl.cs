/* AIMIS
Copyright (C) 2015 Alexis Enston
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
        public System.Threading.Thread thMainUI;
        private int SimSpeed = 0;

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
            if(MainUIclass != null)
                MainUIclass.ClearTrails();

        }

        private void rkbSpeed_Scroll(object sender, EventArgs e)
        {
            if (MainUIclass != null) 
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
            //don't start two sims, this will lead to problems with the ui
            if (thMainUI == null || !thMainUI.IsAlive)
            {

                //tkui class
                tkui TKUI = new tkui();
                TKUI.gbvars = gbvars;
                MainUIclass = TKUI;

                //setup thread
                thMainUI = new System.Threading.Thread(MainUIclass.Main);
                thMainUI.SetApartmentState(System.Threading.ApartmentState.STA);

                //load form for ui
                frmNewSim NewSimform = new frmNewSim();
                NewSimform.thMainUI = thMainUI;
                NewSimform.gbvars = gbvars;
                NewSimform.MainUIclass = MainUIclass;
                NewSimform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please close the current simulation \n before starting a new simulation.", "Unable to start simulation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            //load the graphs
            frmGraphs formgraph = new frmGraphs();
            formgraph.gbvars = gbvars;
            formgraph.Show();
        }

        private void frmControl_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (MainUIclass == null)
                MessageBox.Show("Please start a simulation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("Clear trails when saving. This will result in a smaller file size.", "Clear trails?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    MainUIclass.ClearTrails();
                
                SimSpeed = MainUIclass.SimulationSpeed;
                MainUIclass.SimulationSpeed = 0;
                saveFileDialog1.ShowDialog();
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MainUIclass.SavePlanets(saveFileDialog1.FileName);
            MainUIclass.SimulationSpeed = SimSpeed;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gbvars.blFollowObject = ckDispObjToFollow.Checked;
        }

        private void nmObjToFollow_ValueChanged(object sender, EventArgs e)
        {
            gbvars.intDispObToFollow = (int)nmObjToFollow.Value;
        }

        private void ckMoon_CheckedChanged(object sender, EventArgs e)
        {
            gbvars.blAddMoon = ckMoon.Checked;
        }

        private int frmWidth;
        private int frmHeight;
        private bool blShowHide;

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (blShowHide)
            {
                
                this.Width = frmWidth;
                this.Height = frmHeight;
                btnShowHide.Text = "Collapse";
                blShowHide = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            }
            else
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmWidth = this.Width;
                frmHeight = this.Height;
                this.Width = 94;
                this.Height = 26;
                btnShowHide.Text = "Expand";
                blShowHide = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thMainUI != null)
            {
                if (thMainUI.IsAlive)
                    if (MessageBox.Show("Are you sure you want to quit the simulation?", "Terminate Simulation?", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                        thMainUI.Abort();
                    else
                        e.Cancel = true;
                        

            }

        }

        private void chkAddObjAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            gbvars.blAddObjAdvanced = chkAddObjAdvanced.Checked;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
        
    }
}
