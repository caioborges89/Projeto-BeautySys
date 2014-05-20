using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeautySys.Business;
using BeautySys.Classes;
using BeautySys.Util;

namespace BeautySys.Forms
{
    public partial class FrmFluxoCaixa : Form
    {
        List<FluxoCaixaVO> lista;

        FluxoCaixaBO _fluxoCaixaBO = new FluxoCaixaBO();
        FluxoCaixaVO _fluxoCaixaVO = new FluxoCaixaVO();

        public FrmFluxoCaixa()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            carregarComandas();
            carregarComandasCanceladas();
            carregarCReceber();
            carregarTotais();
        }

        private void carregarComandas()
        {
            lista = _fluxoCaixaBO.buscarComanda(preencherObjeto());

            dgvComandas.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvComandas.Rows.Add(lista[i].numero, lista[i].cliente, lista[i].valor.ToString("###,###,##0.00"));
            }
        }

        private void carregarComandasCanceladas()
        {
            lista = _fluxoCaixaBO.buscarComandaCancelada(preencherObjeto());

            dgvComandasCanceladas.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvComandasCanceladas.Rows.Add(lista[i].numero, lista[i].cliente, lista[i].valor.ToString("###,###,##0.00"));
            }
        }

        private void carregarCReceber()
        {
            lista = _fluxoCaixaBO.buscarCReceber(preencherObjeto());

            dgvContasRecebidas.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvContasRecebidas.Rows.Add(lista[i].numero, lista[i].cliente, lista[i].valor.ToString("###,###,##0.00"));
            }
        }

        private void carregarTotais()
        {
            carregarTotaisCRceber();
            carregarTotaisComanda();
            carregarTotaisCaixaEntrada();
            carregarTotaisCaixaSaida();
            carregarTotaisCaixaAbertura();
            carregarSaldo();
        }

        private void carregarSaldo()
        {
            decimal abertura = Convert.ToDecimal(lblTotalAbertura.Text);
            decimal entrada = Convert.ToDecimal(lblTotalEntradas.Text);
            decimal saida = Convert.ToDecimal(lblTotalSaidas.Text);
            decimal comanda = Convert.ToDecimal(lblTotalComanda.Text);
            decimal creceber = Convert.ToDecimal(lblTotalCReceber.Text);
            decimal saldo;
            lblSaldo.Text = "0.00";

            //saldo = abertura + entrada - saida + comanda + creceber;
            //não pode somar as comandas, pois seus valores ja estao em CReceber
            saldo = abertura + entrada - saida + creceber;

            lblSaldo.Text = saldo.ToString("###,###,##0.00");
        }

        private void carregarTotaisCRceber()
        {
            lblTotalCReceber.Text = "0.00";

            lista = _fluxoCaixaBO.buscarTotalCReceber(preencherObjeto());

            for (int i = 0; i < lista.Count; i++)
            {
                lblTotalCReceber.Text = lista[0].total.ToString("###,###,##0.00");
            }
        }

        private void carregarTotaisComanda()
        {
            lblTotalComanda.Text = "0.00";

            lista = _fluxoCaixaBO.buscarTotalComanda(preencherObjeto());

            for (int i = 0; i < lista.Count; i++)
            {
                lblTotalComanda.Text = lista[0].total.ToString("###,###,##0.00");
            }
        }

        private void carregarTotaisCaixaEntrada()
        {
            lblTotalEntradas.Text = "0.00";

            lista = _fluxoCaixaBO.buscarTotalCaixaEntrada(preencherObjeto());

            for (int i = 0; i < lista.Count; i++)
            {
                lblTotalEntradas.Text = lista[0].total.ToString("###,###,##0.00");
            }
        }

        private void carregarTotaisCaixaSaida()
        {
            lblTotalSaidas.Text = "0.00";

            lista = _fluxoCaixaBO.buscarTotalCaixaSaida(preencherObjeto());

            for (int i = 0; i < lista.Count; i++)
            {
                lblTotalSaidas.Text = lista[0].total.ToString("###,###,##0.00");
            }
        }

        private void carregarTotaisCaixaAbertura()
        {
            lblTotalAbertura.Text = "0.00";

            lista = _fluxoCaixaBO.buscarTotalCaixaAbertura(preencherObjeto());

            for (int i = 0; i < lista.Count; i++)
            {
                lblTotalAbertura.Text = lista[0].total.ToString("###,###,##0.00");
            }
        }

        internal FluxoCaixaVO preencherObjeto()
        {
            _fluxoCaixaVO.dt_inicial = dtpDataInicial.Value;
            _fluxoCaixaVO.dt_final = dtpDataFinal.Value;
            return _fluxoCaixaVO;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
