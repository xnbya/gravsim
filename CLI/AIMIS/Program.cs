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
using System.Drawing;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Windows.Forms;

namespace AIMIS
{
    class MyApplication
    {
        [STAThread]
        public static void Main()
        {
            

            frmControl form = new frmControl();
            gbVariables gbvars = new gbVariables();
            form.gbvars = gbvars;


            Application.EnableVisualStyles();
            Application.Run(form);

            //tkui mainui = new tkui();
           // mainui.Main();
        }
    }
}