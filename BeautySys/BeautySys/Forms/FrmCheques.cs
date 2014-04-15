using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeautySys.Util;
using BeautySys.Classes;
using BeautySys.DataAccess;
using BeautySys.DataAccess.Util;
using BeautySys.Business;

namespace BeautySys.Forms
{
    public partial class FrmCheques : Form
    {
        List<ChequeVO> lista = new List<ChequeVO>();
        ChequeBO _chequeBO = new ChequeBO();
        ChequeVO _chequeVO = new ChequeVO();

        public FrmCheques()
        {
            InitializeComponent();
        }

#region "Métodos"

        public void limparObjetos()
        {
            txbBanco.Clear();
            txbCliente.Clear();
            txbNumero.Clear();
            txbValor.Clear();
            mtxbDtEmissao.Clear();
            mtxbDtVencimento.Clear();
            cboSituação.Text = "";
            GC.Collect();
        }

        private void preencherDtgrid()
        {
            limparObjetos();

            lista = _chequeBO.buscarCheque(new ChequeVO());

            dgvCheques.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvCheques.Rows.Add(lista[i].pk_codigo, lista[i].nro, lista[i].banco ,lista[i].valor);
            }

            dgvCheques.Refresh();
        }

        internal ChequeVO preencherObjeto()
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
            _chequeVO.pk_codigo = Convert.ToInt32(txtCodigo.Text);
            _chequeVO.dt_emissao = Convert.ToDateTime(mtxbDtEmissao.Text);
            _chequeVO.dt_vencimento = Convert.ToDateTime(mtxbDtVencimento.Text);
            _chequeVO.nro = Convert.ToInt32(txbNumero.Text);
            _chequeVO.banco = txbBanco.Text.ToString();
            _chequeVO.situacao = (cboSituação.SelectedItem as ChequeVO).situacao;
            _chequeVO.valor = Convert.ToDecimal(txbValor.Text);          

            return _chequeVO;
        }

        private void preencheCboSituacao()
        {
            ChequeBO _chequeBO = new ChequeBO();
            var list = _chequeBO.buscarCheque(new ChequeVO());
            list.Insert(0, new ChequeVO());
            cboSituação.DataSource = list;
            cboSituação.DisplayMember = "SITUACAO";
            cboSituação.ValueMember = "SITUACAO";
        }
#endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparObjetos();
            mtxbDtEmissao.Focus();
        }

        private void FrmCheques_Load(object sender, EventArgs e)
        {
            preencherDtgrid();
            preencheCboSituacao();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbCliente.Text))
            {
                MessageBox.Show("Preencha o nome do Cliente antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //_chequeVO.fk_cliente = txtNome.Text;
                lista = _chequeBO.buscarCheque(_chequeVO);

                if (lista.Count == 0)
                {
                    if (_chequeBO.gravarCheque(preencherObjeto()))
                    {
                        MessageBox.Show("Serviço cadastrado com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparObjetos();

                        FrmCheques_Load(null, null);
                        //habilitaComponentes(false);
                    }
                }
                else
                {
                    MessageBox.Show("Serviço Inválido! Descrição ja cadastrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um cheque antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _chequeBO.alterarCheque(preencherObjeto());

            MessageBox.Show("Serviço alterado com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmCheques_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um cheque antes de excluir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este Cheque?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            
            _chequeBO.excluirCheque(preencherObjeto());

            MessageBox.Show("Cheque excluído com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmCheques_Load(null, null);
        }

        private void dgvCheques_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _chequeVO.pk_codigo = Convert.ToInt32(dgvCheques.Rows[dgvCheques.CurrentRow.Index].Cells[0].Value);
            lista = _chequeBO.buscarCheque(_chequeVO);
            if (lista.Count > 0)
            {
                txtCodigo.Text = lista[0].pk_codigo.ToString();
                mtxbDtEmissao.Text = lista[0].dt_emissao.ToString();
                mtxbDtVencimento.Text = lista[0].dt_vencimento.ToString();
                txbNumero.Text = lista[0].nro.ToString();
                txbBanco.Text = lista[0].banco.ToString();
                cboSituação.SelectedValue = lista[0].situacao;
                txbCliente.Text = lista[0].cliente.ToString();
                txbValor.Text = lista[0].valor.ToString();
            }
        }
    }
}
