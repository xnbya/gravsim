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
        public System.Threading.Thread thMainUI;

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
                for (int ii = 0; ii < nmRandNumber.Value; ii++)
                {
                    tkui.PlanetObject p1 = new tkui.PlanetObject();
                    //p1.Mass = 0.5f;
                    p1.Position = new Vector2(((float)rand.NextDouble() - 0.5f) * 8f, ((float)rand.NextDouble() - 0.5f) * 8f);
                    p1.Velocity = new Vector2(((float)rand.NextDouble() - 0.5f) * ((float)tbSpeed.Value / 100), ((float)rand.NextDouble() - 0.5f) * ((float)tbSpeed.Value / 100));
                    //Vector2 (0.02f, 0.01f);
                    //p1.Velocity = new Vector2 (0f, 0f);
                    p1.Mass = (float)rand.NextDouble() + (float)tbMass.Value / 20f;
                    p1.Trails = new List<Vector2>();
                    MainUIclass.lstPlanets.Add(p1);
                    //Console.WriteLine ("Added planet!:D");
                }
            }

            if (rbSimple.Checked)
            {
                //add two planets
                tkui.PlanetObject p2 = new tkui.PlanetObject();
                p2.Mass = 1000f;
                p2.Position = new Vector2(0f, 0f);
                p2.Velocity = new Vector2(0f, 0f);
                p2.Trails = new List<Vector2>();
                MainUIclass.lstPlanets.Add(p2);


                tkui.PlanetObject p3 = new tkui.PlanetObject();
                p3.Mass = 3f;
                p3.Position = new Vector2(0f, -3f);
                p3.Velocity = new Vector2(-0.01f, 0f);
                p3.Trails = new List<Vector2>();
                MainUIclass.lstPlanets.Add(p3);
            }

            if(rbSolarSystem.Checked)
            {
                //add sun
                tkui.PlanetObject p2 = new tkui.PlanetObject();
                p2.Mass = 1f;
                p2.Position = new Vector2(0f, 0f);
                p2.Velocity = new Vector2(0f, 0f);
                p2.Trails = new List<Vector2>();
                MainUIclass.lstPlanets.Add(p2);


                //earth
                tkui.PlanetObject p3 = new tkui.PlanetObject();
                p3.Mass = 3.0025E-6f;
                p3.Position = new Vector2(0f, -4.8482E-6f);
                p3.Velocity = new Vector2(-30f, 0f);
                p3.Trails = new List<Vector2>();
                MainUIclass.lstPlanets.Add(p3);
            }


           // System.Threading.Thread newthr = new System.Threading.Thread(MainUIclass.Main);
           // newthr.Start();
            thMainUI.Start();
            


            this.Close();
        }

        private void btnOpenSaved_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            gbvars.NewObjectMass = 5f;
            gbvars.ShowTrails = true;
            gbvars.ShortTrails = true;

            MainUIclass.LoadPlanets(openFileDialog1.FileName);

           
            thMainUI.Start();
            


            this.Close();
        }

        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {
            grbRand.Visible = rbRandom.Checked;
        }
    }
}
