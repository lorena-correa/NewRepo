using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSubastaTrabajo
{
    public partial class FormRegistro : Form
    {

        public FormRegistro()
        {
            InitializeComponent();

            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbTipoUsuario.Items.Add("Seleccione");
            cmbTipoUsuario.Items.Add("Comprador");
            cmbTipoUsuario.Items.Add("Espectador");
            cmbTipoUsuario.SelectedIndex = 0;

            txtContrasenia.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasenia.Text) || cmbTipoUsuario.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            UsuarioDTO nuevoUsuario = new UsuarioDTO
            {
                IdUsuario = txtUsuario.Text,
                Contrasenia = txtContrasenia.Text,
                TipoUsuario = cmbTipoUsuario.SelectedItem.ToString()
            };

            UsuarioServicio servicio = new UsuarioServicio();
            servicio.GuardarUsuarios(nuevoUsuario);

            MessageBox.Show("Usuario registrado exitosamente.");

            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
