using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CCE_Framework2
{
    public partial class fRegistrarse : Form
    {
        Form ventanaanterior;
        public fRegistrarse(Form ventanaanterior)
        {
            InitializeComponent();
            this.ventanaanterior = ventanaanterior;
        }

        private void tbIndicarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void fRegistrarse_Load(object sender, EventArgs e)
        {

        }

        private void rbAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumno.Checked)
            {
                rbProfesor.Checked = false;
                rbOrganizacion.Checked = false;
            }

        }

        private void rbProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProfesor.Checked)
            {
                rbAlumno.Checked = false;
                rbOrganizacion.Checked = false;
            }
        }

        private void rbOrganizacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrganizacion.Checked)
            {
                rbAlumno.Checked = false;
                rbProfesor.Checked = false;
            }
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAlumno.Checked){
                    new Usuario(tbIndicarNombre.Text, tbIndicarCorreo.Text, tbContrasenia.Text, rbAlumno.Text);
                } else if (rbProfesor.Checked) {
                    new Usuario(tbIndicarNombre.Text, tbIndicarCorreo.Text, tbContrasenia.Text, rbProfesor.Text);
                } else if (rbOrganizacion.Checked) {
                    new Usuario(tbIndicarNombre.Text, tbIndicarCorreo.Text, tbContrasenia.Text, rbOrganizacion.Text);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
        
        private void bAtras_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaanterior.Visible=true;
        }
    }
}
