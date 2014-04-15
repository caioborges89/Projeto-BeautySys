using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class TipoProdutoBO
    {
        TipoProdutoDA _tipoProdutoDA = new TipoProdutoDA();

        public bool gravarTipoProduto(TipoProdutoVO tipoProdutoVO)
        {
            return _tipoProdutoDA.gravarTipoProduto(tipoProdutoVO);
        }

        public bool excluirTipoProduto(TipoProdutoVO tipoProdutoVO)
        {
            return _tipoProdutoDA.excluirTipoProduto(tipoProdutoVO);
        }

        public bool alterarTipoProduto(TipoProdutoVO tipoProdutoVO)
        {
            return _tipoProdutoDA.alterarTipoProduto(tipoProdutoVO);
        }

        public List<TipoProdutoVO> buscarTipoProduto(TipoProdutoVO tipoProdutoVO)
        {
            return _tipoProdutoDA.buscarTipoProduto(tipoProdutoVO);
        }
    }
}
