using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.Util;
using BeautySys.Classes;
using BeautySys.DataAccess;
using BeautySys.DataAccess.Util;

namespace BeautySys.Business
{
    class ChequeBO
    {
        ChequeDA _chequeDA = new ChequeDA();

        public bool gravarCheque(ChequeVO chequeVO)
        {
            return _chequeDA.gravarCheque(chequeVO);
        }

        public bool excluirCheque(ChequeVO chequeVO)
        {
            return _chequeDA.excluirCheque(chequeVO);
        }

        public bool alterarCheque(ChequeVO chequeVO)
        {
            return _chequeDA.alterarCheque(chequeVO);
        }

        public List<ChequeVO> buscarCheque(ChequeVO chequeVO)
        {
            return _chequeDA.buscarCheque(chequeVO);
        }
    }
}
