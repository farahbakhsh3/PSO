namespace PSO
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnRunPSO = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblMiliSecTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtmaxIter = new System.Windows.Forms.TextBox();
            this.txtSwarmSize = new System.Windows.Forms.TextBox();
            this.txtdecP = new System.Windows.Forms.TextBox();
            this.txtdimSize = new System.Windows.Forms.TextBox();
            this.txtUBXi = new System.Windows.Forms.TextBox();
            this.combType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLBXi = new System.Windows.Forms.TextBox();
            this.wMirai = new System.Windows.Forms.Label();
            this.txtwMira = new System.Windows.Forms.TextBox();
            this.btnDispPlot = new System.Windows.Forms.Button();
            this.chartGlobalFitness = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLbSpeedXi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUbSpeedXi = new System.Windows.Forms.TextBox();
            this.combFitnessFunc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartGlobalFitness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRunPSO
            // 
            this.btnRunPSO.Location = new System.Drawing.Point(12, 48);
            this.btnRunPSO.Name = "btnRunPSO";
            this.btnRunPSO.Size = new System.Drawing.Size(164, 29);
            this.btnRunPSO.TabIndex = 0;
            this.btnRunPSO.Text = "Run PSO";
            this.btnRunPSO.UseVisualStyleBackColor = true;
            this.btnRunPSO.Click += new System.EventHandler(this.btnRunPSO_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(182, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(695, 348);
            this.treeView1.TabIndex = 12;
            // 
            // lblMiliSecTime
            // 
            this.lblMiliSecTime.AutoSize = true;
            this.lblMiliSecTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMiliSecTime.ForeColor = System.Drawing.Color.Red;
            this.lblMiliSecTime.Location = new System.Drawing.Point(9, 472);
            this.lblMiliSecTime.Name = "lblMiliSecTime";
            this.lblMiliSecTime.Size = new System.Drawing.Size(19, 13);
            this.lblMiliSecTime.TabIndex = 42;
            this.lblMiliSecTime.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(12, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "C1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(12, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "W";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(12, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "maxIter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(12, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "SwarmSize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "decP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "dimSize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "UB Xi";
            // 
            // txtC1
            // 
            this.txtC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtC1.Location = new System.Drawing.Point(103, 382);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(73, 20);
            this.txtC1.TabIndex = 9;
            this.txtC1.Text = "2";
            this.txtC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtW
            // 
            this.txtW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtW.Location = new System.Drawing.Point(103, 356);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(73, 20);
            this.txtW.TabIndex = 8;
            this.txtW.Text = "1";
            this.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmaxIter
            // 
            this.txtmaxIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtmaxIter.Location = new System.Drawing.Point(103, 330);
            this.txtmaxIter.Name = "txtmaxIter";
            this.txtmaxIter.Size = new System.Drawing.Size(73, 20);
            this.txtmaxIter.TabIndex = 7;
            this.txtmaxIter.Text = "100";
            this.txtmaxIter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSwarmSize
            // 
            this.txtSwarmSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSwarmSize.Location = new System.Drawing.Point(103, 304);
            this.txtSwarmSize.Name = "txtSwarmSize";
            this.txtSwarmSize.Size = new System.Drawing.Size(73, 20);
            this.txtSwarmSize.TabIndex = 6;
            this.txtSwarmSize.Text = "5";
            this.txtSwarmSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdecP
            // 
            this.txtdecP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtdecP.Location = new System.Drawing.Point(103, 240);
            this.txtdecP.Name = "txtdecP";
            this.txtdecP.Size = new System.Drawing.Size(73, 20);
            this.txtdecP.TabIndex = 5;
            this.txtdecP.Text = "5";
            this.txtdecP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdimSize
            // 
            this.txtdimSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtdimSize.Location = new System.Drawing.Point(103, 110);
            this.txtdimSize.Name = "txtdimSize";
            this.txtdimSize.Size = new System.Drawing.Size(73, 20);
            this.txtdimSize.TabIndex = 2;
            this.txtdimSize.Text = "2";
            this.txtdimSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUBXi
            // 
            this.txtUBXi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUBXi.Location = new System.Drawing.Point(103, 136);
            this.txtUBXi.Name = "txtUBXi";
            this.txtUBXi.Size = new System.Drawing.Size(73, 20);
            this.txtUBXi.TabIndex = 3;
            this.txtUBXi.Text = "10";
            this.txtUBXi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // combType
            // 
            this.combType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.combType.FormattingEnabled = true;
            this.combType.Items.AddRange(new object[] {
            "Minimization",
            "Maximization"});
            this.combType.Location = new System.Drawing.Point(77, 83);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(99, 21);
            this.combType.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(12, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "C2";
            // 
            // txtC2
            // 
            this.txtC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtC2.Location = new System.Drawing.Point(103, 408);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(73, 20);
            this.txtC2.TabIndex = 10;
            this.txtC2.Text = "2";
            this.txtC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(12, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "LB Xi";
            // 
            // txtLBXi
            // 
            this.txtLBXi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLBXi.Location = new System.Drawing.Point(103, 162);
            this.txtLBXi.Name = "txtLBXi";
            this.txtLBXi.Size = new System.Drawing.Size(73, 20);
            this.txtLBXi.TabIndex = 4;
            this.txtLBXi.Text = "-10";
            this.txtLBXi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wMirai
            // 
            this.wMirai.AutoSize = true;
            this.wMirai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.wMirai.Location = new System.Drawing.Point(12, 437);
            this.wMirai.Name = "wMirai";
            this.wMirai.Size = new System.Drawing.Size(50, 13);
            this.wMirai.TabIndex = 50;
            this.wMirai.Text = "wMiraie";
            // 
            // txtwMira
            // 
            this.txtwMira.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtwMira.Location = new System.Drawing.Point(103, 434);
            this.txtwMira.Name = "txtwMira";
            this.txtwMira.Size = new System.Drawing.Size(73, 20);
            this.txtwMira.TabIndex = 11;
            this.txtwMira.Text = "0.99";
            this.txtwMira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDispPlot
            // 
            this.btnDispPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDispPlot.Enabled = false;
            this.btnDispPlot.Location = new System.Drawing.Point(12, 506);
            this.btnDispPlot.Name = "btnDispPlot";
            this.btnDispPlot.Size = new System.Drawing.Size(164, 29);
            this.btnDispPlot.TabIndex = 51;
            this.btnDispPlot.Text = "Display Plot - Only 2D";
            this.btnDispPlot.UseVisualStyleBackColor = true;
            this.btnDispPlot.Click += new System.EventHandler(this.btnDispPlot_Click);
            // 
            // chartGlobalFitness
            // 
            this.chartGlobalFitness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartGlobalFitness.BorderlineColor = System.Drawing.Color.Black;
            this.chartGlobalFitness.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.chartGlobalFitness.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chartGlobalFitness.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Name = "ChartArea1";
            this.chartGlobalFitness.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGlobalFitness.Legends.Add(legend1);
            this.chartGlobalFitness.Location = new System.Drawing.Point(182, 366);
            this.chartGlobalFitness.Name = "chartGlobalFitness";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.MarkerSize = 3;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Global Best Fitness";
            this.chartGlobalFitness.Series.Add(series1);
            this.chartGlobalFitness.Size = new System.Drawing.Size(695, 169);
            this.chartGlobalFitness.TabIndex = 52;
            this.chartGlobalFitness.Text = "chart1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(12, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "LB Speed Xi";
            // 
            // txtLbSpeedXi
            // 
            this.txtLbSpeedXi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLbSpeedXi.Location = new System.Drawing.Point(103, 214);
            this.txtLbSpeedXi.Name = "txtLbSpeedXi";
            this.txtLbSpeedXi.Size = new System.Drawing.Size(73, 20);
            this.txtLbSpeedXi.TabIndex = 54;
            this.txtLbSpeedXi.Text = "-10";
            this.txtLbSpeedXi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(12, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "UB Speed Xi";
            // 
            // txtUbSpeedXi
            // 
            this.txtUbSpeedXi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUbSpeedXi.Location = new System.Drawing.Point(103, 188);
            this.txtUbSpeedXi.Name = "txtUbSpeedXi";
            this.txtUbSpeedXi.Size = new System.Drawing.Size(73, 20);
            this.txtUbSpeedXi.TabIndex = 53;
            this.txtUbSpeedXi.Text = "10";
            this.txtUbSpeedXi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // combFitnessFunc
            // 
            this.combFitnessFunc.FormattingEnabled = true;
            this.combFitnessFunc.Items.AddRange(new object[] {
            "FuncFitness1 : Ackley",
            "FuncFitness2 : ",
            "FuncFitness3 : Sum Xi^2",
            "FuncFitness4 : Bukin",
            "FuncFitness5: Drop-Wave",
            "FuncFitness6: Levy",
            "FuncFitness7: Rastrigin",
            "FuncFitness8: ",
            "FuncFitness9: ",
            "FuncFitness10: "});
            this.combFitnessFunc.Location = new System.Drawing.Point(15, 12);
            this.combFitnessFunc.Name = "combFitnessFunc";
            this.combFitnessFunc.Size = new System.Drawing.Size(161, 21);
            this.combFitnessFunc.TabIndex = 57;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 547);
            this.Controls.Add(this.combFitnessFunc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLbSpeedXi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtUbSpeedXi);
            this.Controls.Add(this.chartGlobalFitness);
            this.Controls.Add(this.btnDispPlot);
            this.Controls.Add(this.wMirai);
            this.Controls.Add(this.txtwMira);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLBXi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combType);
            this.Controls.Add(this.lblMiliSecTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtmaxIter);
            this.Controls.Add(this.txtSwarmSize);
            this.Controls.Add(this.txtdecP);
            this.Controls.Add(this.txtdimSize);
            this.Controls.Add(this.txtUBXi);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnRunPSO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSO Algorithm.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGlobalFitness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunPSO;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblMiliSecTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtmaxIter;
        private System.Windows.Forms.TextBox txtSwarmSize;
        private System.Windows.Forms.TextBox txtdecP;
        private System.Windows.Forms.TextBox txtdimSize;
        private System.Windows.Forms.TextBox txtUBXi;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLBXi;
        private System.Windows.Forms.Label wMirai;
        private System.Windows.Forms.TextBox txtwMira;
        private System.Windows.Forms.Button btnDispPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGlobalFitness;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLbSpeedXi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUbSpeedXi;
        private System.Windows.Forms.ComboBox combFitnessFunc;
    }
}

