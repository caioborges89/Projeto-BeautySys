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
    public partial class FrmTipoServico : Form
    {
        List<TipoServicoVO> lista;
        TipoServicoBO _tipoServicoBO = new TipoServicoBO();
        TipoServicoVO _tipoServicoVO = new TipoServicoVO();

        public FrmTipoServico()
        {
            InitializeComponent();
        }

        private void FrmTipo_Servico_Load(object sender, EventArgs e)
        {
            limparCampos();

            lista = _tipoServicoBO.buscarTipoServico(new TipoServicoVO());

            dgvTipoServico.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvTipoServico.Rows.Add(lista[i].pk_codigo, lista[i].descricao);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbNome.Text))
            {
                MessageBox.Show("Preencha a DESCRICAO antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _tipoServicoVO.descricao = txbNome.Text;
                lista = _tipoServicoBO.buscarTipoServico(_tipoServicoVO);

                if (lista.Count == 0)
                {
                    if (_tipoServicoBO.gravarTipoServico(preencherObjeto()))
                    {
                        MessageBox.Show("Descrição cadastrada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparCampos();

                        FrmTipo_Servico_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Descrição Inválida! Descrição ja cadastrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limparCampos()
        {
            txbCodigo.Text = "";
            txbNome.Text = "";
        }

        internal TipoServicoVO preencherObjeto()
        {
            if (!String.IsNullOrEmpty(txbCodigo.Text))
                _tipoServicoVO.pk_codigo = Convert.ToInt32(txbCodigo.Text);
            _tipoServicoVO.descricao = txbNome.Text;
            return _tipoServicoVO;
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

            _tipoServicoVO.pk_codigo = Convert.ToInt32(dgvTipoServico.Rows[dgvTipoServico.CurrentRow.Index].Cells[0].Value);

            _tipoServicoBO.excluirTipoServico(_tipoServicoVO);

            MessageBox.Show("Descrição excluída com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmTipo_Servico_Load(null, null);
        }

        private void dgvTipoServico_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigo.Text = Convert.ToString(dgvTipoServico.Rows[dgvTipoServico.CurrentRow.Index].Cells[0].Value);
            txbNome.Text = Convert.ToString(dgvTipoServico.Rows[dgvTipoServico.CurrentRow.Index].Cells[1].Value);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbCodigo.Text))
            {
                MessageBox.Show("Selecione uma descrição antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _tipoServicoBO.alterarTipoServico(preencherObjeto());

            MessageBox.Show("Descrição alterada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmTipo_Servico_Load(null, null);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
