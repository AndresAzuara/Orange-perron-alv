using Orange_perron_chido.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_perron_chido
{
    public partial class OneRAK : Form
    {
        List<List<string>> columnas;
        List<string> objective;
        int index;
        int columnQuantity;
        string objectiveName;
        public OneRAK(List<List<string>> columnas, int index)
        {
            objective = columnas.ElementAt(index);
            foreach(var columna in columnas)
            {
                columna.RemoveAt(0);
            }
            columnas.RemoveAt(index);
            columnas.RemoveAt(0);
            objectiveName = objective.FirstOrDefault().ToString();
            this.columnas = columnas;
            this.index = index;
            columnQuantity = this.columnas.Count;
            InitializeComponent();
            var frequences = getFrequences();

        }

        private List<int> cantidadDeErrores(List<List<FrequenceList>> frecuenciasPorColumna)
        {
            List<int> erroresPorLista = new List<int>();
            foreach(var columna in frecuenciasPorColumna)
            {
                foreach(var atributo in columna)
                {
                    foreach(var frecuence in atributo.frequences)
                    {

                    }
                }
            }
            return erroresPorLista;
        }

        private List<List<FrequenceList>> getFrequences()
        {
            List<List<FrequenceList>> frecuenciasGlobales = new List<List<FrequenceList>>();
            var objectives = objective.GroupBy(r => r).Select(r => r.Key).ToList();
            int cantidadFrecuencias;
            bool crearNuevaFrecuencia;
            foreach (var columna in columnas) //va columna por columna
            {
                List<FrequenceList> frecuencias = new List<FrequenceList>();
                for (int i = 0; i < columna.Count; i++) //toma una sola columna contra la objetivo
                {
                    Frequences frecuencia = new Frequences();
                    frecuencia.element = columna[i];
                    frecuencia.objectiveElement = objective[i];
                    crearNuevaFrecuencia = true;
                    if(frecuencias.Count != 0)
                    {
                        cantidadFrecuencias = frecuencias.Count;
                        for (int y = 0; y < cantidadFrecuencias; y++)
                        {
                                if (frecuencias[y].frequences[0].element.Equals(frecuencia.element))
                                {
                                    frecuencias[y].frequences.Add(frecuencia);
                                    frecuencias[y].quantity++;
                                    crearNuevaFrecuencia = false;
                                }
                        }
                        if(crearNuevaFrecuencia)
                        {
                                var aux = new List<Frequences>();
                                aux.Add(frecuencia);
                                frecuencias.Add(new FrequenceList()
                                {
                                    frequences = aux,
                                    quantity = 1
                                });
                        }
                    }
                    else
                    {
                        frecuencias.Add(new FrequenceList()
                        {
                            frequences = new List<Frequences>(),
                            quantity = 1
                        });
                        frecuencias.FirstOrDefault().frequences.Add(frecuencia);
                    }
                    
                }
                frecuenciasGlobales.Add(frecuencias);
            }
            return frecuenciasGlobales;
        }
    }
}
