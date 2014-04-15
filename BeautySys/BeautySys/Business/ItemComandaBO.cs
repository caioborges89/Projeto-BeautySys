using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class ItemComandaBO
    {
        ItemComandaDA _itemComandaDA = new ItemComandaDA();

        public bool gravarComanda(ItemComandaVO itemComandaVO)
        {
            return _itemComandaDA.gravarItemComanda(itemComandaVO);
        }
    }
}
