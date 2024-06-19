using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using pryTPLab2;
using System.Security.Cryptography.X509Certificates;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryTPLab2
{
    public partial class frmMenuJuego : Form
    {
        private clsConexionBD conexionBD = new clsConexionBD();
        public string varNombre;
        
        public frmMenuJuego()
        {
            InitializeComponent();



            SoundPlayer sonidoNombre = new SoundPlayer();
            sonidoNombre.Stream = pryTPLab2.Properties.Resources.nombreSonido;
            sonidoNombre.Play();

            pctFondo.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
        }

        private void pctFondo_Click(object sender, EventArgs e)
        {
            abrirJuego();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            abrirJuego();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            abrirJuego();
        }

        private void abrirJuego()
        {
            frmJuego frmJuego = new frmJuego(varNombre);
            this.Hide();
            frmJuego.Show();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;

                    varNombre = txtNombre.Text.Trim();

                    if (string.IsNullOrEmpty(varNombre))
                    {
                        MessageBox.Show("Por favor, ingrese un nombre válido.");
                        return;
                    }

                    // Verificar si el jugador ya existe
                    if (!JugadorExiste(varNombre))
                    {
                        // El jugador no existe, lo insertamos
                        InsertarJugador(varNombre);
                    }

                    SoundPlayer sonidoInicio = new SoundPlayer();
                    sonidoInicio.Stream = pryTPLab2.Properties.Resources.Inicio_musica;
                    sonidoInicio.Play();

                    pctFondo.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;

                    pnlJugador.Visible = false;
                    pnlJugador.Enabled = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR: " + error.Message);
            }
        }

        private bool JugadorExiste(string nombreJugador)
        {
            string query = "SELECT COUNT(*) FROM JUGADORES WHERE Jugadores = @nombreJugador";
            List<OleDbParameter> parametros = new List<OleDbParameter>
            {
                new OleDbParameter("@nombreJugador", nombreJugador)
            };

            using (OleDbDataReader reader = conexionBD.EjecutarConsulta(query, parametros))
            {
                if (reader.Read())
                {
                    int count = Convert.ToInt32(reader[0]);
                    return count > 0;
                }
                else
                {
                    return false;
                }
            }
        }
        private void InsertarJugador(string nombreJugador)
        {
            string query = "INSERT INTO JUGADORES (Jugadores) VALUES (@nombreJugador)";
            List<OleDbParameter> parametros = new List<OleDbParameter>
            {
                new OleDbParameter("@nombreJugador", nombreJugador)
            };

            conexionBD.EjecutarComando(query, parametros);
        }
    }
}