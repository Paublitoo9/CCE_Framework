
namespace CCE
{
    partial class fPortada
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
            this.bIniciarSesion = new System.Windows.Forms.Button();
            this.bRegistrarse = new System.Windows.Forms.Button();
            this.lBienvenido = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.llRecuperarContrasenia = new System.Windows.Forms.LinkLabel();
            this.bEntrarComoInvitado = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bIniciarSesion
            // 
            this.bIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bIniciarSesion.Location = new System.Drawing.Point(313, 225);
            this.bIniciarSesion.Name = "bIniciarSesion";
            this.bIniciarSesion.Size = new System.Drawing.Size(179, 41);
            this.bIniciarSesion.TabIndex = 0;
            this.bIniciarSesion.Text = "Iniciar Sesión";
            this.bIniciarSesion.UseVisualStyleBackColor = true;
            this.bIniciarSesion.Click += new System.EventHandler(this.bIniciarSesion_Click);
            // 
            // bRegistrarse
            // 
            this.bRegistrarse.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bRegistrarse.Location = new System.Drawing.Point(111, 315);
            this.bRegistrarse.Name = "bRegistrarse";
            this.bRegistrarse.Size = new System.Drawing.Size(248, 61);
            this.bRegistrarse.TabIndex = 1;
            this.bRegistrarse.Text = "Registrarse";
            this.bRegistrarse.UseVisualStyleBackColor = true;
            this.bRegistrarse.Click += new System.EventHandler(this.bRegistrarse_Click);
            // 
            // lBienvenido
            // 
            this.lBienvenido.AutoSize = true;
            this.lBienvenido.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lBienvenido.Location = new System.Drawing.Point(179, 9);
            this.lBienvenido.Name = "lBienvenido";
            this.lBienvenido.Size = new System.Drawing.Size(469, 86);
            this.lBienvenido.TabIndex = 2;
            this.lBienvenido.Text = "¡BIENVENIDO!";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsuario.Location = new System.Drawing.Point(291, 115);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.PlaceholderText = "nombre de usuario";
            this.tbUsuario.Size = new System.Drawing.Size(223, 29);
            this.tbUsuario.TabIndex = 3;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbContrasenia.Location = new System.Drawing.Point(291, 172);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.PlaceholderText = "contraseña";
            this.tbContrasenia.Size = new System.Drawing.Size(223, 29);
            this.tbContrasenia.TabIndex = 4;
            this.tbContrasenia.UseSystemPasswordChar = true;
            this.tbContrasenia.TextChanged += new System.EventHandler(this.tbContrasenia_TextChanged);
            // 
            // llRecuperarContrasenia
            // 
            this.llRecuperarContrasenia.AutoSize = true;
            this.llRecuperarContrasenia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llRecuperarContrasenia.Location = new System.Drawing.Point(527, 180);
            this.llRecuperarContrasenia.Name = "llRecuperarContrasenia";
            this.llRecuperarContrasenia.Size = new System.Drawing.Size(141, 19);
            this.llRecuperarContrasenia.TabIndex = 5;
            this.llRecuperarContrasenia.TabStop = true;
            this.llRecuperarContrasenia.Text = "Recuperar contraseña";
            this.llRecuperarContrasenia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRecuperarContrasenia_LinkClicked);
            // 
            // bEntrarComoInvitado
            // 
            this.bEntrarComoInvitado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEntrarComoInvitado.Location = new System.Drawing.Point(443, 315);
            this.bEntrarComoInvitado.Name = "bEntrarComoInvitado";
            this.bEntrarComoInvitado.Size = new System.Drawing.Size(248, 61);
            this.bEntrarComoInvitado.TabIndex = 6;
            this.bEntrarComoInvitado.Text = "Entrar Como Invitado";
            this.bEntrarComoInvitado.UseVisualStyleBackColor = true;
            this.bEntrarComoInvitado.Click += new System.EventHandler(this.bEntrarComoInvitado_Click);
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(744, 415);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(22, 23);
            this.bHelp.TabIndex = 14;
            this.bHelp.Text = "?";
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // fPortada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.bEntrarComoInvitado);
            this.Controls.Add(this.llRecuperarContrasenia);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lBienvenido);
            this.Controls.Add(this.bRegistrarse);
            this.Controls.Add(this.bIniciarSesion);
            this.Name = "fPortada";
            this.Text = "CCE Portada";
            this.Load += new System.EventHandler(this.Portada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bIniciarSesion;
        private System.Windows.Forms.Button bRegistrarse;
        private System.Windows.Forms.Label lBienvenido;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.LinkLabel llRecuperarContrasenia;
        private System.Windows.Forms.Button bEntrarComoInvitado;
        private System.Windows.Forms.Button bHelp;
    }
}

