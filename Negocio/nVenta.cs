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
    public class nVenta
    {
        dVenta VentaBD = new dVenta();
        public string CrearVenta(eVenta objVenta)
        {
            return VentaBD.CrearVenta(objVenta);
        }
        public string EliminarPlanCliente(int codigo, int codigoPlan)
        {
            return VentaBD.EliminarPlanCliente(codigo, codigoPlan);
        }
        public DataTable ListarPlanCliente()
        {
            return VentaBD.ListarPlanCliente();
        }
    }
}
