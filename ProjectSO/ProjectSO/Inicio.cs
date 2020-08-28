using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public BindingSource bindingsrs2 = new BindingSource();
        List<process> ProcesosLista1 = new List<process>();
        List<process> Active = new List<process>();
        public int prioridadActual;
        public int TiempoCPUActual;
        
        public int tiempoCPUTotalProcesos = 1;

        public void agregarProcesoLista()
        {
            Console.Write("Llego Hasta aqui xD");


            process lista1 = new process(ProcessName.Text, Convert.ToInt32(ArriveTime.Text), Convert.ToInt32(CPUTime.Text), Convert.ToInt32(Priority.Text), "Listo",
            Convert.ToInt32(CPUTime.Text));
            bindingsrs.Add(lista1);
            bindingsrs2.Add(lista1);
            ProcesosLista1.Add(lista1);
            


            ProcessName.Clear();
            ArriveTime.Clear();
            CPUTime.Clear();
            Priority.Clear();

            Console.Write("Llego Hasta aqui xD");

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
            dgvListadoEjecucion.DataSource = bindingsrs2;
            dgvListadoProcesos1.DataSource = bindingsrs;
            BtnAddtoQueue.Enabled = false;
            btnEjecutarProcesos.Enabled = false;
            Console.Write("Llego Hasta aqui xD");
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
        //funciones de condicion para evaluar estados
        private bool samepriority(process a)
        {

            if (a.priority == prioridadActual && a.estado == "Activo" && a.remainingT > 0)
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
            if (a.CPUt == TiempoCPUActual && a.estado == "Listo" && a.remainingT > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool ActivosAun(process a)
        {
            if (a.remainingT > 0)
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
            int indice = 0;
            string ProcesoActual = "";
            int MayorPrioridad = 1000000;

            Active.ForEach(x =>
            {

                if (x.priority < MayorPrioridad && x.estado == "Listo")
                {
                    ProcesoActual = x.nombreProceso;
                    MayorPrioridad = x.priority;
                }

            });

            indice = Active.FindIndex(i => i.nombreProceso == ProcesoActual);
            return indice;

        }

        //Hola Diosito, soy yo de nuevo



        private void ProcessName_TextChanged(object sender, EventArgs e)
        {
            controlInputsInicio();
        }

        private void Priority_TextChanged(object sender, EventArgs e)
        {
            controlInputsInicio();
        }


        private bool ProcesosActivos(process a)
        {
            if (a.CPUt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private bool queueProcesosEmpty()
        {
            if (bindingsrs.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void execute()
        {
            string algoritmoSeleccionado = txtAlgoritmoSelect.Text;
            int cont = 0;
            int index = 0;

            if (algoritmoSeleccionado == "Prioridad")
            {
                Active = ProcesosLista1.FindAll(ActivosAun);
                while (tiempoCPUTotalProcesos > 0)
                {

                    Console.WriteLine(cont + ". ------ Interacion ------");
                    cont++;

                    Active = ProcesosLista1.FindAll(ActivosAun);

                    Active.ForEach(process =>
                    {
                        Console.WriteLine("Ejecutando Algoritmo de Prioridad");
                        index = PrioridadMasAlta();
                        prioridadActual = Active[index].priority;

                        if (Active[index].remainingT <= Convert.ToInt32(txtQuantum.Text))
                        {
                            Active[index].remainingT = 0;
                        }
                        else
                        {
                            Active[index].remainingT = Active[index].remainingT - Convert.ToInt32(txtQuantum.Text);
                        }

                        if (Active[index].remainingT == 0)
                        {
                            Active[index].estado = "Finalizado";
                        }
                        else
                        {
                            Active[index].estado = "Bloqueado";
                        }

                        Console.WriteLine("  - Proceso: " + Active[index].nombreProceso + ", CPU: " + Active[index].remainingT + ", " + Active[index].estado);

                        pasaryActualizar(Active[index]);
                        tiempoCPUTotalProcesos = Active.Sum(proc => proc.remainingT);

                    });


                    Active.ForEach(proc =>
                    {
                        if (proc.remainingT == 0)
                        {
                            proc.estado = "Finalizado";

                        }
                        else if (proc.remainingT > 0)
                        {
                            proc.estado = "Listo";
                            pasaryActualizar(proc);
                        }
                    });
                }


            }
            if (algoritmoSeleccionado == "Por Tiempo de CPU")
            {


            }

        }


        private void pasaryActualizar(process a)
        {
            int indice = -1;

            DataGridViewRow fila = dgvListadoEjecucion.Rows
                .Cast<DataGridViewRow>()
                .Where(proc => proc.Cells["nombreProceso"].Value.ToString().Equals(a.nombreProceso))
                .First();
            indice = fila.Index;
            process obj = (process)dgvListadoEjecucion.Rows[indice].DataBoundItem;
            obj.remainingT = a.remainingT;
            obj.estado = a.estado;
            dgvListadoEjecucion.Refresh();

        }








        private void btnEjecutarProcesos_Click(object sender, EventArgs e)
        {
            execute();




        }

        private void txtQuantum_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantum.Text != string.Empty && txtQuantum.Text.All(char.IsNumber))
            {
                btnEjecutarProcesos.Enabled = true;
            }
            else
            {
                btnEjecutarProcesos.Enabled = false;
            }

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

