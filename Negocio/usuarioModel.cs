using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades.Cache;

namespace Negocio
{
    public class usuarioModel
    {
        usuarioDao usuarioDao = new usuarioDao();

        public bool LoginUsuario(int user, string pass)
        {
            return usuarioDao.Login(user, pass);
        }

        public void CrearUsuario(eUsuario objusuario)
        {
            usuarioDao.CrearUsuario(objusuario.Codigo, objusuario.Contraseña, objusuario.Tipo, objusuario.Nombre, objusuario.ApellidoPaterno, objusuario.ApellidoMaterno, objusuario.Dni, objusuario.NumeroCelular);
        }



    }
}
