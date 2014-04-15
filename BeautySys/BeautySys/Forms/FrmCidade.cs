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
    public partial class FrmCidade : Form
    {
        List<CidadeVO> lista;
        EstadoBO _estadoBO = new EstadoBO();
        EstadoVO _estadoVO = new EstadoVO();
        CidadeBO _cidadeBO = new CidadeBO();
        CidadeVO _cidadeVO = new CidadeVO(); 

        public FrmCidade()
        {
            InitializeComponent();
            preencherComboBox();
        }

        private void preencherComboBox()
        {
            //preencher UF
            var list = _estadoBO.buscarEstado(_estadoVO);
            list.Insert(0, new EstadoVO());
            cboUF.DataSource = list;
            cboUF.DisplayMember = "UF";
            cboUF.ValueMember = "UF";
        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {
            limparCampos();

            lista = _cidadeBO.buscarCidade(new CidadeVO());

            dgvCidade.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvCidade.Rows.Add(lista[i].pk_codigo, lista[i].nome, lista[i].fk_uf, lista[i].ibge);
            }
        }

        private void limparCampos()
        {
            txtibge.Text = "";
            txtNome.Text = "";
            cboUF.SelectedIndex = -1;
            _cidadeVO.pk_codigo = 0;
        }

        private void dgvCidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _cidadeVO.pk_codigo = Convert.ToInt32(dgvCidade.Rows[dgvCidade.CurrentRow.Index].Cells[0].Value);
            txtNome.Text = Convert.ToString(dgvCidade.Rows[dgvCidade.CurrentRow.Index].Cells[1].Value);
            cboUF.Text = Convert.ToString(dgvCidade.Rows[dgvCidade.CurrentRow.Index].Cells[2].Value);
            txtibge.Text = Convert.ToString(dgvCidade.Rows[dgvCidade.CurrentRow.Index].Cells[3].Value);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                _cidadeVO.nome = txtNome.Text;
                lista = _cidadeBO.buscarCidade(_cidadeVO);

                if (lista.Count == 0)
                {
                    if (_cidadeBO.gravarCidade(preencherObjeto()))
                    {
                        MessageBox.Show("Cidade cadastrada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparCampos();

                        FrmCidade_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Descrição Inválida! Descrição ja cadastrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtibge.Text) || String.IsNullOrEmpty(cboUF.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal CidadeVO preencherObjeto()
        {
            _cidadeVO.nome = txtNome.Text;
            _cidadeVO.ibge = Convert.ToInt32(txtibge.Text);
            _cidadeVO.fk_uf = (cboUF.SelectedItem as EstadoVO).uf;
            return _cidadeVO; 
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validarCampos() && _cidadeVO.pk_codigo > 0)
            {
                _cidadeVO.nome = txtNome.Text;
                lista = _cidadeBO.buscarCidade(_cidadeVO);

                if (lista.Count == 0 || lista[0].pk_codigo == _cidadeVO.pk_codigo)
                {
                    if (_cidadeBO.alterarCidade(preencherObjeto()))
                    {
                        MessageBox.Show("Cidade alterada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparCampos();

                        FrmCidade_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Descrição Inválida! Descrição ja cadastrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!validarCampos() || _cidadeVO.pk_codigo == 0)
            {
                MessageBox.Show("Selecione uma Cidade antes de excluir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esta Cidade?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            //_cidadeVO.pk_codigo = Convert.ToInt32(dgvCidade.Rows[dgvCidade.CurrentRow.Index].Cells[0].Value);

            _cidadeBO.excluirCidade(_cidadeVO);

            MessageBox.Show("Cidade excluída com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparCampos();

            FrmCidade_Load(null, null);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
