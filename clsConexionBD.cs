using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace pryTPLab2
{
    public class clsConexionBD
    {

        public OleDbConnection conexion = new OleDbConnection();
        public OleDbCommand comando = new OleDbCommand();
        public OleDbDataAdapter adaptador = new OleDbDataAdapter();

        string varCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Jugadores.accdb";

        public clsConexionBD()
        {
            conexion.ConnectionString = varCadenaConexion;
            comando.Connection = conexion;

        }

        public void AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public OleDbDataReader EjecutarConsulta(string query, List<OleDbParameter> parametros = null)
        {
            comando.CommandText = query;
            comando.Parameters.Clear();

            if (parametros != null)
            {
                comando.Parameters.AddRange(parametros.ToArray());
            }

            AbrirConexion();
            return comando.ExecuteReader();
        }

        public int EjecutarComando(string query, List<OleDbParameter> parametros = null)
        {
            comando.CommandText = query;
            comando.Parameters.Clear();

            if (parametros != null)
            {
                comando.Parameters.AddRange(parametros.ToArray());
            }

            AbrirConexion();
            int result = comando.ExecuteNonQuery();
            CerrarConexion();

            return result;
        }
    }
}