using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eVenta
    {
        String  codigoVenta     ;
        int     codigoEmpleado  ;
        int     dniCliente      ;
        int     codigoPlan      ;

        /*
@codigoVenta     
@codigoEmpleado
@dniCliente      
@codigoPlan  
        */

        public string CodigoVenta { get => codigoVenta; set => codigoVenta = value; }
        public int CodigoEmpleado { get => codigoEmpleado; set => codigoEmpleado = value; }
        public int DniCliente { get => dniCliente; set => dniCliente = value; }
        public int CodigoPlan { get => codigoPlan; set => codigoPlan = value; }
    }
}
