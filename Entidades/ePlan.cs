using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ePlan
    {
int      codigo;
int      codigoGestor            ;
String   precio               ;
String   cantidadDatosMoviles ;
String   beneficiosAdicionales;
String   serviciosIlimitados  ;
DateTime fechaInicio            ;
DateTime fechaFin               ;

        public int Codigo { get => codigo; set => codigo = value; }
        public int CodigoGestor { get => codigoGestor; set => codigoGestor = value; }
        public string Precio { get => precio; set => precio = value; }
        public string CantidadDatosMoviles { get => cantidadDatosMoviles; set => cantidadDatosMoviles = value; }
        public string BeneficiosAdicionales { get => beneficiosAdicionales; set => beneficiosAdicionales = value; }
        public string ServiciosIlimitados { get => serviciosIlimitados; set => serviciosIlimitados = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
    }
}
