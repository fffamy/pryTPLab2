using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using TreeView = System.Windows.Forms.TreeView;
using pryTPLab2;

namespace pryTPLab2
{
    internal class clsConexionBD
    {
        public static MySqlConnection conex()
        {
            string servidor = "Server=roundhouse.proxy.rlwy.net;Port=53029;Database=juegorol;Uid=root;Pwd=GWNvarIttTeUDaNhCHWcxdkOriZAPLEg;";
            MySqlConnection ConexionBD = new MySqlConnection(servidor);

            try
            {
                return ConexionBD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        public void ConectarBD_Nave(Label lblStatus)
        {
            try
            {

                string CadenaConexion = "Server=roundhouse.proxy.rlwy.net;Port=53029;Database=railway;Uid=root;Pwd=GWNvarIttTeUDaNhCHWcxdkOriZAPLEg;";

                MySqlConnection conn = new MySqlConnection(CadenaConexion);
                conn.Open();
                lblStatus.Text = "Conecatdo";
                lblStatus.BackColor = Color.Green;

            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error " + ex.Message;
            }
        }

        public void ConectarBD_Nave(ToolStripStatusLabel tstpConexionBD)
        {
            try
            {

                string CadenaConexion = "Server=roundhouse.proxy.rlwy.net;Port=53029;Database=railway;Uid=root;Pwd=GWNvarIttTeUDaNhCHWcxdkOriZAPLEg;";

                MySqlConnection conn = new MySqlConnection(CadenaConexion);
                conn.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        public void CargarScore(string Nombre, Int32 Score)
        {
            try
            {
                MySqlConnection ConexionBD = conex();
                ConexionBD.Open();

                // Query para insertar un dato de texto en la tabla
                string query = "INSERT INTO Scores (Player, Score) VALUES (@Player, @Puntos)";

                using (MySqlCommand command = new MySqlCommand(query, ConexionBD))
                {
                    // Asignar el valor de variables
                    command.Parameters.AddWithValue("@Player", Nombre);
                    command.Parameters.AddWithValue("@Puntos", Score);

                    // Ejecutar el comando
                    command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}