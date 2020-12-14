
namespace CCE
{
    partial class Cursos
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
            this.bAtras = new System.Windows.Forms.Button();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lPerfil = new System.Windows.Forms.LinkLabel();
            this.lCursos = new System.Windows.Forms.Label();
            this.lCurso1 = new System.Windows.Forms.LinkLabel();
            this.lCurso2 = new System.Windows.Forms.LinkLabel();
            this.lCurso3 = new System.Windows.Forms.LinkLabel();
            this.lCrearCurso = new System.Windows.Forms.LinkLabel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.bHelp = new System.Windows.Forms.Button();
            this.listCursos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(12, 12);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(21, 23);
            this.bAtras.TabIndex = 20;
            this.bAtras.Text = "<";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lUsuario.Location = new System.Drawing.Point(613, 9);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(149, 21);
            this.lUsuario.TabIndex = 21;
            this.lUsuario.Text = "Nombre del usuario";
            // 
            // lPerfil
            // 
            this.lPerfil.AutoSize = true;
            this.lPerfil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPerfil.Location = new System.Drawing.Point(613, 30);
            this.lPerfil.Name = "lPerfil";
            this.lPerfil.Size = new System.Drawing.Size(67, 21);
            this.lPerfil.TabIndex = 22;
            this.lPerfil.TabStop = true;
            this.lPerfil.Text = "Mi Perfil";
            // 
            // lCursos
            // 
            this.lCursos.AutoSize = true;
            this.lCursos.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCursos.Location = new System.Drawing.Point(39, 12);
            this.lCursos.Name = "lCursos";
            this.lCursos.Size = new System.Drawing.Size(191, 72);
            this.lCursos.TabIndex = 23;
            this.lCursos.Text = "Cursos";
            this.lCursos.Click += new System.EventHandler(this.lTablonDeAnuncios_Click);
            // 
            // lCurso1
            // 
            this.lCurso1.AutoSize = true;
            this.lCurso1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCurso1.Location = new System.Drawing.Point(39, 104);
            this.lCurso1.Name = "lCurso1";
            this.lCurso1.Size = new System.Drawing.Size(0, 54);
            this.lCurso1.TabIndex = 24;
            // 
            // lCurso2
            // 
            this.lCurso2.AutoSize = true;
            this.lCurso2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCurso2.Location = new System.Drawing.Point(39, 204);
            this.lCurso2.Name = "lCurso2";
            this.lCurso2.Size = new System.Drawing.Size(0, 54);
            this.lCurso2.TabIndex = 25;
            // 
            // lCurso3
            // 
            this.lCurso3.AutoSize = true;
            this.lCurso3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCurso3.Location = new System.Drawing.Point(39, 314);
            this.lCurso3.Name = "lCurso3";
            this.lCurso3.Size = new System.Drawing.Size(0, 54);
            this.lCurso3.TabIndex = 26;
            // 
            // lCrearCurso
            // 
            this.lCrearCurso.AutoSize = true;
            this.lCrearCurso.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCrearCurso.Location = new System.Drawing.Point(39, 401);
            this.lCrearCurso.Name = "lCrearCurso";
            this.lCrearCurso.Size = new System.Drawing.Size(113, 28);
            this.lCrearCurso.TabIndex = 27;
            this.lCrearCurso.TabStop = true;
            this.lCrearCurso.Text = "Crear Curso";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(780, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 450);
            this.vScrollBar1.TabIndex = 28;
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(740, 415);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(22, 23);
            this.bHelp.TabIndex = 29;
            this.bHelp.Text = "?";
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // listCursos
            // 
            this.listCursos.FormattingEnabled = true;
            this.listCursos.ItemHeight = 15;
            this.listCursos.Location = new System.Drawing.Point(39, 104);
            this.listCursos.Name = "listCursos";
            this.listCursos.Size = new System.Drawing.Size(550, 274);
            this.listCursos.TabIndex = 30;
            this.listCursos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listCursos);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.lCrearCurso);
            this.Controls.Add(this.lCurso3);
            this.Controls.Add(this.lCurso2);
            this.Controls.Add(this.lCurso1);
            this.Controls.Add(this.lCursos);
            this.Controls.Add(this.lPerfil);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.bAtras);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.LinkLabel lPerfil;
        private System.Windows.Forms.Label lCursos;
        private System.Windows.Forms.LinkLabel lCurso1;
        private System.Windows.Forms.LinkLabel lCurso2;
        private System.Windows.Forms.LinkLabel lCurso3;
        private System.Windows.Forms.LinkLabel lCrearCurso;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.ListBox listCursos;
    }
}