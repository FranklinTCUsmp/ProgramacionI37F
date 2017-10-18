using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastFoodApp.Models
{
    public class ProductosModel
    {
        public List<Producto> ListarProductos()
        {
            var lista = new List<Producto>();

            lista.Add(new Producto
            {
                Id = 1,
                Nombre = "Lomo Saltado",
                Foto = "http://comidasperuanas.net/wp-content/uploads/2015/08/Lomo-Saltado-730x430.jpg",
                Precio = 10
            });

            lista.Add(new Producto
            {
                Id = 2,
                Nombre = "Ceviche",
                Foto = "http://comidasperuanas.net/wp-content/uploads/2015/07/Ceviche-de-Pescado.jpg",
                Precio = 30
            });

            return lista;
        }
    }
}