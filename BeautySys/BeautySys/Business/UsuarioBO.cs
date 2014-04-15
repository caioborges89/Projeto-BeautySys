using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class UsuarioBO
    {
        UsuarioDA _usuarioDA = new UsuarioDA();

        public List<UsuarioVO> busca(UsuarioVO parametros)
        {
            return _usuarioDA.buscarUsuario(parametros);
        }

        public bool gravarUsuario(UsuarioVO usuarioVO)
        {
            return _usuarioDA.gravarUsuario(usuarioVO);
        }

        public bool excluirUsuario(UsuarioVO usuario)
        {
            return _usuarioDA.excluirUsuario(usuario);
        }
    }
}
