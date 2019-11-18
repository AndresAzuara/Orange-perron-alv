namespace Orange_perron_chido
{
    partial class DataCleaning
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
            this.tablaPrincipal = new System.Windows.Forms.DataGridView();
            this.corregirOutliers = new System.Windows.Forms.Button();
            this.DataWatch = new System.Windows.Forms.Button();
            this.optionsWatch = new System.Windows.Forms.ComboBox();
            this.muestreoNombreArchivo = new System.Windows.Forms.TextBox();
            this.transformacionValores = new System.Windows.Forms.ComboBox();
            this.transformatValor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaPrincipal
            // 
            this.tablaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPrincipal.Location = new System.Drawing.Point(13, 13);
            this.tablaPrincipal.Name = "tablaPrincipal";
            this.tablaPrincipal.Size = new System.Drawing.Size(775, 339);
            this.tablaPrincipal.TabIndex = 0;
            this.tablaPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPrincipal_CellContentClick);
            // 
            // corregirOutliers
            // 
            this.corregirOutliers.Location = new System.Drawing.Point(13, 371);
            this.corregirOutliers.Name = "corregirOutliers";
            this.corregirOutliers.Size = new System.Drawing.Size(120, 23);
            this.corregirOutliers.TabIndex = 1;
            this.corregirOutliers.Text = "Corregir outliers";
            this.corregirOutliers.UseVisualStyleBackColor = true;
            this.corregirOutliers.Click += new System.EventHandler(this.corregirOutliers_Click);
            // 
            // DataWatch
            // 
            this.DataWatch.Location = new System.Drawing.Point(189, 406);
            this.DataWatch.Name = "DataWatch";
            this.DataWatch.Size = new System.Drawing.Size(120, 23);
            this.DataWatch.TabIndex = 2;
            this.DataWatch.Text = "Muestreo de datos";
            this.DataWatch.UseVisualStyleBackColor = true;
            this.DataWatch.Click += new System.EventHandler(this.DataWatch_Click);
            // 
            // optionsWatch
            // 
            this.optionsWatch.FormattingEnabled = true;
            this.optionsWatch.Location = new System.Drawing.Point(189, 372);
            this.optionsWatch.Name = "optionsWatch";
            this.optionsWatch.Size = new System.Drawing.Size(121, 21);
            this.optionsWatch.TabIndex = 3;
            // 
            // muestreoNombreArchivo
            // 
            this.muestreoNombreArchivo.Location = new System.Drawing.Point(342, 371);
            this.muestreoNombreArchivo.Name = "muestreoNombreArchivo";
            this.muestreoNombreArchivo.Size = new System.Drawing.Size(142, 20);
            this.muestreoNombreArchivo.TabIndex = 4;
            // 
            // transformacionValores
            // 
            this.transformacionValores.FormattingEnabled = true;
            this.transformacionValores.Location = new System.Drawing.Point(507, 373);
            this.transformacionValores.Name = "transformacionValores";
            this.transformacionValores.Size = new System.Drawing.Size(121, 21);
            this.transformacionValores.TabIndex = 5;
            // 
            // transformatValor
            // 
            this.transformatValor.Location = new System.Drawing.Point(646, 373);
            this.transformatValor.Name = "transformatValor";
            this.transformatValor.Size = new System.Drawing.Size(142, 23);
            this.transformatValor.TabIndex = 6;
            this.transformatValor.Text = "Transformar";
            this.transformatValor.UseVisualStyleBackColor = true;
            this.transformatValor.Click += new System.EventHandler(this.transformatValor_Click);
            // 
            // DataCleaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transformatValor);
            this.Controls.Add(this.transformacionValores);
            this.Controls.Add(this.muestreoNombreArchivo);
            this.Controls.Add(this.optionsWatch);
            this.Controls.Add(this.DataWatch);
            this.Controls.Add(this.corregirOutliers);
            this.Controls.Add(this.tablaPrincipal);
            this.Name = "DataCleaning";
            this.Text = "DataCleaning";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaPrincipal;
        private System.Windows.Forms.Button corregirOutliers;
        private System.Windows.Forms.Button DataWatch;
        private System.Windows.Forms.ComboBox optionsWatch;
        private System.Windows.Forms.TextBox muestreoNombreArchivo;
        private System.Windows.Forms.ComboBox transformacionValores;
        private System.Windows.Forms.Button transformatValor;
    }
}