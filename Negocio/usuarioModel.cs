using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class usuarioModel
    {
        usuarioDao usuarioDao = new usuarioDao();
        public bool LoginUsuario(int user, string pass)
        {
            return usuarioDao.Login(user, pass);
        }
        
    }
}
