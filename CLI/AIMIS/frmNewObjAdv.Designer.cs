namespace AIMIS
{
    partial class frmNewObjAdv
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
            this.label1 = new System.Windows.Forms.Label();
            this.nmMass = new System.Windows.Forms.NumericUpDown();
            this.ckAddMoon = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmMoonMass = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmMoonRadius = new System.Windows.Forms.NumericUpDown();
            this.grpMoon = new System.Windows.Forms.GroupBox();
            this.lbRadius = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTexture = new System.Windows.Forms.TextBox();
            this.btnLoadTexture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.nmRotation = new System.Windows.Forms.NumericUpDown();
            this.chFixed = new System.Windows.Forms.CheckBox();
            this.ctlDirection1 = new AIMIS.ctlDirection();
            ((System.ComponentModel.ISupportInitialize)(this.nmMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoonMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoonRadius)).BeginInit();
            this.grpMoon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRotation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mass:";
            // 
            // nmMass
            // 
            this.nmMass.Location = new System.Drawing.Point(81, 15);
            this.nmMass.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmMass.Name = "nmMass";
            this.nmMass.Size = new System.Drawing.Size(136, 20);
            this.nmMass.TabIndex = 1;
            this.nmMass.ValueChanged += new System.EventHandler(this.nmMass_ValueChanged);
            // 
            // ckAddMoon
            // 
            this.ckAddMoon.AutoSize = true;
            this.ckAddMoon.Location = new System.Drawing.Point(99, 14);
            this.ckAddMoon.Name = "ckAddMoon";
            this.ckAddMoon.Size = new System.Drawing.Size(73, 17);
            this.ckAddMoon.TabIndex = 2;
            this.ckAddMoon.Text = "add moon";
            this.ckAddMoon.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mass of Moon:";
            // 
            // nmMoonMass
            // 
            this.nmMoonMass.Location = new System.Drawing.Point(99, 37);
            this.nmMoonMass.Name = "nmMoonMass";
            this.nmMoonMass.Size = new System.Drawing.Size(120, 20);
            this.nmMoonMass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Orbital Radius:";
            // 
            // nmMoonRadius
            // 
            this.nmMoonRadius.DecimalPlaces = 2;
            this.nmMoonRadius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmMoonRadius.Location = new System.Drawing.Point(99, 63);
            this.nmMoonRadius.Name = "nmMoonRadius";
            this.nmMoonRadius.Size = new System.Drawing.Size(120, 20);
            this.nmMoonRadius.TabIndex = 6;
            // 
            // grpMoon
            // 
            this.grpMoon.Controls.Add(this.lbRadius);
            this.grpMoon.Controls.Add(this.label2);
            this.grpMoon.Controls.Add(this.nmMoonRadius);
            this.grpMoon.Controls.Add(this.ckAddMoon);
            this.grpMoon.Controls.Add(this.label3);
            this.grpMoon.Controls.Add(this.nmMoonMass);
            this.grpMoon.Location = new System.Drawing.Point(1, 142);
            this.grpMoon.Name = "grpMoon";
            this.grpMoon.Size = new System.Drawing.Size(235, 103);
            this.grpMoon.TabIndex = 7;
            this.grpMoon.TabStop = false;
            this.grpMoon.Text = "Moon";
            // 
            // lbRadius
            // 
            this.lbRadius.AutoSize = true;
            this.lbRadius.Location = new System.Drawing.Point(14, 86);
            this.lbRadius.Name = "lbRadius";
            this.lbRadius.Size = new System.Drawing.Size(117, 13);
            this.lbRadius.TabIndex = 7;
            this.lbRadius.Text = "(Radius of planet is XX)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Initial Speed:";
            // 
            // nmSpeed
            // 
            this.nmSpeed.DecimalPlaces = 2;
            this.nmSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nmSpeed.Location = new System.Drawing.Point(81, 41);
            this.nmSpeed.Name = "nmSpeed";
            this.nmSpeed.Size = new System.Drawing.Size(136, 20);
            this.nmSpeed.TabIndex = 9;
            this.nmSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(371, 218);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Texture:";
            // 
            // txtTexture
            // 
            this.txtTexture.Location = new System.Drawing.Point(81, 67);
            this.txtTexture.Name = "txtTexture";
            this.txtTexture.Size = new System.Drawing.Size(108, 20);
            this.txtTexture.TabIndex = 15;
            // 
            // btnLoadTexture
            // 
            this.btnLoadTexture.Location = new System.Drawing.Point(192, 67);
            this.btnLoadTexture.Name = "btnLoadTexture";
            this.btnLoadTexture.Size = new System.Drawing.Size(25, 20);
            this.btnLoadTexture.TabIndex = 16;
            this.btnLoadTexture.Text = "...";
            this.btnLoadTexture.UseVisualStyleBackColor = true;
            this.btnLoadTexture.Click += new System.EventHandler(this.btnLoadTexture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG images|*.png|JPEG Image|*.jpg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Rotation:";
            // 
            // nmRotation
            // 
            this.nmRotation.DecimalPlaces = 2;
            this.nmRotation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmRotation.Location = new System.Drawing.Point(81, 93);
            this.nmRotation.Name = "nmRotation";
            this.nmRotation.Size = new System.Drawing.Size(136, 20);
            this.nmRotation.TabIndex = 18;
            // 
            // chFixed
            // 
            this.chFixed.AutoSize = true;
            this.chFixed.Location = new System.Drawing.Point(81, 119);
            this.chFixed.Name = "chFixed";
            this.chFixed.Size = new System.Drawing.Size(83, 17);
            this.chFixed.TabIndex = 2;
            this.chFixed.Text = "Fixed object";
            this.chFixed.UseVisualStyleBackColor = true;
            // 
            // ctlDirection1
            // 
            this.ctlDirection1.Location = new System.Drawing.Point(242, 12);
            this.ctlDirection1.Name = "ctlDirection1";
            this.ctlDirection1.Size = new System.Drawing.Size(215, 163);
            this.ctlDirection1.TabIndex = 19;
            // 
            // frmNewObjAdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.Controls.Add(this.ctlDirection1);
            this.Controls.Add(this.chFixed);
            this.Controls.Add(this.nmRotation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLoadTexture);
            this.Controls.Add(this.txtTexture);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nmSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpMoon);
            this.Controls.Add(this.nmMass);
            this.Controls.Add(this.label1);
            this.Name = "frmNewObjAdv";
            this.Text = "New Object";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmNewObjAdv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoonMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoonRadius)).EndInit();
            this.grpMoon.ResumeLayout(false);
            this.grpMoon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRotation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmMass;
        private System.Windows.Forms.CheckBox ckAddMoon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmMoonMass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmMoonRadius;
        private System.Windows.Forms.GroupBox grpMoon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmSpeed;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbRadius;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTexture;
        private System.Windows.Forms.Button btnLoadTexture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmRotation;
        private System.Windows.Forms.CheckBox chFixed;
        private ctlDirection ctlDirection1;
    }
}