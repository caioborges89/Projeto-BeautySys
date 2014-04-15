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
    public partial class FrmCaixa_Entrada : Form
    {
        CaixaBO _caixaBO = new CaixaBO();
        CaixaEntradaBO _caixaEntradaBO = new CaixaEntradaBO();
        CaixaEntradaVO _caixaEntradaVO = new CaixaEntradaVO();

        public FrmCaixa_Entrada()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Caixa_Entrada_Load(object sender, EventArgs e)
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtValor.Text) || !String.IsNullOrEmpty(txtDescricao.Text))
            {
                if (_caixaEntradaBO.gravarEntrada(preencherObjeto()))
                {
                    MessageBox.Show("Entrada gravada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limparCampos();
                }
            }
            else
            {
                MessageBox.Show("Informe os dados antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal CaixaEntradaVO preencherObjeto()
        {
            _caixaEntradaVO.descricao = txtDescricao.Text;
            _caixaEntradaVO.valor = Convert.ToInt32(txtValor.Text); 
            return _caixaEntradaVO;
        }


    }
}
