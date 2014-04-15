using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class TipoPagtoBO
    {
        TipoPagtoDA _tipoPagtoDA = new TipoPagtoDA();

        public List<TipoPagtoVO> buscarTipoPagto(TipoPagtoVO tipoPagtoVO)
        {
            return _tipoPagtoDA.buscarTipoPagto();
        }
    }
}
