using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades.Cache;


namespace Datos
{
    public class usuarioDao : ConexionBD
    {
        public bool Login(int user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                   command.Connection = connection;
                   command.CommandText = "select* from usuario where codigo = @codigoUsuario and contraseña = @contraseña";
                   command.Parameters.AddWithValue("@codigoUsuario", user); 
                   command.Parameters.AddWithValue("@contraseña", pass); 
                   command.CommandType = CommandType.Text; 
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UsuarioLoginCache.codigo = reader.GetInt32(0);
                            UsuarioLoginCache.tipo = reader.GetInt32(2);
                            UsuarioLoginCache.nombre = reader.GetString(3);
                            UsuarioLoginCache.apellidoPaterno = reader.GetString(4);
                            UsuarioLoginCache.apellidoMaterno = reader.GetString(5);
                            UsuarioLoginCache.dni = reader.GetString(6);
                            UsuarioLoginCache.numeroCelular = reader.GetString(7);

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }

        }
        public string CrearUsuario(int codigo, string contraseña, int IdTipo , string nombre ,string apellidoPaterno, string apellidoMaterno, string dni , string numeroCelular )
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into usuario values (@codigo,@contraseña,@IdTipo,@nombre,@apellidoPaterno,@apellidoMaterno,@dni,@numeroCelular)";
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@contraseña     ", contraseña     );         
                    command.Parameters.AddWithValue("@IdTipo         ",IdTipo         );
                    command.Parameters.AddWithValue("@nombre         ",nombre         );
                    command.Parameters.AddWithValue("@apellidoPaterno",apellidoPaterno);
                    command.Parameters.AddWithValue("@apellidoMaterno",apellidoMaterno);
                    command.Parameters.AddWithValue("@dni            ",dni            );
                    command.Parameters.AddWithValue("@numeroCelular  ",numeroCelular  );
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    return "Inserto";
                }
            }
        }





    }
}
