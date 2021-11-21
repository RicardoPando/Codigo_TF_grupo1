using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    public class nCliente
    {
        dCliente conCliente = new dCliente();
        public string CrearCliente(eCliente objCliente)
        {
            return conCliente.CrearCliente(objCliente);
        }
        public DataTable Listar()
        {
            return conCliente.Listar();
        }
        public string Editar(string dni, eCliente objCliente)
        {
            return conCliente.EditarCliente(dni, objCliente);
        }
        public string Eliminar(string dni)
        {
            return conCliente.Eliminar(dni);
        }
    }
 }

