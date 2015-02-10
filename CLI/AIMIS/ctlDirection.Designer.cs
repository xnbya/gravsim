namespace AIMIS
{
    partial class ctlDirection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDirection = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nmDirectionAngle = new System.Windows.Forms.NumericUpDown();
            this.grpDirection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDirectionAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDirection
            // 
            this.grpDirection.Controls.Add(this.label5);
            this.grpDirection.Controls.Add(this.nmDirectionAngle);
            this.grpDirection.Location = new System.Drawing.Point(3, 3);
            this.grpDirection.Name = "grpDirection";
            this.grpDirection.Size = new System.Drawing.Size(205, 154);
            this.grpDirection.TabIndex = 11;
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
            // ctlDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpDirection);
            this.Name = "ctlDirection";
            this.Size = new System.Drawing.Size(215, 163);
            this.grpDirection.ResumeLayout(false);
            this.grpDirection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDirectionAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDirection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmDirectionAngle;
    }
}
