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
        public DataTable filtrarSegunIdTipo(int IdTipo)
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from usuario where IdTipo = @IdTipo order by codigo asc";
                    command.Parameters.AddWithValue("@IdTipo", IdTipo);
                    command.CommandType = CommandType.Text;
                    SqlDataReader Leerfilas = command.ExecuteReader();
                    Tabla.Load(Leerfilas);
                    Leerfilas.Close();
                    return Tabla;
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
                    command.CommandText = "select *from usuario order by codigo asc";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tabla.Load(reader);
                    reader.Close();
                    return tabla;
                }
            }
        }



        public DataTable ComboTipoUsuario()
        {
        DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Tipo order by Id";
                    command.CommandType = CommandType.Text;
                    SqlDataReader Leerfilas = command.ExecuteReader();
                    Tabla.Load(Leerfilas);
                    Leerfilas.Close();
                    return Tabla;
                }
            }
        }
        string nombre;
        public string NombreTipoUsuario(int IdTipoUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Tipo where Id=@Id";
                    command.Parameters.AddWithValue("@Id", IdTipoUsuario);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            nombre = reader.GetString(1);
                        }
                    }
                }
            }
            return nombre;
        }


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
                            UsuarioLoginCache.dni = reader.GetInt32(6);
                            UsuarioLoginCache.numeroCelular = reader.GetInt32(7);

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }

        }
        public string CrearUsuario(int codigo, string contraseña, int IdTipo , string nombre ,string apellidoPaterno, string apellidoMaterno, int dni , string numeroCelular )
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

        

        public string EditarUsuario(int codigo, eUsuario objUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update usuario set nombre=@nombre,contraseña=@contraseña ,IdTipo=@IdTipo,apellidoPaterno=@apellidoPaterno,apellidoMaterno=@apellidoMaterno,numeroCelular=@numeroCelular where codigo=@codigo";
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@contraseña     ", objUsuario.Contraseña);
                    command.Parameters.AddWithValue("@IdTipo         ", objUsuario.Tipo);
                    command.Parameters.AddWithValue("@nombre         ", objUsuario.Nombre);
                    command.Parameters.AddWithValue("@apellidoPaterno", objUsuario.ApellidoPaterno);
                    command.Parameters.AddWithValue("@apellidoMaterno", objUsuario.ApellidoMaterno);
                    command.Parameters.AddWithValue("@dni            ", objUsuario.Dni);
                    command.Parameters.AddWithValue("@numeroCelular  ", objUsuario.NumeroCelular);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    return "Editar";
                }
            }
        }
        public string Eliminar(int idUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from usuario where codigo = @codigo";
                    command.Parameters.AddWithValue("@codigo", idUsuario);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    return "Eliminar";
                }
            }
        }


    }
}
