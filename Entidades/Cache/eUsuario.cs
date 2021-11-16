using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Cache
{
    public class eUsuario
    {
        private static int codigo;
        private static string contraseña;
        private static int tipo;
        private static string nombre;
        private static string apellidoPaterno;
        private static string apellidoMaterno;
        private static string dni;
        private static string numeroCelular;

        public  int Codigo { get => codigo; set => codigo = value; }
        public  string Contraseña { get => contraseña; set => contraseña = value; }
        public  int Tipo { get => tipo; set => tipo = value; }
        public  string Nombre { get => nombre; set => nombre = value; }
        public  string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public  string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public  string Dni { get => dni; set => dni = value; }
        public  string NumeroCelular { get => numeroCelular; set => numeroCelular = value; }
    }
}
