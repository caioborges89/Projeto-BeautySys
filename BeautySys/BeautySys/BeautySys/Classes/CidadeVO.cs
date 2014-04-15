using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class CidadeVO
    {
        public int pk_codigo { get; set; }

        public int ibge { get; set; }

        public string nome { get; set; }

        public string fk_uf { get; set; }
    }
}
