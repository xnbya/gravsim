﻿namespace AIMIS
{
    partial class frmEarthOrbit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmHeight = new System.Windows.Forms.NumericUpDown();
            this.nmSpeed = new System.Windows.Forms.NumericUpDown();
            this.nmDirection = new System.Windows.Forms.NumericUpDown();
            this.btnLaunch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDirection)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height above surface:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direction:";
            // 
            // nmHeight
            // 
            this.nmHeight.DecimalPlaces = 2;
            this.nmHeight.Location = new System.Drawing.Point(130, 12);
            this.nmHeight.Name = "nmHeight";
            this.nmHeight.Size = new System.Drawing.Size(120, 20);
            this.nmHeight.TabIndex = 3;
            // 
            // nmSpeed
            // 
            this.nmSpeed.DecimalPlaces = 2;
            this.nmSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmSpeed.Location = new System.Drawing.Point(130, 38);
            this.nmSpeed.Name = "nmSpeed";
            this.nmSpeed.Size = new System.Drawing.Size(120, 20);
            this.nmSpeed.TabIndex = 4;
            // 
            // nmDirection
            // 
            this.nmDirection.Location = new System.Drawing.Point(130, 64);
            this.nmDirection.Name = "nmDirection";
            this.nmDirection.Size = new System.Drawing.Size(120, 20);
            this.nmDirection.TabIndex = 5;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(175, 90);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 6;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // frmEarthOrbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 134);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.nmDirection);
            this.Controls.Add(this.nmSpeed);
            this.Controls.Add(this.nmHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEarthOrbit";
            this.Text = "frmEarthOrbit";
            ((System.ComponentModel.ISupportInitialize)(this.nmHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDirection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmHeight;
        private System.Windows.Forms.NumericUpDown nmSpeed;
        private System.Windows.Forms.NumericUpDown nmDirection;
        private System.Windows.Forms.Button btnLaunch;
    }
}