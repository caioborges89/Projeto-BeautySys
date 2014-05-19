using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class CReceberVO
    {
        public int pk_codigo { get; set; }

        public int fk_comanda { get; set; }

        public int nota_fiscal { get; set; }

        public string serie { get; set; }

        public int fk_cliente { get; set; }

        public DateTime dt_emissao { get; set; }

        public DateTime dt_vencimento { get; set; }

        public decimal valor { get; set; }

        public DateTime dt_pagamento { get; set; }

        public int fk_forma_pagto { get; set; }

        public string cliente { get; set; }

        public string forma_pagto { get; set; }

        public string criterio { get; set; }

        public DateTime dt_emissao_ini { get; set; }

        public DateTime dt_emissao_fim { get; set; }

        public DateTime dt_vencimento_ini { get; set; }

        public DateTime dt_vencimento_fim { get; set; }
    }
}
