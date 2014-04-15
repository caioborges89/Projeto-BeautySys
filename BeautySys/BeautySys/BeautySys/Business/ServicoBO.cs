using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.Util;
using BeautySys.Classes;
using BeautySys.DataAccess;

namespace BeautySys.Business
{
    class ServicoBO
    {
        ServicoDA _servicoDA = new ServicoDA();

        public bool gravarServico(ServicoVO servicoVO)
        {
            return _servicoDA.gravarServico(servicoVO);
        }

        public bool excluirServico(ServicoVO servicoVO)
        {
            return _servicoDA.excluirServico(servicoVO);
        }

        public bool alterarServico(ServicoVO servicoVO)
        {
            return _servicoDA.alterarServico(servicoVO);
        }

        public List<ServicoVO> buscarServico(ServicoVO servicoVO)
        {
            return _servicoDA.buscarServico(servicoVO);
        }
    }
}
