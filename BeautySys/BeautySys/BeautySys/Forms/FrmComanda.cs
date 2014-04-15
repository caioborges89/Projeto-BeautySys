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
    public partial class FrmComanda : Form
    {
        Funcoes _funcoes = new Funcoes();

        ComandaVO _comandaVO = new ComandaVO();
        ComandaBO _comandaBO = new ComandaBO();
        ItemComandaVO _itemComandaVO = new ItemComandaVO();
        ItemComandaBO _itemComandaBO = new ItemComandaBO();
        //ParcelaComandaVO _parcelaComandaVO = new ParcelaComandaVO();
        //ParcelaComandaBO _parcelaComandaBO = new ParcelaComandaBO();
        CReceberVO _cReceberVO = new CReceberVO();
        CReceberBO _cReceberBO = new CReceberBO();

        FormaPagtoBO _formaPagtoBO = new FormaPagtoBO();
        FormaPagtoVO _formaPagtoVO = new FormaPagtoVO();

        public FrmComanda()
        {
            InitializeComponent();
            preencherComboBox();
        }

        private void preencherComboBox()
        {
            ProfissionalBO _profissionalBO = new ProfissionalBO();
            var list = _profissionalBO.buscarProfissional(new ProfissionalVO());
            list.Insert(0, new ProfissionalVO());
            cboProfissional.DataSource = list;
            cboProfissional.DisplayMember = "NOME";
            cboProfissional.ValueMember = "PK_CODIGO";

            FormaPagtoBO _formaPagtoBO = new FormaPagtoBO();
            var listFP = _formaPagtoBO.buscarFormaPagto(new FormaPagtoVO());
            listFP.Insert(0, new FormaPagtoVO());
            cboFormaPagto.DataSource = listFP;
            cboFormaPagto.DisplayMember = "DESCRICAO";
            cboFormaPagto.ValueMember = "PK_CODIGO";

        }

        private void txtNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(txtNomeCliente.Text))
                {
                    PesquisaVO.nome = txtNomeCliente.Text;
                    PesquisaVO.codigo = 0;
                    FrmPesquisaCliente frmPesquisaCliente = new FrmPesquisaCliente();
                    frmPesquisaCliente.ShowDialog();
                    
                    if (PesquisaVO.codigo > 0 && !String.IsNullOrEmpty(PesquisaVO.nome))
                    {
                        txtNomeCliente.Text = PesquisaVO.nome;
                        txtCodigoCliente.Text = Convert.ToString(PesquisaVO.codigo);
                        txtNomeCliente.Enabled = false;
                        txtCodigoCliente.Enabled = false;
                    }
                    else
                    {
                        txtCodigoCliente.Text = "";
                        txtNomeCliente.Text = "";
                    }
                }
            }
        }

        private void txtCodigoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(txtCodigoCliente.Text))
                {
                    PesquisaVO.codigo = Convert.ToInt32(txtCodigoCliente.Text);
                    PesquisaVO.nome = "";
                    FrmPesquisaCliente frmPesquisaCliente = new FrmPesquisaCliente();
                    frmPesquisaCliente.ShowDialog();

                    if (PesquisaVO.codigo > 0 && !String.IsNullOrEmpty(PesquisaVO.nome))
                    {
                        txtNomeCliente.Text = PesquisaVO.nome;
                        txtCodigoCliente.Text = Convert.ToString(PesquisaVO.codigo);
                        txtNomeCliente.Enabled = false;
                        txtCodigoCliente.Enabled = false;
                    }
                    else
                    {
                        txtCodigoCliente.Text = "";
                        txtNomeCliente.Text = "";
                    }

                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = "";
            txtNomeCliente.Enabled = true;
            txtCodigoCliente.Text = "";
            txtCodigoCliente.Enabled = true;
        }

        private void txtDescricaoProdServ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(txtDescricaoProdServ.Text))
                {
                    PesquisaVO.nome = txtDescricaoProdServ.Text;
                    PesquisaVO.codigo = 0;
                    if (rbProduto.Checked == true)
                    {
                        PesquisaVO.tipo = "P";
                    }
                    else
                    {
                        PesquisaVO.tipo = "S";
                    }
                    FrmPesquisaProdServ frmPesquisaProdServ = new FrmPesquisaProdServ();
                    frmPesquisaProdServ.ShowDialog();

                    if (PesquisaVO.codigo > 0 && !String.IsNullOrEmpty(PesquisaVO.nome))
                    {
                        txtDescricaoProdServ.Text = PesquisaVO.nome;
                        txtCodigoProdServ.Text = Convert.ToString(PesquisaVO.codigo);
                        txtValorProdServ.Text = Convert.ToString(PesquisaVO.valor);
                        txtDescricaoProdServ.Enabled = false;
                        txtCodigoProdServ.Enabled = false;
                        txtValorProdServ.Enabled = false;
                        gpbProdServ.Enabled = false;
                        txtQuantidade.Text = "1";
                    }
                    else
                    {
                        txtDescricaoProdServ.Text = "";
                        txtCodigoProdServ.Text = "";
                        txtValorProdServ.Text = "";
                        txtQuantidade.Text = "";
                    }
                }
            }
        }

        private void btnLimparProdServ_Click(object sender, EventArgs e)
        {
            limparProdServ();
        }

        private void limparProdServ()
        {
            txtDescricaoProdServ.Text = "";
            txtDescricaoProdServ.Enabled = true;
            txtCodigoProdServ.Text = "";
            txtCodigoProdServ.Enabled = true;
            txtValorProdServ.Text = "";
            txtValorProdServ.Enabled = true;
            gpbProdServ.Enabled = true;
            txtDescReal.Text = "0,00";
            txtDescPerc.Text = "0,00";
            txtQuantidade.Text = "";
        }

        private void txtCodigoProdServ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(txtCodigoProdServ.Text))
                {
                    PesquisaVO.nome = "";
                    PesquisaVO.codigo = Convert.ToInt32(txtCodigoProdServ.Text);
                    if (rbProduto.Checked == true)
                    {
                        PesquisaVO.tipo = "P";
                    }
                    else
                    {
                        PesquisaVO.tipo = "S";
                    }
                    FrmPesquisaProdServ frmPesquisaProdServ = new FrmPesquisaProdServ();
                    frmPesquisaProdServ.ShowDialog();

                    if (PesquisaVO.codigo > 0 && !String.IsNullOrEmpty(PesquisaVO.nome))
                    {
                        txtDescricaoProdServ.Text = PesquisaVO.nome;
                        txtCodigoProdServ.Text = Convert.ToString(PesquisaVO.codigo);
                        txtValorProdServ.Text = Convert.ToString(PesquisaVO.valor);
                        txtDescricaoProdServ.Enabled = false;
                        txtCodigoProdServ.Enabled = false;
                        txtValorProdServ.Enabled = false;
                        gpbProdServ.Enabled = false;
                        txtQuantidade.Text = "1";
                    }
                    else
                    {
                        txtDescricaoProdServ.Text = "";
                        txtCodigoProdServ.Text = "";
                        txtValorProdServ.Text = "";
                        txtQuantidade.Text = "";
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string prodServAux;

            double totalProdServ;

            if (validarCamposProdServ())
            {
                totalProdServ = Convert.ToDouble(txtValorProdServ.Text) * Convert.ToDouble(txtQuantidade.Text) - Convert.ToDouble(txtDescReal.Text);

                if (rbProduto.Checked == true)
                {
                    prodServAux = "P";
                }
                else
                {
                    prodServAux = "S";
                }

                dgvComanda.Rows.Add(txtCodigoProdServ.Text, txtDescricaoProdServ.Text, prodServAux, txtValorProdServ.Text, txtQuantidade.Text, txtDescReal.Text, totalProdServ);

                //txtValorTotal.Text = Convert.ToString(Convert.ToDouble(txtValorTotal.Text) + totalProdServ);

                txtValorTotal.Text = "0,00";//Zera para preencher de novo
                for (int i = 0; i < dgvComanda.RowCount; i++)
                {
                    txtValorTotal.Text = Convert.ToString(Convert.ToDecimal(txtValorTotal.Text) + Convert.ToDecimal(dgvComanda.Rows[i].Cells[6].Value));
                }
                txtDescTotalPerc.Text = "0,00";
                txtDescTotalReal.Text = "0,00";

                limparProdServ();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos antes de registrar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCamposProdServ()
        {        
            if(txtCodigoProdServ.Enabled == false && !String.IsNullOrEmpty(txtQuantidade.Text))
            {
                if (Convert.ToInt32(txtQuantidade.Text) > 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private void txtDescReal_Leave(object sender, EventArgs e)
        {
            double valor;
            double descReal;
            double descPerc;

            if (!String.IsNullOrEmpty(txtQuantidade.Text) && !String.IsNullOrEmpty(txtValorProdServ.Text))
            {
                valor = Convert.ToDouble(txtValorProdServ.Text) * Convert.ToDouble(txtQuantidade.Text);
                descReal = Convert.ToDouble(txtDescReal.Text);
                descPerc = (100 / valor) * descReal;

                txtDescPerc.Text = Convert.ToString(Math.Round(descPerc,2));
            }            
        }

        private void txtDescPerc_Leave(object sender, EventArgs e)
        {
            double valor;
            double descReal;
            double descPerc;

            if (!String.IsNullOrEmpty(txtQuantidade.Text) && !String.IsNullOrEmpty(txtValorProdServ.Text))
            {
                valor = Convert.ToDouble(txtValorProdServ.Text) * Convert.ToDouble(txtQuantidade.Text);
                descPerc = Convert.ToDouble(txtDescPerc.Text);
                descReal = (valor / 100) * descPerc;
                

                txtDescReal.Text = Convert.ToString(Math.Round(descReal, 2));
            }   
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (validarCamposFinaliza())//Finaliza a Comanda
            {
                //Primeiro, verificar se a forma de pagamento é cheque e cadastrar o cheque
                //na tela de cadastro de cheque, pode clicar em cancelar e volta para a tela da comanda sem finalizar

                //Se não for dinheiro, o CReceber tem q ficar como não pago

                if (_comandaBO.gravarComanda(preencherObjetoComanda()))
                {
                    for (int i = 0; i < dgvComanda.RowCount; i++)
                    {
                        _itemComandaBO.gravarComanda(preencherObjetoItemComanda(i));
                    }

                    _cReceberBO.gravarCReceber(preencherObjetoCReceber());

                    MessageBox.Show("Comanda finalizada com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    desabilitarCampos();
                }
            }
        }

        internal ComandaVO preencherObjetoComanda()
        {
            _comandaVO.pk_codigo = Convert.ToInt32(txtNumeroComanda.Text);
            _comandaVO.data = DateTime.Now;
            _comandaVO.fk_cliente = Convert.ToInt32(txtCodigoCliente.Text);
            _comandaVO.fk_profissional = (cboProfissional.SelectedItem as ProfissionalVO).pk_codigo;
            _comandaVO.obs = txtObservacao.Text;
            _comandaVO.valor = Convert.ToDecimal(txtValorTotal.Text);
            _comandaVO.fk_forma_pagto = (cboFormaPagto.SelectedItem as FormaPagtoVO).pk_codigo;
            _comandaVO.desc_total = Convert.ToDecimal(txtDescTotalReal.Text);
            return _comandaVO;
        }

        internal ItemComandaVO preencherObjetoItemComanda(int i)
        {
            _itemComandaVO.fk_comanda = Convert.ToInt32(txtNumeroComanda.Text);
            _itemComandaVO.cod_prod_serv = Convert.ToInt32(dgvComanda.Rows[i].Cells[0].Value);
            _itemComandaVO.prod_serv = dgvComanda.Rows[i].Cells[2].Value.ToString();
            _itemComandaVO.quantidade = Convert.ToDecimal(dgvComanda.Rows[i].Cells[4].Value);
            _itemComandaVO.valor_unitario = Convert.ToDecimal(dgvComanda.Rows[i].Cells[3].Value);
            _itemComandaVO.valor = Convert.ToDecimal(dgvComanda.Rows[i].Cells[6].Value);
            _itemComandaVO.desc_item = Convert.ToDecimal(dgvComanda.Rows[i].Cells[5].Value);
            return _itemComandaVO;
        }

        internal CReceberVO preencherObjetoCReceber()
        {
            List<FormaPagtoVO> listFP = new List<FormaPagtoVO>();
            
            _cReceberVO.fk_comanda = Convert.ToInt32(txtNumeroComanda.Text);
            _cReceberVO.fk_cliente = Convert.ToInt32(txtCodigoCliente.Text);
            _cReceberVO.dt_emissao = DateTime.Now;
            _cReceberVO.dt_vencimento = DateTime.Now;
            _cReceberVO.valor = Convert.ToDecimal(txtValorTotal.Text);
            _cReceberVO.fk_forma_pagto = (cboFormaPagto.SelectedItem as FormaPagtoVO).pk_codigo;

            _formaPagtoVO.pk_codigo = _cReceberVO.fk_forma_pagto;
            listFP = _formaPagtoBO.buscarFormaPagto(_formaPagtoVO);
            if (listFP[0].tipo == "DINHEIRO")//Se for dinheiro, ja passa como pago
            {
                _cReceberVO.dt_pagamento = DateTime.Now;
            }
            return _cReceberVO;
        }

        private void desabilitarCampos()
        {
            txtNomeCliente.Enabled = false;
            txtCodigoCliente.Enabled = false;
            cboProfissional.Enabled = false;
            txtCodigoProdServ.Enabled = false;
            txtDescricaoProdServ.Enabled = false;
            gpbProdServ.Enabled = false;
            txtValorProdServ.Enabled = false;
            txtQuantidade.Enabled = false;
            txtDescReal.Enabled = false;
            txtDescPerc.Enabled = false;
            btnRegistrar.Enabled = false;
            txtObservacao.Enabled = false;
            txtDescTotalPerc.Enabled = false;
            txtDescTotalReal.Enabled = false;
            txtValorTotal.Enabled = false;
            cboFormaPagto.Enabled = false;
            btnLimparProdServ.Enabled = false;
            btnLimparCliente.Enabled = false;
            btnLimpar.Enabled = false;
            btnFinalizar.Enabled = false;
        }

        private bool validarCamposFinaliza()
        {
            if (txtCodigoCliente.Enabled == true)
            {
                MessageBox.Show("Selecione um CLIENTE antes de finalizar a comanda!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(cboProfissional.Text))
            {
                MessageBox.Show("Selecione um PROFISSIONAL antes de finalizar a comanda!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(cboFormaPagto.Text))
            {
                MessageBox.Show("Selecione uma FORMA DE PAGAMENTO antes de finalizar a comanda!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dgvComanda.RowCount <= 0)
            {
                MessageBox.Show("Registre Produtos/Serviços antes de finalizar a comanda!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void FrmComanda_Load(object sender, EventArgs e)
        {
            //Carregar o código da próxima Comanda
            txtNumeroComanda.Text = Convert.ToString(_funcoes.novoCodigo("COMANDA", "PK_CODIGO"));
            mtxbData.Text = DateTime.Now.ToString();
        }

        private void txtDescTotalReal_Leave(object sender, EventArgs e)
        {
            double valor;
            double descReal;
            double descPerc;

            if (!String.IsNullOrEmpty(txtValorTotal.Text))
            {
                if (Convert.ToDouble(txtValorTotal.Text) > 0.00)
                {
                    txtValorTotal.Text = "0,00";//Zera para preencher de novo

                    for (int i = 0; i < dgvComanda.RowCount; i++)
                    {
                        txtValorTotal.Text = Convert.ToString(Convert.ToDecimal(txtValorTotal.Text) + Convert.ToDecimal(dgvComanda.Rows[i].Cells[6].Value));
                    }

                    valor = Convert.ToDouble(txtValorTotal.Text);
                    descReal = Convert.ToDouble(txtDescTotalReal.Text);
                    descPerc = (100 / valor) * descReal;

                    txtDescTotalPerc.Text = Convert.ToString(Math.Round(descPerc, 2));

                    txtValorTotal.Text = Convert.ToString(Convert.ToDouble(txtValorTotal.Text) - Convert.ToDouble(txtDescTotalReal.Text));
                }
            } 
        }

        private void txtDescTotalPerc_Leave(object sender, EventArgs e)
        {
            double valor;
            double descReal;
            double descPerc;

            if (!String.IsNullOrEmpty(txtValorTotal.Text))
            {
                if (Convert.ToDouble(txtValorTotal.Text) > 0.00)
                {
                    txtValorTotal.Text = "0,00";//Zera para preencher de novo

                    for (int i = 0; i < dgvComanda.RowCount; i++)
                    {
                        txtValorTotal.Text = Convert.ToString(Convert.ToDecimal(txtValorTotal.Text) + Convert.ToDecimal(dgvComanda.Rows[i].Cells[6].Value));
                    }

                    valor = Convert.ToDouble(txtValorTotal.Text);
                    descPerc = Convert.ToDouble(txtDescTotalPerc.Text);
                    descReal = (valor / 100) * descPerc;

                    txtDescTotalReal.Text = Convert.ToString(Math.Round(descReal, 2));

                    txtValorTotal.Text = Convert.ToString(Convert.ToDouble(txtValorTotal.Text) - Convert.ToDouble(txtDescTotalReal.Text));
                }
                
            }   
        }
    }
}
