using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Orange_perron_chido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        OpenFileDialog ofl = new OpenFileDialog();
        List<string> atributos = new List<string>();
        List<string> valores = new List<string>();
        string nombreArchivo;

        private void accionadorArchivo_Click(object sender, EventArgs e)
        {
            int cantidadFilas;
            int cantidadColumnas;
            int valoresFaltantes;
            int valoresNoFaltantes;
            float propocionValoresFaltantes;
            string shortFileName;
            if (ofl.ShowDialog() == DialogResult.OK)
            {
                nombreArchivo = ofl.FileName;
                shortFileName = ofl.SafeFileName.Split('.').FirstOrDefault();
                Console.WriteLine(ofl.FileName);
                int cantidad = 0;
                
                string[] lines = File.ReadAllLines(ofl.FileName);
                foreach (var linea in lines)
                {
                    if(cantidad == 0)
                    {
                        atributos.AddRange(linea.Split(','));
                    }
                    else
                    {
                        valores.AddRange(linea.Split(','));
                    }
                    cantidad++;
                }
                cantidadFilas = valores.Count / atributos.Count;
                cantidadColumnas = atributos.Count;
                valoresFaltantes = obtenerCantidadValoresFaltantes();
                valoresNoFaltantes = obtenerCantidadValoresNoFaltantes();
                propocionValoresFaltantes = (valoresFaltantes * 100) / valoresNoFaltantes;
                rowsQuantity.Text = cantidadFilas.ToString();
                ColumnQuantity.Text = cantidadColumnas.ToString();
                missingValues.Text = valoresFaltantes.ToString();
                proportion.Text = propocionValoresFaltantes.ToString() + "%";
                DataSetName.Text = shortFileName;
                cargarColumnas();
                cargarInformacion();
                //tablaPrincipal.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            }
        }

        private int obtenerCantidadValoresFaltantes()
        {
            int valoresFaltantes = 0;
            foreach(var elemento in valores)
            {
                if(elemento.Equals("") || elemento.Equals(null) || elemento.Equals("?"))
                {
                    valoresFaltantes++;
                }
            }
            return valoresFaltantes;
        }

        private int obtenerCantidadValoresNoFaltantes()
        {
            int valoresNoFaltantes = 0;
            foreach(var elemento in valores)
            {
                if(!elemento.Equals("") || elemento.Equals(null) || elemento.Equals("?"))
                {
                    valoresNoFaltantes++;
                }
            }
            return valoresNoFaltantes;
        }

        private void cargarColumnas()
        {
            int columnas = 0;
            tablaPrincipal.ColumnCount = atributos.Count + 1;
            tablaPrincipal.Columns[columnas++].Name = "ID";
            foreach (var atributo in atributos)
            {
                tablaPrincipal.Columns[columnas++].Name = atributo;
            }
        }

        private void cargarInformacion()
        {
            int id = 1;
            int actual = 0;
            bool completo = true;
                do
                {
                    ArrayList row = new ArrayList();
                    if (actual == valores.Count)
                    {
                        completo = false;
                    break;
                    }
                    row.Add(id++);
                    row.Add(valores.ElementAt(actual++));
                    row.Add(valores.ElementAt(actual++));
                    tablaPrincipal.Rows.Add(row.ToArray());
                } while (completo);
            tablaPrincipal.BorderStyle = BorderStyle.None;
            tablaPrincipal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            tablaPrincipal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tablaPrincipal.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            tablaPrincipal.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            tablaPrincipal.BackgroundColor = Color.White;

            tablaPrincipal.EnableHeadersVisualStyles = false;
            tablaPrincipal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablaPrincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            tablaPrincipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tablaPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tablaPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            List<string> columnElements = new List<string>();
            foreach(DataGridViewRow row in tablaPrincipal.Rows)
            {
                if(row.Cells[columnIndex].Value != null)
                {
                    columnElements.Add(row.Cells[columnIndex].Value.ToString());
                }
            }
            StatisticAnalysisForm analysis = new StatisticAnalysisForm(columnElements, tablaPrincipal.Columns[e.ColumnIndex].Name);
            this.Hide();
            analysis.Show();
        }

        private void getTableData(out List<Object[]> data, out List<string> columnNames)
        {
            data = tablaPrincipal.Rows.OfType<DataGridViewRow>().Select(
                    row => row.Cells.OfType<DataGridViewCell>().Select(c => c.Value).Skip(1).ToArray()).ToList();
            columnNames = new List<string>();
            for (var i = 0; i < tablaPrincipal.ColumnCount; i++)
            {
                if (!tablaPrincipal.Columns[i].HeaderText.Equals("ID"))
                {
                    columnNames.Add(tablaPrincipal.Columns[i].HeaderText);
                }
            }
        }

        private void writeToFile(string path, List<Object[]> data, List<string> columnNames)
        {
            int contador = 0;
            int contadorData = 0;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.Create(path).Dispose();
            using (StreamWriter w = File.AppendText(path))
            {
                Console.WriteLine("header");
                foreach (var column in columnNames)
                {
                    Console.WriteLine(column);
                    w.Write(column);
                    if (++contador != columnNames.Count)
                    {
                        w.Write(",");
                    }
                    else
                    {
                        w.WriteLine("");
                    }
                }
                contador = 0;
                Console.WriteLine("elementos");
                data.RemoveAt(data.Count - 1);
                foreach (var el in data)
                {
                    foreach (var ele in el)
                    {
                        w.Write(ele);
                        if (++contadorData != el.Length)
                        {
                            w.Write(",");
                        }
                        else if (++contador != data.Count)
                        {
                            w.WriteLine("");
                        }
                    }
                    contadorData = 0;
                }
                w.Close();
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            string path = nombreArchivo;
            List<Object[]> data = new List<Object[]>();
            List<string> columnNames = new List<string>();
            getTableData(out data, out columnNames);
            writeToFile(path, data, columnNames);
        }

        private void SaveNewFile_Click(object sender, EventArgs e)
        {
            string path = string.Format(@"C:\Users\pepti\source\repos\Orange perron chido\Files\{0}.csv", Guid.NewGuid());
            List<Object[]> data = new List<Object[]>();
            List<string> columnNames = new List<string>();
            getTableData(out data, out columnNames);
            writeToFile(path, data, columnNames);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in tablaPrincipal.SelectedRows)
            {
                tablaPrincipal.Rows.RemoveAt(row.Index);
            }
        }

        private void StatisticAnalysis_Click(object sender, EventArgs e)
        {
            //StatisticAnalysisForm statisticAnalysisForm = new StatisticAnalysisForm();
            this.Hide();
            //statisticAnalysisForm.Show();
        }
    }
}
