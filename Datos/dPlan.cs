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
    public class dPlan : ConexionBD
    {
        public string CrearPlan(ePlan objPlan)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into Plan values (@codigo,@nombre,@codigoGestor,@precio,@cantidadDatosMoviles,@claroJuegos,@claroApps,@controlAutomatico,@consumoAdicional,@cantidadDatosMoviles,@fechaInicio,@fechaFin)";
                    command.Parameters.AddWithValue("@codigo", objPlan.Codigo);
                    command.Parameters.AddWithValue("@nombre", objPlan.Nombre);
                    command.Parameters.AddWithValue("@codigoGestor         ", objPlan.CodigoGestor);
                    command.Parameters.AddWithValue("@precio               ", objPlan.Precio);
                    command.Parameters.AddWithValue("@cantidadDatosMoviles ", objPlan.CantidadDatosMoviles);
                    command.Parameters.AddWithValue("@claroJuegos", objPlan.ClaroJuegos);
                    command.Parameters.AddWithValue("@claroApps", objPlan.ClubClaroApps);
                    command.Parameters.AddWithValue("@controlAutomatico", objPlan.ControlAutamatico);
                    command.Parameters.AddWithValue("@consumoAdicional", objPlan.ConsumoAdicional);
                    command.Parameters.AddWithValue("@fechaInicio          ", objPlan.FechaInicio);
                    command.Parameters.AddWithValue("@fechaFin             ", objPlan.FechaFin);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    return "Inserto";
                }
            }
        }
        /*SELECT *FROM [dbo].[beneficioPlan]*/
        

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT *FROM[dbo].[plan]";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tabla.Load(reader);
                    reader.Close();
                    return tabla;
                }
            }
        }

        public string EditarPlan(int codigo, ePlan objPlan)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Plan set(@nombre,@codigoGestor,@precio,@cantidadDatosMoviles,@claroJuegos,@claroApps,@controlAutomatico,@consumoAdicional,@cantidadDatosMoviles,@fechaInicio,@fechaFin) where codigo=@codigo";
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", objPlan.Nombre);
                    command.Parameters.AddWithValue("@codigoGestor         ", objPlan.CodigoGestor);
                    command.Parameters.AddWithValue("@precio               ", objPlan.Precio);
                    command.Parameters.AddWithValue("@cantidadDatosMoviles ", objPlan.CantidadDatosMoviles);
                    command.Parameters.AddWithValue("@claroJuegos", objPlan.ClaroJuegos);
                    command.Parameters.AddWithValue("@claroApps", objPlan.ClubClaroApps);
                    command.Parameters.AddWithValue("@controlAutomatico", objPlan.ControlAutamatico);
                    command.Parameters.AddWithValue("@consumoAdicional", objPlan.ConsumoAdicional);
                    command.Parameters.AddWithValue("@fechaInicio          ", objPlan.FechaInicio);
                    command.Parameters.AddWithValue("@fechaFin             ", objPlan.FechaFin);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    return "Editar";
                }
            }
        }
        public string Eliminar(int codigo)
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
