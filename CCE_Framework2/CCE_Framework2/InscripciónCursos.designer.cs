﻿
namespace CCE_Framework2
{
    partial class InscripciónCursos
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
            this.lNombreCurso = new System.Windows.Forms.Label();
            this.bAtras = new System.Windows.Forms.Button();
            this.TInscripcionCurso = new System.Windows.Forms.TextBox();
            this.FechaCurso = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.bInscribirseCurso = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            this.TextoTutor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lNombreCurso
            // 
            this.lNombreCurso.AutoSize = true;
            this.lNombreCurso.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lNombreCurso.Location = new System.Drawing.Point(10, 33);
            this.lNombreCurso.Name = "lNombreCurso";
            this.lNombreCurso.Size = new System.Drawing.Size(457, 86);
            this.lNombreCurso.TabIndex = 4;
            this.lNombreCurso.Text = "NombreCurso";
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(10, 10);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(18, 20);
            this.bAtras.TabIndex = 17;
            this.bAtras.Text = "<";
            this.bAtras.UseVisualStyleBackColor = true;
            // 
            // TInscripcionCurso
            // 
            this.TInscripcionCurso.BackColor = System.Drawing.SystemColors.Menu;
            this.TInscripcionCurso.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.TInscripcionCurso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.TInscripcionCurso.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TInscripcionCurso.Location = new System.Drawing.Point(27, 143);
            this.TInscripcionCurso.Multiline = true;
            this.TInscripcionCurso.Name = "TInscripcionCurso";
            this.TInscripcionCurso.ReadOnly = true;
            this.TInscripcionCurso.Size = new System.Drawing.Size(617, 174);
            this.TInscripcionCurso.TabIndex = 18;
            this.TInscripcionCurso.Text = "Descripción del Evento";
            // 
            // FechaCurso
            // 
            this.FechaCurso.AutoSize = true;
            this.FechaCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FechaCurso.Location = new System.Drawing.Point(490, 79);
            this.FechaCurso.Name = "FechaCurso";
            this.FechaCurso.Size = new System.Drawing.Size(89, 20);
            this.FechaCurso.TabIndex = 19;
            this.FechaCurso.Text = "dd/mm/yyyy";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(669, -1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 393);
            this.vScrollBar1.TabIndex = 20;
            // 
            // bInscribirseCurso
            // 
            this.bInscribirseCurso.Location = new System.Drawing.Point(27, 339);
            this.bInscribirseCurso.Name = "bInscribirseCurso";
            this.bInscribirseCurso.Size = new System.Drawing.Size(112, 29);
            this.bInscribirseCurso.TabIndex = 21;
            this.bInscribirseCurso.Text = "Inscribirse";
            this.bInscribirseCurso.UseVisualStyleBackColor = true;
            this.bInscribirseCurso.Click += new System.EventHandler(this.bInscribirseCurso_Click);
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(639, 360);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(19, 20);
            this.bHelp.TabIndex = 22;
            this.bHelp.Text = "?";
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // TextoTutor
            // 
            this.TextoTutor.AutoSize = true;
            this.TextoTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextoTutor.Location = new System.Drawing.Point(27, 107);
            this.TextoTutor.Name = "TextoTutor";
            this.TextoTutor.Size = new System.Drawing.Size(67, 20);
            this.TextoTutor.TabIndex = 23;
            this.TextoTutor.Text = "Tutor/es";
            // 
            // InscripciónCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.TextoTutor);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.bInscribirseCurso);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.FechaCurso);
            this.Controls.Add(this.TInscripcionCurso);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.lNombreCurso);
            this.Name = "InscripciónCursos";
            this.Text = "CCE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombreCurso;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.TextBox TInscripcionCurso;
        private System.Windows.Forms.Label FechaCurso;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button bInscribirseCurso;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Label TextoTutor;
    }
}