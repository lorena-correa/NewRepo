using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace appSubastaTrabajo.Formularios
{
    public partial class FormPrincipal : Form
    {
        private UsuarioDTO usuarioActual;
        public FormPrincipal(UsuarioDTO usuario)
        {
            try
            {

                InitializeComponent();
                SubastaServicio subastaServicio = SubastaServicio();

                var datos = subastaServicio.ObtenerSubastas();
                var subastas = datos.Select(datos => SubastaFactory.Crear(datos)).ToList();

                usuarioActual = usuario;

                lblIdUsuario.Text = usuario.IdUsuario;
                lblTipoUsuario.Text = usuario.TipoUsuario;
            }catch(Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
