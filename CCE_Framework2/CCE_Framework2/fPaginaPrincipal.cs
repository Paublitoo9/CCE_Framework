using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CCE_Framework2
{
    public partial class fPaginaPrincipal : Form
    {
        Form ventanaanterior;
        public fPaginaPrincipal(Form ventanaanterior)
        {
            InitializeComponent();
            this.ventanaanterior=ventanaanterior;
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void llMiPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Perfil ventana = new Perfil(this);
           this.Visible = false;
           ventana.ShowDialog();
           this.Visible = true;
        }

        private void bTablonDeAnuncio_Click(object sender, EventArgs e)
        {
            TablonDeAnuncios ventana = new TablonDeAnuncios();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bAtras_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            ventanaanterior.Visible = true;
        }

        private void bCursos_Click(object sender, EventArgs e)
        {

        }
    }
}
