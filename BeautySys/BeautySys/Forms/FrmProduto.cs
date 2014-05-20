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
    public partial class FrmProduto : Form
    {
        List<ProdutoVO> lista = new List<ProdutoVO>();
        ProdutoBO _produtoBO = new ProdutoBO();
        ProdutoVO _produtoVO = new ProdutoVO();

        public FrmProduto()
        {
            InitializeComponent();
        }

#region "Métodos"

        private void limparObjetos()
        {
            txtCodigo.Clear();
            txtComissao.Clear();
            txtCusto.Clear();
            txtDescMaximo.Clear();
            txtEstoque.Clear();
            txtEstoqueMinino.Clear();
            txtNome.Clear();
            txtObs.Clear();
            txtValor.Clear();
            cbMedida.Text = "";
            cbTipoProduto.Text = "";
            GC.Collect();            
        }

        private void preencherDtgrid()
        {
            limparObjetos();

            lista = _produtoBO.buscarProduto(new ProdutoVO());

            DgvCadProdutos.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                DgvCadProdutos.Rows.Add(lista[i].pk_codigo, lista[i].descricao, lista[i].qtde_estoque, lista[i].valor);
            }

            DgvCadProdutos.Refresh();
        }

        internal ProdutoVO preencherObjeto()
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
                _produtoVO.pk_codigo = Convert.ToInt32(txtCodigo.Text);
            _produtoVO.descricao = txtNome.Text;
            _produtoVO.fk_tipo_produto = (cbTipoProduto.SelectedItem as TipoProdutoVO).pk_codigo;
            _produtoVO.fk_medida = (cbMedida.SelectedItem as MedidaVO).pk_medida;
            if (!String.IsNullOrEmpty(txtEstoque.Text))
            {
                _produtoVO.qtde_estoque = Convert.ToDecimal(txtEstoque.Text);
            }
            else
            {
                _produtoVO.qtde_estoque = 0;
            }
            if (!String.IsNullOrEmpty(txtEstoqueMinino.Text))
            {
                _produtoVO.estoque_minimo = Convert.ToInt32(txtEstoqueMinino.Text);
            }
            else
            {
                _produtoVO.estoque_minimo = 0;
            }
            if (!String.IsNullOrEmpty(txtValor.Text))
            {
                _produtoVO.valor = Convert.ToDecimal(txtValor.Text);
            }
            else
            {
                _produtoVO.valor = 0;
            }
            if (!String.IsNullOrEmpty(txtCusto.Text))
            {
                _produtoVO.custo = Convert.ToDecimal(txtCusto.Text);
            }
            else
            {
                _produtoVO.custo = 0;
            }
            if (!String.IsNullOrEmpty(txtDescMaximo.Text))
            {
                _produtoVO.desc_max = Convert.ToDecimal(txtDescMaximo.Text);
            }
            else
            {
                _produtoVO.desc_max = 0;
            }
            if (!String.IsNullOrEmpty(txtComissao.Text))
            {
                _produtoVO.comissao = Convert.ToDecimal(txtComissao.Text);
            }
            else
            {
                _produtoVO.comissao = 0;
            }
            _produtoVO.obs = txtObs.Text;

            return _produtoVO;
        }

        private void preencheComboBox()
        {
            TipoProdutoBO  _tipoProdutoBO = new TipoProdutoBO();
            var list = _tipoProdutoBO.buscarTipoProduto(new TipoProdutoVO());
            list.Insert(0, new TipoProdutoVO());
            cbTipoProduto.DataSource = list;
            cbTipoProduto.DisplayMember = "DESCRICAO";
            cbTipoProduto.ValueMember = "PK_CODIGO";

            MedidaBO _medidaBO = new MedidaBO();
            var list2 = _medidaBO.buscarMedida(new MedidaVO());
            list2.Insert(0, new MedidaVO());
            cbMedida.DataSource = list2;
            cbMedida.DisplayMember = "NOME";
            cbMedida.ValueMember = "PK_MEDIDA";
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
                txtComissao.Enabled = true;
                txtCusto.Enabled = true;
                txtDescMaximo.Enabled = true;
                txtEstoque.Enabled = true;
                txtEstoqueMinino.Enabled = true;
                txtNome.Enabled = true;
                txtObs.Enabled = true;
                txtValor.Enabled = true;
                cbMedida.Enabled = true;
                cbTipoProduto.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
                btnGravar.Enabled = false;
                txtComissao.Enabled = false;
                txtCusto.Enabled = false;
                txtDescMaximo.Enabled = false;
                txtEstoque.Enabled = false;
                txtEstoqueMinino.Enabled = false;
                txtNome.Enabled = false;
                txtObs.Enabled = false;
                txtValor.Enabled = false;
                cbMedida.Enabled = false;
                cbTipoProduto.Enabled = false;
            }
        }

        private void preencheCbMedida()
        {
            MedidaBO _medidaBO = new MedidaBO();
            var list = _medidaBO.buscarMedida(new MedidaVO());
            list.Insert(0, new MedidaVO());
            cbTipoProduto.DataSource = list;
            cbTipoProduto.DisplayMember = "NOME";
            cbTipoProduto.ValueMember = "NOME";
        }

