using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Views.Descuentos
{
    public partial class FrmDescuentos : Form
    {
        public FrmDescuentos()
        {
            InitializeComponent();
        }

        private void btnNuevoDescuento_Click(object sender, EventArgs e)
        {
            FrmNuevoDescuento frmNuevoDescuento = new FrmNuevoDescuento();
            frmNuevoDescuento.Show();
        }
    }
}
