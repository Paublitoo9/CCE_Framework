
namespace CCE
{
    partial class InscripcionEventos
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
            this.lNombre = new System.Windows.Forms.Label();
            this.lOrganizador = new System.Windows.Forms.Label();
            this.bInscribir = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.lFecha = new System.Windows.Forms.Label();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.bHelp = new System.Windows.Forms.Button();
            this.bAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lNombre.Location = new System.Drawing.Point(17, 31);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(492, 86);
            this.lNombre.TabIndex = 3;
            this.lNombre.Text = "NombreEvento";
            // 
            // lOrganizador
            // 
            this.lOrganizador.AutoSize = true;
            this.lOrganizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lOrganizador.Location = new System.Drawing.Point(32, 127);
            this.lOrganizador.Name = "lOrganizador";
            this.lOrganizador.Size = new System.Drawing.Size(117, 20);
            this.lOrganizador.TabIndex = 5;
            this.lOrganizador.Text = "Organizador/es";
            // 
            // bInscribir
            // 
            this.bInscribir.Location = new System.Drawing.Point(32, 393);
            this.bInscribir.Name = "bInscribir";
            this.bInscribir.Size = new System.Drawing.Size(131, 33);
            this.bInscribir.TabIndex = 7;
            this.bInscribir.Text = "Inscribirse";
            this.bInscribir.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(780, -2);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 453);
            this.vScrollBar1.TabIndex = 8;
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lFecha.Location = new System.Drawing.Point(579, 84);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(89, 20);
            this.lFecha.TabIndex = 9;
            this.lFecha.Text = "dd/mm/yyyy";
            // 
            // tDescripcion
            // 
            this.tDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.tDescripcion.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.tDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tDescripcion.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tDescripcion.Location = new System.Drawing.Point(32, 172);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ReadOnly = true;
            this.tDescripcion.Size = new System.Drawing.Size(719, 200);
            this.tDescripcion.TabIndex = 6;
            this.tDescripcion.Text = "Descripción del Evento";
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(744, 415);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(22, 23);
            this.bHelp.TabIndex = 15;
            this.bHelp.Text = "?";
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(6, 0);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(21, 23);
            this.bAtras.TabIndex = 16;
            this.bAtras.Text = "<";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // InscripcionEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.bInscribir);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.lOrganizador);
            this.Controls.Add(this.lNombre);
            this.Name = "InscripcionEventos";
            this.Text = "CCE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lOrganizador;
        private System.Windows.Forms.Button bInscribir;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bAtras;
    }
}