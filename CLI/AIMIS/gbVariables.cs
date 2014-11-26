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
using System.Linq;
using System.Text;

namespace AIMIS
{
    public class gbVariables
    {
        public bool ShowTrails;
        public bool ShortTrails;
        public float NewObjectMass;
        public System.Drawing.Color NewObjectColour;
        public List<float> lstVelocities = new List<float>();
        public bool blFollowObject = false;
        public int intObjectToTrack = 0;

        

    }
}
