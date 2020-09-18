﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSO
{
    
    public partial class procesoslista : Form
    {

        public static string gblNombreProceso;
        VentanaAProcesos init = new VentanaAProcesos();
        
        public static List<VentanaAProcesos.process> ProcesosListaTransferir;

        public BindingSource bindingsrs = new BindingSource();
        public List<VentanaAProcesos.process> ProcesosListaInicial = new List<VentanaAProcesos.process>();

        private void procesoslista_Load(object sender, EventArgs e)
        {
            dgvListadoProcesos1.DataSource = bindingsrs;
        }


        public void agregarProcesoLista()
    {
         
            VentanaAProcesos.process lista1 = new VentanaAProcesos.process(ProcessName.Text, Convert.ToInt32(ArriveTime.Text), Convert.ToInt32(CPUTime.Text), Convert.ToInt32(Priority.Text), "Listo",
        Convert.ToInt32(CPUTime.Text));
        
        bindingsrs.Add(lista1);
        ProcesosListaInicial.Add(lista1);
        

        ProcessName.Clear();
        ArriveTime.Clear();
        CPUTime.Clear();
        Priority.Clear();

    }

    public void AddtoQueue_Click(object sender, EventArgs e)
    {
        agregarProcesoLista();

    }

    private void controlInputsInicio()
    {
        if (ProcessName.Text.Trim() != string.Empty && ProcessName.Text.All(char.IsLetter)
            && ArriveTime.Text != string.Empty && ArriveTime.Text.All(char.IsNumber)
            && CPUTime.Text != string.Empty && CPUTime.Text.All(char.IsNumber)
            && Priority.Text != string.Empty && Priority.Text.All(char.IsNumber))

        {
            BtnAddtoQueue.Enabled = true;
           
        }
        else
        {
            if (!(ProcessName.Text.All(Char.IsLetter)))
            {
               // errorProvider1.SetError(ProcessName, "El Nombre solo debe contener letras.");
            }
            else
            {
              //  errorProvider1.SetError(ProcessName, "Debe Introducir un nombre para el Proceso");
            }
            BtnAddtoQueue.Enabled = false;
            ProcessName.Focus();
        }

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
    

        public procesoslista()
        {
            InitializeComponent();
        }

        private void BtnAddtoQueue_Click(object sender, EventArgs e)
        {
            agregarProcesoLista();
        }

        private void ProcessName_TextChanged(object sender, EventArgs e)
        {
            controlInputsInicio();
        }

        private void Priority_TextChanged(object sender, EventArgs e)
        {
            controlInputsInicio();
        }

        private void dgvListadoProcesos1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcesosListaTransferir = ProcesosListaInicial;
            Close();
        }
    }
}