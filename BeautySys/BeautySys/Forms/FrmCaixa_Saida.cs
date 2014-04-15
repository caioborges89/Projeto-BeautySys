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
    public partial class FrmCaixa_Saida : Form
    {
        CaixaBO _caixaBO = new CaixaBO();
        CaixaSaidaBO _caixaSaidaBO = new CaixaSaidaBO();
        CaixaSaidaVO _caixaSaidaVO = new CaixaSaidaVO();

        public FrmCaixa_Saida()
        {
            InitializeComponent();
        }

        private void FrmCaixa_Saida_Load(object sender, EventArgs e)
        {
            if (!_caixaBO.verificarCaixaHoje())
            {
                MessageBox.Show("Não existe nenhum caixa aberto com a data de hoje!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCampos();
            }
        }

        private void limparCampos()
        {
            txtValor.Enabled = false;
            btnLancar.Enabled = false;
            txtDescricao.Enabled = false;
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtValor.Text) || !String.IsNullOrEmpty(txtDescricao.Text))
            {
                if (_caixaSaidaBO.gravarSaida(preencherObjeto()))
                {
                    MessageBox.Show("Saida gravada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limparCampos();
                }
            }
            else
            {
                MessageBox.Show("Informe os dados antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal CaixaSaidaVO preencherObjeto()
        {
            _caixaSaidaVO.descricao = txtDescricao.Text;
            _caixaSaidaVO.valor = Convert.ToInt32(txtValor.Text);
            return _caixaSaidaVO;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
