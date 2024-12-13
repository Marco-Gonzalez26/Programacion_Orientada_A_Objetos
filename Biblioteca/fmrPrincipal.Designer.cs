namespace Biblioteca
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditoriales = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTiendas = new System.Windows.Forms.Button();
            this.btnDescuentos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTrabajos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.btnTrabajos);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDescuentos);
            this.panel1.Controls.Add(this.btnTiendas);
            this.panel1.Controls.Add(this.btnEditoriales);
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.btnAutores);
            this.panel1.Controls.Add(this.btnLibros);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnEditoriales
            // 
            this.btnEditoriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.btnEditoriales.FlatAppearance.BorderSize = 0;
            this.btnEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditoriales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.btnEditoriales.Location = new System.Drawing.Point(315, 88);
            this.btnEditoriales.Name = "btnEditoriales";
            this.btnEditoriales.Size = new System.Drawing.Size(146, 59);
            this.btnEditoriales.TabIndex = 6;
            this.btnEditoriales.Text = "Editoriales";
            this.btnEditoriales.UseVisualStyleBackColor = false;
            this.btnEditoriales.Click += new System.EventHandler(this.btnEditoriales_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.btnEmpleados.Location = new System.Drawing.Point(40, 218);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(146, 61);
            this.btnEmpleados.TabIndex = 5;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.btnVentas.Location = new System.Drawing.Point(315, 291);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(146, 66);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.btnAutores.FlatAppearance.BorderSize = 0;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.btnAutores.Location = new System.Drawing.Point(40, 153);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(146, 57);
            this.btnAutores.TabIndex = 3;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = false;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.btnLibros.Location = new System.Drawing.Point(40, 88);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(146, 59);
            this.btnLibros.TabIndex = 2;
            this.btnLibros.Text = "Libros ";
            this.btnLibros.UseVisualStyleBackColor = false;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido/a Administrador\r\n\r\n";
            // 
            // btnTiendas
            // 
            this.btnTiendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.btnTiendas.FlatAppearance.BorderSize = 0;
            this.btnTiendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.btnTiendas.Location = new System.Drawing.Point(315, 153);
            this.btnTiendas.Name = "btnTiendas";
            this.btnTiendas.Size = new System.Drawing.Size(146, 59);
            this.btnTiendas.TabIndex = 7;
            this.btnTiendas.Text = "Tiendas";
            this.btnTiendas.UseVisualStyleBackColor = false;
            this.btnTiendas.Click += new System.EventHandler(this.btnTiendas_Click);
            // 
            // btnDescuentos
            // 
            this.btnDescuentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.btnDescuentos.FlatAppearance.BorderSize = 0;
            this.btnDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.btnDescuentos.Location = new System.Drawing.Point(315, 218);
            this.btnDescuentos.Name = "btnDescuentos";
            this.btnDescuentos.Size = new System.Drawing.Size(146, 59);
            this.btnDescuentos.TabIndex = 8;
            this.btnDescuentos.Text = "Descuentos";
            this.btnDescuentos.UseVisualStyleBackColor = false;
            this.btnDescuentos.Click += new System.EventHandler(this.btnDescuentos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.button1.Location = new System.Drawing.Point(40, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "Descuentos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTrabajos
            // 
            this.btnTrabajos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.btnTrabajos.FlatAppearance.BorderSize = 0;
            this.btnTrabajos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrabajos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.btnTrabajos.Location = new System.Drawing.Point(175, 372);
            this.btnTrabajos.Name = "btnTrabajos";
            this.btnTrabajos.Size = new System.Drawing.Size(146, 66);
            this.btnTrabajos.TabIndex = 10;
            this.btnTrabajos.Text = "Trabajos";
            this.btnTrabajos.UseVisualStyleBackColor = false;
            this.btnTrabajos.Click += new System.EventHandler(this.btnTrabajos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "Gestion de biblioteca";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnEditoriales;
        private System.Windows.Forms.Button btnDescuentos;
        private System.Windows.Forms.Button btnTiendas;
        private System.Windows.Forms.Button btnTrabajos;
        private System.Windows.Forms.Button button1;
    }
}

