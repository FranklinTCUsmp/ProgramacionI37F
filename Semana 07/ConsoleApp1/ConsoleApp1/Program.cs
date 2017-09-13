using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new TiendaEntities();

            //var productos = contexto.Productos.Where(p => p.Precio < 1).ToList();

            var p1 = new Producto();
            p1.Nombre = "Chocolate";
            p1.Precio = 1.5m;

            contexto.Productos.Add(p1);

            contexto.SaveChanges();
        }

        //private static void adonet()
        //{
        //    var lista = new List<Producto>();

        //    // Integrated Security = Usar credenciales de Windows
        //    // User Id / Password = Usar credenciales de SQL Server
        //    using (var conexion = new SqlConnection("Data Source=.;Initial Catalog=Tienda;Integrated Security=true"))
        //    {
        //        conexion.Open();

        //        using (var comando = new SqlCommand("SELECT * FROM productos", conexion))
        //        {
        //            using (var reader = comando.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    var producto = new Producto();

        //                    producto.Id = Convert.ToInt32(reader[0]);
        //                    producto.Nombre = reader[1].ToString();
        //                    producto.Precio = Convert.ToDecimal(reader[2]);

        //                    lista.Add(producto);
        //                }
        //            }
        //        }
        //    }
        //}
    }

    //public class Producto
    //{
    //    public int Id { get; set; }
    //    public string Nombre { get; set; }
    //    public decimal Precio { get; set; }
    //}
}
