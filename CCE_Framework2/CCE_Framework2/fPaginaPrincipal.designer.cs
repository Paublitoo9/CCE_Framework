
namespace CCE_Framework2
{
    partial class fPaginaPrincipal
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
            this.bCursos = new System.Windows.Forms.Button();
            this.bTablonDeAnuncio = new System.Windows.Forms.Button();
            this.bForoGeneral = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            this.lNombreUsuario = new System.Windows.Forms.Label();
            this.llMiPerfil = new System.Windows.Forms.LinkLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.bAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCursos
            // 
            this.bCursos.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCursos.Location = new System.Drawing.Point(57, 76);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(347, 57);
            this.bCursos.TabIndex = 0;
            this.bCursos.Text = "Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bTablonDeAnuncio
            // 
            this.bTablonDeAnuncio.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTablonDeAnuncio.Location = new System.Drawing.Point(57, 166);
            this.bTablonDeAnuncio.Name = "bTablonDeAnuncio";
            this.bTablonDeAnuncio.Size = new System.Drawing.Size(346, 57);
            this.bTablonDeAnuncio.TabIndex = 1;
            this.bTablonDeAnuncio.Text = "Tablón de Anuncio";
            this.bTablonDeAnuncio.UseVisualStyleBackColor = true;
            this.bTablonDeAnuncio.Click += new System.EventHandler(this.bTablonDeAnuncio_Click);
            // 
            // bForoGeneral
            // 
            this.bForoGeneral.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bForoGeneral.Location = new System.Drawing.Point(57, 250);
            this.bForoGeneral.Name = "bForoGeneral";
            this.bForoGeneral.Size = new System.Drawing.Size(347, 57);
            this.bForoGeneral.TabIndex = 2;
            this.bForoGeneral.Text = "Foro General";
            this.bForoGeneral.UseVisualStyleBackColor = true;
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(638, 360);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(19, 20);
            this.bHelp.TabIndex = 14;
            this.bHelp.Text = "?";
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // lNombreUsuario
            // 
            this.lNombreUsuario.AutoSize = true;
            this.lNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lNombreUsuario.Location = new System.Drawing.Point(467, 19);
            this.lNombreUsuario.Name = "lNombreUsuario";
            this.lNombreUsuario.Size = new System.Drawing.Size(172, 21);
            this.lNombreUsuario.TabIndex = 15;
            this.lNombreUsuario.Text = "Nombre del Usuario (?)";
            // 
            // llMiPerfil
            // 
            this.llMiPerfil.AutoSize = true;
            this.llMiPerfil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.llMiPerfil.Location = new System.Drawing.Point(467, 49);
            this.llMiPerfil.Name = "llMiPerfil";
            this.llMiPerfil.Size = new System.Drawing.Size(68, 21);
            this.llMiPerfil.TabIndex = 16;
            this.llMiPerfil.TabStop = true;
            this.llMiPerfil.Text = "Mi perfil";
            this.llMiPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMiPerfil_LinkClicked);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(467, 133);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(3, 0);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(18, 20);
            this.bAtras.TabIndex = 18;
            this.bAtras.Text = "<";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // fPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.llMiPerfil);
            this.Controls.Add(this.lNombreUsuario);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.bForoGeneral);
            this.Controls.Add(this.bTablonDeAnuncio);
            this.Controls.Add(this.bCursos);
            this.Name = "fPaginaPrincipal";
            this.Text = "CCE Pagina Principal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bTablonDeAnuncio;
        private System.Windows.Forms.Button bForoGeneral;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Label lNombreUsuario;
        private System.Windows.Forms.LinkLabel llMiPerfil;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button bAtras;
    }
}