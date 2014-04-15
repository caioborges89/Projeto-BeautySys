using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class ClienteVO
    {
        public int pk_codigo { get; set; }

        public string nome { get; set; }

        public string telefone { get; set; }

        public string celular { get; set; }

        public string email { get; set; }

        public DateTime dt_nascto { get; set; }

        public string cpf { get; set; }

        public string rg { get; set; }

        public DateTime dt_cad { get; set; }

        public string cep { get; set; }

        public string endereco { get; set; }

        public string numero { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }

        public int fk_cidade { get; set; }

        public string obs { get; set; }

        public string uf { get; set; }
    }
}
