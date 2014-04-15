using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess;
using BeautySys.Classes;

namespace BeautySys.Business
{
    class ProfissionalBO
    {
        ProfissionalDA _profissionalDA = new ProfissionalDA();

        public bool gravarProfissional(ProfissionalVO profissionalVO)
        {
            return _profissionalDA.gravarProfissional(profissionalVO);
        }

        public bool excluirProfissional(ProfissionalVO profissionalVO)
        {
            return _profissionalDA.excluirProfissional(profissionalVO);
        }

        public bool alterarProfissional(ProfissionalVO profissionalVO)
        {
            return _profissionalDA.alterarProfissional(profissionalVO);
        }

        public List<ProfissionalVO> buscarProfissional(ProfissionalVO profissionalVO)
        {
            return _profissionalDA.buscarProfissional(profissionalVO);
        }
    }
}
