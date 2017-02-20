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
using System.Drawing;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Windows.Forms;
using System.IO;

namespace AIMIS
{
    class MyApplication
    {
        [STAThread]
        public static void Main()
        {
            
	    //load the main form, and instantiate gbVariables
          /*  frmControl form = new frmControl();
            gbVariables gbvars = new gbVariables();
            form.gbvars = gbvars;

            //lauch the application
            Application.EnableVisualStyles();
            Application.Run(form); */
			gbVariables gbvars = new gbVariables();

			gbvars.NewObjectMass = 5f;
			gbvars.ShowTrails = true;
			gbvars.ShortTrails = true;

			int currentSim = 4;

			tkui MainF = new tkui ();
			MainF.gbvars = gbvars;
			//read input
			string[] lines = File.ReadAllLines("robots.mat");
			string rawin = lines [currentSim];


			//robots
			string robots = rawin.Split(new string[] {": ("}, StringSplitOptions.None)[1].Split('#')[0];
			foreach (string rob in robots.Split('(')) {
				double x = Double.Parse (rob.Split (',') [0]);
				double y = Double.Parse(rob.Split(',')[1].Split(')')[0]);

				MainF.NewPlanet (gbvars.NewObjectMass, (float)x, (float)y, 0, 0);

			}

			//obsticals
			if (rawin.Split ('#').Length == 2) {
				string[] obsticals = rawin.Split ('#') [1].Split (';');
				foreach (string obstical in obsticals) {
					//parse
					List<Vector2> vertices = new List<Vector2> ();
					foreach (string vect in obstical.Split('(')) {
						if (vect != "") {
							double x = Double.Parse (vect.Split (',') [0]);
							double y = Double.Parse (vect.Split (',') [1].Split (')') [0]);
							vertices.Add (new Vector2 ((float)x, (float)y));
						}
					}

					//complete
					vertices.Add(vertices[0]);
					MainF.lstObsticals.Add (vertices);
				}
			}


			//read output
			lines = File.ReadAllLines("out.mat");
			rawin = lines [currentSim + 2];

			string[] paths = rawin.Split(new string[] {": ("}, StringSplitOptions.None)[1].Split (';');
			foreach (string path in paths) {
				//parse
				List<Vector2> vertices = new List<Vector2> ();
				foreach (string vect in path.Split('(')) {
					if (vect != "") {
						double x = Double.Parse (vect.Split (',') [0]);
						double y = Double.Parse (vect.Split (',') [1].Split (')') [0]);
						vertices.Add (new Vector2 ((float)x, (float)y));
					}
				}

				MainF.lstTrails.Add (vertices);
			} 


		

			MainF.Main ();

        }
    }
}