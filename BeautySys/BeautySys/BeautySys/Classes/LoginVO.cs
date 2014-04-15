using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeautySys.Classes
{
    class LoginVO
    {
        public static string Servidor { get; set; }

        public static string Usuario { get; set; }

        public static string Senha { get; set; }

        public static DateTime ultimoAcesso { get; set; }
    }
}
