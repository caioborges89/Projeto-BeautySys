using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class ItemComandaVO
    {
        public int pk_codigo { get; set; }

        public int fk_comanda { get; set; }

        public int cod_prod_serv { get; set; }

        public string prod_serv { get; set; }//P = Produto ... S = Serviço

        public decimal quantidade { get; set; }

        public decimal valor { get; set; }

        public decimal valor_unitario { get; set; }

        public decimal desc_item { get; set; }
    }
}
