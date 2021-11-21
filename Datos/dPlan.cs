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
                    command.CommandText = "insert into Plan values (@codigo,@codigoGestor,@precio,@cantidadDatosMoviles,@beneficiosAdicionales,@serviciosIlimitados,@fechaInicio,@fechaFin)";
                    command.Parameters.AddWithValue("@codigo;", objPlan.Codigo);
                    command.Parameters.AddWithValue("@codigoGestor         ", objPlan.CodigoGestor);
                    command.Parameters.AddWithValue("@precio               ", objPlan.Precio             );
                    command.Parameters.AddWithValue("@cantidadDatosMoviles ", objPlan.CantidadDatosMoviles             );
                    command.Parameters.AddWithValue("@beneficiosAdicionales", objPlan.BeneficiosAdicionales             );
                    command.Parameters.AddWithValue("@serviciosIlimitados  ", objPlan.ServiciosIlimitados             );
                    command.Parameters.AddWithValue("@fechaInicio          ", objPlan.FechaInicio             );
                    command.Parameters.AddWithValue("@fechaFin             ", objPlan.FechaFin);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
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
                    command.CommandText = "select *from Plan order by codigo asc";
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
                    command.Parameters.AddWithValue("@serviciosIlimitados  ", objPlan.ServiciosIlimitados);
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
