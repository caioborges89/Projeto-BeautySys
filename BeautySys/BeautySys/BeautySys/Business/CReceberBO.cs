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
    }
}
