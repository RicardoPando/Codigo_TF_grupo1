using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades.Cache;

/*
 using System.Text;
using System.Threading.Tasks; 
using System.Data; 
using System.Data.SqlClient; 
namespace DataAccess 
{
public class UserDao : Connectiontosal
public bool Login(string user, string pass),
using (var connection = GetConnection()
connection.Open(); using (var command = new SqlCommand())
command.Connection = connection; command.CommandText = "select *from Users where LoginName=Quser and Password=@pass"; command.Parameters.AddwithValue("Quser", user); command.Parameters.AddwithValue("@pass", pass); command.CommandType = CommandType.Text; SqlDataReader reader = command.ExecuteReaderO; if (reader.HasRows)
return true;
else
return false;

 */
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
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }

        }


    }
}
