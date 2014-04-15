using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class ClienteBO
    {
        ClienteDA _clienteDA = new ClienteDA();

        public bool gravarCliente(ClienteVO clienteVO)
        {
            return _clienteDA.gravarCliente(clienteVO);
        }

        public bool excluirCliente(ClienteVO clienteVO)
        {
            return _clienteDA.excluirCliente(clienteVO);
        }

        public bool alterarCliente(ClienteVO clienteVO)
        {
            return _clienteDA.alterarCliente(clienteVO);
        }

        public List<ClienteVO> buscarCliente(ClienteVO clienteVO)
        {
            return _clienteDA.buscarCliente(clienteVO);
        }
    }
}
