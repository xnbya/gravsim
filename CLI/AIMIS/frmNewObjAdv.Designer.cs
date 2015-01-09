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
            this.label4 = new System.Windows.Forms.Label();
            this.nmSpeed = new System.Windows.Forms.NumericUpDown();
            this.grpDirection = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nmDirectionAngle = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoonMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoonRadius)).BeginInit();
            this.grpMoon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSpeed)).BeginInit();
            this.grpDirection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDirectionAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mass:";
            // 
            // nmMass
            // 
            this.nmMass.Location = new System.Drawing.Point(97, 17);
            this.nmMass.Name = "nmMass";
            this.nmMass.Size = new System.Drawing.Size(120, 20);
            this.nmMass.TabIndex = 1;
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
            this.nmMoonRadius.Location = new System.Drawing.Point(99, 63);
            this.nmMoonRadius.Name = "nmMoonRadius";
            this.nmMoonRadius.Size = new System.Drawing.Size(120, 20);
            this.nmMoonRadius.TabIndex = 6;
            // 
            // grpMoon
            // 
            this.grpMoon.Controls.Add(this.label2);
            this.grpMoon.Controls.Add(this.nmMoonRadius);
            this.grpMoon.Controls.Add(this.ckAddMoon);
            this.grpMoon.Controls.Add(this.label3);
            this.grpMoon.Controls.Add(this.nmMoonMass);
            this.grpMoon.Location = new System.Drawing.Point(223, 8);
            this.grpMoon.Name = "grpMoon";
            this.grpMoon.Size = new System.Drawing.Size(235, 103);
            this.grpMoon.TabIndex = 7;
            this.grpMoon.TabStop = false;
            this.grpMoon.Text = "Moon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 45);
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
            this.nmSpeed.Location = new System.Drawing.Point(97, 43);
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
            this.grpDirection.Location = new System.Drawing.Point(12, 76);
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
            this.btnOK.Location = new System.Drawing.Point(351, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmNewObjAdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 397);
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
    }
}