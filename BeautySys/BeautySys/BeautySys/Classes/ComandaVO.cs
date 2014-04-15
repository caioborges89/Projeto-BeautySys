using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class ComandaVO
    {
        public int pk_codigo { get; set; }

        public DateTime data { get; set; }

        public int fk_cliente { get; set; }

        public int fk_profissional { get; set; }

        public string obs { get; set; }

        public decimal valor { get; set; }

        public int fk_forma_pagto { get; set; }

        public decimal desc_total { get; set; }
    }
}
