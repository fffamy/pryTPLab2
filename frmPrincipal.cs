using pryTPLab2;

namespace pryTPLab2
{
    public partial class frmPrincipal : Form
    {
        clsConexionBD objConexionBD;


        public frmPrincipal()
        {
            InitializeComponent();
            objConexionBD = new clsConexionBD();

        }

        private void mnsFirma_Click(object sender, EventArgs e)
        {
            frmFirma FrmFirma = new frmFirma();
            this.Hide();
            FrmFirma.Show();
        }

        private void mnsGalaga_Click(object sender, EventArgs e)
        {
            frmMenuJuego frmMenuJuego = new frmMenuJuego();
            this.Hide();
            frmMenuJuego.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            objConexionBD.ConectarBD_Nave(tstpConexionBD);

        }

        private void mnsMonstruario_Click(object sender, EventArgs e)
        {
            frmMonstruario frmMonstruario = new frmMonstruario();
            this.Hide();
            frmMonstruario.Show();
        }

        private void mnsJugadores_Click(object sender, EventArgs e)
        {
            frmJugadores frmJugadores = new frmJugadores();
            this.Hide();
            frmJugadores.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar un MessageBox de confirmación
            var confirmResult = MessageBox.Show("¿Seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario selecciona "Yes", cerrar la aplicación
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
