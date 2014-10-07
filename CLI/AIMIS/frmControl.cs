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
    public partial class frmControl : Form
    {
        public gbVariables gbvars;
        public frmControl()
        {
            InitializeComponent();
        }

        private void rbNoTrails_CheckedChanged(object sender, EventArgs e)
        {
            gbvars.ShowTrails = false;
        }
    }
}
