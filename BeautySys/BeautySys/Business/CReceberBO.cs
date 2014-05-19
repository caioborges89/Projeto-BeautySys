using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class CReceberBO
    {
        CReceberDA _cReceberDA = new CReceberDA();

        public bool gravarCReceber(CReceberVO cReceberVO)
        {
            return _cReceberDA.gravarCReceber(cReceberVO);
        }

        public bool excluirCReceber(CReceberVO cReceberVO)
        {
            return _cReceberDA.excluirCReceber(cReceberVO);
        }

        public bool alterarCReceber(CReceberVO cReceberVO)
        {
            return _cReceberDA.alterarCReceber(cReceberVO);
        }

        public List<CReceberVO> buscarCReceber(CReceberVO cReceberVO)
        {
            return _cReceberDA.buscarCReceber(cReceberVO);
        }

        public bool baixarCReceber(CReceberVO cReceberVO)
        {
            return _cReceberDA.baixarCReceber(cReceberVO);
        }
    }
}
