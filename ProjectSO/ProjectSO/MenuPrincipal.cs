using System;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigCPU cpucon = new ConfigCPU();
            cpucon.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentanaAProcesos taskmanager = new VentanaAProcesos();
            taskmanager.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfigMMU mmuconfi = new ConfigMMU();
            mmuconfi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            procesoslista processlist = new procesoslista();
            processlist.Show();
        }
    }
}
