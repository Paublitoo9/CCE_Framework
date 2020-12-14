
namespace CCE
{
    partial class EditPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPerfil));
            this.bAtras = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            this.tName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Sperfil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tMail = new System.Windows.Forms.TextBox();
            this.tPass1 = new System.Windows.Forms.TextBox();
            this.tPass2 = new System.Windows.Forms.TextBox();
            this.Dperfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(4, 1);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(21, 23);
            this.bAtras.TabIndex = 27;
            this.bAtras.Text = "<";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(744, 416);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(22, 23);
            this.bHelp.TabIndex = 26;
            this.bHelp.Text = "?";
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tName.Location = new System.Drawing.Point(498, 121);
            this.tName.Name = "tName";
            this.tName.PlaceholderText = "Cambiar Nombre";
            this.tName.Size = new System.Drawing.Size(218, 39);
            this.tName.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(546, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(99, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 39);
            this.textBox2.TabIndex = 22;
            // 
            // Sperfil
            // 
            this.Sperfil.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sperfil.Location = new System.Drawing.Point(45, 386);
            this.Sperfil.Name = "Sperfil";
            this.Sperfil.Size = new System.Drawing.Size(203, 53);
            this.Sperfil.TabIndex = 20;
            this.Sperfil.Text = "Guardar";
            this.Sperfil.UseVisualStyleBackColor = true;
            this.Sperfil.Click += new System.EventHandler(this.Sperfil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cambiar Contraseña : ";
            // 
            // tMail
            // 
            this.tMail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tMail.Location = new System.Drawing.Point(36, 23);
            this.tMail.Name = "tMail";
            this.tMail.PlaceholderText = "CambiarMail";
            this.tMail.Size = new System.Drawing.Size(289, 39);
            this.tMail.TabIndex = 21;
            // 
            // tPass1
            // 
            this.tPass1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tPass1.Location = new System.Drawing.Point(45, 196);
            this.tPass1.Name = "tPass1";
            this.tPass1.PlaceholderText = "Nueva Contraseña";
            this.tPass1.Size = new System.Drawing.Size(289, 36);
            this.tPass1.TabIndex = 28;
            // 
            // tPass2
            // 
            this.tPass2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tPass2.Location = new System.Drawing.Point(45, 264);
            this.tPass2.Name = "tPass2";
            this.tPass2.PlaceholderText = "Repetir Nueva Contraseña";
            this.tPass2.Size = new System.Drawing.Size(289, 36);
            this.tPass2.TabIndex = 29;
            // 
            // Dperfil
            // 
            this.Dperfil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dperfil.Location = new System.Drawing.Point(45, 337);
            this.Dperfil.Name = "Dperfil";
            this.Dperfil.Size = new System.Drawing.Size(119, 28);
            this.Dperfil.TabIndex = 30;
            this.Dperfil.Text = "Eliminar perfil";
            this.Dperfil.UseVisualStyleBackColor = true;
            this.Dperfil.Click += new System.EventHandler(this.Dperfil_Click);
            // 
            // EditPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dperfil);
            this.Controls.Add(this.tPass2);
            this.Controls.Add(this.tPass1);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tMail);
            this.Controls.Add(this.Sperfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "EditPerfil";
            this.Text = "CCE Editar Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Sperfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tMail;
        private System.Windows.Forms.TextBox tPass1;
        private System.Windows.Forms.TextBox tPass2;
        private System.Windows.Forms.Button Dperfil;
    }
}