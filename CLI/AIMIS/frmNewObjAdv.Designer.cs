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
            this.grpDirection = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nmDirectionAngle = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grLocation = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nmPosY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmPosX = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTexture = new System.Windows.Forms.TextBox();
            this.btnLoadTexture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.nmRotation = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoonMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoonRadius)).BeginInit();
            this.grpMoon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSpeed)).BeginInit();
            this.grpDirection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDirectionAngle)).BeginInit();
            this.grLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPosX)).BeginInit();
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
            this.nmMass.Name = "nmMass";
            this.nmMass.Size = new System.Drawing.Size(120, 20);
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
            this.grpMoon.Location = new System.Drawing.Point(225, 132);
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
            this.nmSpeed.DecimalPlaces = 3;
            this.nmSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmSpeed.Location = new System.Drawing.Point(81, 41);
            this.nmSpeed.Name = "nmSpeed";
            this.nmSpeed.Size = new System.Drawing.Size(120, 20);
            this.nmSpeed.TabIndex = 9;
            this.nmSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // grpDirection
            // 
            this.grpDirection.Controls.Add(this.label5);
            this.grpDirection.Controls.Add(this.nmDirectionAngle);
            this.grpDirection.Location = new System.Drawing.Point(12, 143);
            this.grpDirection.Name = "grpDirection";
            this.grpDirection.Size = new System.Drawing.Size(205, 154);
            this.grpDirection.TabIndex = 10;
            this.grpDirection.TabStop = false;
            this.grpDirection.Text = "Direction";
            this.grpDirection.Paint += new System.Windows.Forms.PaintEventHandler(this.grpDirection_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Angle:";
            // 
            // nmDirectionAngle
            // 
            this.nmDirectionAngle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmDirectionAngle.Location = new System.Drawing.Point(57, 15);
            this.nmDirectionAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nmDirectionAngle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nmDirectionAngle.Name = "nmDirectionAngle";
            this.nmDirectionAngle.Size = new System.Drawing.Size(120, 20);
            this.nmDirectionAngle.TabIndex = 0;
            this.nmDirectionAngle.ValueChanged += new System.EventHandler(this.nmDirectionAngle_ValueChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(385, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grLocation
            // 
            this.grLocation.Controls.Add(this.label8);
            this.grLocation.Controls.Add(this.nmPosY);
            this.grLocation.Controls.Add(this.label7);
            this.grLocation.Controls.Add(this.label6);
            this.grLocation.Controls.Add(this.nmPosX);
            this.grLocation.Location = new System.Drawing.Point(223, 12);
            this.grLocation.Name = "grLocation";
            this.grLocation.Size = new System.Drawing.Size(235, 80);
            this.grLocation.TabIndex = 13;
            this.grLocation.TabStop = false;
            this.grLocation.Text = "Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "(Simulation is currently 5x6)";
            // 
            // nmPosY
            // 
            this.nmPosY.Location = new System.Drawing.Point(150, 19);
            this.nmPosY.Name = "nmPosY";
            this.nmPosY.Size = new System.Drawing.Size(79, 20);
            this.nmPosY.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "X:";
            // 
            // nmPosX
            // 
            this.nmPosX.Location = new System.Drawing.Point(29, 19);
            this.nmPosX.Name = "nmPosX";
            this.nmPosX.Size = new System.Drawing.Size(79, 20);
            this.nmPosX.TabIndex = 0;
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
            this.btnLoadTexture.Location = new System.Drawing.Point(195, 65);
            this.btnLoadTexture.Name = "btnLoadTexture";
            this.btnLoadTexture.Size = new System.Drawing.Size(25, 23);
            this.btnLoadTexture.TabIndex = 16;
            this.btnLoadTexture.Text = "...";
            this.btnLoadTexture.UseVisualStyleBackColor = true;
            this.btnLoadTexture.Click += new System.EventHandler(this.btnLoadTexture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG images|*.png";
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
            this.nmRotation.Size = new System.Drawing.Size(120, 20);
            this.nmRotation.TabIndex = 18;
            // 
            // frmNewObjAdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 311);
            this.Controls.Add(this.nmRotation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLoadTexture);
            this.Controls.Add(this.txtTexture);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grLocation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpDirection);
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
            this.grpDirection.ResumeLayout(false);
            this.grpDirection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDirectionAngle)).EndInit();
            this.grLocation.ResumeLayout(false);
            this.grLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPosX)).EndInit();
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
        private System.Windows.Forms.GroupBox grpDirection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmDirectionAngle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmPosY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmPosX;
        private System.Windows.Forms.Label lbRadius;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTexture;
        private System.Windows.Forms.Button btnLoadTexture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmRotation;
    }
}