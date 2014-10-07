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

namespace AIMIS
{
	class MyApplication
	{
		public static void DrawCircle (int segments, float xpos, float ypos, float radius)
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
		}

		[STAThread]
		public static void Main ()
		{

			//show trails?
			bool blTrails = true;

			using (var game = new GameWindow(700,500, new GraphicsMode(8,2,0))) {
				//list of planets
				List<PlanetObject> lstPlanets = new List<PlanetObject> ();

				//list of trails of 'dead' planets
				List<List<Vector2>> lstTrails = new List<List<Vector2>> ();

				//color of planets
				Color colPlanets = Color.LightYellow;

				//keep trails infinitly
				bool blKeepTrails = true;

				//viewpoint
				Vector3 ViewPointV = new Vector3 (0f, 0f, 0f);
				float ZoomMulti = 1f;


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

				game.UpdateFrame += (sender, e) =>
				{
				
					
					if (game.Keyboard [Key.Escape]) {
						game.Exit ();
					}
					if (game.Keyboard [Key.A]) {
						//col1 = Color.Red;
						//matrix = Matrix4.C(0f,0.5f,0.5f,0f,0f,0f,0.5f,0.2f,0.2f);
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


					if (game.Keyboard [Key.B]) {
						//delete trails
						lstTrails = new List<List<Vector2>> ();

						foreach (PlanetObject planobj in lstPlanets) {
							planobj.Trails = new List<Vector2> ();
						}
					}

					if (game.Keyboard [Key.T]) {
						blTrails = !blTrails;
					}


				

				};

				
				Random rand = new Random ();

				//gravitational constant
				float G = 0.0000005f;





				//create random planets
				for (int ii = 0; ii <  0; ii ++) {
					PlanetObject p1 = new PlanetObject ();
					//p1.Mass = 0.5f;
					p1.Position = new Vector2 (((float)rand.NextDouble () - 0.5f) * 8f, ((float)rand.NextDouble () - 0.5f) * 8f);
					p1.Velocity = new Vector2 (((float)rand.NextDouble () - 0.5f) / 20, ((float)rand.NextDouble () - 0.5f) / 50);
//Vector2 (0.02f, 0.01f);
					//p1.Velocity = new Vector2 (0f, 0f);
					p1.Mass = (float)rand.NextDouble () + 0.02f;
					p1.Trails = new List<Vector2> ();
					lstPlanets.Add (p1); 
					//Console.WriteLine ("Added planet!:D");
				}

				//other planets

				PlanetObject p2 = new PlanetObject ();
				p2.Mass = 1000f;
				p2.Position = new Vector2 (0f, 0f);
				p2.Velocity = new Vector2 (0f, 0f);
				p2.Trails = new List<Vector2> ();
				//p2.Radius = 0.005f;
				lstPlanets.Add (p2);


				PlanetObject p3 = new PlanetObject ();
				p3.Mass = 3f;
				p3.Position = new Vector2 (0f, -3f);
				p3.Velocity = new Vector2 (-0.01f, 0f);
				//p3.Radius = 0.003f;
				p3.Trails = new List<Vector2> ();
				lstPlanets.Add (p3);

				PlanetObject p4 = new PlanetObject ();
				p4.Mass = 3f;
				p4.Position = new Vector2 (0f, 3f);
				p4.Velocity = new Vector2 (0.01f, 0f);
				p4.Trails = new List<Vector2> ();
				lstPlanets.Add (p4);
					






				//Vector2 velocity = new Vector2 (0f, 0f);
				game.RenderFrame += (sender, e) =>
				{
					// render graphics
					GL.Clear (ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

					GL.MatrixMode (MatrixMode.Projection);
					//trackobject
					/*
					ViewPointV.X = -lstPlanets[0].Position.X / 10;
					ViewPointV.Y = -lstPlanets[0].Position.Y / 8;
					Console.Write("plan");
					Console.WriteLine(lstPlanets[0].Position.X);
					Console.WriteLine(ViewPointV.X);
					*/



					//GL.LoadIdentity();
					matrix = Matrix4.CreateTranslation (ViewPointV);

					GL.LoadMatrix (ref matrix);
					GL.Ortho (-10.0 * ZoomMulti, 10.0 * ZoomMulti, -8.0 * ZoomMulti, 8.0 * ZoomMulti, 0.0, 4.0);

					//speedup
					for(int zx = 0; zx < 5; zx ++) {

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
									if (blKeepTrails) {
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
					if (blTrails) {
						foreach (List<Vector2> TrailL in lstTrails) {
							GL.Begin (PrimitiveType.LineStrip);	
							foreach (Vector2 pos in TrailL) {
								GL.Vertex2 (pos.X, pos.Y);
							}
							GL.End ();//
						}
					}

					foreach (PlanetObject planob in lstPlanets) {
						if(!blKeepTrails && planob.Trails.Count > 500 ) {
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


						if (blTrails) {
							GL.Begin (PrimitiveType.LineStrip);	
							foreach (Vector2 pos in planob.Trails) {
								GL.Vertex2 (pos.X, pos.Y);
							}
							GL.End ();
						}
						//planet
			
					}

				


					game.SwapBuffers ();
					Console.WriteLine (game.UpdateFrequency);
					Console.WriteLine (lstPlanets.Count);
					Console.WriteLine (lstPlanets [0].Trails.Count * lstPlanets.Count);
				};



				// Run the game at 60 updates per second
				game.Run (60.0);
			}
		}
	}
}