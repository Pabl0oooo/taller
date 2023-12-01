using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller.conec
{
    internal class cconexion
    {
        MySqlConnection conex = new MySqlConnection();
        static string servidor = "localhost";
        static string database = "vehiculos";
        static string user = "gabriel";
        static string password = "1234";
        string cadenaConexion = "server=" + servidor + ";" + "database=" + database + ";" + "user=" + user + ";" + "password=" + password + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
               // MessageBox.Show("se conecto a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se conecto a la base de datos" + ex.ToString());
            }
            return conex;
         }
      public void cerrarConexion() 
        {
            conex.Close();
        }
    }
}
