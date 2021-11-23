using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
using Entidades.Cache;

namespace Negocio
{
    public class usuarioModel
    {
        usuarioDao usuarioDao = new usuarioDao();

        //public string NombreTipo(int IdTipo)
        //{
        //    return usuarioDao.NombreTipo(IdTipo);
        //}
        public DataTable filtrarSegunIdTipo(int IdTipo)
        {
            return usuarioDao.filtrarSegunIdTipo(IdTipo);
        }

        public string NombreTipoUsuario(int IdTipoUsuario)
        {
            return usuarioDao.NombreTipoUsuario(IdTipoUsuario);
        }


        public DataTable ComboTipoUsuario()
        {
            return usuarioDao.ComboTipoUsuario();
        }

        public bool LoginUsuario(int user, string pass)
        {
            return usuarioDao.Login(user, pass);
        }

        public void CrearUsuario(eUsuario objusuario)
        {
            usuarioDao.CrearUsuario(objusuario.Codigo, objusuario.Contraseña, objusuario.Tipo, objusuario.Nombre, objusuario.ApellidoPaterno, objusuario.ApellidoMaterno, objusuario.Dni, objusuario.NumeroCelular);
        }

        public string EditarUsuario(int IdUsuario, eUsuario objUsuario)
        {
           return usuarioDao.EditarUsuario(IdUsuario, objUsuario);
        }
        public DataTable Listar()
        {
            return usuarioDao.Listar();
        }
        public string Eliminar(int idUsuario)
        {
            return usuarioDao.Eliminar(idUsuario);
        }

    }
}
