using System.Data.SqlClient;

namespace Aplicación_Desafío
{
    public class BDGeneral
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Test;Data Source=DESKTOP-QTOSK05");
            conexion.Open();

            return conexion;
        }




    }
}
