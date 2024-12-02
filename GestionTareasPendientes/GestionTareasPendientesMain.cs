using System;

namespace GestionTareasPendientes
{
    public partial class GestionTareasPendientesMain : Form
    {
        public GestionTareasPendientesMain()
        {
            InitializeComponent();
        }



        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {


            string tarea = txtTarea.Text.ToString();
            if(tarea.Trim().Length > 3) { 
                lstTareas.Items.Add(tarea);
                txtTarea.Text = "";
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine(lstTareas.Items.Count.ToString());

            if (lstTareas.Items.Count > 0)
            {
               int lstTareasLength = lstTareas.Items.Count;

                lstTareas.Items.RemoveAt(lstTareasLength - 1);
            }
            
        }
    }
}