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
            ViewBag.ListadoDeProductos = productos;

            return View();
        }

        public ActionResult Promociones()
        {
            return View();
        }
    }
}