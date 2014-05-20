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
    class SituacaoChequeBO
    {
        SituacaoChequeDA  _situacaoChequeDA = new SituacaoChequeDA();

        public bool gravarSituacaoCheque(SituacaoChequeVO situacaoChequeVO)
        {
            return _situacaoChequeDA.gravarSituacaoCheque(situacaoChequeVO);
        }

        public bool excluirSituacaoCheque(SituacaoChequeVO  situacaoChequeVO)
        {
            return _situacaoChequeDA.excluirSituacaoCheque(situacaoChequeVO);
        }

        public bool alterarSituacaoCheque(SituacaoChequeVO situacaoChequeVO)
        {
            return _situacaoChequeDA.alterarSituacaoCheque(situacaoChequeVO);
        }

        public List<SituacaoChequeVO> buscarSituacaoCheque(SituacaoChequeVO situacaoChequeVO)
        {
            return _situacaoChequeDA.buscarSituacaoCheque(situacaoChequeVO);
        }
    }
}
