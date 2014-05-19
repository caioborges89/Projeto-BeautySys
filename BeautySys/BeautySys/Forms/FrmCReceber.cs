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
    public partial class FrmCReceber : Form
    {
        private int codCli = 0;

        List<CReceberVO> lista;
        CReceberBO _cReceberBO = new CReceberBO();
        CReceberVO _cReceberVO = new CReceberVO();

        FormaPagtoBO _formaPagtoBO = new FormaPagtoBO();
        FormaPagtoVO _formaPagtoVO = new FormaPagtoVO();

        public FrmCReceber()
        {
            InitializeComponent();
            preencherComboBox();
        }

        private void preencherComboBox()
        {
            FormaPagtoBO _formaPagtoBO = new FormaPagtoBO();
            var listFP = _formaPagtoBO.buscarFormaPagto(new FormaPagtoVO());
            listFP.Insert(0, new FormaPagtoVO());
            cboFormaPagto.DataSource = listFP;
            cboFormaPagto.DisplayMember = "DESCRICAO";
            cboFormaPagto.ValueMember = "PK_CODIGO";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCReceber_Load(object sender, EventArgs e)
        {
            string dt_pagto = "";
            string notaFiscal = "";
            limparCampos();

            lista = _cReceberBO.buscarCReceber(new CReceberVO());

            dgvCReceber.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                if (!lista[i].dt_pagamento.ToString("dd/MM/yyyy").Equals("01/01/0001"))
                {
                    dt_pagto = lista[i].dt_pagamento.ToString("dd/MM/yyyy");
                }
                else
                {
                    dt_pagto = "";
                }
                //NOTA_FICAL
                if (lista[i].nota_fiscal > 0)
                {
                    notaFiscal = Convert.ToString(lista[i].nota_fiscal);
                }
                else
                {
                    notaFiscal = "";
                }

                dgvCReceber.Rows.Add(lista[i].pk_codigo, lista[i].cliente, lista[i].valor, lista[i].dt_vencimento.ToString("dd/MM/yyyy"), lista[i].dt_emissao.ToString("dd/MM/yyyy"), dt_pagto, lista[i].fk_comanda, lista[i].forma_pagto, notaFiscal, lista[i].serie, lista[i].fk_cliente);
            }
        }

        private void limparCampos()
        {
            txbCodigo.Text = "";
            txbCliente.Text = "";
            txbValor.Text = "";
            mtxbVencimento.Text = "";
            mtxbEmissa.Text = "";
            mtxbPagamento.Text = "";
            txbComanda.Text = "";
            cboFormaPagto.SelectedIndex = -1;
            txbDuplicata.Text = "";
            txbSerie.Text = "";
            codCli = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void dgvCReceber_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigo.Text = Convert.ToString(dgvCReceber.Rows[dgvCReceber.CurrentRow.Index].Cells[0].Value);
            txbCliente.Text = Convert.ToString(dgvCReceber.Rows[dgvCReceber.CurrentRow.Index].Cells[1].Value);
            txbValor.Text = Convert.ToString(dgvCReceber.Rows[dgvCReceber.CurrentRow.Index].Cells[2].Value);
            mtxbVencimento.Text = Convert.ToString(dgvCReceber.Rows[dgvCReceber.CurrentRow.Index].Cells[3].Value);
            mtxbEmissa.Text = Convert.ToString(dgvCReceber.Rows[dgvCReceber.CurrentRow.Index].Cells[4].Value);
            mtxbPagamento.Text = Convert.ToString(dgvCReceber.Rows[dgvCReceber.CurrentRow.Index].Cells[5].Value);
            if (Convert.ToInt32(dgvCReceber.Rows[dgvCReceber.CurrentRow.Index].Cells[6].Value) > 0)
            {
                txbComanda.Text = Convert.ToString(dgvCReceber.Rows[dgvCReceber.CurrentRow.Index].Cells[6].Value);
            }
            cboFormaPagto.Text = Convert.ToString(dgvCReceber.Rows[dgvCReceber.CurrentRow.Index].Cells[7].Value);
            txbDuplicata.Text = Convert.ToString(dgvCReceber.Rows[dgvCReceber.CurrentRow.Index].Cells[8].Value);
            txbSerie.Text = Convert.ToString(dgvCReceber.Rows[dgvCReceber.CurrentRow.Index].Cells[9].Value);
            codCli = Convert.ToInt32(dgvCReceber.Rows[dgvCReceber.CurrentRow.Index].Cells[10].Value);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (validarCamposPesquisa())
            {
                preencherObjetoPesquisa();

                string dt_pagto = "";
                string notaFiscal = "";
                limparCampos();

                lista = _cReceberBO.buscarCReceber(_cReceberVO);

                dgvCReceber.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (!lista[i].dt_pagamento.ToString("dd/MM/yyyy").Equals("01/01/0001"))
                    {
                        dt_pagto = lista[i].dt_pagamento.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        dt_pagto = "";
                    }
                    //NOTA_FICAL
                    if (lista[i].nota_fiscal > 0)
                    {
                        notaFiscal = Convert.ToString(lista[i].nota_fiscal);
                    }
                    else
                    {
                        notaFiscal = "";
                    }

                    dgvCReceber.Rows.Add(lista[i].pk_codigo, lista[i].cliente, lista[i].valor, lista[i].dt_vencimento.ToString("dd/MM/yyyy"), lista[i].dt_emissao.ToString("dd/MM/yyyy"), dt_pagto, lista[i].fk_comanda, lista[i].forma_pagto, notaFiscal, lista[i].serie);
                }
            }
            
        }

        internal CReceberVO preencherObjetoPesquisa()
        {
            if (rbAberto.Checked)
                _cReceberVO.criterio = rbAberto.Text;

            if (rbBaixada.Checked)
                _cReceberVO.criterio = rbBaixada.Text;

            if (rbTodas.Checked)
                _cReceberVO.criterio = rbTodas.Text;

            //if (!String.IsNullOrEmpty(mtxbEmisIni.Text) && !String.IsNullOrEmpty(mtxbEmisFin.Text))
            if (mtxbEmisIni.Text.ToString().Length >= 10 && mtxbEmisFin.Text.ToString().Length >= 10)
            {
                _cReceberVO.dt_emissao_ini = Convert.ToDateTime(mtxbEmisIni.Text);
                _cReceberVO.dt_emissao_fim = Convert.ToDateTime(mtxbEmisFin.Text);
            }
            else
            {
                _cReceberVO.dt_emissao_ini = Convert.ToDateTime(null);
                _cReceberVO.dt_emissao_fim = Convert.ToDateTime(null);
            }

            if (mtxbVencIni.Text.ToString().Length >= 10 && mtxbVencFin.Text.ToString().Length >= 10)
            {
                _cReceberVO.dt_vencimento_ini = Convert.ToDateTime(mtxbVencIni.Text);
                _cReceberVO.dt_vencimento_fim = Convert.ToDateTime(mtxbVencFin.Text);
            }
            else
            {
                _cReceberVO.dt_vencimento_ini = Convert.ToDateTime(null);
                _cReceberVO.dt_vencimento_fim = Convert.ToDateTime(null);
            }
            return _cReceberVO;
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

        private bool validarCampos()
        {
            if (codCli == 0)
            {
                MessageBox.Show("Selecione um Cliente válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(txbValor.Text))
            {
                MessageBox.Show("Informe um valor!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (mtxbVencimento.Text.ToString().Length < 10)
            {
                MessageBox.Show("Informe uma data de vencimento!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (mtxbEmissa.Text.ToString().Length < 10)
            {
                MessageBox.Show("Informe uma data de emissão!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(cboFormaPagto.Text))
            {
                MessageBox.Show("Informe uma forma de pagamento!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (mtxbPagamento.Text.ToString().Length >= 10)
            {
                MessageBox.Show("Conta Inválida! Baixa ja foi efetuada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(txbCodigo.Text))
            {
                MessageBox.Show("Selecione uma Conta antes de excluir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esta Conta?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            _cReceberBO.excluirCReceber(preencherObjeto());

            MessageBox.Show("Conta excluída com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparCampos();

            FrmCReceber_Load(null, null);
        }

        internal CReceberVO preencherObjeto()
        {
            if (!String.IsNullOrEmpty(txbCodigo.Text))
                _cReceberVO.pk_codigo = Convert.ToInt32(txbCodigo.Text);
            if (!String.IsNullOrEmpty(txbComanda.Text))
                _cReceberVO.fk_comanda = Convert.ToInt32(txbComanda.Text);
            if (!String.IsNullOrEmpty(txbDuplicata.Text))
                _cReceberVO.nota_fiscal = Convert.ToInt32(txbDuplicata.Text);
            if (!String.IsNullOrEmpty(txbSerie.Text))
                _cReceberVO.serie = txbSerie.Text;
            _cReceberVO.fk_cliente = codCli;
            _cReceberVO.dt_emissao = Convert.ToDateTime(mtxbEmissa.Text);
            _cReceberVO.dt_vencimento = Convert.ToDateTime(mtxbVencimento.Text);
            _cReceberVO.valor = Convert.ToDecimal(txbValor.Text);
            if (mtxbPagamento.Text.ToString().Length > 10)
                _cReceberVO.dt_pagamento = Convert.ToDateTime(mtxbPagamento.Text);
            _cReceberVO.fk_forma_pagto = (cboFormaPagto.SelectedItem as FormaPagtoVO).pk_codigo;
            
            return _cReceberVO;
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

        private void txbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            codCli = 0;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbCodigo.Text))
            {
                MessageBox.Show("Selecione uma Conta antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (codCli == 0)
            {
                MessageBox.Show("Selecione um Cliente válido antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (validarCampos())
            {
                _cReceberBO.alterarCReceber(preencherObjeto());

                MessageBox.Show("Conta alterada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmCReceber_Load(null, null);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                _cReceberBO.gravarCReceber(preencherObjeto());

                MessageBox.Show("Conta Gravada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmCReceber_Load(null, null);
            }
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbCodigo.Text))
            {
                MessageBox.Show("Selecione uma Conta antes de baixar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mtxbPagamento.Text.ToString().Length >= 10)
            {
                MessageBox.Show("Conta já baixada anteriormente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _cReceberVO.pk_codigo = Convert.ToInt32(txbCodigo.Text);
            _cReceberVO.dt_pagamento = DateTime.Now;

            _cReceberBO.baixarCReceber(_cReceberVO);

            MessageBox.Show("Conta Baixada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmCReceber_Load(null, null);
        }
    }
}

