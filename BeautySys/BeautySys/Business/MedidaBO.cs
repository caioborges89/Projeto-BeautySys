using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.Util;
using BeautySys.Classes;
using BeautySys.DataAccess;

namespace BeautySys.Business
{
    class MedidaBO
    {
        MedidaDA _medidaDA = new MedidaDA();

        public bool gravarMedida(MedidaVO medidaVO)
        {
            return _medidaDA.gravarMedida(medidaVO);
        }

        public bool excluirMedida(MedidaVO medidaVO)
        {
            return _medidaDA.excluirMedida(medidaVO);
        }

        public bool alterarMedida(MedidaVO medidaVO)
        {
            return _medidaDA.alterarMedida(medidaVO);
        }

        public List<MedidaVO> buscarMedida(MedidaVO medidaVO)
        {
            return _medidaDA.buscarMedida(medidaVO);
        }
    }
}
