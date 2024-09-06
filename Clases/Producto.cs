namespace Aplicación_Desafío.Clases
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int IdTipoproducto { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto() { }

        public Producto(int idProducto, int idTipoproducto, string nombre, double precio, int cantidad)
        {
            IdProducto = idProducto;
            IdTipoproducto = idTipoproducto;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
