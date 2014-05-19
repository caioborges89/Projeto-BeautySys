using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class FluxoCaixaVO
    {
        public DateTime dt_inicial { get; set; }

        public DateTime dt_final { get; set; }

        public double total { get; set; }

        public int numero { get; set; }

        public string cliente { get; set; }

        public double valor { get; set; }
    }
}
