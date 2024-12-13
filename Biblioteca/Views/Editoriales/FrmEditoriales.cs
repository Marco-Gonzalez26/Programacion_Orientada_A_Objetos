using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Views.Editoriales
{
    public partial class FrmEditoriales : Form
    {
        public FrmEditoriales()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevaEditorial_Click(object sender, EventArgs e)
        {
            FrmNuevaEditorial frmNuevaEditorial = new FrmNuevaEditorial();
            frmNuevaEditorial.Show();
        }
    }
}
