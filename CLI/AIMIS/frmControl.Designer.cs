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
            this.rbNoTrails = new System.Windows.Forms.RadioButton();
            this.rbShortTrails = new System.Windows.Forms.RadioButton();
            this.rbLongTrails = new System.Windows.Forms.RadioButton();
            this.grbTrails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTrails
            // 
            this.grbTrails.Controls.Add(this.rbLongTrails);
            this.grbTrails.Controls.Add(this.rbShortTrails);
            this.grbTrails.Controls.Add(this.rbNoTrails);
            this.grbTrails.Location = new System.Drawing.Point(12, 12);
            this.grbTrails.Name = "grbTrails";
            this.grbTrails.Size = new System.Drawing.Size(109, 102);
            this.grbTrails.TabIndex = 0;
            this.grbTrails.TabStop = false;
            this.grbTrails.Text = "Trails";
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
            // rbShortTrails
            // 
            this.rbShortTrails.AutoSize = true;
            this.rbShortTrails.Location = new System.Drawing.Point(6, 42);
            this.rbShortTrails.Name = "rbShortTrails";
            this.rbShortTrails.Size = new System.Drawing.Size(74, 17);
            this.rbShortTrails.TabIndex = 1;
            this.rbShortTrails.TabStop = true;
            this.rbShortTrails.Text = "Short trails";
            this.rbShortTrails.UseVisualStyleBackColor = true;
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
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 262);
            this.Controls.Add(this.grbTrails);
            this.Name = "frmControl";
            this.Text = "frmControl";
            this.grbTrails.ResumeLayout(false);
            this.grbTrails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTrails;
        private System.Windows.Forms.RadioButton rbLongTrails;
        private System.Windows.Forms.RadioButton rbShortTrails;
        private System.Windows.Forms.RadioButton rbNoTrails;
    }
}