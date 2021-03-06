﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;



namespace ProjectSO
{


    public partial class VentanaAProcesos : Form
    {

        int CPUQuantumTime1 = ConfigCPU.gblQuantutime;
        string AlgoritmoCPUconfig = ConfigCPU.gblmetodoEjec;

        int paginadoMMU = ConfigMMU.gblpaginasMMU;
        string algoritmoMMU = ConfigMMU.gblalgoritmoMMU;


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

        public static BindingSource bindingsrs2 = new BindingSource(); //https://www.codeproject.com/Questions/734276/how-to-add-data-dynamically-to-Gridview

        public static BindingSource bindingsrs3 = new BindingSource();

        public List<process> ProcesosLista1 = new List<process>();
        public List<process> processMMU = new List<process>();
        public List<process> ActiveprocessMMU = new List<process>();

        List<process> Active = new List<process>();
        List<process> samepriority = new List<process>();
        List<process> sameCPUTime = new List<process>();

        Queue<process> lista1 = new Queue<process>();

        public int prioridadActual;
        public int TiempoCPUActual;
        public int fallosMMU = 0;
        string mandaraListviewMMU;

        public int tiempoCPUTotalProcesos = 1;



        private void Inicio_Load(object sender, EventArgs e)
        {

            dgvListadoEjecucion.DataSource = bindingsrs2;
            ProcesosLista1 = procesoslista.ProcesosListaTransferir;
            dgvMMUDisplay.DataSource = bindingsrs3;
            setTextosdetalles();

        }

        private void addprocessforMMU(process a)
        {
            if (a.estado == "Listo" || a.estado == "Procesando")
            {
                processMMU.Add(a);
            }

        }


        //funciones de condicion para evaluar estados
        private bool priorityigual(process a)
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

        private bool CPUTimeigual(process a)
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

        private int CPUTimemasbajo()
        {
            int indice = 0;
            string ProcesoActual = "";
            int CPUTimeAlta = 9000000;

            Active.ForEach(x =>
            {
                if (x.CPUt < CPUTimeAlta && x.estado == "Listo")
                {
                    ProcesoActual = x.nombreProceso;
                    CPUTimeAlta = x.CPUt;
                }

            });

            indice = Active.FindIndex(i => i.nombreProceso == ProcesoActual);
            return indice;

        }


        private int llegada()
        {
            int indice = 0;
            string ProcesoActual = "";
            int CPUTimeAlta = 9000000;

            Active.ForEach(x =>
            {
                if (x.CPUt < CPUTimeAlta && x.estado == "Listo")
                {
                    ProcesoActual = x.nombreProceso;
                    CPUTimeAlta = x.CPUt;
                }

            });

            indice = Active.FindIndex(i => i.nombreProceso == ProcesoActual);
            return indice;

        }



        private void resetmainingTime()
        {

            //pendiente
            ProcesosLista1.ForEach(a =>
            {
                a.remainingT = a.CPUt;
                a.estado = "Listo";


            });

            Active = ProcesosLista1.FindAll(ActivosAun);

            Active.ForEach(x =>
            {
                bindingsrs2.Add(x);

            });

        }


        private void execute()
        {

            int index = 0;

            Active = ProcesosLista1.FindAll(ActivosAun);

            if (AlgoritmoCPUconfig == "Prioridad")
            {
                Active = ProcesosLista1.FindAll(ActivosAun);
                while (tiempoCPUTotalProcesos > 0)
                {

                    Active = ProcesosLista1.FindAll(ActivosAun);

                    Active.ForEach(process =>
                    {
                        

                        index = PrioridadMasAlta();
                        prioridadActual = Active[index].priority;

                        aquivatodo(ProcesosLista1, index, Active[index]); //MMU

                        samepriority = Active.FindAll(priorityigual);

                        if (samepriority.Count > 1)
                        {
                            index = llegada();
                        }


                        if (Active[index].remainingT <= CPUQuantumTime1)
                        {
                            Active[index].remainingT = 0;
                        }
                        else
                        {
                            Active[index].remainingT = Active[index].remainingT - CPUQuantumTime1;
                        }

                        if ((Active[index].remainingT > 0))
                        {
                            Active[index].estado = "Bloqueado";
                        }
                        if ((Active[index].remainingT == 0))
                        {
                            Active[index].estado = "Finalizado";
                        }



                        pasaryActualizar(Active[index]);
                        pasaryActualizarMMUGrid(Active[index]);
                        tiempoCPUTotalProcesos = Active.Sum(proc => proc.remainingT);


                        ListViewItem listViewItem = new ListViewItem("Procesando: ");
                        listViewItem.SubItems.Add(Active[index].nombreProceso);
                        listViewItem.SubItems.Add(Active[index].estado);
                        listViewItem.SubItems.Add(Convert.ToString(Active[index].remainingT));
                        ViewDetalleProceso.Items.Add(listViewItem);

                        


                        wait(2000);


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
                            wait(2000);
                        }
                    });
                }


            }

