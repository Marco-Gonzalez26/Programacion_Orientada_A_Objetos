namespace GestionTareasPendientes
{
    partial class GestionTareasPendientesMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.lstTareas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(40, 42);
            this.txtTarea.Margin = new System.Windows.Forms.Padding(5);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(384, 33);
            this.txtTarea.TabIndex = 0;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAgregarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTarea.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarTarea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarTarea.Image = global::GestionTareasPendientes.Properties.Resources.add;
            this.btnAgregarTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTarea.Location = new System.Drawing.Point(40, 98);
            this.btnAgregarTarea.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(185, 46);
            this.btnAgregarTarea.TabIndex = 1;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(66)))), ((int)(((byte)(53)))));
            this.btnEliminarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTarea.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarTarea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarTarea.Image = global::GestionTareasPendientes.Properties.Resources.bin1;
            this.btnEliminarTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarTarea.Location = new System.Drawing.Point(307, 450);
            this.btnEliminarTarea.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(185, 47);
            this.btnEliminarTarea.TabIndex = 2;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // lstTareas
            // 
            this.lstTareas.FormattingEnabled = true;
            this.lstTareas.ItemHeight = 25;
            this.lstTareas.Location = new System.Drawing.Point(40, 175);
            this.lstTareas.Margin = new System.Windows.Forms.Padding(5);
            this.lstTareas.Name = "lstTareas";
            this.lstTareas.Size = new System.Drawing.Size(708, 254);
            this.lstTareas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nueva Tarea:";
            // 
            // GestionTareasPendientesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTareas);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.txtTarea);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GestionTareasPendientesMain";
            this.Text = "Gestion de Tareas Pendientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

  
        private TextBox txtTarea;
        private Button btnAgregarTarea;
        private Button btnEliminarTarea;
        private ListBox lstTareas;
        private Label label1;
    }
}