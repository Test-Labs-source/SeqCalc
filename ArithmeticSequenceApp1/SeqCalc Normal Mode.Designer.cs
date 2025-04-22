using System;

namespace ArithmeticSequenceApp1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtU1 = new System.Windows.Forms.TextBox();
            this.txtU2 = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCommonDifference = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.listBoxSequence = new System.Windows.Forms.ListBox();
            this.txtCommonDifference = new System.Windows.Forms.TextBox();
            this.chartSequence = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartSequence)).BeginInit();
            this.SuspendLayout();
            // 
            // txtU1
            // 
            this.txtU1.Location = new System.Drawing.Point(143, 33);
            this.txtU1.Name = "txtU1";
            this.txtU1.Size = new System.Drawing.Size(100, 20);
            this.txtU1.TabIndex = 0;
            // 
            // txtU2
            // 
            this.txtU2.Location = new System.Drawing.Point(289, 33);
            this.txtU2.Name = "txtU2";
            this.txtU2.Size = new System.Drawing.Size(100, 20);
            this.txtU2.TabIndex = 1;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(428, 33);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "U1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "U2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "عدد الحدود";
            // 
            // lblCommonDifference
            // 
            this.lblCommonDifference.AutoSize = true;
            this.lblCommonDifference.Location = new System.Drawing.Point(585, 17);
            this.lblCommonDifference.Name = "lblCommonDifference";
            this.lblCommonDifference.Size = new System.Drawing.Size(44, 13);
            this.lblCommonDifference.TabIndex = 6;
            this.lblCommonDifference.Text = "r الأساس";
            this.lblCommonDifference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCommonDifference.Click += new System.EventHandler(this.lblCommonDifference_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalculate.Location = new System.Drawing.Point(22, 324);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(242, 27);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // listBoxSequence
            // 
            this.listBoxSequence.FormattingEnabled = true;
            this.listBoxSequence.Location = new System.Drawing.Point(22, 72);
            this.listBoxSequence.Name = "listBoxSequence";
            this.listBoxSequence.Size = new System.Drawing.Size(236, 238);
            this.listBoxSequence.TabIndex = 8;
            this.listBoxSequence.SelectedIndexChanged += new System.EventHandler(this.listBoxSequence_SelectedIndexChanged);
            // 
            // txtCommonDifference
            // 
            this.txtCommonDifference.Location = new System.Drawing.Point(560, 33);
            this.txtCommonDifference.Name = "txtCommonDifference";
            this.txtCommonDifference.Size = new System.Drawing.Size(100, 20);
            this.txtCommonDifference.TabIndex = 9;
            // 
            // chartSequence
            // 
            this.chartSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartSequence.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSequence.Legends.Add(legend2);
            this.chartSequence.Location = new System.Drawing.Point(270, 72);
            this.chartSequence.Name = "chartSequence";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Sequence";
            this.chartSequence.Series.Add(series2);
            this.chartSequence.Size = new System.Drawing.Size(532, 359);
            this.chartSequence.TabIndex = 10;
            this.chartSequence.Text = "chart1";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(22, 389);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(121, 25);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.Location = new System.Drawing.Point(22, 357);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(242, 27);
            this.btnSwitchMode.TabIndex = 12;
            this.btnSwitchMode.Text = "Switch to Advanced Mode";
            this.btnSwitchMode.UseVisualStyleBackColor = true;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(149, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 25);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "التمثيل البياني";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(19, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(45, 13);
            this.labelVersion.TabIndex = 15;
            this.labelVersion.Text = "Version:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(19, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Check For Updates !";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArithmeticSequenceApp1.Properties.Resources.Matht;
            this.ClientSize = new System.Drawing.Size(818, 443);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSwitchMode);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.chartSequence);
            this.Controls.Add(this.txtCommonDifference);
            this.Controls.Add(this.listBoxSequence);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCommonDifference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtU2);
            this.Controls.Add(this.txtU1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeqCalc Normal Mode";
            ((System.ComponentModel.ISupportInitialize)(this.chartSequence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblCommonDifference_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtU1;
        private System.Windows.Forms.TextBox txtU2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCommonDifference;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox listBoxSequence;
        private System.Windows.Forms.TextBox txtCommonDifference;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSequence;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSwitchMode;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

