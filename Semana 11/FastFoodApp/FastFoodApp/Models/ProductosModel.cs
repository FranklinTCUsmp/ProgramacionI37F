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
            var contexto = new FastfoodEntities();

            var productos = contexto.Productos.Where(p => p.Categoria.Nombre == "Comida Criolla").ToList();

            return productos;
        }

        public Producto GetProductoPorId(int id)
        {
            var contexto = new FastfoodEntities();

            var producto = contexto.Productos.FirstOrDefault(p => p.Id == id);

            return producto;
        }
    }
}