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
    public partial class FrmMedida : Form
    {
        List<MedidaVO> lista = new List<MedidaVO>();
        MedidaBO _medidaBO = new MedidaBO();
        MedidaVO _medidaVO = new MedidaVO();

        public FrmMedida()
        {
            InitializeComponent();
        }

#region "Métodos"

        private void limparObjetos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            GC.Collect();            
        }

        private void preencherDtgrid()
        {
            limparObjetos();

            lista = _medidaBO.buscarMedida(new MedidaVO());

            dgvUnidadeMedida.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvUnidadeMedida.Rows.Add(lista[i].pk_medida, lista[i].nome);
            }

            dgvUnidadeMedida.Refresh();
        }

        internal MedidaVO preencherObjeto()
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
                _medidaVO.pk_medida = txtCodigo.Text;
            _medidaVO.nome = txtNome.Text;
            return _medidaVO;
        }

        /// <summary>
        /// Método que habilita ou desabilita os componentes
        /// do formulário.
        /// </summary>
        /// Se flag for igual a true, os componentes são 
        /// habilitados, se for false, são desabilitados.
        /// <param name="flag"></param>
        private void habilitaComponentes(bool flag)
        {
            if (flag)
            {
                btnExcluir.Enabled = true;
                btnGravar.Enabled = true;               
                txtNome.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
                btnGravar.Enabled = false;                
                txtNome.Enabled = false;
            }
        }

#endregion

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //habilitaComponentes(true);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione uma descrição antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _medidaBO.alterarMedida(preencherObjeto());

            MessageBox.Show("Descrição alterada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmMedida_Load(null, null);
        }

        private void FrmMedida_Load(object sender, EventArgs e)
        {
            preencherDtgrid();
            //habilitaComponentes(false);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione uma descrição antes de excluir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esta Descrição?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            //_medidaVO.pk_medida = txtCodigo.Text;

            _medidaBO.excluirMedida(preencherObjeto());

            MessageBox.Show("Descrição excluída com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmMedida_Load(null, null);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            //habilitaComponentes(true);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preencha a DESCRICAO antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _medidaVO.nome = txtNome.Text;
                lista = _medidaBO.buscarMedida(_medidaVO);

                if (lista.Count == 0)
                {
                    if (_medidaBO.gravarMedida(preencherObjeto()))
                    {
                        MessageBox.Show("Descrição cadastrada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparObjetos();

                        FrmMedida_Load(null, null);
                        //habilitaComponentes(false);
                    }
                }
                else
                {
                    MessageBox.Show("Descrição Inválida! Descrição ja cadastrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }

        private void dgvUnidadeMedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = Convert.ToString(dgvUnidadeMedida.Rows[dgvUnidadeMedida.CurrentRow.Index].Cells[0].Value);
            txtNome.Text = Convert.ToString(dgvUnidadeMedida.Rows[dgvUnidadeMedida.CurrentRow.Index].Cells[1].Value);
        }
    }
}
