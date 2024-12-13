
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Views.Editoriales;
using Biblioteca.Views.Libros;
using Biblioteca.Views.Autores;
using Biblioteca.Views.Ventas;
using Biblioteca.Views.Empleados;
using Biblioteca.Views.Descuentos;
using Biblioteca.Views.Tiendas;
using Biblioteca.Views.Trabajos;

namespace Biblioteca
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FmrLibros fmrLibros = new FmrLibros();
            fmrLibros.Show();
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            FrmEditoriales fmrEditoriales = new FrmEditoriales();
            fmrEditoriales.Show();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            FrmAutores fmrAutores = new FrmAutores();
            fmrAutores.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados fmrEmpleados = new FrmEmpleados();
            fmrEmpleados.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas fmrVentas = new FrmVentas();
            fmrVentas.Show();
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            FrmDescuentos fmrDescuentos = new FrmDescuentos();
            fmrDescuentos.Show();
        }

        private void btnTiendas_Click(object sender, EventArgs e)
        {
            FrmTiendas fmrTiendas = new FrmTiendas();
            fmrTiendas.Show();
        }

        private void btnTrabajos_Click(object sender, EventArgs e)
        {
            FrmTrabajos frmTrabajos = new FrmTrabajos();
            frmTrabajos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDescuentos frmDescuentos = new FrmDescuentos();
            frmDescuentos.Show();
        }
    }
}
