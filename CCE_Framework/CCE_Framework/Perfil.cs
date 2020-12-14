using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CCE
{
    public partial class Perfil : Form
    {
        Form ventanaAnterior;
        //Usuario u;
        public Perfil(Form VentanaAnterior)//,Usuario u)
        {
            InitializeComponent();
            this.ventanaAnterior = VentanaAnterior;
            //this.u = u;
            MostrarUsuario();
        }

        public void MostrarUsuario()
        {
            /*tMail.Text = u.Mail;
            tRol.Text = u.MyRol;
            tName.Text = u.Username;*/
        }
        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaAnterior.Visible = true;
        }
    }
}
