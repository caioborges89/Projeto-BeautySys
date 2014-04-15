using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class ChequeVO
    {
        public int pk_codigo { get; set; }

        public int nro { get; set; }

        public string banco { get; set; }

        public int fk_cliente { get; set; }

        public string cliente { get; set; }

        public DateTime dt_emissao { get; set; }

        public DateTime dt_vencimento { get; set; }

        public decimal valor { get; set; }

        public int situacao { get; set; }
    }
}
