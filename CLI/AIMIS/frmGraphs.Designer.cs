namespace AIMIS
{
    partial class frmGraphs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraphs));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.nudPlanetIndex = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chTrackNew = new System.Windows.Forms.CheckBox();
            this.chTrackObject = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlanetIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.MarkerBorderWidth = 2;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(638, 330);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 500;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // nudPlanetIndex
            // 
            this.nudPlanetIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudPlanetIndex.Location = new System.Drawing.Point(107, 359);
            this.nudPlanetIndex.Name = "nudPlanetIndex";
            this.nudPlanetIndex.Size = new System.Drawing.Size(120, 20);
            this.nudPlanetIndex.TabIndex = 3;
            this.nudPlanetIndex.ValueChanged += new System.EventHandler(this.nudPlanetIndex_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Planet to track:";
            // 
            // chTrackNew
            // 
            this.chTrackNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chTrackNew.AutoSize = true;
            this.chTrackNew.Checked = true;
            this.chTrackNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chTrackNew.Location = new System.Drawing.Point(350, 362);
            this.chTrackNew.Name = "chTrackNew";
            this.chTrackNew.Size = new System.Drawing.Size(114, 17);
            this.chTrackNew.TabIndex = 5;
            this.chTrackNew.Text = "Track new objects";
            this.chTrackNew.UseVisualStyleBackColor = true;
            this.chTrackNew.CheckedChanged += new System.EventHandler(this.chTrackNew_CheckedChanged);
            // 
            // chTrackObject
            // 
            this.chTrackObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chTrackObject.AutoSize = true;
            this.chTrackObject.Location = new System.Drawing.Point(470, 362);
            this.chTrackObject.Name = "chTrackObject";
            this.chTrackObject.Size = new System.Drawing.Size(99, 17);
            this.chTrackObject.TabIndex = 6;
            this.chTrackObject.Text = "Highlight object";
            this.chTrackObject.UseVisualStyleBackColor = true;
            this.chTrackObject.CheckedChanged += new System.EventHandler(this.chTrackObject_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Image = global::AIMIS.Properties.Resources.edit_clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(233, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 32);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Graph";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 396);
            this.Controls.Add(this.chTrackObject);
            this.Controls.Add(this.chTrackNew);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPlanetIndex);
            this.Controls.Add(this.btnClear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGraphs";
            this.Text = "AIMIS Graphs";
            this.Load += new System.EventHandler(this.frmGraphs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlanetIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.NumericUpDown nudPlanetIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chTrackNew;
        private System.Windows.Forms.CheckBox chTrackObject;
    }
}