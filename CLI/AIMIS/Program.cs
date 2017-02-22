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

			//int currentSim = 25;

			tkui MainF = new tkui ();
			MainF.gbvars = gbvars;
			//MainF.LoadNewSim ();



		

			MainF.Main ();

        }
    }
}