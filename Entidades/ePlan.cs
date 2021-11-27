using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ePlan
    {
        private int codigo;
        private String nombre;
        private int codigoGestor;
        private int precio;
        private int cantidadDatosMoviles;
        private bool claroJuegos;
        private bool clubClaroApps;
        private bool controlAutamatico;
        private bool consumoAdicional;
        private String fechaInicio;
        private String fechaFin;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int CodigoGestor { get => codigoGestor; set => codigoGestor = value; }
        public int Precio { get => precio; set => precio = value; }
        public int CantidadDatosMoviles { get => cantidadDatosMoviles; set => cantidadDatosMoviles = value; }
        public bool ClaroJuegos { get => claroJuegos; set => claroJuegos = value; }
        public bool ClubClaroApps { get => clubClaroApps; set => clubClaroApps = value; }
        public bool ControlAutamatico { get => controlAutamatico; set => controlAutamatico = value; }
        public bool ConsumoAdicional { get => consumoAdicional; set => consumoAdicional = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string FechaFin { get => fechaFin; set => fechaFin = value; }




        //private bool claroJuegos;
        //private bool clubClaroApps;
        //private bool controlAutamatico;
        //private bool consumoAdicional;


    }
}
