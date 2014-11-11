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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AIMIS
{
    public partial class frmGraphs : Form
    {
        public gbVariables gbvars;

        public frmGraphs()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void frmGraphs_Load(object sender, EventArgs e)
        {
            chart1.DataSource = gbvars.lstVelocities;

            chart1.DataBind();
            chart1.Series.First().XValueMember = "X";
            chart1.Series.First().YValueMembers = "Y";
            chart1.Update();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            chart1.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
