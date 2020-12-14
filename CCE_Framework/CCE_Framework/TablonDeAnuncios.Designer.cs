
namespace CCE
{
    partial class TablonDeAnuncios
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
            this.lEvento1 = new System.Windows.Forms.LinkLabel();
            this.lTablonDeAnuncios = new System.Windows.Forms.Label();
            this.lEvento2 = new System.Windows.Forms.LinkLabel();
            this.lEvento3 = new System.Windows.Forms.LinkLabel();
            this.lCrearEvento = new System.Windows.Forms.LinkLabel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lPerfil = new System.Windows.Forms.LinkLabel();
            this.bHelp = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lEvento1
            // 
            this.lEvento1.AutoSize = true;
            this.lEvento1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lEvento1.Location = new System.Drawing.Point(28, 108);
            this.lEvento1.Name = "lEvento1";
            this.lEvento1.Size = new System.Drawing.Size(385, 54);
            this.lEvento1.TabIndex = 0;
            this.lEvento1.TabStop = true;
            this.lEvento1.Text = "Evento de Ejemplo 1";
            // 
            // lTablonDeAnuncios
            // 
            this.lTablonDeAnuncios.AutoSize = true;
            this.lTablonDeAnuncios.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lTablonDeAnuncios.Location = new System.Drawing.Point(12, 9);
            this.lTablonDeAnuncios.Name = "lTablonDeAnuncios";
            this.lTablonDeAnuncios.Size = new System.Drawing.Size(498, 72);
            this.lTablonDeAnuncios.TabIndex = 1;
            this.lTablonDeAnuncios.Text = "Tablón de Anuncios";
            this.lTablonDeAnuncios.Click += new System.EventHandler(this.lTablonDeAnuncios_Click);
            // 
            // lEvento2
            // 
            this.lEvento2.AutoSize = true;
            this.lEvento2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lEvento2.Location = new System.Drawing.Point(28, 208);
            this.lEvento2.Name = "lEvento2";
            this.lEvento2.Size = new System.Drawing.Size(385, 54);
            this.lEvento2.TabIndex = 2;
            this.lEvento2.TabStop = true;
            this.lEvento2.Text = "Evento de Ejemplo 2";
            // 
            // lEvento3
            // 
            this.lEvento3.AutoSize = true;
            this.lEvento3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lEvento3.Location = new System.Drawing.Point(28, 308);
            this.lEvento3.Name = "lEvento3";
            this.lEvento3.Size = new System.Drawing.Size(385, 54);
            this.lEvento3.TabIndex = 3;
            this.lEvento3.TabStop = true;
            this.lEvento3.Text = "Evento de Ejemplo 3";
            // 
            // lCrearEvento
            // 
            this.lCrearEvento.AutoSize = true;
            this.lCrearEvento.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCrearEvento.Location = new System.Drawing.Point(28, 398);
            this.lCrearEvento.Name = "lCrearEvento";
            this.lCrearEvento.Size = new System.Drawing.Size(123, 28);
            this.lCrearEvento.TabIndex = 4;
            this.lCrearEvento.TabStop = true;
            this.lCrearEvento.Text = "Crear Evento";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(779, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 450);
            this.vScrollBar1.TabIndex = 5;
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUsuario.Location = new System.Drawing.Point(616, 9);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(149, 21);
            this.lUsuario.TabIndex = 6;
            this.lUsuario.Text = "Nombre del usuario";
            // 
            // lPerfil
            // 
            this.lPerfil.AutoSize = true;
            this.lPerfil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPerfil.Location = new System.Drawing.Point(616, 30);
            this.lPerfil.Name = "lPerfil";
            this.lPerfil.Size = new System.Drawing.Size(67, 21);
            this.lPerfil.TabIndex = 7;
            this.lPerfil.TabStop = true;
            this.lPerfil.Text = "Mi Perfil";
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
            this.bAtras.Location = new System.Drawing.Point(3, 0);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(21, 23);
            this.bAtras.TabIndex = 19;
            this.bAtras.Text = "<";
            this.bAtras.UseVisualStyleBackColor = true;
            // 
            // TablonDeAnuncios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.lPerfil);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.lCrearEvento);
            this.Controls.Add(this.lEvento3);
            this.Controls.Add(this.lEvento2);
            this.Controls.Add(this.lTablonDeAnuncios);
            this.Controls.Add(this.lEvento1);
            this.Name = "TablonDeAnuncios";
            this.Text = "TablónDeAnuncios";
            this.Load += new System.EventHandler(this.TablónDeAnuncios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lEvento1;
        private System.Windows.Forms.Label lTablonDeAnuncios;
        private System.Windows.Forms.LinkLabel lEvento2;
        private System.Windows.Forms.LinkLabel lEvento3;
        private System.Windows.Forms.LinkLabel lCrearEvento;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.LinkLabel lPerfil;
        private System.Windows.Forms.Button bHelp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bAtras;
    }
}