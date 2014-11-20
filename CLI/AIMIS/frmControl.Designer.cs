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
            this.cboNewColour = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNewMass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewSim = new System.Windows.Forms.Button();
            this.btnGraphs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grbTrails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rkbSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTrails
            // 
            this.grbTrails.Controls.Add(this.btnClearTrails);
            this.grbTrails.Controls.Add(this.rbLongTrails);
            this.grbTrails.Controls.Add(this.rbShortTrails);
            this.grbTrails.Controls.Add(this.rbNoTrails);
            this.grbTrails.Location = new System.Drawing.Point(12, 12);
            this.grbTrails.Name = "grbTrails";
            this.grbTrails.Size = new System.Drawing.Size(165, 102);
            this.grbTrails.TabIndex = 0;
            this.grbTrails.TabStop = false;
            this.grbTrails.Text = "Trails";
            // 
            // btnClearTrails
            // 
            this.btnClearTrails.Location = new System.Drawing.Point(86, 30);
            this.btnClearTrails.Name = "btnClearTrails";
            this.btnClearTrails.Size = new System.Drawing.Size(55, 40);
            this.btnClearTrails.TabIndex = 3;
            this.btnClearTrails.Text = "Clear Trails";
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
            this.rkbSpeed.Location = new System.Drawing.Point(18, 133);
            this.rkbSpeed.Maximum = 100;
            this.rkbSpeed.Name = "rkbSpeed";
            this.rkbSpeed.Size = new System.Drawing.Size(451, 45);
            this.rkbSpeed.TabIndex = 1;
            this.rkbSpeed.Scroll += new System.EventHandler(this.rkbSpeed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed of simulation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNewColour);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboNewMass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(183, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Objects";
            // 
            // cboNewColour
            // 
            this.cboNewColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewColour.FormattingEnabled = true;
            this.cboNewColour.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "Green",
            "White"});
            this.cboNewColour.Location = new System.Drawing.Point(56, 45);
            this.cboNewColour.Name = "cboNewColour";
            this.cboNewColour.Size = new System.Drawing.Size(121, 21);
            this.cboNewColour.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colour:";
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
            this.cboNewMass.Size = new System.Drawing.Size(121, 21);
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
            // btnNewSim
            // 
            this.btnNewSim.Location = new System.Drawing.Point(394, 21);
            this.btnNewSim.Name = "btnNewSim";
            this.btnNewSim.Size = new System.Drawing.Size(75, 40);
            this.btnNewSim.TabIndex = 4;
            this.btnNewSim.Text = "New Simulation";
            this.btnNewSim.UseVisualStyleBackColor = true;
            this.btnNewSim.Click += new System.EventHandler(this.btnNewSim_Click);
            // 
            // btnGraphs
            // 
            this.btnGraphs.Location = new System.Drawing.Point(394, 67);
            this.btnGraphs.Name = "btnGraphs";
            this.btnGraphs.Size = new System.Drawing.Size(75, 27);
            this.btnGraphs.TabIndex = 5;
            this.btnGraphs.Text = "View Graphs";
            this.btnGraphs.UseVisualStyleBackColor = true;
            this.btnGraphs.Click += new System.EventHandler(this.btnGraphs_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(394, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "XML file |*.xml";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // frmControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(481, 177);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGraphs);
            this.Controls.Add(this.btnNewSim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rkbSpeed);
            this.Controls.Add(this.grbTrails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmControl";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AIMIS control window";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmControl_Load);
            this.grbTrails.ResumeLayout(false);
            this.grbTrails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rkbSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboNewColour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNewMass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewSim;
        private System.Windows.Forms.Button btnGraphs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}