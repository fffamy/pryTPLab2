using pryTPLab2;
using System.Data.OleDb;
using System.Data;

namespace pryTPLab2
{
    public partial class frmPrincipal : Form
    {

        private clsConexionBD conexionBD;
        public frmPrincipal()
        {
            InitializeComponent();
            // Inicializa la conexión a la base de datos
            conexionBD = new clsConexionBD();
            // Evento para cargar los datos cuando el formulario se abra
            this.Load += new EventHandler(frmPrincipal_Load);
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


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // Método para cargar datos desde la base de datos Access
        private void LoadData()
        {
            // Query para seleccionar los datos que deseas mostrar
            string query = "SELECT * FROM Jugadores";

            try
            {
                // Crear un adaptador de datos para ejecutar la consulta y llenar el DataTable
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conexionBD.conexion);
                DataTable dataTable = new DataTable();

                // Llenar el DataTable con los datos de la consulta
                adapter.Fill(dataTable);

                // Asignar el DataTable como la fuente de datos del DataGridView
                dgvPuntaje.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
