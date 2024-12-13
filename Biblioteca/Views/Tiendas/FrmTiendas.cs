using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Views.Tiendas
{
    public partial class FrmTiendas : Form
    {
        public FrmTiendas()
        {
            InitializeComponent();
        }

        private void btnNuevaTienda_Click(object sender, EventArgs e)
        {
            FrmNuevaTienda frmNuevaTienda = new FrmNuevaTienda();
            frmNuevaTienda.Show();
        }
    }
}
