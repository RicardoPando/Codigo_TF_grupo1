using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Cache
{
    public static class UsuarioLoginCache
    {
        public static int codigo { get; set; }
        public static int tipo { get; set; }
        public static string nombre { get; set; }
        public static string apellidoPaterno { get; set; }
        public static string apellidoMaterno { get; set; }
        public static int dni { get; set; }
        public static int numeroCelular { get; set; }
    }
}
