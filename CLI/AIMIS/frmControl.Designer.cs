namespace AIMIS
{
    partial class frmControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbTrails = new System.Windows.Forms.GroupBox();
            this.btnClearTrails = new System.Windows.Forms.Button();
            this.rbLongTrails = new System.Windows.Forms.RadioButton();
            this.rbShortTrails = new System.Windows.Forms.RadioButton();
            this.rbNoTrails = new System.Windows.Forms.RadioButton();
            this.rkbSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAddObjAdvanced = new System.Windows.Forms.CheckBox();
            this.ckMoon = new System.Windows.Forms.CheckBox();
            this.cboNewMass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ckDispObjToFollow = new System.Windows.Forms.CheckBox();
            this.nmObjToFollow = new System.Windows.Forms.NumericUpDown();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGraphs = new System.Windows.Forms.Button();
            this.btnNewSim = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.grbTrails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rkbSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmObjToFollow)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTrails
            // 
            this.grbTrails.Controls.Add(this.btnClearTrails);
            this.grbTrails.Controls.Add(this.rbLongTrails);
            this.grbTrails.Controls.Add(this.rbShortTrails);
            this.grbTrails.Controls.Add(this.rbNoTrails);
            this.grbTrails.Location = new System.Drawing.Point(12, 23);
            this.grbTrails.Name = "grbTrails";
            this.grbTrails.Size = new System.Drawing.Size(99, 151);
            this.grbTrails.TabIndex = 0;
            this.grbTrails.TabStop = false;
            this.grbTrails.Text = "Trails";
            // 
            // btnClearTrails
            // 
            this.btnClearTrails.Image = global::AIMIS.Properties.Resources.edit_clear;
            this.btnClearTrails.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClearTrails.Location = new System.Drawing.Point(6, 88);
            this.btnClearTrails.Name = "btnClearTrails";
            this.btnClearTrails.Size = new System.Drawing.Size(84, 48);
            this.btnClearTrails.TabIndex = 3;
            this.btnClearTrails.Text = "Clear Trails";
            this.btnClearTrails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClearTrails.UseVisualStyleBackColor = true;
            this.btnClearTrails.Click += new System.EventHandler(this.btnClearTrails_Click);
            // 
            // rbLongTrails
            // 
            this.rbLongTrails.AutoSize = true;
            this.rbLongTrails.Location = new System.Drawing.Point(6, 65);
            this.rbLongTrails.Name = "rbLongTrails";
            this.rbLongTrails.Size = new System.Drawing.Size(73, 17);
            this.rbLongTrails.TabIndex = 2;
            this.rbLongTrails.TabStop = true;
            this.rbLongTrails.Text = "Long trails";
            this.rbLongTrails.UseVisualStyleBackColor = true;
            this.rbLongTrails.CheckedChanged += new System.EventHandler(this.rbNoTrails_CheckedChanged);
            // 
            // rbShortTrails
            // 
            this.rbShortTrails.AutoSize = true;
            this.rbShortTrails.Checked = true;
            this.rbShortTrails.Location = new System.Drawing.Point(6, 42);
            this.rbShortTrails.Name = "rbShortTrails";
            this.rbShortTrails.Size = new System.Drawing.Size(74, 17);
            this.rbShortTrails.TabIndex = 1;
            this.rbShortTrails.TabStop = true;
            this.rbShortTrails.Text = "Short trails";
            this.rbShortTrails.UseVisualStyleBackColor = true;
            this.rbShortTrails.CheckedChanged += new System.EventHandler(this.rbNoTrails_CheckedChanged);
            // 
            // rbNoTrails
            // 
            this.rbNoTrails.AutoSize = true;
            this.rbNoTrails.Location = new System.Drawing.Point(6, 19);
            this.rbNoTrails.Name = "rbNoTrails";
            this.rbNoTrails.Size = new System.Drawing.Size(63, 17);
            this.rbNoTrails.TabIndex = 0;
            this.rbNoTrails.TabStop = true;
            this.rbNoTrails.Text = "No trails";
            this.rbNoTrails.UseVisualStyleBackColor = true;
            this.rbNoTrails.CheckedChanged += new System.EventHandler(this.rbNoTrails_CheckedChanged);
            // 
            // rkbSpeed
            // 
            this.rkbSpeed.Location = new System.Drawing.Point(15, 193);
            this.rkbSpeed.Maximum = 100;
            this.rkbSpeed.Name = "rkbSpeed";
            this.rkbSpeed.Size = new System.Drawing.Size(310, 45);
            this.rkbSpeed.TabIndex = 1;
            this.rkbSpeed.Value = 20;
            this.rkbSpeed.Scroll += new System.EventHandler(this.rkbSpeed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed of simulation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAddObjAdvanced);
            this.groupBox1.Controls.Add(this.ckMoon);
            this.groupBox1.Controls.Add(this.cboNewMass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(117, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Objects";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkAddObjAdvanced
            // 
            this.chkAddObjAdvanced.AutoSize = true;
            this.chkAddObjAdvanced.Location = new System.Drawing.Point(9, 45);
            this.chkAddObjAdvanced.Name = "chkAddObjAdvanced";
            this.chkAddObjAdvanced.Size = new System.Drawing.Size(114, 17);
            this.chkAddObjAdvanced.TabIndex = 3;
            this.chkAddObjAdvanced.Text = "Advanced Options";
            this.chkAddObjAdvanced.UseVisualStyleBackColor = true;
            this.chkAddObjAdvanced.CheckedChanged += new System.EventHandler(this.chkAddObjAdvanced_CheckedChanged);
            // 
            // ckMoon
            // 
            this.ckMoon.AutoSize = true;
            this.ckMoon.Location = new System.Drawing.Point(127, 45);
            this.ckMoon.Name = "ckMoon";
            this.ckMoon.Size = new System.Drawing.Size(75, 17);
            this.ckMoon.TabIndex = 2;
            this.ckMoon.Text = "Add Moon";
            this.ckMoon.UseVisualStyleBackColor = true;
            this.ckMoon.CheckedChanged += new System.EventHandler(this.ckMoon_CheckedChanged);
            // 
            // cboNewMass
            // 
            this.cboNewMass.FormattingEnabled = true;
            this.cboNewMass.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "25",
            "50",
            "100"});
            this.cboNewMass.Location = new System.Drawing.Point(56, 18);
            this.cboNewMass.Name = "cboNewMass";
            this.cboNewMass.Size = new System.Drawing.Size(146, 21);
            this.cboNewMass.TabIndex = 1;
            this.cboNewMass.Text = "5";
            this.cboNewMass.SelectedValueChanged += new System.EventHandler(this.cboNewMass_SelectedValueChanged);
            this.cboNewMass.TextChanged += new System.EventHandler(this.cboNewMass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mass:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "XML file |*.xml";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // ckDispObjToFollow
            // 
            this.ckDispObjToFollow.AutoSize = true;
            this.ckDispObjToFollow.Location = new System.Drawing.Point(117, 105);
            this.ckDispObjToFollow.Name = "ckDispObjToFollow";
            this.ckDispObjToFollow.Size = new System.Drawing.Size(90, 17);
            this.ckDispObjToFollow.TabIndex = 7;
            this.ckDispObjToFollow.Text = "Follow Object";
            this.ckDispObjToFollow.UseVisualStyleBackColor = true;
            this.ckDispObjToFollow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nmObjToFollow
            // 
            this.nmObjToFollow.Location = new System.Drawing.Point(213, 104);
            this.nmObjToFollow.Name = "nmObjToFollow";
            this.nmObjToFollow.Size = new System.Drawing.Size(112, 20);
            this.nmObjToFollow.TabIndex = 8;
            this.nmObjToFollow.ValueChanged += new System.EventHandler(this.nmObjToFollow_ValueChanged);
            // 
            // btnShowHide
            // 
            this.btnShowHide.Image = global::AIMIS.Properties.Resources.view_restore;
            this.btnShowHide.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowHide.Location = new System.Drawing.Point(2, 1);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(90, 23);
            this.btnShowHide.TabIndex = 9;
            this.btnShowHide.Text = "Collapse";
            this.btnShowHide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::AIMIS.Properties.Resources.document_save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(117, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Simulation";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGraphs
            // 
            this.btnGraphs.Image = global::AIMIS.Properties.Resources.office_chart_area_stacked;
            this.btnGraphs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGraphs.Location = new System.Drawing.Point(246, 128);
            this.btnGraphs.Name = "btnGraphs";
            this.btnGraphs.Size = new System.Drawing.Size(79, 64);
            this.btnGraphs.TabIndex = 5;
            this.btnGraphs.Text = "View Graphs";
            this.btnGraphs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGraphs.UseVisualStyleBackColor = true;
            this.btnGraphs.Click += new System.EventHandler(this.btnGraphs_Click);
            // 
            // btnNewSim
            // 
            this.btnNewSim.Image = global::AIMIS.Properties.Resources.window_new;
            this.btnNewSim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewSim.Location = new System.Drawing.Point(117, 128);
            this.btnNewSim.Name = "btnNewSim";
            this.btnNewSim.Size = new System.Drawing.Size(123, 30);
            this.btnNewSim.TabIndex = 4;
            this.btnNewSim.Text = "New Simulation";
            this.btnNewSim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSim.UseVisualStyleBackColor = true;
            this.btnNewSim.Click += new System.EventHandler(this.btnNewSim_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.Location = new System.Drawing.Point(279, 1);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(46, 23);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(330, 229);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.nmObjToFollow);
            this.Controls.Add(this.ckDispObjToFollow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGraphs);
            this.Controls.Add(this.btnNewSim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rkbSpeed);
            this.Controls.Add(this.grbTrails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmControl";
            this.Text = "AIMIS control window";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmControl_FormClosing);
            this.Load += new System.EventHandler(this.frmControl_Load);
            this.grbTrails.ResumeLayout(false);
            this.grbTrails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rkbSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmObjToFollow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTrails;
        private System.Windows.Forms.RadioButton rbLongTrails;
        private System.Windows.Forms.RadioButton rbShortTrails;
        private System.Windows.Forms.RadioButton rbNoTrails;
        private System.Windows.Forms.Button btnClearTrails;
        private System.Windows.Forms.TrackBar rkbSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboNewMass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewSim;
        private System.Windows.Forms.Button btnGraphs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox ckDispObjToFollow;
        private System.Windows.Forms.NumericUpDown nmObjToFollow;
        private System.Windows.Forms.CheckBox ckMoon;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.CheckBox chkAddObjAdvanced;
        private System.Windows.Forms.Button btnAbout;
    }
}