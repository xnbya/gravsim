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
    public partial class frmNewObjAdv : Form
    {
        public float fAngle = 0;
        public gbVariables gbvars;
        public float fMass;
        public bool blAddMoon;
        public float fMoonMass;
        public float fMoonDistance;
        public float fSpeed;
        public string stTextureFilename;
        public float fRotation;
        public bool blFixed;

        public frmNewObjAdv()
        {
            InitializeComponent();

        }
        

        private void frmNewObjAdv_Load(object sender, EventArgs e)
        {
            nmMass.Value = (decimal)gbvars.NewObjectMass;
            ckAddMoon.Checked = gbvars.blAddMoon;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
	    //store the variables so they can be accessed by tkui
            fAngle = ctlDirection1.fAngle;
            fMass = (float)nmMass.Value;
            fMoonMass = (float)nmMoonMass.Value;
            fMoonDistance = (float)nmMoonRadius.Value;
            blAddMoon = ckAddMoon.Checked;
            fSpeed = (float)nmSpeed.Value / 1000f;
            stTextureFilename = txtTexture.Text;
            fRotation = (float)nmRotation.Value;
            blFixed = chFixed.Checked;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nmMass_ValueChanged(object sender, EventArgs e)
        {
	    //calculate radius
            lbRadius.Text = "(Radius of main planet is " + Decimal.Round((decimal)Math.Pow(((double)nmMass.Value * 3) / (Math.PI * 4 * 8000), (double)1 / 3), 2).ToString() + " )";
        
        }

        private void btnLoadTexture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txtTexture.Text = openFileDialog1.FileName;
        }
    }
}
