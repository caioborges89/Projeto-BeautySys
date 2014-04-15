using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class FormaPagtoBO
    {
        FormaPagtoDA _FormaPagtoDA = new FormaPagtoDA();

        public bool gravarFormaPagto(FormaPagtoVO formaPagtoVO)
        {
            return _FormaPagtoDA.gravarFormaPagto(formaPagtoVO);
        }

        public bool excluirFormaPagto(FormaPagtoVO formaPagtoVO)
        {
            return _FormaPagtoDA.excluirFormaPagto(formaPagtoVO);
        }

        public bool alterarFormaPagto(FormaPagtoVO formaPagtoVO)
        {
            return _FormaPagtoDA.alterarFormaPagto(formaPagtoVO);
        }

        public List<FormaPagtoVO> buscarFormaPagto(FormaPagtoVO formaPagtoVO)
        {
            return _FormaPagtoDA.buscarFormaPagto(formaPagtoVO);
        }
    }
}
