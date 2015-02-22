/* AIMIS
Copyright (C) 2014, 2015 Alexis Enston
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
            //image from http://domain.acwebserve.com/browserdetect/Images/Satellite.png 
            MainUIclass.NewPlanet(5f, 0f, (float)nmHeight.Value + MainUIclass.lstPlanets[0].Radius, 
                (float)Math.Cos(-ctlDirection1.fAngle) * (float)nmSpeed.Value / 50, 
                (float)Math.Sin(-ctlDirection1.fAngle) * (float)nmSpeed.Value / 50);

            MainUIclass.blShowGeostatDot = chPoint.Checked;
            if (chPoint.Checked)
            {
                MainUIclass.fAngleGeostat = MainUIclass.lstPlanets[0].RotationAngle;
            }
        }

        private void frmEarthOrbit_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MainUIclass.lstPlanets.RemoveRange(1, MainUIclass.lstPlanets.Count - 1);
            MainUIclass.ClearTrails();
        }
    }
}
