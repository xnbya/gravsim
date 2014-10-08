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
            this.grbTrails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rkbSpeed)).BeginInit();
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
            this.rkbSpeed.Location = new System.Drawing.Point(12, 210);
            this.rkbSpeed.Maximum = 100;
            this.rkbSpeed.Name = "rkbSpeed";
            this.rkbSpeed.Size = new System.Drawing.Size(400, 45);
            this.rkbSpeed.TabIndex = 1;
            this.rkbSpeed.Scroll += new System.EventHandler(this.rkbSpeed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed of simulation";
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rkbSpeed);
            this.Controls.Add(this.grbTrails);
            this.Name = "frmControl";
            this.Text = "AIMIS control window";
            this.grbTrails.ResumeLayout(false);
            this.grbTrails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rkbSpeed)).EndInit();
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
    }
}