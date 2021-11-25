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
        private String precio;
        private int cantidadDatosMoviles;
        private int beneficiosAdicionales;
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int CodigoGestor { get => codigoGestor; set => codigoGestor = value; }
        public string Precio { get => precio; set => precio = value; }
        public int CantidadDatosMoviles { get => cantidadDatosMoviles; set => cantidadDatosMoviles = value; }
        public int BeneficiosAdicionales { get => beneficiosAdicionales; set => beneficiosAdicionales = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        //private bool claroJuegos;
        //private bool clubClaroApps;
        //private bool controlAutamatico;
        //private bool consumoAdicional;


    }
}
