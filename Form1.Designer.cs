namespace Orange_perron_chido
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.accionadorArchivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaPrincipal = new System.Windows.Forms.DataGridView();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.SaveNewFile = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.DataSetName = new System.Windows.Forms.Label();
            this.rowsQuantity = new System.Windows.Forms.Label();
            this.ColumnQuantity = new System.Windows.Forms.Label();
            this.missingValues = new System.Windows.Forms.Label();
            this.proportion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.columnToAutomatic = new System.Windows.Forms.ComboBox();
            this.DevelopAnalyse = new System.Windows.Forms.Button();
            this.AlgoritmNames = new System.Windows.Forms.ComboBox();
            this.metodology = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrincipal)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // accionadorArchivo
            // 
            this.accionadorArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.accionadorArchivo.FlatAppearance.BorderSize = 0;
            this.accionadorArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.accionadorArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accionadorArchivo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accionadorArchivo.ForeColor = System.Drawing.SystemColors.Control;
            this.accionadorArchivo.Location = new System.Drawing.Point(0, 28);
            this.accionadorArchivo.Name = "accionadorArchivo";
            this.accionadorArchivo.Size = new System.Drawing.Size(139, 29);
            this.accionadorArchivo.TabIndex = 0;
            this.accionadorArchivo.Text = "Abrir Archivo";
            this.accionadorArchivo.UseVisualStyleBackColor = false;
            this.accionadorArchivo.Click += new System.EventHandler(this.accionadorArchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(367, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORANGE PERRON CHIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tablaPrincipal
            // 
            this.tablaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaPrincipal.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaPrincipal.Location = new System.Drawing.Point(145, 40);
            this.tablaPrincipal.Name = "tablaPrincipal";
            this.tablaPrincipal.RowTemplate.Height = 25;
            this.tablaPrincipal.Size = new System.Drawing.Size(655, 261);
            this.tablaPrincipal.TabIndex = 2;
            this.tablaPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPrincipal_CellContentClick);
            // 
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SaveChanges.FlatAppearance.BorderSize = 0;
            this.SaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChanges.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveChanges.Location = new System.Drawing.Point(0, 75);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(139, 26);
            this.SaveChanges.TabIndex = 3;
            this.SaveChanges.Text = "Guardar";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // SaveNewFile
            // 
            this.SaveNewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SaveNewFile.FlatAppearance.BorderSize = 0;
            this.SaveNewFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SaveNewFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.SaveNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveNewFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNewFile.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveNewFile.Location = new System.Drawing.Point(3, 117);
            this.SaveNewFile.Name = "SaveNewFile";
            this.SaveNewFile.Size = new System.Drawing.Size(136, 26);
            this.SaveNewFile.TabIndex = 4;
            this.SaveNewFile.Text = "Guardar Como";
            this.SaveNewFile.UseVisualStyleBackColor = false;
            this.SaveNewFile.Click += new System.EventHandler(this.SaveNewFile_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit.Location = new System.Drawing.Point(0, 162);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(139, 24);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Salir";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.deleteRow.FlatAppearance.BorderSize = 0;
            this.deleteRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.deleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRow.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRow.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteRow.Location = new System.Drawing.Point(689, 1);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(111, 34);
            this.deleteRow.TabIndex = 6;
            this.deleteRow.Text = "Eliminar";
            this.deleteRow.UseVisualStyleBackColor = false;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // DataSetName
            // 
            this.DataSetName.AutoSize = true;
            this.DataSetName.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSetName.ForeColor = System.Drawing.SystemColors.Control;
            this.DataSetName.Location = new System.Drawing.Point(158, 331);
            this.DataSetName.Name = "DataSetName";
            this.DataSetName.Size = new System.Drawing.Size(33, 20);
            this.DataSetName.TabIndex = 7;
            this.DataSetName.Text = "xxx";
            // 
            // rowsQuantity
            // 
            this.rowsQuantity.AutoSize = true;
            this.rowsQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsQuantity.ForeColor = System.Drawing.SystemColors.Control;
            this.rowsQuantity.Location = new System.Drawing.Point(158, 374);
            this.rowsQuantity.Name = "rowsQuantity";
            this.rowsQuantity.Size = new System.Drawing.Size(18, 20);
            this.rowsQuantity.TabIndex = 8;
            this.rowsQuantity.Text = "0";
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.AutoSize = true;
            this.ColumnQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnQuantity.ForeColor = System.Drawing.SystemColors.Control;
            this.ColumnQuantity.Location = new System.Drawing.Point(340, 331);
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.Size = new System.Drawing.Size(18, 20);
            this.ColumnQuantity.TabIndex = 9;
            this.ColumnQuantity.Text = "0";
            // 
            // missingValues
            // 
            this.missingValues.AutoSize = true;
            this.missingValues.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingValues.ForeColor = System.Drawing.SystemColors.Control;
            this.missingValues.Location = new System.Drawing.Point(340, 374);
            this.missingValues.Name = "missingValues";
            this.missingValues.Size = new System.Drawing.Size(18, 20);
            this.missingValues.TabIndex = 10;
            this.missingValues.Text = "0";
            // 
            // proportion
            // 
            this.proportion.AutoSize = true;
            this.proportion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proportion.ForeColor = System.Drawing.SystemColors.Control;
            this.proportion.Location = new System.Drawing.Point(158, 418);
            this.proportion.Name = "proportion";
            this.proportion.Size = new System.Drawing.Size(18, 20);
            this.proportion.TabIndex = 11;
            this.proportion.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(158, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre del archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(158, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Instancias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(340, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Atributos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(340, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Atributos faltantes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(158, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Proporción de valores faltantes";
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.accionadorArchivo);
            this.MenuVertical.Controls.Add(this.SaveChanges);
            this.MenuVertical.Controls.Add(this.SaveNewFile);
            this.MenuVertical.Controls.Add(this.Exit);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(142, 450);
            this.MenuVertical.TabIndex = 18;
            // 
            // columnToAutomatic
            // 
            this.columnToAutomatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.columnToAutomatic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnToAutomatic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnToAutomatic.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnToAutomatic.ForeColor = System.Drawing.SystemColors.Window;
            this.columnToAutomatic.FormattingEnabled = true;
            this.columnToAutomatic.Location = new System.Drawing.Point(624, 341);
            this.columnToAutomatic.Name = "columnToAutomatic";
            this.columnToAutomatic.Size = new System.Drawing.Size(164, 28);
            this.columnToAutomatic.TabIndex = 19;
            // 
            // DevelopAnalyse
            // 
            this.DevelopAnalyse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.DevelopAnalyse.FlatAppearance.BorderSize = 0;
            this.DevelopAnalyse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.DevelopAnalyse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevelopAnalyse.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevelopAnalyse.ForeColor = System.Drawing.SystemColors.Control;
            this.DevelopAnalyse.Location = new System.Drawing.Point(679, 412);
            this.DevelopAnalyse.Name = "DevelopAnalyse";
            this.DevelopAnalyse.Size = new System.Drawing.Size(121, 38);
            this.DevelopAnalyse.TabIndex = 20;
            this.DevelopAnalyse.Text = "Analizar";
            this.DevelopAnalyse.UseVisualStyleBackColor = false;
            this.DevelopAnalyse.Click += new System.EventHandler(this.DevelopAnalyse_Click);
            // 
            // AlgoritmNames
            // 
            this.AlgoritmNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.AlgoritmNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgoritmNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlgoritmNames.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgoritmNames.ForeColor = System.Drawing.SystemColors.Window;
            this.AlgoritmNames.FormattingEnabled = true;
            this.AlgoritmNames.Location = new System.Drawing.Point(624, 374);
            this.AlgoritmNames.Name = "AlgoritmNames";
            this.AlgoritmNames.Size = new System.Drawing.Size(164, 28);
            this.AlgoritmNames.TabIndex = 21;
            // 
            // metodology
            // 
            this.metodology.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.metodology.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metodology.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodology.ForeColor = System.Drawing.SystemColors.Window;
            this.metodology.FormattingEnabled = true;
            this.metodology.Location = new System.Drawing.Point(624, 307);
            this.metodology.Name = "metodology";
            this.metodology.Size = new System.Drawing.Size(164, 28);
            this.metodology.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(513, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Metodología";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(513, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Algoritmo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(513, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Clase";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.metodology);
            this.Controls.Add(this.AlgoritmNames);
            this.Controls.Add(this.DevelopAnalyse);
            this.Controls.Add(this.columnToAutomatic);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proportion);
            this.Controls.Add(this.missingValues);
            this.Controls.Add(this.ColumnQuantity);
            this.Controls.Add(this.rowsQuantity);
            this.Controls.Add(this.DataSetName);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.tablaPrincipal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrincipal)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accionadorArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaPrincipal;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button SaveNewFile;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button deleteRow;
        private System.Windows.Forms.Label DataSetName;
        private System.Windows.Forms.Label rowsQuantity;
        private System.Windows.Forms.Label ColumnQuantity;
        private System.Windows.Forms.Label missingValues;
        private System.Windows.Forms.Label proportion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.ComboBox columnToAutomatic;
        private System.Windows.Forms.Button DevelopAnalyse;
        private System.Windows.Forms.ComboBox AlgoritmNames;
        private System.Windows.Forms.ComboBox metodology;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

