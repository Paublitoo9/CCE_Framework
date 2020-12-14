using System;
using System.Windows.Forms;

namespace CCE
{
    public partial class fPortada : Form
    {
        public fPortada()
        {
            InitializeComponent();
        }

      


        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            fRegistrarse ventana = new fRegistrarse(this);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void Portada_Load(object sender, EventArgs e)
        {
        }

        private void tbContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void llRecuperarContrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void bIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void bEntrarComoInvitado_Click(object sender, EventArgs e)
        {
            fPaginaPrincipal ventana = new fPaginaPrincipal(this);
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
