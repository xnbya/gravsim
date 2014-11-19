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
using System.IO;
using System.Xml.Serialization;

namespace AIMIS
{
	public class tkui
	{
        public gbVariables gbvars;

        public void SavePlanets(string filename)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof (List<PlanetObject>));

            using(Stream stream = File.Create(filename)) {
                xmlser.Serialize(stream, lstPlanets);
            }

        }

        public void LoadPlanets(string filename)
        {
           XmlSerializer xmlser = new XmlSerializer(typeof (List<PlanetObject>));

           using (Stream stream = File.Open(filename, FileMode.Open))
           {
               lstPlanets = xmlser.Deserialize(stream) as List<PlanetObject>;
           }
            

        }

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

		public class PlanetObject
		{
			private float mass;
			private float radius;

			public float Mass {
				get {
					return this.mass;
				}
				set {
					this.mass = value;
					this.radius = (float)Math.Pow ((value * 3) / (Math.PI * 4 * 8000), (double)1 / 3);
				}
			}

			public float Radius {
				get {
					return this.radius;
				}
			}

			public Vector2 Velocity;
			public Vector2 Position;
			public List<Vector2> Trails;
            public Color PColour;
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

        public Vector2 MousePosition(float mX, float mY, GameWindow game)
        {
            Vector2 vecMousePos = new Vector2(((mX) / (float)game.Width - 0.5f) * 20f * ZoomMulti - ViewPointV.X * 10f * ZoomMulti, 0 - ((mY) / (float)game.Height - 0.5f) * 16f * ZoomMulti - ViewPointV.Y * 8f * ZoomMulti);
            //Console.WriteLine(ViewPointV);
            return vecMousePos;

        }

        //vars
        //list of planets
        public List<PlanetObject> lstPlanets = new List<PlanetObject>();

        //list of trails of 'dead' planets
        List<List<Vector2>> lstTrails = new List<List<Vector2>>();

        //color of planets
        Color colPlanets = Color.LightYellow;

        //viewpoint
        Vector3 ViewPointV = new Vector3(0f, 0f, 0f);
        float ZoomMulti = 1f;



        //speed
        public int SimulationSpeed = 1;

		public void Main ()
		{

			using (var game = new GameWindow(700,500, new GraphicsMode(8,2,0))) {
                game.Title = "AIMIS";
               // game.WindowState = WindowState.Fullscreen;
              //  DisplayDevice.Default.ChangeResolution(1280, 1024,2, 30);
               

				Matrix4 matrix = Matrix4.CreateTranslation (0, 0, 0);
				game.Load += (sender, e) =>
				{
					// setup settings, load textures, sounds
					game.VSync = VSyncMode.On;
				};

				game.Resize += (sender, e) =>
				{
					GL.Viewport (0, 0, game.Width, game.Height);
				};

                //mouse click to add logic
                Vector2 MoCinitialvec = new Vector2(0f, 0f);
                Vector2 MoCdvec = new Vector2(0f, 0f);
                bool MoCdraw = false;

                game.Mouse.ButtonDown += (sender, e) =>
                    {
                        MoCinitialvec = MousePosition(e.X, e.Y, game);
                        MoCdraw = true;

                        //Console.WriteLine(e.X.ToString() + ' ' + e.Y.ToString());

                    };

                game.Mouse.ButtonUp += (sender, e) =>
                    {
                        MoCdraw = false;
                       // float MoCfinalX = ((float)e.X / (float)game.Width - 0.5f) * 20f * ZoomMulti;
                       // float MoCfinalY = 0 - ((float)e.Y / (float)game.Height - 0.5f) * 16f * ZoomMulti;


                        MoCdvec = MousePosition(e.X, e.Y, game);
                        PlanetObject plan = new PlanetObject();
                        plan.Mass = gbvars.NewObjectMass;
                        plan.Position = MoCinitialvec;
                        plan.Velocity = (MoCdvec - MoCinitialvec) * 0.05f; // new Vector2((MoCfinalX - MoCinitialX) / 50f, (MoCfinalY - MoCinitialY) / 50f);
                        plan.Trails = new List<Vector2>();
                        //p2.Radius = 0.005f;
                        lstPlanets.Add(plan);
                    };

                game.Mouse.WheelChanged += (sender, e) =>
                    {
                        ZoomMulti -= e.DeltaPrecise * 0.05f;
                    };

                game.Mouse.Move += (sender, e) =>
                    {
                        MoCdvec = MousePosition(e.X, e.Y, game); // new Vector2(((float)e.X / (float)game.Width - 0.5f) * 20f * ZoomMulti, 0 - ((float)e.Y / (float)game.Height - 0.5f) * 16f * ZoomMulti);
                    };

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
                        }

                    };

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
						ZoomMulti += 0.01f;
					}
					if (game.Keyboard [Key.X]) {
						ZoomMulti -= 0.01f;
					}
                    			

				};

				
				Random rand = new Random ();

				//gravitational constant
				float G = 0.0000006673f;
                
				//Vector2 velocity = new Vector2 (0f, 0f);
				game.RenderFrame += (sender, e) =>
				{
					// render graphics
					GL.Clear (ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

					GL.MatrixMode (MatrixMode.Projection);


					//trackobject
                    if (gbvars.blFollowObject)
                    {
                        float LargestMass = 0f;
                        Vector2 Position = new Vector2(0f, 0f);
                        foreach (PlanetObject planob in lstPlanets)
                        {
                            if (planob.Mass > LargestMass)
                            {
                                Position = planob.Position;
                                LargestMass = planob.Mass;
                            }
                        }

                        ViewPointV.X = -Position.X / 10;
                        ViewPointV.Y = -Position.Y / 8;
                        Console.Write("plan");
                        //Console.WriteLine(lstPlanets[0].Position.X);
                        Console.WriteLine(ViewPointV.X);
                    }
					



					//GL.LoadIdentity();
					matrix = Matrix4.CreateTranslation (ViewPointV);

					GL.LoadMatrix (ref matrix);
					GL.Ortho (-10.0 * ZoomMulti, 10.0 * ZoomMulti, -8.0 * ZoomMulti, 8.0 * ZoomMulti, 0.0, 4.0);

					//speedup
					for(int zx = 0; zx < SimulationSpeed; zx ++) {

                        //keep list of speeds for graphs
                        if (lstPlanets.Count > gbvars.intObjectToTrack)
                        {

                            gbvars.lstVelocities.Add(lstPlanets[gbvars.intObjectToTrack].Velocity.Length);
                            Console.WriteLine(lstPlanets[gbvars.intObjectToTrack].Velocity.Length);

                            if (lstPlanets.Count > 500)
                            {
                                lstPlanets.RemoveAt(0);
                            }
                        }

					//foreach (PlanetObject planob in lstPlanets) {
					//calculate forces between objects
					for (int i = lstPlanets.Count - 1; i >= 0; i--) {

						PlanetObject planob = lstPlanets [i];
						for (int ic = lstPlanets.Count - 1; ic >= 0; ic--) {
							PlanetObject plan2 = lstPlanets [ic];
							if (plan2 != planob) {

								//calculate force with vectors
								float dissqu = (float)Math.Pow ((planob.Position.X - plan2.Position.X), 2)
									+ (float)Math.Pow ((planob.Position.Y - plan2.Position.Y), 2);
								Vector2 Force = - G * ((planob.Mass * plan2.Mass) / dissqu) * ((planob.Position - plan2.Position) / (float)Math.Sqrt (dissqu));
								Vector2 Acceleration = Force / planob.Mass;
								planob.Velocity += Acceleration; 

								//collision detection, merge objects
								if (Math.Abs (planob.Position.X - plan2.Position.X) < planob.Radius && Math.Abs (planob.Position.Y - plan2.Position.Y) < planob.Radius) {
									Vector2 CombVelocity = planob.Velocity * planob.Mass + plan2.Velocity * plan2.Mass;
									planob.Mass += plan2.Mass;
									//planob.Radius = (float)Math.Sqrt( Math.Pow(plan2.Radius,2) + Math.Pow(planob.Radius,2));
									CombVelocity = CombVelocity / planob.Mass;
									planob.Velocity = CombVelocity;
									if (!gbvars.ShortTrails) {
										lstTrails.Add (plan2.Trails);
									}
									lstPlanets.RemoveAt (ic);
									
									i --;
								}



							}
						}
					}

					//}



					//draw

					GL.Color3 (Color.DarkRed);

					//draw vector [dead] trails
                    if (gbvars.ShowTrails)
                    {
						foreach (List<Vector2> TrailL in lstTrails) {
							GL.Begin (PrimitiveType.LineStrip);	
							foreach (Vector2 pos in TrailL) {
								GL.Vertex2 (pos.X, pos.Y);
							}
							GL.End ();
						}
					}

					foreach (PlanetObject planob in lstPlanets) {
						if(gbvars.ShortTrails && planob.Trails.Count > 500 ) {
							planob.Trails.RemoveAt(0);
						}
						planob.Trails.Add (planob.Position);
						planob.Position += planob.Velocity;
					}
					}

					//draw planets
					for (int i = lstPlanets.Count - 1; i >= 0; i--) {
						PlanetObject planob = lstPlanets [i];
						GL.Color3 (colPlanets);
						DrawCircle (30, planob.Position.X, planob.Position.Y, planob.Radius);		

						GL.Color3 (Color.DarkRed);
							
						//trails
						//planob.Trails.Add(planob.Position);
						//planob.Position += planob.Velocity;


                        if (gbvars.ShowTrails)
                        {
							GL.Begin (PrimitiveType.LineStrip);	
							foreach (Vector2 pos in planob.Trails) {
								GL.Vertex2 (pos.X, pos.Y);
							}
							GL.End ();
						}
						//planet
			
					}


                

                    //draw mouse click line
                    if (MoCdraw)
                    {
                        GL.Begin(PrimitiveType.Lines);
                        GL.Color3(Color.Yellow);
                        GL.Vertex2(MoCinitialvec);
                        GL.Vertex2(MoCdvec);
                        GL.End();

                        DrawCircle(30, MoCinitialvec.X, MoCinitialvec.Y, 0.1f);
                    }

				


					game.SwapBuffers ();
					//Console.WriteLine (game.UpdateFrequency);
					//Console.WriteLine (lstPlanets.Count);
					//Console.WriteLine (lstPlanets [0].Trails.Count * lstPlanets.Count);
				};



				// Run the game at 60 updates per second
				game.Run (60.0);
			}
		}
	}
}