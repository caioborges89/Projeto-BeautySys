using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class EstadoBO
    {
        EstadoDA _estadoDA = new EstadoDA();

        public bool gravarEstado(EstadoVO estadoVO)
        {
            return _estadoDA.gravarEstado(estadoVO);
        }

        public bool excluirEstado(EstadoVO estadoVO)
        {
            return _estadoDA.excluirEstado(estadoVO);
        }

        public bool alterarEstado(EstadoVO estadoVO)
        {
            return _estadoDA.alterarEstado(estadoVO);
        }

        public List<EstadoVO> buscarEstado(EstadoVO estadoVO)
        {
            return _estadoDA.buscarEstado(estadoVO);
        }
    }
}
