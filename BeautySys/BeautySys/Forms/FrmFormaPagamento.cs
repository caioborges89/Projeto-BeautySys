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
    public partial class FrmFormaPagamento : Form
    {
        List<FormaPagtoVO> lista;
        FormaPagtoBO _formaPagtoBO = new FormaPagtoBO();
        FormaPagtoVO _formaPagtoVO = new FormaPagtoVO();

        TipoPagtoVO _tipoPagtoVO = new TipoPagtoVO();
        TipoPagtoBO _tipoPagtoBO = new TipoPagtoBO();

        public FrmFormaPagamento()
        {
            InitializeComponent();
            preencherComboBox();
        }

        private void preencherComboBox()
        {
            //preencher Tipo
            var list = _tipoPagtoBO.buscarTipoPagto(_tipoPagtoVO);
            list.Insert(0, new TipoPagtoVO());
            cboTipo .DataSource = list;
            cboTipo.DisplayMember = "DESCRICAO";
            cboTipo.ValueMember = "PK_CODIGO";
        }

        private void FrmFormaPagamento_Load(object sender, EventArgs e)
        {
            limparCampos();

            lista = _formaPagtoBO.buscarFormaPagto(new FormaPagtoVO());

            dgvFormaPagto.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvFormaPagto.Rows.Add(lista[i].pk_codigo, lista[i].descricao, lista[i].tipo);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            cboTipo.SelectedIndex = -1;
            txtCodigo.Text = "";
            txtDescricao.Text = "";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescricao.Text) || String.IsNullOrEmpty(cboTipo.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _formaPagtoVO.descricao = txtDescricao.Text;
                lista = _formaPagtoBO.buscarFormaPagto(_formaPagtoVO);

                if (lista.Count == 0)
                {
                    if (_formaPagtoBO.gravarFormaPagto(preencherObjeto()))
                    {
                        MessageBox.Show("Forma de Pagamento cadastrada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparCampos();

                        FrmFormaPagamento_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Forma Inválida! Forma de Pagamento ja cadastrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        internal FormaPagtoVO preencherObjeto()
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
                _formaPagtoVO.pk_codigo = Convert.ToInt32(txtCodigo.Text);
            _formaPagtoVO.descricao = txtDescricao.Text;
            _formaPagtoVO.fk_tipo = (cboTipo.SelectedItem as TipoPagtoVO).pk_codigo;
            return _formaPagtoVO;
        }

        private void dgvFormaPagto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = Convert.ToString(dgvFormaPagto.Rows[dgvFormaPagto.CurrentRow.Index].Cells[0].Value);
            txtDescricao.Text = Convert.ToString(dgvFormaPagto.Rows[dgvFormaPagto.CurrentRow.Index].Cells[1].Value);
            cboTipo.Text = Convert.ToString(dgvFormaPagto.Rows[dgvFormaPagto.CurrentRow.Index].Cells[2].Value);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione uma Forma de Pagamento antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _formaPagtoBO.alterarFormaPagto(preencherObjeto());

            MessageBox.Show("Forma de Pagamento alterada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmFormaPagamento_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione uma Forma de Pagamento antes de excluir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esta Forma de Pagamento?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            _formaPagtoBO.excluirFormaPagto(preencherObjeto());

            MessageBox.Show("Forma de Pagamento excluída com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparCampos();

            FrmFormaPagamento_Load(null, null);
        }
    }
}
