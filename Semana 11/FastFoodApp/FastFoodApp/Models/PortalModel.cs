using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FastFoodApp.Models
{
    public class PortalModel
    {
        public void GuardarConsulta(Consulta consulta)
        {
            var contexto = new FastfoodEntities();

            consulta.FechaCreacion = DateTime.Now;

            contexto.Consultas.Add(consulta);

            contexto.SaveChanges();
        }
    }
}