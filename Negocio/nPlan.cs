using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Datos;
namespace Negocio
{
    public class nPlan
    {
        dPlan conPlan = new dPlan();
        public string CrearPlan(ePlan objPlan)
        {
            return conPlan.CrearPlan(objPlan);
        }    
        public DataTable Listar()
        {
            return conPlan.Listar();
        }
        public string EditarPlan(string codigo, ePlan objPlan)
        {
            return conPlan.EditarPlan(codigo, objPlan);
        }
        public string Eliminar(string codigo)
        {
            return conPlan.Eliminar(codigo);
        }
    }
}
