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
using OpenTK;

namespace AIMIS
{
    public partial class frmNewSim : Form
    {
        public gbVariables gbvars;
        public tkui MainUIclass;

        public frmNewSim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            gbvars.NewObjectMass = 5f;
            gbvars.ShowTrails = true;
            gbvars.ShortTrails = true;
            Random rand = new Random();

            if(rbRandom.Checked)
            {
                //create random planets
                for (int ii = 0; ii < 500; ii++)
                {
                    tkui.PlanetObject p1 = new tkui.PlanetObject();
                    //p1.Mass = 0.5f;
                    p1.Position = new Vector2(((float)rand.NextDouble() - 0.5f) * 8f, ((float)rand.NextDouble() - 0.5f) * 8f);
                    p1.Velocity = new Vector2(((float)rand.NextDouble() - 0.5f) / 20, ((float)rand.NextDouble() - 0.5f) / 50);
                    //Vector2 (0.02f, 0.01f);
                    //p1.Velocity = new Vector2 (0f, 0f);
                    p1.Mass = (float)rand.NextDouble() + 0.02f;
                    p1.Trails = new List<Vector2>();
                    MainUIclass.lstPlanets.Add(p1);
                    //Console.WriteLine ("Added planet!:D");
                }
            }



            System.Threading.Thread newthr = new System.Threading.Thread(MainUIclass.Main);
            newthr.Start();


            this.Close();
        }
    }
}
