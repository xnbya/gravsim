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
using System.IO;
using System.Xml.Serialization;
using System.Drawing.Imaging;

namespace AIMIS
{
	public class tkui
	{
        public gbVariables gbvars;

		public Color[] pathCols = {Color.Chartreuse, Color.CornflowerBlue, Color.Coral, Color.OrangeRed,
			Color.DeepPink, Color.DarkViolet, Color.DarkTurquoise};

        //serialize the lstPlanets to the filename given
        public void SavePlanets(string filename)
        {
				
            XmlSerializer xmlser = new XmlSerializer(typeof (List<PlanetObject>));

            using(Stream stream = File.Create(filename)) {
                    xmlser.Serialize(stream, lstPlanets);
              
            }

        }

		public void LoadNewSim(GameWindow game) {

			//title
			game.Title = "MAT " + gbvars.currentSim.ToString() + " obstacle " + hiObject.ToString();

			//clear
			lstPlanets.Clear();
			lstTrails.Clear ();
			lstObsticals.Clear ();
			lstTrailOffsets.Clear ();


			//read input
			string[] lines = File.ReadAllLines("robots.mat");
			string rawin = lines [gbvars.currentSim];


			//robots
			string robots = rawin.Split(new string[] {": ("}, StringSplitOptions.None)[1].Split('#')[0];
			foreach (string rob in robots.Split('(')) {
				double x = Double.Parse (rob.Split (',') [0]);
				double y = Double.Parse(rob.Split(',')[1].Split(')')[0]);

				NewPlanet (gbvars.NewObjectMass, (float)x, (float)y, 0, 0);

			}

			//obstacals
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
					lstObsticals.Add (vertices);
				}
			}


			//read output

			lines = File.ReadAllLines("out.mat");
			rawin = lines [gbvars.currentSim + 2];

			string[] paths = rawin.Split(new string[] {": ("}, StringSplitOptions.None)[1].Split (new string[] {"; ("}, StringSplitOptions.None);
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



				//find needed offset
				if (lstTrailOffsets.Count == 0) {
					lstTrailOffsets.Add (0);
				} else {
					bool added = false;
					for (int i = 0; i < lstTrails.Count; i++) {
						for (int j = 0; j < lstTrails [i].Count; j++) {
							Vector2 a = lstTrails [i] [j];
							Vector2 b = vertices [0];
							Console.Write ((a - b).Length);
							if ((a - b).Length < 0.01f && lstTrailOffsets [i] >= 0) {
								
								lstTrailOffsets.Add (j + lstTrailOffsets [i]);
								added = true;
							}
						}
					}
					if (!added) {
						lstTrailOffsets.Add (-1);
					}
				}

