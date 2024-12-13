using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Views.Ventas
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            FrmNuevaVenta frmNuevaVenta = new FrmNuevaVenta();
            frmNuevaVenta.Show();
        }
    }
}
