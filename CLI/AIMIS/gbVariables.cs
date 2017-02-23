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
using System.Linq;
using System.Text;

namespace AIMIS
{
    public class gbVariables
    {
        //show trails?
        public bool ShowTrails;
        //use short trails - helps performance
        public bool ShortTrails;
        //mass of objects added
        public float NewObjectMass;
        //for graph
        public List<float> lstVelocities = new List<float>();
        public bool blFollowObject = false;
        public int intDispObToFollow = 0;
        public int intObjectToTrack = 0;
        public bool blGraphTrack = false;
        public bool blTrackNewObject = true;


        //gravitational constant
        public float G = 0.0000006673f;

        //add moon with new object
        public bool blAddMoon = false;

        //add new object advanced option
        public bool blAddObjAdvanced = false;

		//current
		public int currentSim = 0;
		public int hiObstacle = -1;



    }
}
