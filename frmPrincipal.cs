using pryTPLab2;

namespace pryTPLab2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnsGalaga_Click(object sender, EventArgs e)
        {
            frmMenuJuego frmMenuJuego = new frmMenuJuego();
            this.Hide();
            frmMenuJuego.Show();
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
