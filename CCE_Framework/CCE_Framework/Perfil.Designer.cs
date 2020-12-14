
namespace CCE
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.tName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tRol = new System.Windows.Forms.TextBox();
            this.tMail = new System.Windows.Forms.TextBox();
            this.EdPerfil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bHelp = new System.Windows.Forms.Button();
            this.bAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tName.Location = new System.Drawing.Point(475, 152);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(209, 39);
            this.tName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(470, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre de Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tRol
            // 
            this.tRol.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tRol.Location = new System.Drawing.Point(109, 91);
            this.tRol.Name = "tRol";
            this.tRol.Size = new System.Drawing.Size(209, 39);
            this.tRol.TabIndex = 12;
            // 
            // tMail
            // 
            this.tMail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tMail.Location = new System.Drawing.Point(109, 24);
            this.tMail.Name = "tMail";
            this.tMail.Size = new System.Drawing.Size(209, 39);
            this.tMail.TabIndex = 11;
            // 
            // EdPerfil
            // 
            this.EdPerfil.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EdPerfil.Location = new System.Drawing.Point(36, 359);
            this.EdPerfil.Name = "EdPerfil";
            this.EdPerfil.Size = new System.Drawing.Size(254, 61);
            this.EdPerfil.TabIndex = 10;
            this.EdPerfil.Text = "Editar perfil";
            this.EdPerfil.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(744, 415);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(22, 23);
            this.bHelp.TabIndex = 16;
            this.bHelp.Text = "?";
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // bAtras
            // 
            this.bAtras.Location = new System.Drawing.Point(3, 0);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(21, 23);
            this.bAtras.TabIndex = 17;
            this.bAtras.Text = "<";
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tRol);
            this.Controls.Add(this.tMail);
            this.Controls.Add(this.EdPerfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Perfil";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tRol;
        private System.Windows.Forms.TextBox tMail;
        private System.Windows.Forms.Button EdPerfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.TextBox tName;
    }
}