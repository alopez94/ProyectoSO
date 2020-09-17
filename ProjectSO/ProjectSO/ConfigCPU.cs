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
    public partial class ConfigCPU : Form
    {

        public static string gblmetodoEjec = "";
        public static int gblQuantutime = 0;
        

        //validar information entrante
        private void validateinput()
        {
            if (txtCPUConfig.Text.Trim() != string.Empty && txtQuantumCPUConfig.Text.All(char.IsNumber))
            {
                btnGuardarCPUConfig.Enabled = true;
            }
            else
            {
                btnGuardarCPUConfig.Enabled = false;
            }


        }

        public ConfigCPU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            gblmetodoEjec = txtCPUConfig.Text;
            gblQuantutime =  Convert.ToInt32(txtQuantumCPUConfig.Text);
            Close();


        }

        private void txtCPUConfig_TextChanged(object sender, EventArgs e)
        {
            validateinput();
        }

        private void ConfigCPU_Load(object sender, EventArgs e)
        {
            validateinput();
        }
    }
}
