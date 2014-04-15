using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class FormaPagtoVO
    {
        public int pk_codigo { get; set; }

        public string descricao { get; set; }

        public int fk_tipo { get; set; }

        public string tipo { get; set; }
    }
}
