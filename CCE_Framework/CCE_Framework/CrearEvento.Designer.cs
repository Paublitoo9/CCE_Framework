
namespace CCE
{
    partial class CrearEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tNombre = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lOrganizador = new System.Windows.Forms.Label();
            this.bModificar = new System.Windows.Forms.Button();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bAtras = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tNombre.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tNombre.Location = new System.Drawing.Point(27, 31);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(426, 93);
            this.tNombre.TabIndex = 0;
            this.tNombre.Text = "NombreEvento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(510, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lOrganizador
            // 
            this.lOrganizador.AutoSize = true;
            this.lOrganizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lOrganizador.Location = new System.Drawing.Point(27, 152);
            this.lOrganizador.Name = "lOrganizador";
            this.lOrganizador.Size = new System.Drawing.Size(117, 20);
            this.lOrganizador.TabIndex = 6;
            this.lOrganizador.Text = "Organizador/es";
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(150, 151);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(74, 24);
            this.bModificar.TabIndex = 7;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // tDescripcion
            // 
            this.tDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.tDescripcion.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.tDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tDescripcion.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tDescripcion.Location = new System.Drawing.Point(27, 191);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(719, 200);
            this.tDescripcion.TabIndex = 8;
            this.tDescripcion.Text = "Descripción del Evento";
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(27, 405);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(131, 33);
            this.bGuardar.TabIndex = 9;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(3, 0);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(21, 23);
            this.bAtras.TabIndex = 19;
            this.bAtras.Text = "<";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(744, 415);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(22, 23);
            this.bHelp.TabIndex = 20;
            this.bHelp.Text = "?";
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // CrearEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.lOrganizador);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tNombre);
            this.Name = "CrearEvento";
            this.Text = "Crear Evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lOrganizador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Button bGuardar;
    }
}