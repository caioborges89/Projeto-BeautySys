using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;

namespace BeautySys.Business
{
    class LoginBO
    {
        public string getLogin()
        {
            return LoginDA.getLogin();
        }
    }
}
