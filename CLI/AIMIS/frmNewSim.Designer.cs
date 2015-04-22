namespace AIMIS
{
    partial class frmNewSim
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
            this.rbEmpty = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grbRand = new System.Windows.Forms.GroupBox();
            this.tbSpread = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmRandNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.tbMass = new System.Windows.Forms.TrackBar();
            this.rbEarthOrbit = new System.Windows.Forms.RadioButton();
            this.btnOpenSaved = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.grbRand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRandNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMass)).BeginInit();
            this.SuspendLayout();
            // 
            // rbEmpty
            // 
            this.rbEmpty.AutoSize = true;
            this.rbEmpty.Location = new System.Drawing.Point(12, 12);
            this.rbEmpty.Name = "rbEmpty";
            this.rbEmpty.Size = new System.Drawing.Size(105, 17);
            this.rbEmpty.TabIndex = 0;
            this.rbEmpty.TabStop = true;
            this.rbEmpty.Text = "Empty Simulation";
            this.rbEmpty.UseVisualStyleBackColor = true;
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(12, 35);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(90, 17);
            this.rbRandom.TabIndex = 1;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Random Start";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.CheckedChanged += new System.EventHandler(this.rbRandom_CheckedChanged);
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Location = new System.Drawing.Point(12, 58);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(81, 17);
            this.rbSimple.TabIndex = 2;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple Orbit";
            this.rbSimple.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML files|*.xml|All files|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // grbRand
            // 
            this.grbRand.Controls.Add(this.tbSpread);
            this.grbRand.Controls.Add(this.label4);
            this.grbRand.Controls.Add(this.label2);
            this.grbRand.Controls.Add(this.nmRandNumber);
            this.grbRand.Controls.Add(this.label1);
            this.grbRand.Controls.Add(this.label3);
            this.grbRand.Controls.Add(this.tbSpeed);
            this.grbRand.Controls.Add(this.tbMass);
            this.grbRand.Location = new System.Drawing.Point(123, 12);
            this.grbRand.Name = "grbRand";
            this.grbRand.Size = new System.Drawing.Size(220, 202);
            this.grbRand.TabIndex = 5;
            this.grbRand.TabStop = false;
            this.grbRand.Text = "Random Start";
            this.grbRand.Visible = false;
            // 
            // tbSpread
            // 
            this.tbSpread.Location = new System.Drawing.Point(9, 156);
            this.tbSpread.Minimum = 1;
            this.tbSpread.Name = "tbSpread";
            this.tbSpread.Size = new System.Drawing.Size(205, 45);
            this.tbSpread.TabIndex = 7;
            this.tbSpread.Value = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Spread";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average speed";
            // 
            // nmRandNumber
            // 
            this.nmRandNumber.Location = new System.Drawing.Point(105, 14);
            this.nmRandNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmRandNumber.Name = "nmRandNumber";
            this.nmRandNumber.Size = new System.Drawing.Size(109, 20);
            this.nmRandNumber.TabIndex = 1;
            this.nmRandNumber.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of objects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Average mass";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(9, 57);
            this.tbSpeed.Maximum = 100;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(205, 45);
            this.tbSpeed.TabIndex = 2;
            this.tbSpeed.TickFrequency = 10;
            // 
            // tbMass
            // 
            this.tbMass.Location = new System.Drawing.Point(9, 108);
            this.tbMass.Maximum = 100;
            this.tbMass.Name = "tbMass";
            this.tbMass.Size = new System.Drawing.Size(205, 45);
            this.tbMass.TabIndex = 3;
            this.tbMass.TickFrequency = 10;
            // 
            // rbEarthOrbit
            // 
            this.rbEarthOrbit.AutoSize = true;
            this.rbEarthOrbit.Location = new System.Drawing.Point(12, 81);
            this.rbEarthOrbit.Name = "rbEarthOrbit";
            this.rbEarthOrbit.Size = new System.Drawing.Size(75, 17);
            this.rbEarthOrbit.TabIndex = 6;
            this.rbEarthOrbit.TabStop = true;
            this.rbEarthOrbit.Text = "Earth Orbit";
            this.rbEarthOrbit.UseVisualStyleBackColor = true;
            // 
            // btnOpenSaved
            // 
            this.btnOpenSaved.Image = global::AIMIS.Properties.Resources.document_open;
            this.btnOpenSaved.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenSaved.Location = new System.Drawing.Point(12, 144);
            this.btnOpenSaved.Name = "btnOpenSaved";
            this.btnOpenSaved.Size = new System.Drawing.Size(105, 32);
            this.btnOpenSaved.TabIndex = 4;
            this.btnOpenSaved.Text = "Load saved ";
            this.btnOpenSaved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenSaved.UseVisualStyleBackColor = true;
            this.btnOpenSaved.Click += new System.EventHandler(this.btnOpenSaved_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Image = global::AIMIS.Properties.Resources.fork;
            this.btnLaunch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLaunch.Location = new System.Drawing.Point(12, 106);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(105, 32);
            this.btnLaunch.TabIndex = 3;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // frmNewSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 226);
            this.Controls.Add(this.rbEarthOrbit);
            this.Controls.Add(this.grbRand);
            this.Controls.Add(this.btnOpenSaved);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.rbSimple);
            this.Controls.Add(this.rbRandom);
            this.Controls.Add(this.rbEmpty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewSim";
            this.Text = "New Simulation";
            this.TopMost = true;
            this.grbRand.ResumeLayout(false);
            this.grbRand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRandNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEmpty;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnOpenSaved;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox grbRand;
        private System.Windows.Forms.NumericUpDown nmRandNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbMass;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbSpread;
        private System.Windows.Forms.RadioButton rbEarthOrbit;
    }
}