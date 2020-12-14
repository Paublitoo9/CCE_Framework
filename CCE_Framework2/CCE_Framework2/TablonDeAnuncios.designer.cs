
namespace CCE_Framework2
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
            this.listEventos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lEvento1
            // 
            this.lEvento1.AutoSize = true;
            this.lEvento1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.lEvento1.Location = new System.Drawing.Point(24, 94);
            this.lEvento1.Name = "lEvento1";
            this.lEvento1.Size = new System.Drawing.Size(0, 54);
            this.lEvento1.TabIndex = 0;
            // 
            // lTablonDeAnuncios
            // 
            this.lTablonDeAnuncios.AutoSize = true;
            this.lTablonDeAnuncios.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.lTablonDeAnuncios.Location = new System.Drawing.Point(10, 8);
            this.lTablonDeAnuncios.Name = "lTablonDeAnuncios";
            this.lTablonDeAnuncios.Size = new System.Drawing.Size(498, 72);
            this.lTablonDeAnuncios.TabIndex = 1;
            this.lTablonDeAnuncios.Text = "Tablón de Anuncios";
            this.lTablonDeAnuncios.Click += new System.EventHandler(this.lTablonDeAnuncios_Click);
            // 
            // lEvento2
            // 
            this.lEvento2.AutoSize = true;
            this.lEvento2.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.lEvento2.Location = new System.Drawing.Point(24, 180);
            this.lEvento2.Name = "lEvento2";
            this.lEvento2.Size = new System.Drawing.Size(0, 54);
            this.lEvento2.TabIndex = 2;
            // 
            // lEvento3
            // 
            this.lEvento3.AutoSize = true;
            this.lEvento3.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.lEvento3.Location = new System.Drawing.Point(24, 267);
            this.lEvento3.Name = "lEvento3";
            this.lEvento3.Size = new System.Drawing.Size(0, 54);
            this.lEvento3.TabIndex = 3;
            // 
            // lCrearEvento
            // 
            this.lCrearEvento.AutoSize = true;
            this.lCrearEvento.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lCrearEvento.Location = new System.Drawing.Point(24, 345);
            this.lCrearEvento.Name = "lCrearEvento";
            this.lCrearEvento.Size = new System.Drawing.Size(123, 28);
            this.lCrearEvento.TabIndex = 4;
            this.lCrearEvento.TabStop = true;
            this.lCrearEvento.Text = "Crear Evento";
            this.lCrearEvento.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lCrearEvento_LinkClicked);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(668, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 390);
            this.vScrollBar1.TabIndex = 5;
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lUsuario.Location = new System.Drawing.Point(528, 8);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(149, 21);
            this.lUsuario.TabIndex = 6;
            this.lUsuario.Text = "Nombre del usuario";
            // 
            // lPerfil
            // 
            this.lPerfil.AutoSize = true;
            this.lPerfil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lPerfil.Location = new System.Drawing.Point(528, 26);
            this.lPerfil.Name = "lPerfil";
            this.lPerfil.Size = new System.Drawing.Size(67, 21);
            this.lPerfil.TabIndex = 7;
            this.lPerfil.TabStop = true;
            this.lPerfil.Text = "Mi Perfil";
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(638, 360);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(19, 20);
            this.bHelp.TabIndex = 15;
            this.bHelp.Text = "?";
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(3, 0);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(18, 20);
            this.bAtras.TabIndex = 19;
            this.bAtras.Text = "<";
            this.bAtras.UseVisualStyleBackColor = true;
            // 
            // listEventos
            // 
            this.listEventos.FormattingEnabled = true;
            this.listEventos.Location = new System.Drawing.Point(22, 83);
            this.listEventos.Name = "listEventos";
            this.listEventos.Size = new System.Drawing.Size(472, 238);
            this.listEventos.TabIndex = 31;
            // 
            // TablonDeAnuncios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.listEventos);
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
        private System.Windows.Forms.ListBox listEventos;
    }
}