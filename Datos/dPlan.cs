using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dPlan:ConexionBD
    {
        public string CrearPlan(ePlan objPlan)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into Plan values (@codigo,@nombre,@codigoGestor,@precio,@cantidadDatosMoviles,@beneficiosAdicionales,@fechaInicio,@fechaFin)";
                    command.Parameters.AddWithValue("@codigo", objPlan.Codigo);
                    command.Parameters.AddWithValue("@nombre", objPlan.Nombre);
                    command.Parameters.AddWithValue("@codigoGestor         ", objPlan.CodigoGestor);
                    command.Parameters.AddWithValue("@precio               ", objPlan.Precio             );
                    command.Parameters.AddWithValue("@cantidadDatosMoviles ", objPlan.CantidadDatosMoviles             );
                    command.Parameters.AddWithValue("@beneficiosAdicionales", objPlan.Codigo);
                    command.Parameters.AddWithValue("@fechaInicio          ", objPlan.FechaInicio             );
                    command.Parameters.AddWithValue("@fechaFin             ", objPlan.FechaFin);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    //command.CommandText = "insert into beneficioPlan values (@codigoPlan,@claroJuegos,@clubClaroApps,@controlAutomatico,@consumoAdicional)";
                    //command.Parameters.AddWithValue("@codigoPlan", objPlan.Codigo);
                    //    command.Parameters.AddWithValue("@claroJuegos      ",objPlan.ClaroJuegos);
                    //command.Parameters.AddWithValue("@clubClaroApps    ", objPlan.ClubClaroApps);
                    //command.Parameters.AddWithValue("@controlAutomatico", objPlan.ControlAutamatico);
                    //command.Parameters.AddWithValue("@consumoAdicional ", objPlan.ConsumoAdicional);
                    //command.ExecuteNonQuery();
                    //command.Parameters.Clear();
                    return "Inserto";
                }
            }
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT        TOP (200) codigo, nombre, codigoGestor, precio, cantidadDatosMoviles, beneficiosAdicionales, fechaInicio, fechaFin FROM[plan]";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tabla.Load(reader);
                    reader.Close();
                    return tabla;
                }
            }
        }

        public string EditarPlan(string codigo, ePlan objPlan)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Plan set codigo=@codigo,codigoGestor=@codigoGestor,precio=@precio,cantidadDatosMoviles=@cantidadDatosMoviles,beneficiosAdicionales=@beneficiosAdicionales where codigo=@codigo";
                    command.Parameters.AddWithValue("@codigo;", objPlan.Codigo);
                    command.Parameters.AddWithValue("@codigoGestor         ", objPlan.CodigoGestor);
                    command.Parameters.AddWithValue("@precio               ", objPlan.Precio);
                    command.Parameters.AddWithValue("@cantidadDatosMoviles ", objPlan.CantidadDatosMoviles);
                    command.Parameters.AddWithValue("@beneficiosAdicionales", objPlan.BeneficiosAdicionales);
                    command.Parameters.AddWithValue("@fechaInicio          ", objPlan.FechaInicio);
                    command.Parameters.AddWithValue("@fechaFin             ", objPlan.FechaFin);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    return "Editar";
                }
            }
        }
        public string Eliminar(string codigo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from Plan where codigo = @codigo";
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    return "Eliminar";
                }
            }
        }

    }
}
