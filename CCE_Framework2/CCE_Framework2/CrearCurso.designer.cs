
namespace CCE_Framework2
{
    partial class CrearCurso
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
            this.tNombreCurso = new System.Windows.Forms.TextBox();
            this.dFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lFechaInicio = new System.Windows.Forms.Label();
            this.lFechaFinal = new System.Windows.Forms.Label();
            this.lTutor = new System.Windows.Forms.Label();
            this.bModificar = new System.Windows.Forms.Button();
            this.tDescricion = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.bHelp = new System.Windows.Forms.Button();
            this.bAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tNombreCurso
            // 
            this.tNombreCurso.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.tNombreCurso.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tNombreCurso.Location = new System.Drawing.Point(14, 32);
            this.tNombreCurso.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tNombreCurso.Multiline = true;
            this.tNombreCurso.Name = "tNombreCurso";
            this.tNombreCurso.Size = new System.Drawing.Size(396, 70);
            this.tNombreCurso.TabIndex = 0;
            this.tNombreCurso.Text = "NombreCurso";
            this.tNombreCurso.TextChanged += new System.EventHandler(this.tNombreCurso_TextChanged);
            // 
            // dFechaInicio
            // 
            this.dFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dFechaInicio.Location = new System.Drawing.Point(535, 32);
            this.dFechaInicio.Name = "dFechaInicio";
            this.dFechaInicio.Size = new System.Drawing.Size(239, 25);
            this.dFechaInicio.TabIndex = 1;
            // 
            // dFechaFin
            // 
            this.dFechaFin.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dFechaFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dFechaFin.Location = new System.Drawing.Point(535, 77);
            this.dFechaFin.Name = "dFechaFin";
            this.dFechaFin.Size = new System.Drawing.Size(239, 25);
            this.dFechaFin.TabIndex = 2;
            // 
            // lFechaInicio
            // 
            this.lFechaInicio.AutoSize = true;
            this.lFechaInicio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lFechaInicio.Location = new System.Drawing.Point(418, 32);
            this.lFechaInicio.Name = "lFechaInicio";
            this.lFechaInicio.Size = new System.Drawing.Size(115, 21);
            this.lFechaInicio.TabIndex = 3;
            this.lFechaInicio.Text = "Fecha de inicio:";
            // 
            // lFechaFinal
            // 
            this.lFechaFinal.AutoSize = true;
            this.lFechaFinal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lFechaFinal.Location = new System.Drawing.Point(418, 81);
            this.lFechaFinal.Name = "lFechaFinal";
            this.lFechaFinal.Size = new System.Drawing.Size(108, 21);
            this.lFechaFinal.TabIndex = 4;
            this.lFechaFinal.Text = "Fecha de final:";
            // 
            // lTutor
            // 
            this.lTutor.AutoSize = true;
            this.lTutor.Location = new System.Drawing.Point(14, 117);
            this.lTutor.Name = "lTutor";
            this.lTutor.Size = new System.Drawing.Size(85, 28);
            this.lTutor.TabIndex = 5;
            this.lTutor.Text = "Tutor/es";
            // 
            // bModificar
            // 
            this.bModificar.AutoSize = true;
            this.bModificar.Location = new System.Drawing.Point(116, 112);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(106, 38);
            this.bModificar.TabIndex = 6;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // tDescricion
            // 
            this.tDescricion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tDescricion.Location = new System.Drawing.Point(14, 169);
            this.tDescricion.Multiline = true;
            this.tDescricion.Name = "tDescricion";
            this.tDescricion.Size = new System.Drawing.Size(760, 232);
            this.tDescricion.TabIndex = 7;
            this.tDescricion.Text = "Descripción del curso...";
            this.tDescricion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(14, 407);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(118, 36);
            this.bGuardar.TabIndex = 8;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(781, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 453);
            this.vScrollBar1.TabIndex = 9;
            // 
            // bHelp
            // 
            this.bHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bHelp.Location = new System.Drawing.Point(744, 415);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(22, 23);
            this.bHelp.TabIndex = 15;
            this.bHelp.Text = "?";
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // bAtras
            // 
            this.bAtras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bAtras.Location = new System.Drawing.Point(3, 0);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(21, 23);
            this.bAtras.TabIndex = 19;
            this.bAtras.Text = "<";
            this.bAtras.UseVisualStyleBackColor = true;
            // 
            // CrearCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tDescricion);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.lTutor);
            this.Controls.Add(this.lFechaFinal);
            this.Controls.Add(this.lFechaInicio);
            this.Controls.Add(this.dFechaFin);
            this.Controls.Add(this.dFechaInicio);
            this.Controls.Add(this.tNombreCurso);
            this.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Name = "CrearCurso";
            this.Text = "CrearCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombreCurso;
        private System.Windows.Forms.DateTimePicker dFechaInicio;
        private System.Windows.Forms.DateTimePicker dFechaFin;
        private System.Windows.Forms.Label lFechaInicio;
        private System.Windows.Forms.Label lFechaFinal;
        private System.Windows.Forms.Label lTutor;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.TextBox tDescricion;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bAtras;
    }
}