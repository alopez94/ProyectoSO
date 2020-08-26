using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSO
{
    public partial class VentanaAProcesos : Form
    {
        public VentanaAProcesos()
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

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnEjecutarProcesos.Enabled = false;
            BtnAddtoQueue.Enabled = false;
        }

        private void controlInputsInicio()
        {
            if(ProcessName.Text.Trim() != string.Empty && ProcessName.Text.All(char.IsLetter))
            {
                BtnAddtoQueue.Enabled = true;
                errorProvider1.SetError(ProcessName, "");
            }
            else
            {
                if (!(ProcessName.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(ProcessName, "El Nombre solo debe contener letras.");
                }
                else
                {
                    errorProvider1.SetError(ProcessName, "Debe Introducir un nombre para el Proceso");
                }
                BtnAddtoQueue.Enabled = false;
                ProcessName.Focus();
            }

        }

        private void ProcessName_TextChanged(object sender, EventArgs e)
        {
            controlInputsInicio();
        }

        private void btnEliminarProceso_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item1 in queueProcesosLista.SelectedItems)
            {
                queueProcesosLista.Items.Remove(item1);             
            }
           
        }
    }
}
