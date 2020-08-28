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

        public class process
        {
            public string nombreProceso
            {
                get; set;

            }

            public int arrivet
            {
                get; set;
            }

            public int CPUt
            {
                get; set;
            }

            public int priority
            {
                get; set;
            }

            public string estado
            {
                get; set;
            }

            public int remainingT
            {
                get; set;
            }
            public process(string name1, int arrivet1, int CPUtime, int priority1, string state, int remainingTime)
            {

                nombreProceso = name1;
                arrivet = arrivet1;
                CPUt = CPUtime;
                priority = priority1;
                estado = state;
                remainingT = remainingTime;
            }
        }

        public BindingSource bindingsrs = new BindingSource(); // https://www.codeproject.com/Questions/734276/how-to-add-data-dynamically-to-Gridview
        List<process> ProcesosLista1 = new List<process>();
        public int prioridadActual;
        public int TiempoCPUActual;

        public void agregarProcesoLista()
        {
            process lista1 = new process(ProcessName.Text, Convert.ToInt32(ArriveTime.Text), Convert.ToInt32(CPUTime.Text), Convert.ToInt32(Priority.Text), "Agregado",
            Convert.ToInt32(CPUTime.Text));
            bindingsrs.Add(lista1);
            ProcesosLista1.Add(lista1);


            ProcessName.Clear();
            ArriveTime.Clear();
            CPUTime.Clear();
            Priority.Clear();
        }

        public void AddtoQueue_Click(object sender, EventArgs e)
        {
            agregarProcesoLista();


        }

        private void queueProcesosLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            dgvListadoProcesos1.DataSource = bindingsrs;
            BtnAddtoQueue.Enabled = false;
            btnEjecutarProcesos.Enabled = false;

        }

        private void controlInputsInicio()
        {
            if (ProcessName.Text.Trim() != string.Empty && ProcessName.Text.All(char.IsLetter)
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

        private bool samepriority(process a){

            if(a.priority == prioridadActual && a.estado == "Activo" && a.remainingT > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

         }

        private bool sameCPUTime(process a)
        {
            if(a.CPUt == TiempoCPUActual && a.estado == "Listo" && a.remainingT > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private int PrioridadMasAlta()
        {



            return 0;

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
          
           
            
        }

        

       

       
           public void OrdenarPorPrioridad(List<process> a)
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
            OrdenarPorPrioridad(ProcesosLista1);




        }

        private void txtQuantum_TextChanged(object sender, EventArgs e)
        {
            queueProcesosEmpty();
        }

        private void ArriveTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListadoProcesos1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            DataGridViewRow conteoinicio = dgvListadoProcesos1.Rows[0];
            if (dgvListadoProcesos1.SelectedRows.Contains(conteoinicio))
            {
                // Do not allow the user to delete the Starting Balance row.
                MessageBox.Show("Cannot delete Starting Balance row!");

                // Cancel the deletion if the Starting Balance row is included.
                e.Cancel = true;
            }
        }
    }

}

