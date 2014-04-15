using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class UsuarioVO
    {
        public int pk_codigo { get; set; }

        public string nome { get; set; }

        public string senha { get; set; }

        public DateTime ultimo_acesso { get; set; }
    }
}
