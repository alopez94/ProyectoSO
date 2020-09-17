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
    public partial class ConfigMMU : Form
    {

        public static string gblalgoritmoMMU;
        public static int gblpaginasMMU;

        public ConfigMMU()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnconfigGuardarMMU_Click(object sender, EventArgs e)
        {
            gblalgoritmoMMU = txtAlgoritmoMMU.Text;
            gblpaginasMMU = Convert.ToInt32(txtPaginasMMU.Text);
            Close();
        }
    }
}
