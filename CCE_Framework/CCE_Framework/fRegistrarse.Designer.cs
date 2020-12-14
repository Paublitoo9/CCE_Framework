
namespace CCE
{
    partial class fRegistrarse
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
            this.tbIndicarNombre = new System.Windows.Forms.TextBox();
            this.lCorreo = new System.Windows.Forms.Label();
            this.lContrasenia = new System.Windows.Forms.Label();
            this.lRepetirContrasenia = new System.Windows.Forms.Label();
            this.tbIndicarCorreo = new System.Windows.Forms.TextBox();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.tbRepetirContrasenia = new System.Windows.Forms.TextBox();
            this.bRegistrarse = new System.Windows.Forms.Button();
            this.rbAlumno = new System.Windows.Forms.RadioButton();
            this.rbProfesor = new System.Windows.Forms.RadioButton();
            this.rbOrganizacion = new System.Windows.Forms.RadioButton();
            this.rRol = new System.Windows.Forms.Label();
            this.bHelp = new System.Windows.Forms.Button();
            this.bAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNombre.Location = new System.Drawing.Point(206, 46);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(84, 24);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre:";
            // 
            // tbIndicarNombre
            // 
            this.tbIndicarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbIndicarNombre.Location = new System.Drawing.Point(323, 46);
            this.tbIndicarNombre.Name = "tbIndicarNombre";
            this.tbIndicarNombre.PlaceholderText = "Indicar Nombre";
            this.tbIndicarNombre.Size = new System.Drawing.Size(277, 29);
            this.tbIndicarNombre.TabIndex = 1;
            this.tbIndicarNombre.TextChanged += new System.EventHandler(this.tbIndicarNombre_TextChanged);
            // 
            // lCorreo
            // 
            this.lCorreo.AutoSize = true;
            this.lCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCorreo.Location = new System.Drawing.Point(217, 102);
            this.lCorreo.Name = "lCorreo";
            this.lCorreo.Size = new System.Drawing.Size(73, 24);
            this.lCorreo.TabIndex = 2;
            this.lCorreo.Text = "Correo:";
            // 
            // lContrasenia
            // 
            this.lContrasenia.AutoSize = true;
            this.lContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lContrasenia.Location = new System.Drawing.Point(185, 159);
            this.lContrasenia.Name = "lContrasenia";
            this.lContrasenia.Size = new System.Drawing.Size(111, 24);
            this.lContrasenia.TabIndex = 3;
            this.lContrasenia.Text = "Contraseña:";
            // 
            // lRepetirContrasenia
            // 
            this.lRepetirContrasenia.AutoSize = true;
            this.lRepetirContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lRepetirContrasenia.Location = new System.Drawing.Point(120, 211);
            this.lRepetirContrasenia.Name = "lRepetirContrasenia";
            this.lRepetirContrasenia.Size = new System.Drawing.Size(176, 24);
            this.lRepetirContrasenia.TabIndex = 4;
            this.lRepetirContrasenia.Text = "Repetir Contraseña:";
            // 
            // tbIndicarCorreo
            // 
            this.tbIndicarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbIndicarCorreo.Location = new System.Drawing.Point(323, 102);
            this.tbIndicarCorreo.Name = "tbIndicarCorreo";
            this.tbIndicarCorreo.PlaceholderText = "Indicar Correo";
            this.tbIndicarCorreo.Size = new System.Drawing.Size(277, 29);
            this.tbIndicarCorreo.TabIndex = 5;
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbContrasenia.Location = new System.Drawing.Point(323, 159);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.PlaceholderText = "Contraseña";
            this.tbContrasenia.Size = new System.Drawing.Size(277, 29);
            this.tbContrasenia.TabIndex = 6;
            // 
            // tbRepetirContrasenia
            // 
            this.tbRepetirContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRepetirContrasenia.Location = new System.Drawing.Point(323, 211);
            this.tbRepetirContrasenia.Name = "tbRepetirContrasenia";
            this.tbRepetirContrasenia.PlaceholderText = "Repetir Contraseña";
            this.tbRepetirContrasenia.Size = new System.Drawing.Size(277, 29);
            this.tbRepetirContrasenia.TabIndex = 7;
            // 
            // bRegistrarse
            // 
            this.bRegistrarse.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bRegistrarse.Location = new System.Drawing.Point(131, 362);
            this.bRegistrarse.Name = "bRegistrarse";
            this.bRegistrarse.Size = new System.Drawing.Size(202, 56);
            this.bRegistrarse.TabIndex = 8;
            this.bRegistrarse.Text = "Registrarse";
            this.bRegistrarse.UseVisualStyleBackColor = true;
            this.bRegistrarse.Click += new System.EventHandler(this.bRegistrarse_Click);
            // 
            // rbAlumno
            // 
            this.rbAlumno.AutoSize = true;
            this.rbAlumno.Location = new System.Drawing.Point(323, 267);
            this.rbAlumno.Name = "rbAlumno";
            this.rbAlumno.Size = new System.Drawing.Size(68, 19);
            this.rbAlumno.TabIndex = 9;
            this.rbAlumno.TabStop = true;
            this.rbAlumno.Text = "Alumno";
            this.rbAlumno.UseVisualStyleBackColor = true;
            this.rbAlumno.CheckedChanged += new System.EventHandler(this.rbAlumno_CheckedChanged);
            // 
            // rbProfesor
            // 
            this.rbProfesor.AutoSize = true;
            this.rbProfesor.Location = new System.Drawing.Point(323, 292);
            this.rbProfesor.Name = "rbProfesor";
            this.rbProfesor.Size = new System.Drawing.Size(69, 19);
            this.rbProfesor.TabIndex = 10;
            this.rbProfesor.TabStop = true;
            this.rbProfesor.Text = "Profesor";
            this.rbProfesor.UseVisualStyleBackColor = true;
            this.rbProfesor.CheckedChanged += new System.EventHandler(this.rbProfesor_CheckedChanged);
            // 
            // rbOrganizacion
            // 
            this.rbOrganizacion.AutoSize = true;
            this.rbOrganizacion.Location = new System.Drawing.Point(323, 317);
            this.rbOrganizacion.Name = "rbOrganizacion";
            this.rbOrganizacion.Size = new System.Drawing.Size(95, 19);
            this.rbOrganizacion.TabIndex = 11;
            this.rbOrganizacion.TabStop = true;
            this.rbOrganizacion.Text = "Organización";
            this.rbOrganizacion.UseVisualStyleBackColor = true;
            this.rbOrganizacion.CheckedChanged += new System.EventHandler(this.rbOrganizacion_CheckedChanged);
            // 
            // rRol
            // 
            this.rRol.AutoSize = true;
            this.rRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rRol.Location = new System.Drawing.Point(185, 287);
            this.rRol.Name = "rRol";
            this.rRol.Size = new System.Drawing.Size(43, 24);
            this.rRol.TabIndex = 12;
            this.rRol.Text = "Rol:";
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(744, 415);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(22, 23);
            this.bHelp.TabIndex = 13;
            this.bHelp.Text = "?";
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(3, 0);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(21, 23);
            this.bAtras.TabIndex = 14;
            this.bAtras.Text = "<";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // fRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.rRol);
            this.Controls.Add(this.rbOrganizacion);
            this.Controls.Add(this.rbProfesor);
            this.Controls.Add(this.rbAlumno);
            this.Controls.Add(this.bRegistrarse);
            this.Controls.Add(this.tbRepetirContrasenia);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.tbIndicarCorreo);
            this.Controls.Add(this.lRepetirContrasenia);
            this.Controls.Add(this.lContrasenia);
            this.Controls.Add(this.lCorreo);
            this.Controls.Add(this.tbIndicarNombre);
            this.Controls.Add(this.lNombre);
            this.Name = "fRegistrarse";
            this.Text = "CCE Registrarse";
            this.Load += new System.EventHandler(this.fRegistrarse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tbIndicarNombre;
        private System.Windows.Forms.Label lCorreo;
        private System.Windows.Forms.Label lContrasenia;
        private System.Windows.Forms.Label lRepetirContrasenia;
        private System.Windows.Forms.TextBox tbIndicarCorreo;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.TextBox tbRepetirContrasenia;
        private System.Windows.Forms.Button bRegistrarse;
        private System.Windows.Forms.RadioButton rbAlumno;
        private System.Windows.Forms.RadioButton rbProfesor;
        private System.Windows.Forms.RadioButton rbOrganizacion;
        private System.Windows.Forms.Label rRol;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bAtras;
    }
}