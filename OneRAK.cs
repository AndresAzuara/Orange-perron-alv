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
        List<List<string>> lists;
        List<string> objective;
        int index;
        int columnQuantity;
        int[] frequences;
        string objectiveName;
        public OneRAK(List<List<string>> columnas, int index)
        {
            objective = columnas.ElementAt(index);
            objectiveName = objective.FirstOrDefault().ToString();
            lists = columnas;
            this.index = index;
            columnQuantity = lists.Count;
            frequences = new int[columnQuantity];
            InitializeComponent();
        }

        private void getFrequences()
        {
            int i = 0;
            foreach(var list in lists)
            {
                foreach(var column in list)
                {
                    if(column != list.First())
                    {
                        //frequences[i++] = 
                    }
                }
            }
        }
    }
}
