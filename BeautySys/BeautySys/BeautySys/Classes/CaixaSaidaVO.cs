using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class CaixaSaidaVO
    {
        public int pk_codigo { get; set; }

        public string descricao { get; set; }

        public float valor { get; set; }

        public int fk_caixa { get; set; }
    }
}
