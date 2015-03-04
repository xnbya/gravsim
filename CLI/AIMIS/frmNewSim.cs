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
                    p1.Position = new Vector2(((float)rand.NextDouble() - 0.5f) * 8f * (float)tbSpread.Value, ((float)rand.NextDouble() - 0.5f) * 8f * (float)tbSpread.Value);
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

                MainUIclass.NewPlanet(1000f, 0f, 0f, 4.47E-5f, 0f);
                MainUIclass.NewPlanet(3f, 0f, -3f, -0.0149f, 0f);
               // MainUIclass.NewPlanet(4f, 0f, 5f, 0f, 0f);
           
            }

            if (rbEarthOrbit.Checked)
            {
                frmEarthOrbit formearth = new frmEarthOrbit();
                formearth.MainUIclass = MainUIclass;
                formearth.thMainUI = thMainUI;
                formearth.gbvars = gbvars;
                formearth.Show();
                this.Hide();
                //int Texture = MainUIclass.LoadTexture();

                //gbvars.G = 6.673E-11f;

                //Mass in U
                MainUIclass.NewPlanet(10000f, 0f, 0f, 0f, 0f, "earth.png", -0.002f, true);
                MainUIclass.blGeoStat = true;
                //radius in km
               // MainUIclass.lstPlanets[0].Radius = 6371f;

                //MainUIclass.NewPlanet(5E5f, 0f, 35780, 0f, 0f);
                //MainUIclass.lstPlanets[1].Radius = 100f;

                //MainUIclass.ZoomMulti = 50f;


                //ISS test


                //NewPlanet(3f, 0f, -3f, -0.0149f, 0f, new Bitmap("ship.png"));
                //NewPlanet(4f, 0f, 5f, 0f, 0f);
            }


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
