using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFoodApp.Models;

namespace FastFoodApp.Controllers
{
    public class PortalController : Controller
    {
        public ActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcesarContacto(Consulta consulta)
        {
            var modelo = new PortalModel();

            modelo.GuardarConsulta(consulta);

            return RedirectToAction("Confirmacion");
        }

        public ActionResult Confirmacion()
        {
            return View();
        }
    }
}