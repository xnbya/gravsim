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

        //serialize the lstPlanets to the filename given
        public void SavePlanets(string filename)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof (List<PlanetObject>));

            using(Stream stream = File.Create(filename)) {
                xmlser.Serialize(stream, lstPlanets);
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
                    else if (this.BitmapTexture != null)
                    {
                        this.texture = tkui.LoadTexture(this.BitmapTexture);
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

            public Bitmap BitmapTexture;
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
            Vector2 vecMousePos = new Vector2(((mX) / (float)game.Width - 0.5f) * game.Width * 2 * 
                ZoomMulti - ViewPointV.X * game.Width * ZoomMulti, 0 - ((mY) / (float)game.Height - 0.5f)
                * game.Height * 2 * ZoomMulti - ViewPointV.Y * game.Height * ZoomMulti);
            //Console.WriteLine(ViewPointV);
            return vecMousePos;

        }

		//For the textures - image of earth
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

        //vars
        //list of planets
        public List<PlanetObject> lstPlanets = new List<PlanetObject>();

        

        //list of trails of 'dead' planets
        List<List<Vector2>> lstTrails = new List<List<Vector2>>();

        //color of planets
        Color colPlanets = Color.LightYellow;

        //viewpoint
        Vector3 ViewPointV = new Vector3(0f, 0f, 0f);
        float ZoomMulti = 0.01f;



        //speed
        public int SimulationSpeed = 1;

		public void Main ()
		{

			using (var game = new GameWindow(700,500, new GraphicsMode(8,2,0))) {
                
               // game.WindowState = WindowState.Fullscreen;
              //  DisplayDevice.Default.ChangeResolution(1280, 1024,2, 30);
               

				Matrix4 matrix = Matrix4.CreateTranslation (0, 0, 0);
				game.Load += (sender, e) =>
				{
					// setup settings, load textures, sounds
					game.VSync = VSyncMode.On;
                    game.Title = "AIMIS Simulation";
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
                
				//load textures
				GL.Enable (EnableCap.Texture2D);
				//GL.Enable (EnableCap.Blend);
				GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
				//int EarthTexture = LoadTexture(new Bitmap("earth.png"));
                //lstPlanets[0].Texture = EarthTexture;
               // float RotAngle = 0f;
			

                game.Mouse.ButtonDown += (sender, e) =>
                    {
                        MoCinitialvec = MousePosition(e.X, e.Y, game);
                        MoCdvec = MoCinitialvec;

                        if (e.Button == MouseButton.Left)
                        {
                            MoCdraw = true;
                        }
                        if (e.Button == MouseButton.Right) {
                            //MovePrev = MousePosition(e.X, e.Y, game);
                            PrevViewpoint = ViewPointV;
                        }


                    };

                game.Mouse.ButtonUp += (sender, e) =>
                    {
                        if (e.Button == MouseButton.Left)
                        {


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
                                   
                                    //p2.Radius = 0.005f;
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

                            else
                            {

                                MoCdvec = MousePosition(e.X, e.Y, game);
                                PlanetObject plan = new PlanetObject();
                                plan.Mass = gbvars.NewObjectMass;
                                plan.Position = MoCinitialvec;
                                plan.Velocity = (MoCdvec - MoCinitialvec) * 0.05f;
                                plan.Trails = new List<Vector2>();
                                plan.BitmapTexture = new Bitmap("ship.png");
                                //p2.Radius = 0.005f;
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

                game.Mouse.WheelChanged += (sender, e) =>
                    {
                        
                        if (ZoomMulti - e.DeltaPrecise * 0.001f > 0)
                        {

                            ZoomMulti -= e.DeltaPrecise * 0.001f;
                        }

                    };

                game.Mouse.Move += (sender, e) =>
                    {
                        //if(!gbvars.blAddObjAdvanced)
                        MoCdvec = MousePosition(e.X, e.Y, game);

                        if(e.Mouse.RightButton == ButtonState.Pressed)
                        {

                            ViewPointV = new Vector3((MoCdvec - MoCinitialvec).X / (game.Width * ZoomMulti), (MoCdvec - MoCinitialvec).Y / (game.Height * ZoomMulti), 0) + PrevViewpoint;
                            
                        }
                        
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
						ZoomMulti += 0.001f;
					}
					if (game.Keyboard [Key.X] && ZoomMulti > 0.001f) {
                        
						    ZoomMulti -= 0.001f;
					}
                    			

				};



                float G = gbvars.G;
                
				//Vector2 velocity = new Vector2 (0f, 0f);
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
					



					//GL.LoadIdentity();
                    matrix = Matrix4.CreateTranslation(ViewPointV);

					GL.LoadMatrix (ref matrix);
					GL.Ortho (-game.Width * ZoomMulti, game.Width * ZoomMulti, -game.Height * ZoomMulti, game.Height * ZoomMulti, 0.0, 4.0);

					//speedup
					for(int zx = 0; zx < SimulationSpeed; zx ++) {

                        //keep list of speeds for graphs
                        if (lstPlanets.Count > gbvars.intObjectToTrack)
                        {

                            gbvars.lstVelocities.Add(lstPlanets[gbvars.intObjectToTrack].Velocity.Length);
                            //Console.WriteLine(lstPlanets[gbvars.intObjectToTrack].Velocity.Length);

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
							if (plan2.Position != planob.Position) {

								//calculate force with vectors
								float dissqu = (float)Math.Pow ((planob.Position.X - plan2.Position.X), 2)
									+ (float)Math.Pow ((planob.Position.Y - plan2.Position.Y), 2);
								Vector2 Force = - G * ((planob.Mass * plan2.Mass) / dissqu) * ((planob.Position - plan2.Position) / (float)Math.Sqrt (dissqu));
								Vector2 Acceleration = Force / planob.Mass;
								planob.Velocity += Acceleration; 

								//collision detection, merge objects
								if (Math.Abs (planob.Position.X - plan2.Position.X) < planob.Radius && Math.Abs (planob.Position.Y - plan2.Position.Y) < planob.Radius) {
									Vector2 CombVelocity = planob.Velocity * planob.Mass + plan2.Velocity * plan2.Mass;
                                    //Keep texture of largest object
                                    if (planob.Mass < plan2.Mass)
                                    {
                                        planob.Texture = plan2.Texture;
                                    }
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
                       
                        
                            planob.Trails.Add(planob.Position);
                        
						planob.Position += planob.Velocity;
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
                       
                        if (planob.Texture > 0)
                        {
                            //Draw planet with texture
                            GL.BindTexture(TextureTarget.Texture2D, planob.Texture);
                            GL.Enable(EnableCap.Blend);

                            GL.Color3(Color.White);

                            

                            Matrix4 rotmatrix = Matrix4.CreateFromAxisAngle(new Vector3(0, 0, 1), planob.RotationAngle);
                            rotmatrix = rotmatrix * Matrix4.CreateTranslation(planob.Position.X, planob.Position.Y, 0);
                            
                            GL.MultMatrix(ref rotmatrix);

                            //GL.LoadMatrix(ref rotmatrix);
                            //GL.Ortho(-game.Width * ZoomMulti, game.Width * ZoomMulti, -game.Height * ZoomMulti, game.Height * ZoomMulti, 0.0, 4.0);
                            
                            planob.RotationAngle += planob.RotationTime;
                            GL.MatrixMode(MatrixMode.Modelview);

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

                            GL.BindTexture(TextureTarget.Texture2D, 0);

                           
                            GL.MatrixMode(MatrixMode.Projection);
                            GL.LoadMatrix(ref matrix);
                            GL.Ortho(-game.Width * ZoomMulti, game.Width * ZoomMulti, -game.Height * ZoomMulti, game.Height * ZoomMulti, 0.0, 4.0);


                        }
                        
                        else
                        {
                            DrawCircle(30, planob.Position.X, planob.Position.Y, planob.Radius);
                            
                        }
                       // GL.Color4(255, 255, 255, 50);
                        
                        GL.Color3(Color.DarkRed);
						
							
						//trails

                        if (gbvars.ShowTrails)
                        {

							GL.Begin (PrimitiveType.LineStrip);

                            for (int j = 0; j < planob.Trails.Count; j++)
                            {
                                GL.Vertex2(planob.Trails[j].X, planob.Trails[j].Y);
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




                    Console.WriteLine(game.RenderFrequency);
                    

					game.SwapBuffers ();
				};



				// Run the simulaton at 60 updates per second
				game.Run (60.0);
                
			}
		}
	}
}