using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class TipoServicoBO
    {
        TipoServicoDA _tipoServicoDA = new TipoServicoDA();

        public bool gravarTipoServico(TipoServicoVO tipoServicoVO)
        {
            return _tipoServicoDA.gravarTipoServico(tipoServicoVO);
        }

        public bool excluirTipoServico(TipoServicoVO tipoServicoVO)
        {
            return _tipoServicoDA.excluirTipoServico(tipoServicoVO);
        }

        public bool alterarTipoServico(TipoServicoVO tipoServicoVO)
        {
            return _tipoServicoDA.alterarTipoServico(tipoServicoVO);
        }

        public List<TipoServicoVO> buscarTipoServico(TipoServicoVO tipoServicoVO)
        {
            return _tipoServicoDA.buscarTipoServico(tipoServicoVO);
        }
    }
}
