using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.Util;
using BeautySys.Classes;
using BeautySys.DataAccess;

namespace BeautySys.Business
{
    class ProdutoBO
    {
        ProdutoDA _produtoDA = new ProdutoDA();

        public bool gravarProduto(ProdutoVO produtoVO)
        {
            return _produtoDA.gravarProduto(produtoVO);
        }

        public bool excluirProduto(ProdutoVO produtoVO)
        {
            return _produtoDA.excluirProduto(produtoVO);
        }

        public bool alterarProduto(ProdutoVO produtoVO)
        {
            return _produtoDA.alterarProduto(produtoVO);
        }

        public List<ProdutoVO> buscarProduto(ProdutoVO produtoVO)
        {
            return _produtoDA.buscarProduto(produtoVO);
        }
    }
}
