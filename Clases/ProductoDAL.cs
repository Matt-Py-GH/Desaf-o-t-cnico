using System.Data.SqlClient;

namespace Aplicación_Desafío.Clases
{
    public class ProductoDAL
    {
        public static int AgregarProducto(Producto producto)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "INSERT INTO Producto (idTipoProducto,nombre,precio,cantidad) VALUES(" + producto.IdTipoproducto + ", '" + producto.Nombre + "', " + producto.Precio + ", "+producto.Cantidad+");";
                SqlCommand comandoAgregar = new SqlCommand(query, conexion);

                retorna = comandoAgregar.ExecuteNonQuery();
            }

            return retorna;
        }

        public static int EliminarProducto(Producto producto)
        {
            int resultado = 0;

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "EXEC EliminarProducto @IdProducto";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@IdProducto", producto.IdProducto);

                resultado = comando.ExecuteNonQuery();
            }

            return resultado;
        }

        public static int ModificarProducto(Producto producto)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "UPDATE Producto SET" +
                    "IdTipo="+producto.IdTipoproducto+", '"+producto.Nombre+"'" +
                    ""+producto.Precio+", "+producto.Cantidad+" WHERE id="+producto.IdProducto+"";
                SqlCommand comandoModificar = new SqlCommand(query, conexion);

                retorna = comandoModificar.ExecuteNonQuery();
                conexion.Close();
            }

            return retorna;
        }

        public static List<Producto> ProductosMostrados()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "SELECT IdProducto, IdTipoProducto, Nombre, Precio, Cantidad FROM Producto";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.IdProducto = reader.GetInt32(0);
                    producto.IdTipoproducto = reader.GetInt32(1);
                    producto.Nombre = reader.GetString(2);
                    producto.Precio = reader.GetDouble(3);
                    producto.Cantidad = reader.GetInt32(4);
                    lista.Add(producto);
                }
                conexion.Close();
                return lista;
            }
        }

    }

}
