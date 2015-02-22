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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AIMIS
{
    public partial class ctlDirection : UserControl
    {
        //control for specifying angle in degrees, and showing a graphic of the direction

        public float fAngle;

        public ctlDirection()
        {
            InitializeComponent();
        }

        private void nmDirectionAngle_ValueChanged(object sender, EventArgs e)
        {
            if (nmDirectionAngle.Value == 360)
                nmDirectionAngle.Value = 0;
            if (nmDirectionAngle.Value == -1)
                nmDirectionAngle.Value = 350;

            fAngle = ((float)nmDirectionAngle.Value * (float)Math.PI) / 180;
            grpDirection.Refresh();
        }

        private void grpDirection_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red);
            e.Graphics.DrawEllipse(pen, 70, 40, 100, 100);

            e.Graphics.DrawLine(pen, 120, 90, 120 + (float)Math.Cos(fAngle) * 50, 90 + (float)Math.Sin(fAngle) * 50);
        }
    }
}
