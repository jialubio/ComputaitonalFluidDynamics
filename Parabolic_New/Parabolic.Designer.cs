namespace Parabolic_New
{
    partial class Parabolic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberOfPoints = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumberOfSteps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSpaceStepSize = new System.Windows.Forms.TextBox();
            this.textBoxTimeStepSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDiffusionNumber = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxDiffusionConstant = new System.Windows.Forms.TextBox();
            this.buttonStepSolution = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelStepCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBeta = new System.Windows.Forms.TextBox();
            this.chartSolution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSolution)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Points";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNumberOfPoints
            // 
            this.textBoxNumberOfPoints.Location = new System.Drawing.Point(131, 1);
            this.textBoxNumberOfPoints.Name = "textBoxNumberOfPoints";
            this.textBoxNumberOfPoints.Size = new System.Drawing.Size(116, 22);
            this.textBoxNumberOfPoints.TabIndex = 2;
            this.textBoxNumberOfPoints.Text = "101";
            this.textBoxNumberOfPoints.TextChanged += new System.EventHandler(this.TextBoxNumberOfPoints_TextChanged);
            // 
            // label2
            // 
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Steps";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNumberOfSteps
            // 
            this.textBoxNumberOfSteps.Location = new System.Drawing.Point(131, 26);
            this.textBoxNumberOfSteps.Name = "textBoxNumberOfSteps";
            this.textBoxNumberOfSteps.Size = new System.Drawing.Size(116, 22);
            this.textBoxNumberOfSteps.TabIndex = 4;
            this.textBoxNumberOfSteps.Text = "1000";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Space Step Size";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time Step Size";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSpaceStepSize
            // 
            this.textBoxSpaceStepSize.ForeColor = System.Drawing.Color.Red;
            this.textBoxSpaceStepSize.Location = new System.Drawing.Point(131, 51);
            this.textBoxSpaceStepSize.Name = "textBoxSpaceStepSize";
            this.textBoxSpaceStepSize.Size = new System.Drawing.Size(116, 22);
            this.textBoxSpaceStepSize.TabIndex = 7;
            this.textBoxSpaceStepSize.Text = "0.01";
            // 
            // textBoxTimeStepSize
            // 
            this.textBoxTimeStepSize.ForeColor = System.Drawing.Color.Red;
            this.textBoxTimeStepSize.Location = new System.Drawing.Point(131, 76);
            this.textBoxTimeStepSize.Name = "textBoxTimeStepSize";
            this.textBoxTimeStepSize.Size = new System.Drawing.Size(116, 22);
            this.textBoxTimeStepSize.TabIndex = 8;
            this.textBoxTimeStepSize.Text = "0.001";
            this.textBoxTimeStepSize.TextChanged += new System.EventHandler(this.TextBoxTimeStepSize_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Diffusion Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Diffusion Constant";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDiffusionNumber
            // 
            this.textBoxDiffusionNumber.ForeColor = System.Drawing.Color.Red;
            this.textBoxDiffusionNumber.Location = new System.Drawing.Point(131, 126);
            this.textBoxDiffusionNumber.Name = "textBoxDiffusionNumber";
            this.textBoxDiffusionNumber.Size = new System.Drawing.Size(116, 22);
            this.textBoxDiffusionNumber.TabIndex = 12;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(289, 0);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(103, 23);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Reset Values";
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxDiffusionConstant
            // 
            this.textBoxDiffusionConstant.Location = new System.Drawing.Point(131, 101);
            this.textBoxDiffusionConstant.Name = "textBoxDiffusionConstant";
            this.textBoxDiffusionConstant.Size = new System.Drawing.Size(116, 22);
            this.textBoxDiffusionConstant.TabIndex = 14;
            this.textBoxDiffusionConstant.Text = "1.0";
            // 
            // buttonStepSolution
            // 
            this.buttonStepSolution.Enabled = false;
            this.buttonStepSolution.Location = new System.Drawing.Point(289, 50);
            this.buttonStepSolution.Name = "buttonStepSolution";
            this.buttonStepSolution.Size = new System.Drawing.Size(103, 23);
            this.buttonStepSolution.TabIndex = 15;
            this.buttonStepSolution.Text = "Step Solution";
            this.buttonStepSolution.Click += new System.EventHandler(this.buttonStepSolution_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Enabled = false;
            this.buttonRun.Location = new System.Drawing.Point(289, 80);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(103, 23);
            this.buttonRun.TabIndex = 16;
            this.buttonRun.Text = "Run Solution";
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelStepCount
            // 
            this.labelStepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStepCount.Location = new System.Drawing.Point(411, 50);
            this.labelStepCount.Name = "labelStepCount";
            this.labelStepCount.Size = new System.Drawing.Size(215, 23);
            this.labelStepCount.TabIndex = 17;
            this.labelStepCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(635, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 168);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solution Method";
            // 
            // radioButton6
            // 
            this.radioButton6.Location = new System.Drawing.Point(19, 136);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(121, 24);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "beta Method";
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(19, 112);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(196, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Crank-Nicolson Method";
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(19, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(177, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Laasonen Method";
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(19, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(168, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Dufort-Frankel Method";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(19, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(168, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Richardson Method";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(19, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(149, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "FTCS Method";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "beta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Visible = false;
            // 
            // textBoxBeta
            // 
            this.textBoxBeta.Location = new System.Drawing.Point(131, 152);
            this.textBoxBeta.Name = "textBoxBeta";
            this.textBoxBeta.Size = new System.Drawing.Size(116, 22);
            this.textBoxBeta.TabIndex = 20;
            this.textBoxBeta.Text = "0.5";
            this.textBoxBeta.Visible = false;
            // 
            // chartSolution
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSolution.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSolution.Legends.Add(legend2);
            this.chartSolution.Location = new System.Drawing.Point(15, 182);
            this.chartSolution.Name = "chartSolution";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Solution";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartSolution.Series.Add(series2);
            this.chartSolution.Size = new System.Drawing.Size(853, 276);
            this.chartSolution.TabIndex = 21;
            this.chartSolution.Text = "chart1";
            // 
            // Parabolic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 470);
            this.Controls.Add(this.chartSolution);
            this.Controls.Add(this.textBoxBeta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelStepCount);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonStepSolution);
            this.Controls.Add(this.textBoxDiffusionConstant);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxDiffusionNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTimeStepSize);
            this.Controls.Add(this.textBoxSpaceStepSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumberOfSteps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumberOfPoints);
            this.Controls.Add(this.label1);
            this.Name = "Parabolic";
            this.Text = "Parabolic";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumberOfPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumberOfSteps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSpaceStepSize;
        private System.Windows.Forms.TextBox textBoxTimeStepSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDiffusionNumber;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxDiffusionConstant;
        private System.Windows.Forms.Button buttonStepSolution;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelStepCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBeta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSolution;
    }
}

