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
    public partial class frmNewObjAdv : Form
    {
        public float fAngle = 0;
        public gbVariables gbvars;
        public float fMass;
        public bool blAddMoon;
        public float fMoonMass;
        public float fMoonDistance;
        public float fSpeed;


        public frmNewObjAdv()
        {
            InitializeComponent();

        }

        private void grpDirection_Paint(object sender, PaintEventArgs e)
        {
            //draw the direction line
            //center 120,90
            //length 50
            Pen pen = new Pen(Color.Red);
            e.Graphics.DrawEllipse(pen, 70, 40, 100, 100);

            e.Graphics.DrawLine(pen, 120, 90,  120 + (float)Math.Cos(fAngle) * 50, 90 + (float)Math.Sin(fAngle) * 50);
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

        private void frmNewObjAdv_Load(object sender, EventArgs e)
        {
            nmMass.Value = (decimal)gbvars.NewObjectMass;
            ckAddMoon.Checked = gbvars.blAddMoon;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fMass = (float)nmMass.Value;
            fMoonMass = (float)nmMoonMass.Value;
            fMoonDistance = (float)nmMoonRadius.Value;
            blAddMoon = ckAddMoon.Checked;
            fSpeed = (float)nmSpeed.Value;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
