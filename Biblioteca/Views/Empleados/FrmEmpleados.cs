using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Views.Empleados
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnNuevaEditorial_Click(object sender, EventArgs e)
        {
            FrmNuevoEmpleado frmNuevoEmpleado = new FrmNuevoEmpleado();
            frmNuevoEmpleado.Show();
        }
    }
}
