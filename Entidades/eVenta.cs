using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eVenta
    {
       public int  codigoVenta     ;
       public int     codigoEmpleado  ;
       public int     dniCliente      ;
       public int     codigoPlan      ;

        /*
@codigoVenta     
@codigoEmpleado
@dniCliente      
@codigoPlan  
        */

        public int CodigoVenta { get => codigoVenta; set => codigoVenta = value; }
        public int CodigoEmpleado { get => codigoEmpleado; set => codigoEmpleado = value; }
        public int DniCliente { get => dniCliente; set => dniCliente = value; }
        public int CodigoPlan { get => codigoPlan; set => codigoPlan = value; }
    }
}
