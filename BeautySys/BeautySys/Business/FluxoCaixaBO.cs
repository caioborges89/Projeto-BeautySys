using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.Util;
using BeautySys.Classes;
using BeautySys.DataAccess;
using BeautySys.DataAccess.Util;

namespace BeautySys.Business
{
    class FluxoCaixaBO
    {
        FluxoCaixaDA _fluxocaixa = new FluxoCaixaDA();

        public List<FluxoCaixaVO> buscarComanda(FluxoCaixaVO comandaVO)
        {
            return _fluxocaixa.buscarComanda(comandaVO);
        }

        public List<FluxoCaixaVO> buscarComandaCancelada(FluxoCaixaVO comandaVO)
        {
            return _fluxocaixa.buscarComandaCancelada(comandaVO);
        }

        public List<FluxoCaixaVO> buscarCReceber(FluxoCaixaVO comandaVO)
        {
            return _fluxocaixa.buscarCReceber(comandaVO);
        }

        public List<FluxoCaixaVO> buscarTotalCReceber(FluxoCaixaVO comandaVO)
        {
            return _fluxocaixa.buscarTotalCReceber(comandaVO);
        }

        public List<FluxoCaixaVO> buscarTotalComanda(FluxoCaixaVO comandaVO)
        {
            return _fluxocaixa.buscarTotalComanda(comandaVO);
        }

        public List<FluxoCaixaVO> buscarTotalCaixaEntrada(FluxoCaixaVO comandaVO)
        {
            return _fluxocaixa.buscarTotalCaixaEntrada(comandaVO);
        }

        public List<FluxoCaixaVO> buscarTotalCaixaSaida(FluxoCaixaVO comandaVO)
        {
            return _fluxocaixa.buscarTotalCaixaSaida(comandaVO);
        }

        public List<FluxoCaixaVO> buscarTotalCaixaAbertura(FluxoCaixaVO comandaVO)
        {
            return _fluxocaixa.buscarTotalCaixaAbertura(comandaVO);
        }
    }
}
