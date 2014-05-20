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
        private Int64 codCli = 0;

        List<ChequeVO> lista = new List<ChequeVO>();
        ChequeBO _chequeBO = new ChequeBO();
        ChequeVO _chequeVO = new ChequeVO();
        ClienteDA _clienteDA = new ClienteDA();

        List<SituacaoChequeVO> listaSituacao = new List<SituacaoChequeVO>();
        SituacaoChequeBO _situacaoChequeBO = new SituacaoChequeBO();
        SituacaoChequeVO _situacaoChequeVO = new SituacaoChequeVO();

        public FrmCheques()
        {
            InitializeComponent();
            atualizarDtgrid();
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

        private void atualizarDtgrid()
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
            _chequeVO.fk_cliente = Convert.ToInt32(codCli);
            _chequeVO.situacao = Convert.ToInt32((cboSituação.SelectedItem as SituacaoChequeVO).pk_codigo);
            _chequeVO.valor = Convert.ToDecimal(txbValor.Text);          

            return _chequeVO;
        }

        private void preencheCboSituacao()
        {
            SituacaoChequeBO _situacaoChequeBO = new SituacaoChequeBO();
            var list = _situacaoChequeBO.buscarSituacaoCheque(new SituacaoChequeVO());
            list.Insert(0, new SituacaoChequeVO());
            cboSituação.DataSource = list;
            cboSituação.DisplayMember = "DESCRICAO";
            cboSituação.ValueMember = "PK_CODIGO";
        }

        private bool validarCamposPesquisa()
        {
            if (mtxbEmisIni.Text.ToString().Length > 6 || mtxbEmisFin.Text.ToString().Length > 6)
            {
                if ((mtxbEmisIni.Text.ToString().Length < 10 && mtxbEmisIni.Text.ToString().Length >= 6) || (mtxbEmisFin.Text.ToString().Length < 10 && mtxbEmisFin.Text.ToString().Length >= 6))
                {
                    MessageBox.Show("Preenche o inicio e o final da data de emissão!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (mtxbVencIni.Text.ToString().Length > 6 || mtxbVencFin.Text.ToString().Length > 6)
            {
                if ((mtxbVencIni.Text.ToString().Length < 10 && mtxbVencIni.Text.ToString().Length >= 6) || (mtxbVencFin.Text.ToString().Length < 10 && mtxbVencFin.Text.ToString().Length >= 6))
                {
                    MessageBox.Show("Preenche o inicio e o final da data de vencimento!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }


        internal ChequeVO preencherObjetoPesquisa()
        {
            if (rbaberto.Checked)
                _chequeVO.criterio = rbaberto.Text;

            if (rbbaixado.Checked)
                _chequeVO.criterio = rbbaixado.Text;

            if (rbtodos.Checked)
                _chequeVO.criterio = rbtodos.Text;

            if (rbdevolvido.Checked)
                _chequeVO.criterio = rbdevolvido.Text; 

            //if (!String.IsNullOrEmpty(mtxbEmisIni.Text) && !String.IsNullOrEmpty(mtxbEmisFin.Text))
            if (mtxbEmisIni.Text.ToString().Length >= 10 && mtxbEmisFin.Text.ToString().Length >= 10)
            {
                _chequeVO.dt_emissao_ini = Convert.ToDateTime(mtxbEmisIni.Text);
                _chequeVO.dt_emissao_fim = Convert.ToDateTime(mtxbEmisFin.Text);
            }
            else
            {
                _chequeVO.dt_emissao_ini = Convert.ToDateTime(null);
                _chequeVO.dt_emissao_fim = Convert.ToDateTime(null);
            }

            if (mtxbVencIni.Text.ToString().Length >= 10 && mtxbVencFin.Text.ToString().Length >= 10)
            {
                _chequeVO.dt_vencimento_ini = Convert.ToDateTime(mtxbVencIni.Text);
                _chequeVO.dt_vencimento_fim = Convert.ToDateTime(mtxbVencFin.Text);
            }
            else
            {
                _chequeVO.dt_vencimento_ini = Convert.ToDateTime(null);
                _chequeVO.dt_vencimento_fim = Convert.ToDateTime(null);
            }
            return _chequeVO;
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
            preencheCboSituacao();
            atualizarDtgrid();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbCliente.Text))
            {
                MessageBox.Show("Preencha o nome do Cliente antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lista = _chequeBO.buscarCheque(_chequeVO);

                    if (_chequeBO.gravarCheque(preencherObjeto()))
                    {
                        MessageBox.Show("Cheque cadastrado com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparObjetos();

                        FrmCheques_Load(null, null);
                        atualizarDtgrid();
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
            _chequeVO.nro = Convert.ToInt32(dgvCheques.Rows[dgvCheques.CurrentRow.Index].Cells[0].Value);
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
                codCli = Convert.ToInt32(lista[0].fk_cliente);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (validarCamposPesquisa())
            {
                preencherObjetoPesquisa();

                string dt_emissao = "";
                limparObjetos();

                lista = _chequeBO.buscarCheque(_chequeVO);

                dgvCheques.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (!lista[i].dt_emissao.ToString("dd/MM/yyyy").Equals("01/01/0001"))
                    {
                        dt_emissao = lista[i].dt_emissao.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        dt_emissao = "";
                    }
                    dgvCheques.Rows.Add(lista[i].pk_codigo, lista[i].nro, lista[i].banco, lista[i].valor);
                }
            }
        }

        private void txbCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(txbCliente.Text))
                {
                    PesquisaVO.nome = txbCliente.Text;
                    PesquisaVO.codigo = 0;
                    FrmPesquisaCliente frmPesquisaCliente = new FrmPesquisaCliente();
                    frmPesquisaCliente.ShowDialog();

                    if (PesquisaVO.codigo > 0 && !String.IsNullOrEmpty(PesquisaVO.nome))
                    {
                        txbCliente.Text = PesquisaVO.nome;
                        codCli = PesquisaVO.codigo;
                    }
                    else
                    {
                        txbCliente.Text = "";
                        codCli = 0;
                    }
                }
            }
        }
    }
}
