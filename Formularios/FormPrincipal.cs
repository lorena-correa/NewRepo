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
        private List<Subasta> listaSubastas;
        private Subasta subastaSeleccionada;

        public FormPrincipal(UsuarioDTO usuario)
        {
            try
            {
                InitializeComponent();

                SubastaServicio subastaServicio = new SubastaServicio();
                var datos = subastaServicio.ObtenerSubastas();

                listaSubastas = datos.Select(d => SubastaFactory.Crear(d)).ToList();

                CargarGrid();

                usuarioActual = usuario;

                lblIdUsuario.Text = usuario.IdUsuario;
                lblTipoUsuario.Text = usuario.TipoUsuario;

                if (usuario.TipoUsuario == "Espectador")
                {
                    button1.Enabled = false;
                }

                dataGridView1.CellClick += dataGridView1_CellClick;
                button1.Click += button1_Click;
                button2.Click += button2_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                subastaSeleccionada = listaSubastas[e.RowIndex];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (subastaSeleccionada == null)
                    throw new Exception("Seleccione una subasta");

                decimal monto = decimal.Parse(textBox1.Text);

                subastaSeleccionada.Ofertar(usuarioActual, monto);

                GuardarSubastas(); 

                MessageBox.Show("Oferta realizada");

                RecargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (subastaSeleccionada == null)
                    throw new Exception("Seleccione una subasta");

                subastaSeleccionada.Ofertar(usuarioActual, subastaSeleccionada.PrecioActual);

                GuardarSubastas(); 

                MessageBox.Show("Precio aceptado");

                RecargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarGrid()
        {
            dataGridView1.DataSource = listaSubastas.Select(s => new
            {
                s.NombreProducto,
                s.PrecioActual,
                Tipo = s.Estrategia.GetType().Name,
                Estado = s.Activa ? "Activa" : "Cerrada"
            }).ToList();
        }

        private void RecargarGrid()
        {
            dataGridView1.DataSource = null;
            CargarGrid();
        }

        private void GuardarSubastas()
        {
            SubastaServicio servicio = new SubastaServicio();

            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Subastas.json");

            File.WriteAllText(ruta, "[]");

            foreach (var s in listaSubastas)
            {
                servicio.GuardarSubasta(new SubastaDTO
                {
                    NombreProducto = s.NombreProducto,
                    PrecioActual = s.PrecioActual,
                    TipoSubasta = s.Estrategia.GetType().Name.Replace("Subasta", ""),
                    Activa = s.Activa
                });
            }
        }
    }
}