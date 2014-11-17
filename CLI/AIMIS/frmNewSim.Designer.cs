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
            this.btnLaunch = new System.Windows.Forms.Button();
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
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(12, 91);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 3;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // frmNewSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 155);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.rbSimple);
            this.Controls.Add(this.rbRandom);
            this.Controls.Add(this.rbEmpty);
            this.Name = "frmNewSim";
            this.Text = "New Simulation";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEmpty;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.Button btnLaunch;
    }
}