using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionBD
    {
        static private string cadena = "Data Source=DESKTOP-B458LB3\\SQLEXPRESS;Initial Catalog=EmpresaClaro;Integrated Security=True";
       // private SqlConnection Conexion = new SqlConnection(cadena);

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(cadena);
        }

        //public SqlConnection AbrirConexion()
        //{
        //    if (Conexion.State == ConnectionState.Closed)
        //        Conexion.Open();
        //    return Conexion;
        //}

        //public SqlConnection CerrarConexion()
        //{
        //    if (Conexion.State == ConnectionState.Open)
        //        Conexion.Close();
        //    return Conexion;
        //}
    }
}
