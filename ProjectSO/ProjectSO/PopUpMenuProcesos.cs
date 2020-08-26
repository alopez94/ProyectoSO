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
    public partial class PopUpMenuProcesos : Form
    {

       

        public PopUpMenuProcesos()
        {
            InitializeComponent();
        }

        private void PopUpMenuProcesos_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesarPorMetodo_Click(object sender, EventArgs e)
        {

            //tengo que mandar el tipo de arrangement
            this.Close();

        }
    }
}
