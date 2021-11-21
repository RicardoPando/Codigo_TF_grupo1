using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class eCliente
    {
        private static int dni;
        private static String nombre           ;
        private static String apellidoPaterno  ;
        private static String apellidoMaterno  ;
        private static int numeroCelular       ;

        public  int Dni { get => dni; set => dni = value; }
        public  string Nombre { get => nombre; set => nombre = value; }
        public  string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public  string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public  int NumeroCelular { get => numeroCelular; set => numeroCelular = value; }
    }
}
