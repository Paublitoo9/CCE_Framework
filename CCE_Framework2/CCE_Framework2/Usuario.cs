using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CCE_Framework2
{
    class Usuario
    {
        private static string BD_PROVIDER = Properties.Settings.Default.PROVIDER;
        private static string BD_DATA = Properties.Settings.Default.DATA;
        private static string BD_USER = Properties.Settings.Default.USER;
        private static string BD_PWD = Properties.Settings.Default.PWD;

        public static string cadenaConexion = "Database=" + BD_DATA + "; Data Source=" + BD_PROVIDER + "; User Id= " + BD_USER + "; Password=" + BD_PWD + "";
        MySqlConnection conexion = new MySqlConnection(cadenaConexion);

        private string username;
        private string email;
        private string password;
        private string rol;


        public Usuario(string n, string e, string p, string r)
        {

            conexion.Open();

            string sql = "INSERT INTO USUARIOS VALUES('" + n + "', '"
                + e + "', '" + p + "', '" + r + "');";

            try {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();

                username = n;
                password = p;
                email = e;
                rol = r;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al guardar: " + ex.Message);
            } finally {
                conexion.Close();
            }
        }
    }
}

