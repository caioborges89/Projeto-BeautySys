using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class CaixaVO
    {
        public int pk_codigo { get; set; }

        public DateTime dt_hr_abertura { get; set; }

        public DateTime dt_hr_fechamento { get; set; }

        public double valor_inicial { get; set; }

        public double valor_final { get; set; }
    }
}
