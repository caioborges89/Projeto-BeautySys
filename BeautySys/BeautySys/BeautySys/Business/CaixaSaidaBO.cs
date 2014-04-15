using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;


namespace BeautySys.Business
{
    class CaixaSaidaBO
    {
        CaixaSaidaDA _caixaSaidaDA = new CaixaSaidaDA();

        public bool gravarSaida(CaixaSaidaVO caixaSaidaVO)
        {
            return _caixaSaidaDA.gravarSaida(caixaSaidaVO);
        }
    }
}
