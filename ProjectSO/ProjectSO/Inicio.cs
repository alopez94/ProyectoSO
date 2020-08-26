using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
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
            ListaAlQueue();
            queueProcesosEmpty();

        }

        private void queueProcesosLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            BtnAddtoQueue.Enabled = false;
            btnEjecutarProcesos.Enabled = false;
            
        }

        private void controlInputsInicio()
        {
            if(ProcessName.Text.Trim() != string.Empty && ProcessName.Text.All(char.IsLetter) 
                && ArriveTime.Text != string.Empty && ArriveTime.Text.All(char.IsNumber)
                && CPUTime.Text != string.Empty && CPUTime.Text.All(char.IsNumber)
                && Priority.Text != string.Empty && Priority.Text.All(char.IsNumber))

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

        private void Priority_TextChanged(object sender, EventArgs e)
        {
            controlInputsInicio();
        }


        private void queueProcesosEmpty()
        {
            if(queueProcesosLista.Items.Count >= 2 && QuantumText.Text != string.Empty)
            {
                btnEjecutarProcesos.Enabled = true;
            }
            
            else
            {
                btnEjecutarProcesos.Enabled = false;
            }

        }

        private void btnEliminarProceso_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item1 in queueProcesosLista.SelectedItems)
            {
                queueProcesosLista.Items.Remove(item1);             
            }

            queueProcesosEmpty();

        }

        public class process
        {
            public string nombre;
            public string arrivet;
            public string CPUt;
            public string priority;
        }

        public List<process> ProcesosLista1 = new List<process>();

        public void ListaAlQueue()
        {

            ;
            process lista1 = new process();
            lista1.nombre = ProcessName.Text;
            lista1.arrivet = ArriveTime.Text;
            lista1.CPUt = CPUTime.Text;
            lista1.priority = Priority.Text;
            ProcesosLista1.Add(lista1);
           
        }

        private void OrdenarPorPrioridad()
        {
           


        }
        private void OrdernarPorArriveTime()
        {

        }

        private void OrdernarPorCPUTime()
        {

        }

        private void btnEjecutarProcesos_Click(object sender, EventArgs e)
        {
           

            
            using (PopUpMenuProcesos popupOpcion1 = new PopUpMenuProcesos())
                popupOpcion1.ShowDialog();
           
        }

        private void QuantumText_TextChanged(object sender, EventArgs e)
        {
            queueProcesosEmpty();
        }
    }

}

