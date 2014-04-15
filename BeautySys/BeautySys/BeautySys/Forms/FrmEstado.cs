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
    public partial class FrmEstado : Form
    {
        List<EstadoVO> lista;
        EstadoBO _estadoBO = new EstadoBO();
        EstadoVO _estadoVO = new EstadoVO();

        public FrmEstado()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEstado_Load(object sender, EventArgs e)
        {
            limparCampos();

            lista = _estadoBO.buscarEstado(new EstadoVO());

            dgvEstado.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvEstado.Rows.Add(lista[i].uf, lista[i].nome);
            }
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtSigla.Text = "";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtSigla.Text))
            {
                MessageBox.Show("Preencha o NOME e a SIGLA antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _estadoVO.uf = txtSigla.Text;
                lista = _estadoBO.buscarEstado(_estadoVO);

                if (lista.Count == 0)
                {
                    if (_estadoBO.gravarEstado(preencherObjeto()))
                    {
                        MessageBox.Show("Descrição cadastrada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparCampos();

                        FrmEstado_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Estado Inválido! UF ja cadastrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        internal EstadoVO preencherObjeto()
        {
            _estadoVO.uf = txtSigla.Text;
            txtSigla.Enabled = true; 
            _estadoVO.nome = txtNome.Text;
            return _estadoVO; 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void dgvEstado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSigla.Text = Convert.ToString(dgvEstado.Rows[dgvEstado.CurrentRow.Index].Cells[0].Value);
            txtSigla.Enabled = false; 
            txtNome.Text = Convert.ToString(dgvEstado.Rows[dgvEstado.CurrentRow.Index].Cells[1].Value);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtSigla.Text))
            {
                MessageBox.Show("Selecione um ESTADO antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _estadoBO.alterarEstado(preencherObjeto());

            MessageBox.Show("Estado alterado com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmEstado_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtSigla.Text))
            {
                MessageBox.Show("Selecione um ESTADO antes de excluir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este Estado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            _estadoVO.uf = Convert.ToString(dgvEstado.Rows[dgvEstado.CurrentRow.Index].Cells[0].Value);

            _estadoBO.excluirEstado(_estadoVO);

            MessageBox.Show("Estado excluído com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmEstado_Load(null, null);
        }
    }
}
