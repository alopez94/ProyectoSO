using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSO
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

       
        private void AddtoQueue_Click(object sender, EventArgs e)
        {
            string [] list = { ProcessName.Text, ArriveTime.Text, CPUTime.Text, Priority.Text };
            ListViewItem lvi = new ListViewItem(list);
            queueProcesosLista.Items.Add(lvi);

            ProcessName.Clear();
            ArriveTime.Clear();
            CPUTime.Clear();
            Priority.Clear();

        }

        private void queueProcesosLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
