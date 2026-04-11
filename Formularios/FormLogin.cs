using appSubastaTrabajo.Formularios;

namespace appSubastaTrabajo
{
    public partial class FormLogin : Form

    {
        public FormLogin()
        {
            InitializeComponent();
            txtContrasenia.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormRegistro registro = new FormRegistro();
            registro.ShowDialog();

            this.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
           UsuarioServicio servicio = new UsuarioServicio();
            var usuarios = servicio.ObtenerUsuarios();

            var usuario = usuarios.FirstOrDefault(u => u.IdUsuario == txtUsuario.Text && u.Contrasenia == txtContrasenia.Text);

            if(usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                return;
            }

            MessageBox.Show($"Bienvenido {usuario.IdUsuario} ({usuario.TipoUsuario})");

            FormPrincipal main = new FormPrincipal(usuario);
            main.Show();
            this.Hide();
        }
    }
}
