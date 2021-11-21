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
    public class dCliente:ConexionBD
    {

        public string CrearCliente(eCliente objCliente)
        {
            using (var connection=GetConnection())
            {
                connection.Open();
                using (var command=new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into cliente values (@dni,@nombre,@apellidoPaterno,@apellidoMaterno,@numeroCelular)";
                    command.Parameters.AddWithValue("@dni               ", objCliente.Dni);
                    command.Parameters.AddWithValue("@nombre            ", objCliente.Nombre            );
                    command.Parameters.AddWithValue("@apellidoPaterno   ", objCliente.ApellidoPaterno   );
                    command.Parameters.AddWithValue("@apellidoMaterno   ", objCliente.ApellidoMaterno   );
                    command.Parameters.AddWithValue("@numeroCelular     ", objCliente.NumeroCelular     );
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
                    command.CommandText = "select *from cliente order by dni asc";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tabla.Load(reader);
                    reader.Close();
                    return tabla;
                }
            }
        }

        public string EditarCliente(string Dni, eCliente objCliente)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update cliente set dni=@dni,nombre=@nombre,apellidoPaterno=@apellidoPaterno,apellidoMaterno=@apellidoMaterno,numeroCelular=@numeroCelular where dni=@dni";
                    command.Parameters.AddWithValue("@dni", Dni);
                    command.Parameters.AddWithValue("@nombre",          objCliente.Nombre);
                    command.Parameters.AddWithValue("@apellidoPaterno", objCliente.ApellidoPaterno);
                    command.Parameters.AddWithValue("@apellidoMaterno", objCliente.ApellidoMaterno);
                    command.Parameters.AddWithValue("@numeroCelular",   objCliente.NumeroCelular);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    return "Editar";
                }
            }
        }
        public string Eliminar(string dni)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from cliente where dni = @dni";
                    command.Parameters.AddWithValue("@dni", dni);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    return "Eliminar";
                }
            }
        }
    }
}
