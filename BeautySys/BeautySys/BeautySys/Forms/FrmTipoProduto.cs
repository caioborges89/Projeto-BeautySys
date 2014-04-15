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

namespace BeautySys
{
    public partial class FrmTipoProduto : Form
    {
        List<TipoProdutoVO> lista;
        TipoProdutoBO _tipoProdutoBO = new TipoProdutoBO();
        TipoProdutoVO _tipoProdutoVO = new TipoProdutoVO();

        public FrmTipoProduto()
        {
            InitializeComponent();
        }

        private void FrmTipoProduto_Load(object sender, EventArgs e)
        {
            limparCampos();

            lista = _tipoProdutoBO.buscarTipoProduto(new TipoProdutoVO());

            dgvTipoProduto.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvTipoProduto.Rows.Add(lista[i].pk_codigo, lista[i].descricao);
            }
        }

        private void limparCampos()
        {
            txbCodigo.Text = "";
            txbNome.Text = "";
        }

        internal TipoProdutoVO preencherObjeto()
        {
            if (!String.IsNullOrEmpty(txbCodigo.Text))
                _tipoProdutoVO.pk_codigo = Convert.ToInt32(txbCodigo.Text);
            _tipoProdutoVO.descricao = txbNome.Text;
            return _tipoProdutoVO;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbNome.Text))
            {
                MessageBox.Show("Preencha a DESCRICAO antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _tipoProdutoVO.descricao = txbNome.Text;
                lista = _tipoProdutoBO.buscarTipoProduto(_tipoProdutoVO);

                if (lista.Count == 0)
                {
                    if (_tipoProdutoBO.gravarTipoProduto(preencherObjeto()))
                    {
                        MessageBox.Show("Descrição cadastrada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparCampos();

                        FrmTipoProduto_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Descrição Inválida! Descrição ja cadastrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbCodigo.Text))
            {
                MessageBox.Show("Selecione uma descrição antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _tipoProdutoBO.alterarTipoProduto(preencherObjeto());

            MessageBox.Show("Descrição alterada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmTipoProduto_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbCodigo.Text))
            {
                MessageBox.Show("Selecione uma descrição antes de excluir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esta Descrição?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            _tipoProdutoVO.pk_codigo = Convert.ToInt32(dgvTipoProduto.Rows[dgvTipoProduto.CurrentRow.Index].Cells[0].Value);

            _tipoProdutoBO.excluirTipoProduto(_tipoProdutoVO);

            MessageBox.Show("Descrição excluída com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmTipoProduto_Load(null, null);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTipoProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigo.Text = Convert.ToString(dgvTipoProduto.Rows[dgvTipoProduto.CurrentRow.Index].Cells[0].Value);
            txbNome.Text = Convert.ToString(dgvTipoProduto.Rows[dgvTipoProduto.CurrentRow.Index].Cells[1].Value);
        }
    }
}
