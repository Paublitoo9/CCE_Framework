using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CCE
{
    public partial class EditPerfil : Form
    {
        Form ventanaAnterior;
        //Usuario u;
        public EditPerfil(Form ventanaAnterior) //,Usuario u)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
           // this.u = u;
        }

        private void VolverAnterior()
        {
            this.Visible = false;
            ventanaAnterior.Visible = true;
        }
        private void Sperfil_Click(object sender, EventArgs e)
        {
            /*
            if (!tMail.Text.Equals(u.Mail))
            {
                u.Mail = tMail.Text;
            }
            if (!tPass1.Text.Equals(u.Password))
            {
                if (tPass1.Text.Equals(tPass2.Text))
                {
                    u.Password = tPass1.Text;
                }
                
            }
            if (!tName.Text.Equals(u.Username))
            {
                u.Username = tName.Text;
            }*/
            fPortada ventana = new fPortada();
            this.Visible = false;
            ventana.ShowDialog();
        }

       

        private void bAtras_Click(object sender, EventArgs e)
        {
            VolverAnterior();
        }

        private void Dperfil_Click(object sender, EventArgs e)
        {
            //u.BorrarUsuario();
            fPortada ventana = new fPortada();
            this.Visible = false;
            ventana.ShowDialog();
        }
    }
}
