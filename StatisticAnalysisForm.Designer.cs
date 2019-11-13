namespace Orange_perron_chido
{
    partial class StatisticAnalysisForm
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
            this.Mode = new System.Windows.Forms.Label();
            this.Median = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.Label();
            this.StandarDesviation = new System.Windows.Forms.Label();
            this.ValueMode = new System.Windows.Forms.Label();
            this.ValueMedian = new System.Windows.Forms.Label();
            this.ValueAverage = new System.Windows.Forms.Label();
            this.ValueStandarDesviation = new System.Windows.Forms.Label();
            this.boxPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Frecuencias = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frecuencias)).BeginInit();
            this.SuspendLayout();
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Location = new System.Drawing.Point(36, 13);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(34, 13);
            this.Mode.TabIndex = 0;
            this.Mode.Text = "Moda";
            // 
            // Median
            // 
            this.Median.AutoSize = true;
            this.Median.Location = new System.Drawing.Point(39, 71);
            this.Median.Name = "Median";
            this.Median.Size = new System.Drawing.Size(48, 13);
            this.Median.TabIndex = 1;
            this.Median.Text = "Mediana";
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.Location = new System.Drawing.Point(39, 128);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(51, 13);
            this.Average.TabIndex = 2;
            this.Average.Text = "Promedio";
            // 
            // StandarDesviation
            // 
            this.StandarDesviation.AutoSize = true;
            this.StandarDesviation.Location = new System.Drawing.Point(42, 187);
            this.StandarDesviation.Name = "StandarDesviation";
            this.StandarDesviation.Size = new System.Drawing.Size(105, 13);
            this.StandarDesviation.TabIndex = 3;
            this.StandarDesviation.Text = "Desviación Estandar";
            // 
            // ValueMode
            // 
            this.ValueMode.AutoSize = true;
            this.ValueMode.Location = new System.Drawing.Point(39, 39);
            this.ValueMode.Name = "ValueMode";
            this.ValueMode.Size = new System.Drawing.Size(13, 13);
            this.ValueMode.TabIndex = 4;
            this.ValueMode.Text = "0";
            // 
            // ValueMedian
            // 
            this.ValueMedian.AutoSize = true;
            this.ValueMedian.Location = new System.Drawing.Point(42, 97);
            this.ValueMedian.Name = "ValueMedian";
            this.ValueMedian.Size = new System.Drawing.Size(13, 13);
            this.ValueMedian.TabIndex = 5;
            this.ValueMedian.Text = "0";
            // 
            // ValueAverage
            // 
            this.ValueAverage.AutoSize = true;
            this.ValueAverage.Location = new System.Drawing.Point(42, 154);
            this.ValueAverage.Name = "ValueAverage";
            this.ValueAverage.Size = new System.Drawing.Size(13, 13);
            this.ValueAverage.TabIndex = 6;
            this.ValueAverage.Text = "0";
            // 
            // ValueStandarDesviation
            // 
            this.ValueStandarDesviation.AutoSize = true;
            this.ValueStandarDesviation.Location = new System.Drawing.Point(45, 218);
            this.ValueStandarDesviation.Name = "ValueStandarDesviation";
            this.ValueStandarDesviation.Size = new System.Drawing.Size(13, 13);
            this.ValueStandarDesviation.TabIndex = 7;
            this.ValueStandarDesviation.Text = "0";
            // 
            // boxPlot
            // 
            chartArea1.Name = "ChartArea1";
            this.boxPlot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.boxPlot.Legends.Add(legend1);
            this.boxPlot.Location = new System.Drawing.Point(203, 13);
            this.boxPlot.Name = "boxPlot";
            this.boxPlot.Size = new System.Drawing.Size(554, 425);
            this.boxPlot.TabIndex = 8;
            this.boxPlot.Text = "chart1";
            // 
            // Frecuencias
            // 
            this.Frecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Frecuencias.Location = new System.Drawing.Point(61, 81);
            this.Frecuencias.Name = "Frecuencias";
            this.Frecuencias.Size = new System.Drawing.Size(669, 86);
            this.Frecuencias.TabIndex = 9;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(48, 324);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 10;
            this.back.Text = "Atras";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // StatisticAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Frecuencias);
            this.Controls.Add(this.boxPlot);
            this.Controls.Add(this.ValueStandarDesviation);
            this.Controls.Add(this.ValueAverage);
            this.Controls.Add(this.ValueMedian);
            this.Controls.Add(this.ValueMode);
            this.Controls.Add(this.StandarDesviation);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Median);
            this.Controls.Add(this.Mode);
            this.Name = "StatisticAnalysisForm";
            this.Text = "StatisticAnalysisForm";
            ((System.ComponentModel.ISupportInitialize)(this.boxPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frecuencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Label Median;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.Label StandarDesviation;
        private System.Windows.Forms.Label ValueMode;
        private System.Windows.Forms.Label ValueMedian;
        private System.Windows.Forms.Label ValueAverage;
        private System.Windows.Forms.Label ValueStandarDesviation;
        private System.Windows.Forms.DataVisualization.Charting.Chart boxPlot;
        private System.Windows.Forms.DataGridView Frecuencias;
        private System.Windows.Forms.Button back;
    }
}