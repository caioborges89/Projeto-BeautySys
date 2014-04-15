using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class CidadeBO
    {
        CidadeDA _cidadeDA = new CidadeDA();

        public bool gravarCidade(CidadeVO cidadeVO)
        {
            return _cidadeDA.gravarCidade(cidadeVO);
        }

        public bool excluirCidade(CidadeVO cidadeVO)
        {
            return _cidadeDA.excluirCidade(cidadeVO);
        }

        public bool alterarCidade(CidadeVO cidadeVO)
        {
            return _cidadeDA.alterarCidade(cidadeVO);
        }

        public List<CidadeVO> buscarCidade(CidadeVO cidadeVO)
        {
            return _cidadeDA.buscarCidade(cidadeVO);
        }
    }
}
