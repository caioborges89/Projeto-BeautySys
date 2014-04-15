using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class CaixaEntradaBO
    {
        CaixaEntradaDA _caixaEntradaDA = new CaixaEntradaDA();

        public bool gravarEntrada(CaixaEntradaVO caixaEntradaVO)
        {
            return _caixaEntradaDA.gravarEntrada(caixaEntradaVO);
        }
    }
}
