using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class ComandaBO
    {
        ComandaDA _comandaDA = new ComandaDA();

        public bool gravarComanda(ComandaVO comandaVO)
        {
            return _comandaDA.gravarComanda(comandaVO);
        }
    }
}
