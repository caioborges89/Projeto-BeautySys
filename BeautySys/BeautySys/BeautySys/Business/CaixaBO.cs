using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class CaixaBO
    {
        CaixaDA _caixaDA = new CaixaDA();

        public bool abrirCaixa(CaixaVO caixaVO)
        {
            return _caixaDA.abrirCaixa(caixaVO);
        }

        public CaixaVO verificarCaixa()
        {
            return _caixaDA.verificarCaixa();
        }

        public bool fecharCaixa(CaixaVO caixaVO)
        {
            return _caixaDA.fecharCaixa(caixaVO);
        }

        public bool verificarCaixaHoje()
        {
            return _caixaDA.verificarCaixaHoje();
        }
    }
}