				lstTrails.Add (vertices);

			}

			//add offsets
			bool finding = true;
			while (finding) {
				finding = false;
				for (int k = 0; k < lstTrailOffsets.Count; k++) {
					if (lstTrailOffsets [k] == -1) {			

						bool added = false;
						for (int i = 0; i < lstTrails.Count; i++) {
							for (int j = 0; j < lstTrails [i].Count; j++) {
								Vector2 a = lstTrails [i] [j];
								Vector2 b = lstTrails [k] [0];
								Console.Write ((a - b).Length);
								if (i != k && (a - b).Length < 0.01f && lstTrailOffsets [i] >= 0) {

									lstTrailOffsets[k] = (j + lstTrailOffsets [i]);
									added = true;
								}
							}
						}
						if (!added) {
							finding = true;
						}
					}
				}
			}





		}

        //unserialize lstPlanets from the file
        public void LoadPlanets(string filename)
        {
           XmlSerializer xmlser = new XmlSerializer(typeof (List<PlanetObject>));

           using (Stream stream = File.Open(filename, FileMode.Open))
           {
               lstPlanets = xmlser.Deserialize(stream) as List<PlanetObject>;
           }

            //reset textures
           foreach (PlanetObject planob in lstPlanets)
           {
               planob.Texture = 0;
           }
            

        }

        //Add an object / planet to the simulation
        public void NewPlanet(float Mass, float PosX, float PosY, float VelX, float VelY, string TextureFilename = null, float Rotation = 0, bool Fixed = false)
        {
            tkui.PlanetObject p2 = new tkui.PlanetObject();
            p2.Mass = Mass;
            p2.Position = new Vector2(PosX, PosY);
            p2.Velocity = new Vector2(VelX, VelY);
            p2.Trails = new List<Vector2>();
            p2.BitmapFilename = TextureFilename;
            p2.RotationAngle = 0f;
            p2.RotationTime = Rotation;
            p2.Fixed = Fixed;
            lstPlanets.Add(p2);
        }

        //draw a circle on the opentk gamewindow
		public void DrawCircle (int segments, float xpos, float ypos, float radius)
		{

			GL.Begin (PrimitiveType.Polygon);	
			for (int i = 0; i < segments; i ++) {
				float theta = (2.0f * (float)Math.PI * i) / (float)segments;
				float cxx = radius * (float)Math.Cos (theta);
				float cyy = radius * (float)Math.Sin (theta);
				GL.Vertex2 (xpos + cxx, ypos + cyy);
			}
			GL.End ();
		}


        //the class for each object
		public class PlanetObject
		{
            
			private float mass;
            private float radius;
            //mass
			public float Mass {
				get {
					return this.mass;
				}
				set {
					this.mass = value;
                    this.radius = (float)Math.Pow ((value * 3) / (Math.PI * 4 * 8000), (double)1 / 3);
				}
			}
            //radius calculated from mass
			public float Radius {
				get {
					return this.radius;
				}
                set
                {
                    this.radius = value;
                }
			}

            //position and movement
			public Vector2 Velocity;
			public Vector2 Position;
            //Trails
			public List<Vector2> Trails;
            //Rotation - angle to add each step
            //Used for planets with textures
            public float RotationTime;
            public float RotationAngle;
            //texture
            private int texture;
            //load texture if called
            public int Texture
            {
                get
                {
                    if (this.texture > 0)
                        return this.texture;
                    else if (this.BitmapFilename != null)
                    {
                        this.texture = tkui.LoadTexture(new Bitmap(this.BitmapFilename));
                        return this.texture;
                    }
                    else
                        return 0;
                }
                set
                {
                    this.texture = value;
                }
            }

            //public Bitmap BitmapTexture;
            public string BitmapFilename;
            //dont move this object, ie keep it at center for earth sims
            public bool Fixed;
		}

        public void ClearTrails()
        {
            //delete trails
            lstTrails = new List<List<Vector2>>();

            foreach (PlanetObject planobj in lstPlanets)
            {
                planobj.Trails = new List<Vector2>();
            }
        }

        //get the position of the mouse as a vector scaled to the gamewindow
        public Vector2 MousePosition(float mX, float mY, GameWindow game)
        {
            Vector2 vecMousePos = new Vector2(((mX) / (float)game.Width - 0.5f) * game.Width * 2 * 
                ZoomMulti - ViewPointV.X * game.Width * ZoomMulti, 0 - ((mY) / (float)game.Height - 0.5f)
                * game.Height * 2 * ZoomMulti - ViewPointV.Y * game.Height * ZoomMulti);
            return vecMousePos;

        }

		//For the textures - ie image of earth
        //loads a bitmap, and returns it's location as an int
		public static int LoadTexture(Bitmap bitmap)
		{
			int texture;
			GL.GenTextures(1, out texture);
			GL.BindTexture(TextureTarget.Texture2D, texture);

			BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
			                                  ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

			GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0,
			              OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);

			bitmap.UnlockBits(data);
			bitmap.Dispose();


			GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)All.Linear);

		
			return texture;
		}

		//number of parts to print
		int numTrailParts = 0;

        //variables
        //list of planets
        public List<PlanetObject> lstPlanets = new List<PlanetObject>();
        //list of trails of 'dead' planets
        public List<List<Vector2>> lstTrails = new List<List<Vector2>>();

		public List<int> lstTrailOffsets = new List<int> ();

		//obsticals 
		public List<List<Vector2>> lstObsticals = new List<List<Vector2>>();


        //color of planets
        Color colPlanets = Color.LightYellow;
        //viewpoint
        Vector3 ViewPointV = new Vector3(0f, 0f, 0f);
        public float ZoomMulti = 0.01f;
        //speed
        public int SimulationSpeed = 0;
        //Draw lines for showing geostyationary orbit?
        public bool blGeoStat = false;
        //Show dot on earth for geostat
        public bool blShowGeostatDot = false;
        public float fAngleGeostat = 0f;

		//highlight object
		public int hiObject = 0;

        [STAThread]
		public void Main ()
		{

			using (var game = new GameWindow(700,500, new GraphicsMode(32,24,0,4))) {
                
                //run at 60fps
                game.TargetRenderFrequency = 60;

				Matrix4 matrix = Matrix4.CreateTranslation (0, 0, 0);
				game.Load += (sender, e) =>
				{
					// setup settings, load textures, sounds
					game.VSync = VSyncMode.On;
                    game.Title = "press b";
				};

				game.Resize += (sender, e) =>
				{
					GL.Viewport (0, 0, game.Width, game.Height);
				};

                //mouse click to add logic
                Vector2 MoCinitialvec = new Vector2(0f, 0f);
                Vector2 MoCdvec = new Vector2(0f, 0f);
                bool MoCdraw = false;
                Vector3 PrevViewpoint = new Vector3(0f, 0f, 0f);
                
				//enable textures
				GL.Enable (EnableCap.Texture2D);
				GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
			

                //mouse click event
                game.Mouse.ButtonDown += (sender, e) =>
                    {
                        MoCinitialvec = MousePosition(e.X, e.Y, game);
                        MoCdvec = MoCinitialvec;

                        //start adding an object
                        if (e.Button == MouseButton.Left)
                        {
                            MoCdraw = true;
                        }

                        //start moving viewpoint
                        if (e.Button == MouseButton.Right) {
                            PrevViewpoint = ViewPointV;
                        }


                    };

                game.Mouse.ButtonUp += (sender, e) =>
                    {
                        //if left click - add object
                        if (e.Button == MouseButton.Left)
                        {
                            //show advanced options?
                            if (gbvars.blAddObjAdvanced)
                            {
                                frmNewObjAdv frmobj = new frmNewObjAdv();
                                frmobj.gbvars = gbvars;
                                frmobj.ShowDialog();
                                if (frmobj.DialogResult == System.Windows.Forms.DialogResult.OK)
                                {

                                    PlanetObject plan = new PlanetObject();
                                    plan.Mass = frmobj.fMass;
                                    plan.Position = MoCinitialvec;
                                    plan.Velocity = new Vector2((float)Math.Cos(frmobj.fAngle) * frmobj.fSpeed, -(float)Math.Sin(frmobj.fAngle) * frmobj.fSpeed);
                                    plan.Trails = new List<Vector2>();
                                    if (File.Exists(frmobj.stTextureFilename))
                                    {
                                        plan.BitmapFilename = frmobj.stTextureFilename;
                                    }
                                    plan.RotationAngle = 0f;
                                    plan.RotationTime = frmobj.fRotation;
                                    plan.Fixed = frmobj.blFixed;                                   
                                    lstPlanets.Add(plan);

                                    //are we graphing the speed of the new planets?
                                    if (gbvars.blTrackNewObject)
                                    {
                                        gbvars.intObjectToTrack = lstPlanets.Count - 1;
                                        gbvars.lstVelocities.Clear();
                                    }

                                    //add a moon?
                                    if (frmobj.blAddMoon)
                                    {
                                        float distance = frmobj.fMoonDistance;
                                        PlanetObject moon = new PlanetObject();
                                        moon.Mass = frmobj.fMoonMass;
                                        moon.Position = MoCinitialvec;
                                        moon.Position.X += distance;
                                        moon.Velocity = plan.Velocity; //(MoCdvec - MoCinitialvec) * 0.05f;
                                        moon.Velocity.Y += (float)Math.Sqrt((gbvars.G * (moon.Mass + plan.Mass)) / distance);
                                        moon.Trails = new List<Vector2>();
                                        lstPlanets.Add(moon);
                                    }
                                }
                            }

                            //otherwise add object without any dialogue
                            else
                            {

                                MoCdvec = MousePosition(e.X, e.Y, game);
                                PlanetObject plan = new PlanetObject();
                                plan.Mass = gbvars.NewObjectMass;
                                plan.Position = MoCinitialvec;
                                plan.Velocity = (MoCdvec - MoCinitialvec) * 0.05f;
                                plan.Trails = new List<Vector2>();
                                lstPlanets.Add(plan);

                                //are we graphing the speed of the new planets?
                                if (gbvars.blTrackNewObject)
                                {
                                    gbvars.intObjectToTrack = lstPlanets.Count - 1;
                                    gbvars.lstVelocities.Clear();
                                }

                                //add a moon?
                                if (gbvars.blAddMoon)
                                {
                                    float distance = plan.Radius * 3;
                                    PlanetObject moon = new PlanetObject();
                                    moon.Mass = gbvars.NewObjectMass / 10;
                                    moon.Position = MoCinitialvec;
                                    moon.Position.X += distance;
                                    moon.Velocity = (MoCdvec - MoCinitialvec) * 0.05f;
                                    moon.Velocity.Y += (float)Math.Sqrt((gbvars.G * (moon.Mass + plan.Mass)) / distance);
                                    moon.Trails = new List<Vector2>();
                                    lstPlanets.Add(moon);
                                }
                            }

                            MoCdraw = false;
                        }
                    };

                //scroll wheel - zoom in / out
                game.Mouse.WheelChanged += (sender, e) =>
                    {
                        
                        if (ZoomMulti - e.DeltaPrecise * 0.001f > 0)
                        {
                            ZoomMulti -= e.DeltaPrecise * 0.001f;
                        }

                    };

                //moving mouse
                game.Mouse.Move += (sender, e) =>
                    {
                        //for adding object
                        MoCdvec = MousePosition(e.X, e.Y, game);
                        
                        //for moving viewpoint
                        if(e.Mouse.RightButton == ButtonState.Pressed)
                        {
                            ViewPointV = new Vector3((MoCdvec - MoCinitialvec).X / (game.Width * ZoomMulti), (MoCdvec - MoCinitialvec).Y / (game.Height * ZoomMulti), 0) + PrevViewpoint;
                        }
                        
                    };

                //keyboard input
                game.KeyPress += (sender, e) =>
                    {
                        switch (e.KeyChar)
                        {
                            case 'f':
                                game.WindowState = WindowState.Fullscreen;
                                break;                        
                            case 'c':
                                gbvars.ShowTrails = !gbvars.ShowTrails;
                                break;
                            case 't':
                                lstTrails = new List<List<Vector2>> ();
						        foreach (PlanetObject planobj in lstPlanets) {
							        planobj.Trails = new List<Vector2> ();
						        }
                                break;
							case 'n':
								numTrailParts++;
								break;
					case 'm':
						numTrailParts--;
						break;
					case 'b':
						gbvars.currentSim++;
						LoadNewSim(game);
						break;
					case 'v':
						gbvars.currentSim--;
						LoadNewSim(game);
						break;
					case '1':
						gbvars.hiObstacle--;
						//title
						game.Title = "MAT " + gbvars.currentSim.ToString() + " obstacle " + gbvars.hiObstacle.ToString();
						break;
					case '2':
						gbvars.hiObstacle++;
						//title
						game.Title = "MAT " + gbvars.currentSim.ToString() + " obstacle " + gbvars.hiObstacle.ToString();
						break;

                        }

                    };

                //more keyboard input
				game.UpdateFrame += (sender, e) =>
				{
					if (game.Keyboard [Key.Escape]) {
						game.Exit ();
					}
					if (game.Keyboard [Key.A]) {
						ViewPointV.X += 0.01f;
					}
					if (game.Keyboard [Key.D]) {
						ViewPointV.X -= 0.01f;
					}
					if (game.Keyboard [Key.W]) {
						ViewPointV.Y -= 0.01f;
					}
					if (game.Keyboard [Key.S]) {
						ViewPointV.Y += 0.01f;
					}
					if (game.Keyboard [Key.Z]) {
						ZoomMulti += 0.001f;
					}
					if (game.Keyboard [Key.X] && ZoomMulti > 0.001f) {
                        ZoomMulti -= 0.001f;
					}

				};
                
                //for slowing down simulation
                int SimulationSlowDownStep = 0;
                
				game.RenderFrame += (sender, e) =>
				{
					// render graphics
                    //clears screen
					GL.Clear (ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

					GL.MatrixMode (MatrixMode.Projection);

                    Vector2 followPosition = new Vector2(0, 0);

					//trackobject
                    if (gbvars.blFollowObject && lstPlanets.Count > gbvars.intDispObToFollow)
                    {
                        followPosition = lstPlanets[gbvars.intDispObToFollow].Position;
                        ViewPointV.X = -followPosition.X / (game.Width * ZoomMulti);
                        ViewPointV.Y = -followPosition.Y / (game.Height * ZoomMulti);
                    }
					
                    matrix = Matrix4.CreateTranslation(ViewPointV);

					GL.LoadMatrix (ref matrix);
					GL.Ortho (-game.Width * ZoomMulti, game.Width * ZoomMulti, -game.Height * ZoomMulti, game.Height * ZoomMulti, 0.0, 4.0);

					//speedup / slowdown
                    //slowdown?
                    if (SimulationSpeed < 20)
                    {
                        //Stop simulation when sim speed = 0
                        if (SimulationSpeed == 0)
                            SimulationSlowDownStep = 1;

                        SimulationSlowDownStep += SimulationSpeed;
                        if (SimulationSlowDownStep > 20)
                            SimulationSlowDownStep = 0;
                    }
                    else
                        SimulationSlowDownStep = 0;
                        

					for(int zx = 20; (zx < SimulationSpeed || zx == 20) && SimulationSlowDownStep == 0; zx ++) {

                        //keep list of speeds for graphs
                        if (lstPlanets.Count > gbvars.intObjectToTrack)
                        {
                            gbvars.lstVelocities.Add(lstPlanets[gbvars.intObjectToTrack].Velocity.Length);
                            if (lstPlanets.Count > 500)
                            {
                                lstPlanets.RemoveAt(0);
                            }
                        }

					//calculate forces between objects
					for (int i = lstPlanets.Count - 1; i >= 0; i--) {

						PlanetObject planob = lstPlanets [i];

						for (int ic = lstPlanets.Count - 1; ic >= 0; ic--) {
							PlanetObject plan2 = lstPlanets [ic];
							if (plan2.Position != planob.Position) {

								//collision detection, merge objects
                                //check if they overlap, and if we have a fixed object
                                if ((planob.Position - plan2.Position).Length < planob.Radius)
                                {
                                    //if fixed, keep it
                                    if (plan2.Fixed)
                                    {
                                        planob = plan2;
                                    }
                                    if (planob.Fixed != true)
                                    {
                                        Vector2 CombVelocity = planob.Velocity * planob.Mass + plan2.Velocity * plan2.Mass;
                                        //Keep texture of largest object
                                        if (planob.Mass < plan2.Mass)
                                            planob.Texture = plan2.Texture;

                                        planob.Mass += plan2.Mass;
                                        planob.Velocity = CombVelocity / planob.Mass;
                                    }
                                    //add 'dead' objects trails to the other list
                                    lstTrails.Add(plan2.Trails);

                                    //Delete the 'dead' object
                                    lstPlanets.RemoveAt(ic);
                                    i--;
                                }

                                else
                                {
                                    //calculate force with vectors
                                    //Skip this if we have a 'fixed' object
                                    if (planob.Fixed != true)
                                    {
                                        //distance squared
                                        float dissqu = (planob.Position - plan2.Position).Length;
                                        dissqu = dissqu * dissqu;
                                        Vector2 Force = -gbvars.G * ((planob.Mass * plan2.Mass) / dissqu) * ((planob.Position - plan2.Position) / (float)Math.Sqrt(dissqu));
                                        Vector2 Acceleration = Force / planob.Mass;
                                        planob.Velocity += Acceleration;
                                    }
                                }
							}
						}
					}

					
				    foreach (PlanetObject planob in lstPlanets) {
                            //add a 'step' to the planet
                            planob.Position += planob.Velocity;

                            //add the trails
                            //are we doing short trails?
						    if(gbvars.ShortTrails && planob.Trails.Count > 500 ) {
							    planob.Trails.RemoveAt(0);
						    }   
                            
                            planob.Trails.Add(planob.Position);
					    }
					}
                    
                    //Now draw the objects to the gamewindow

					//GL.Color3(Color.MediumPurple);

					//draw obsticals
					for(int i = 0; i < lstObsticals.Count; i++) {
						List<Vector2> vertices = lstObsticals[i];
					
						if(i == gbvars.hiObstacle) {
							GL.Color3(Color.Blue);
						}
						else {
							GL.Color3(Color.LightSkyBlue);
						}
						GL.Begin (PrimitiveType.LineStrip);

						for (int j = 0; j < vertices.Count; j++)
						{
							GL.Vertex2(vertices[j]);
						}
						GL.End ();


					}


                    //draw vector [dead] trails
					if (gbvars.ShowTrails)
                    {
						for(int i = 0; i < lstTrails.Count; i++) 
                        {
							GL.Color3(pathCols[i % 6]);
							List<Vector2> TrailL = lstTrails[i];
							if(lstTrailOffsets[i] < numTrailParts) {
								

	                            GL.Begin(PrimitiveType.LineStrip);
								int ii = 0;
								while(ii < (numTrailParts - lstTrailOffsets[i]) && ii < TrailL.Count) 
	                            {
										GL.Vertex2(TrailL[ii].X, TrailL[ii].Y);
										ii++;
	                            }
	                            GL.End();

								//draw current robot
								//GL.Color3(Color.Yellow);
								if(ii > 0)
									DrawCircle(30, TrailL[ii-1].X, TrailL[ii-1].Y, 0.1f);
							}
							

                        }
                    }



					//draw planets
					for (int i = lstPlanets.Count - 1; i >= 0; i--) {
                        if (i == gbvars.intObjectToTrack && gbvars.blGraphTrack)
                            GL.Color3(Color.Yellow);
                        else
                        {
                            if (gbvars.blFollowObject && i == gbvars.intDispObToFollow)
                                GL.Color3(Color.Blue);
                            else
                                GL.Color3(colPlanets);
                        }

						PlanetObject planob = lstPlanets [i];

                        //spin a planet, but only do it if we have a texture, otherwise its pointless
                        //also only do it if we're doing the 'step'
                        if (planob.Texture > 0 && SimulationSlowDownStep == 0)
                        {
                            if (SimulationSpeed < 20)
                                planob.RotationAngle += planob.RotationTime;
                            else
                                planob.RotationAngle += planob.RotationTime * (SimulationSpeed - 19);
                            if (planob.RotationAngle > (float)Math.PI * 2)
                                planob.RotationAngle -= (float)Math.PI * 2;
                            if (planob.RotationAngle < -(float)Math.PI * 2)
                                planob.RotationAngle += (float)Math.PI * 2;
                        }
                       
                        if (planob.Texture > 0)
                        {
                            //Draw planet with texture
                            GL.BindTexture(TextureTarget.Texture2D, planob.Texture);
                            GL.Enable(EnableCap.Blend);

                            //don't recolor the texture
                            GL.Color3(Color.White);                            

                            //rotate?
                            Matrix4 rotmatrix = Matrix4.CreateFromAxisAngle(new Vector3(0, 0, 1), planob.RotationAngle);
                            rotmatrix = rotmatrix * Matrix4.CreateTranslation(planob.Position.X, planob.Position.Y, 0);
                            
                            GL.MultMatrix(ref rotmatrix);

                            GL.MatrixMode(MatrixMode.Modelview);

                            //draw square for mapping of texture
                            GL.Begin(PrimitiveType.Quads);
                            GL.TexCoord2(0, 0);
                            GL.Vertex2(- planob.Radius,  - planob.Radius);
                            GL.TexCoord2(1, 0);
                            GL.Vertex2(planob.Radius, - planob.Radius);
                            GL.TexCoord2(1, 1);
                            GL.Vertex2( planob.Radius, planob.Radius);
                            GL.TexCoord2(0, 1);
                            GL.Vertex2(- planob.Radius, planob.Radius);
                            GL.End();

                            //map texture
                            GL.BindTexture(TextureTarget.Texture2D, 0);

                           
                            GL.MatrixMode(MatrixMode.Projection);
                            GL.LoadMatrix(ref matrix);
                            GL.Ortho(-game.Width * ZoomMulti, game.Width * ZoomMulti, -game.Height * ZoomMulti, game.Height * ZoomMulti, 0.0, 4.0);


                        }
                        
                        else
                        {
                            //draw a circle to represent object
                            DrawCircle(30, planob.Position.X, planob.Position.Y, planob.Radius);
                            
                        }

                        GL.Color3(Color.DarkRed);
						
							
						//draw trails
                        if (gbvars.ShowTrails)
                        {

							GL.Begin (PrimitiveType.LineStrip);

                            for (int j = 0; j < planob.Trails.Count; j++)
                            {
                                GL.Vertex2(planob.Trails[j].X, planob.Trails[j].Y);
                            }
							GL.End ();
						}
			
					}


                    //draw mouse click line, for when adding object
                    if (MoCdraw)
                    {
                        GL.Begin(PrimitiveType.Lines);
                        GL.Color3(Color.Yellow);
                        GL.Vertex2(MoCinitialvec);
                        GL.Vertex2(MoCdvec);
                        GL.End();

                        //draw the object
                        DrawCircle(30, MoCinitialvec.X, MoCinitialvec.Y, (float)Math.Pow((gbvars.NewObjectMass * 3) / (Math.PI * 4 * 8000), (double)1 / 3));
                    }

                    //Draw lines for geostationary simulation
                    if (blGeoStat && lstPlanets.Count > 1)
                    {
                        for (int i = 1; i < lstPlanets.Count; i++)
                        {
                            GL.Begin(PrimitiveType.Lines);
                            GL.Color3(Color.Aqua);
                            GL.Vertex2(lstPlanets[0].Position);
                            GL.Vertex2(lstPlanets[i].Position);
                            GL.End();
                        }
                    }

                    //Draw earth sim arrows
                    if (blShowGeostatDot)
                    {
                        GL.Color3(Color.Yellow);
                        DrawCircle(30, (float)Math.Sin(-lstPlanets[0].RotationAngle + fAngleGeostat) * lstPlanets[0].Radius, (float)Math.Cos(-lstPlanets[0].RotationAngle + fAngleGeostat) * lstPlanets[0].Radius, 0.1f);
                    }

					//DrawCircle(20, (float)1.25172613420093, (float)1.364106114122106, (float)0.1);

                    //load onto screen
					game.SwapBuffers ();
				};

                //run the game loop
                game.Run();
                
			}
		}
	}
}