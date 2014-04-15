using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeautySys.Classes;
using BeautySys.Forms;

namespace BeautySys.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "BeautySys - Versão: " + Application.ProductVersion + " - Usuário: " + LoginVO.Usuario;
            timer1.Enabled = true;
            
        }

        private void BtnCadUser_Click(object sender, EventArgs e)
        {
            FrmCadUser frmCadUser = new FrmCadUser();
            frmCadUser.ShowDialog();
        }

        private void btnCadTipoServico_Click(object sender, EventArgs e)
        {
            FrmTipoServico frmTipoServico = new FrmTipoServico();
            frmTipoServico.ShowDialog();
        }

        private void btnTipoProduto_Click(object sender, EventArgs e)
        {
            FrmTipoProduto frmTipoProduto = new FrmTipoProduto();
            frmTipoProduto.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = Convert.ToString(DateTime.Now);
        }

        private void BtnCadProduto_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }

        private void BtnCadTpProduto_Click(object sender, EventArgs e)
        {
            FrmTipoProduto frmTipoProduto = new FrmTipoProduto();
            frmTipoProduto.ShowDialog();
        }

        private void BtnCadServico_Click(object sender, EventArgs e)
        {
            FrmServico frmServico = new FrmServico();
            frmServico.ShowDialog();
        }

        private void BtnCadastroMedidas_Click(object sender, EventArgs e)
        {
            FrmMedida frmMedida = new FrmMedida();
            frmMedida.ShowDialog();
        }

        private void btnCadProfissionais_Click(object sender, EventArgs e)
        {
            FrmProfissional frmProfissional = new FrmProfissional();
            frmProfissional.ShowDialog();
        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
        }

        private void btnCadEstados_Click(object sender, EventArgs e)
        {
            FrmEstado frmEstado = new FrmEstado();
            frmEstado.ShowDialog();
        }

        private void btnCadCidades_Click(object sender, EventArgs e)
        {
            FrmCidade frmCidade = new FrmCidade();
            frmCidade.ShowDialog();
        }

        private void btnFechamentoCaixa_Click(object sender, EventArgs e)
        {
            FrmCaixa_Fechamento frmcaixaFechamento = new FrmCaixa_Fechamento();
            frmcaixaFechamento.ShowDialog();
        }

        private void btnAberturaCaixa_Click(object sender, EventArgs e)
        {
            FrmCaixa_Abertura frmcaixaAbertura = new FrmCaixa_Abertura();
            frmcaixaAbertura.ShowDialog();
        }

        private void btnEntCaixa_Click(object sender, EventArgs e)
        {
            FrmCaixa_Entrada frmcaixaEntrada = new FrmCaixa_Entrada();
            frmcaixaEntrada.ShowDialog(); 
        }

        private void btnSaiCaixa_Click(object sender, EventArgs e)
        {
            FrmCaixa_Saida frmCaixaSaida = new FrmCaixa_Saida();
            frmCaixaSaida.ShowDialog(); 
        }

        private void btnFormaPagto_Click(object sender, EventArgs e)
        {
            FrmFormaPagamento frmFormaPagto = new FrmFormaPagamento();
            frmFormaPagto.ShowDialog();
        }

        private void btnFluxoCaixa_Click(object sender, EventArgs e)
        {
            FrmFluxoCaixa frmFluxoCaixa = new FrmFluxoCaixa();
            frmFluxoCaixa.ShowDialog();
        }

        private void btnCReceber_Click(object sender, EventArgs e)
        {
            FrmCReceber frmCReceber = new FrmCReceber();
            frmCReceber.ShowDialog();
        }

        private void btnCheques_Click(object sender, EventArgs e)
        {
            FrmCheques frmCheque = new FrmCheques();
            frmCheque.ShowDialog();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            FrmComanda frmComanda = new FrmComanda();
            frmComanda.ShowDialog();
        }
    }
}
