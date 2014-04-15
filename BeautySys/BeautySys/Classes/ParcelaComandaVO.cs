using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class ParcelaComandaVO
    {
        public int pk_codigo { get; set; }

        public int fk_comanda { get; set; }

        public decimal valor { get; set; }

        public int fk_forma_pagto { get; set; }

        public int qtde_parcelas { get; set; }

        public decimal desc_total { get; set; }
    }
}
