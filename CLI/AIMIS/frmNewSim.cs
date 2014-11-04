using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AIMIS
{
    public partial class frmNewSim : Form
    {
        public gbVariables gbvars;
        public tkui MainUIclass;

        public frmNewSim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            gbvars.NewObjectMass = 5f;
            gbvars.ShowTrails = true;
            gbvars.ShortTrails = true;

            if(rbRandom.Checked)
            {
                //create random planets
                for (int ii = 0; ii < 50; ii++)
                {
                    tkui.PlanetObject p1 = new tkui.PlanetObject();
                    //p1.Mass = 0.5f;
                    p1.Position = new Vector2(((float)rand.NextDouble() - 0.5f) * 8f, ((float)rand.NextDouble() - 0.5f) * 8f);
                    p1.Velocity = new Vector2(((float)rand.NextDouble() - 0.5f) / 20, ((float)rand.NextDouble() - 0.5f) / 50);
                    //Vector2 (0.02f, 0.01f);
                    //p1.Velocity = new Vector2 (0f, 0f);
                    p1.Mass = (float)rand.NextDouble() + 0.02f;
                    p1.Trails = new List<Vector2>();
                    MainUIclass.lstPlanets.Add(p1);
                    //Console.WriteLine ("Added planet!:D");
                }
            }



            System.Threading.Thread newthr = new System.Threading.Thread(MainUIclass.Main);
            newthr.Start();

            this.Close();
        }
    }
}
