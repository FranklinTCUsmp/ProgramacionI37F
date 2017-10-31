using FastFoodApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastFoodApp.Controllers
{
    public class ProductosController : Controller
    {
        public ActionResult Listado()
        {
            var modelo = new ProductosModel();

            var productos = modelo.ListarProductos();
            

            return View(productos);
        }

        public ActionResult Ver(int id)
        {
            var modelo = new ProductosModel();

            var producto = modelo.GetProductoPorId(id);

            return View(producto);
        }

        public ActionResult Promociones()
        {
            return View();
        }
    }
}