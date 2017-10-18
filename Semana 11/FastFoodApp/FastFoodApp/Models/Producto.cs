using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastFoodApp.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public decimal Precio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
    }
}