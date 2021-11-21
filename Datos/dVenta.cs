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
    public class dVenta:ConexionBD
    {
        public string CrearVenta(eVenta objVenta)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into Venta values (@dni,@nombre,@apellidoPaterno,@apellidoMaterno,@numeroCelular)";
                    command.Parameters.AddWithValue("@codigoVenta      ", objVenta.CodigoVenta);
                    command.Parameters.AddWithValue("@codigoEmpleado   ", objVenta.CodigoEmpleado);
                    command.Parameters.AddWithValue("@dniCliente       ", objVenta.DniCliente);
                    command.Parameters.AddWithValue("@codigoPlan     ", objVenta.CodigoPlan);
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
                    command.CommandText = "select *from Venta order by dni asc";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tabla.Load(reader);
                    reader.Close();
                    return tabla;
                }
            }
        }

        public string EditarVenta(string codigo, eVenta objVenta)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Venta set codigoVenta=@codigoVenta ,codigoEmpleado=@codigoEmpleado,dniCliente=@dniCliente,codigoPlan=@codigoPlan where codigo=@codigo";
                    command.Parameters.AddWithValue("@codigo     ", codigo);
                    command.Parameters.AddWithValue("@codigoEmpleado   ", objVenta.CodigoEmpleado);
                    command.Parameters.AddWithValue("@dniCliente       ", objVenta.DniCliente);
                    command.Parameters.AddWithValue("@codigoPlan     ", objVenta.CodigoPlan);
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
                    command.CommandText = "delete from Venta where codigo = @codigo";
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