#endregion
        
        private void Produto_Load(object sender, EventArgs e)
        {
            preencheComboBox();
            preencherDtgrid();
            //habilitaComponentes(false);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preencha a DESCRICAO antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _produtoVO.descricao = txtNome.Text;
                lista = _produtoBO.buscarProduto(_produtoVO);

                if (lista.Count == 0)
                {
                    if (_produtoBO.gravarProduto(preencherObjeto()))
                    {
                        MessageBox.Show("Produto cadastrado com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparObjetos();
                        
                        Produto_Load(null, null);
                        //habilitaComponentes(false);
                    }
                }
                else
                {
                    MessageBox.Show("Produto Inválido! Descrição ja cadastrada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um produto antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _produtoBO.alterarProduto(preencherObjeto());

            MessageBox.Show("Produto alterado com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Produto_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um produto antes de excluir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este Produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            //_produtoVO.pk_codigo = Convert.ToInt32(DgvCadProdutos.Rows[DgvCadProdutos.CurrentRow.Index].Cells[0].Value);

            _produtoBO.excluirProduto(preencherObjeto());

            MessageBox.Show("Produto excluído com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Produto_Load(null, null);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //habilitaComponentes(true);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            //habilitaComponentes(true);
        }

        private void DgvCadProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _produtoVO.pk_codigo = Convert.ToInt32(DgvCadProdutos.Rows[DgvCadProdutos.CurrentRow.Index].Cells[0].Value);
            lista = _produtoBO.buscarProduto(_produtoVO);
            if (lista.Count > 0)
            {
                txtCodigo.Text = lista[0].pk_codigo.ToString();
                txtNome.Text = lista[0].descricao;
                cbTipoProduto.SelectedValue = lista[0].fk_tipo_produto;
                cbMedida.SelectedValue = lista[0].fk_medida;
                txtEstoque.Text = Convert.ToString(lista[0].qtde_estoque);
                txtEstoqueMinino.Text = Convert.ToString(lista[0].estoque_minimo);
                txtValor.Text = lista[0].valor.ToString("###,###,##0.00");
                txtCusto.Text = lista[0].custo.ToString("###,###,##0.00");
                txtDescMaximo.Text = lista[0].desc_max.ToString("###,###,##0.00");
                txtComissao.Text = lista[0].comissao.ToString("###,###,##0.00");
                txtObs.Text = lista[0].obs;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            txtValor.Text = Funcoes.valorMonetario(txtValor.Text);
        }

        private void txtCusto_Leave(object sender, EventArgs e)
        {
            txtCusto.Text = Funcoes.valorMonetario(txtCusto.Text);
        }

        private void txtDescMaximo_Leave(object sender, EventArgs e)
        {
            txtDescMaximo.Text = Funcoes.valorMonetario(txtDescMaximo.Text);
        }

        private void txtComissao_Leave(object sender, EventArgs e)
        {
            txtComissao.Text = Funcoes.valorMonetario(txtComissao.Text);
        }
             
    }
}
