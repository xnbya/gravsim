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
    public partial class frmTEst : Form
    {
        private Variables varib;
        public frmTEst(Variables vars)
        {
            InitializeComponent();
            varib = vars;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            varib.blShowTrails = false;
        }
    }
}
