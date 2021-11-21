using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Cache
{
    public class eUsuario
    {
        private  int codigo;
        private  string contraseña;
        private  int tipo;
        private  string nombre;
        private  string apellidoPaterno;
        private  string apellidoMaterno;
        private  string dni;
        private  string numeroCelular;

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