            if (AlgoritmoCPUconfig == "CPU" || AlgoritmoCPUconfig== "Mixto")
            {
                Active = ProcesosLista1.FindAll(ActivosAun);


                while (tiempoCPUTotalProcesos > 0)
                {

                    Active = ProcesosLista1.FindAll(ActivosAun);


                    Active.ForEach(process =>
                    {
                        index = CPUTimemasbajo();
                        TiempoCPUActual = Active[index].CPUt;
                     
                        aquivatodo(ProcesosLista1, index, Active[index]); //MMU

                        sameCPUTime = Active.FindAll(CPUTimeigual);

                        if (sameCPUTime.Count > 0)
                        {
                            index = PrioridadMasAlta();
                        }



                        if (Active[index].remainingT < CPUQuantumTime1)
                        {

                            Active[index].remainingT = 0;

                        }
                        else
                        {

                            Active[index].remainingT = Active[index].remainingT - CPUQuantumTime1;

                        }

                        if (Active[index].remainingT == 0)
                        {
                            Active[index].estado = "Finalizado";
                        }
                        if ((Active[index].remainingT > 0))
                        {
                            Active[index].estado = "Bloqueado";
                        }


                        pasaryActualizar(Active[index]);
                        pasaryActualizarMMUGrid(Active[index]);
                        tiempoCPUTotalProcesos = Active.Sum(proc => proc.remainingT);
                        wait(2000);

                        ListViewItem listViewItem = new ListViewItem("Proceso: ");
                        listViewItem.SubItems.Add(Active[index].nombreProceso);
                        listViewItem.SubItems.Add(Active[index].estado);
                        listViewItem.SubItems.Add(Convert.ToString(Active[index].remainingT));
                        ViewDetalleProceso.Items.Add(listViewItem);

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
                            wait(2000);
                        }
                    });


                }
            }
        }

        private void restart(process a)
        {
            a.remainingT = a.CPUt;
            a.estado = "Listo";

        }

        private void aquivatodo(List<process> a, int index, process b)
        {

            //lista a tiene que ser la lista de procesos activos de MMU
            if (algoritmoMMU == "FIFO")
            {
                if (lista1.Count <= paginadoMMU)
                {




                    Console.WriteLine("agrego en seccion 1");
                    Console.WriteLine("elementos en lista =>" + a.Count);
                    Console.WriteLine("en el queue: " + lista1.Count);

                    if (lista1.Contains(b))
                    {
                        fallosMMU = fallosMMU + 1;
                        lista1.Enqueue(b);

                        Console.WriteLine("Fallos " + fallosMMU);

                    }
                    else
                    {
                        lista1.Enqueue(b);
                        Console.WriteLine("Agregado sin Fallo");
                    }

                    mandaraListviewMMU = "Elementos en Queue =>" + lista1.Count + " Proceso => " + b.nombreProceso + ". Fallos => " + fallosMMU;
                    lvDetallesMMU.Items.Add(mandaraListviewMMU);
                }

                else
                {
                    if (lista1.Count > 0)
                    {
                        lista1.Dequeue();
                    }
                    Console.WriteLine("agrego en seccion 2");

                    Console.WriteLine("elementos en lista =>" + a.Count);
                    Console.WriteLine("en el queue: " + lista1.Count);

                    if (lista1.Contains(b))
                    {
                        fallosMMU = fallosMMU + 1;
                        lista1.Enqueue(b);

                        Console.WriteLine("Fallos " + fallosMMU);

                    }
                    else
                    {
                        lista1.Enqueue(b);
                        Console.WriteLine("Agregado sin Fallo");
                    }

                    mandaraListviewMMU = "Elementos en Queue =>" + lista1.Count + " Proceso => " + b.nombreProceso + ". Fallos => " + fallosMMU;
                    lvDetallesMMU.Items.Add(mandaraListviewMMU);

                }
            }
        }   
        private void reiniciarlista()
        {
            ProcesosLista1.ForEach(proc =>
            {
                restart(proc);
            });

            processMMU.ForEach(procM =>
            {
                restart(procM);
            });

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

        private void pasaryActualizarMMUGrid(process b)
        {
            int indice = -1;

            DataGridViewRow filaMMU = dgvMMUDisplay.Rows
                .Cast<DataGridViewRow>()
                .Where(procmmu => procmmu.Cells["nombreProceso"].Value.ToString().Equals(b.nombreProceso))
                .First();
            indice = filaMMU.Index;
            procesoslista.processforMMU objmmu = (procesoslista.processforMMU)dgvMMUDisplay.Rows[indice].DataBoundItem;
            objmmu.estado = b.estado;
            if(b.estado == "Finalizado") { 
                objmmu.MMUalocation = "";
            }
            else
            {
                objmmu.MMUalocation = "Memory " + indice.ToString();
            }
            
            dgvMMUDisplay.Refresh();

        }

        private void btnEjecutarProcesos_Click(object sender, EventArgs e)
        {
            execute();

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();

            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();

            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            resetmainingTime();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dgvListadoEjecucion.DataSource = null; //eliminando la data
            
            reiniciarlista();
            dgvListadoEjecucion.Refresh();
         
            dgvMMUDisplay.Refresh();
            ViewDetalleProceso.Clear();

        }


        private void setTextosdetalles()
        {
            DetalleQuantumCPU.Text = CPUQuantumTime1.ToString();
            detalleAlgoritmoCPU.Text = AlgoritmoCPUconfig;
            DetalleAlgoritmoMMU.Text = algoritmoMMU;
            DetallePaginasMMU.Text = paginadoMMU.ToString();





                }

        
    }

}

