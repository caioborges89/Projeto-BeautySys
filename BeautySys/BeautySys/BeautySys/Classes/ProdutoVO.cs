using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class ProdutoVO
    {
        public int pk_codigo {get;set;}

        public string descricao { get; set; }

        public int fk_tipo_produto { get; set; }

        public string fk_medida { get; set; }

        public decimal qtde_estoque { get; set; }

        public int estoque_minimo { get; set; }

        public decimal valor { get; set; }

        public decimal custo { get; set; }

        public decimal desc_max { get; set; }

        public decimal comissao { get; set; }

        public string obs { get; set; }
    }
}
