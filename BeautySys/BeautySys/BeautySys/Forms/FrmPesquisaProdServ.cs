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
    public partial class FrmPesquisaProdServ : Form
    {
        List<ServicoVO> listaServ;
        ServicoBO _servicoBO = new ServicoBO();
        ServicoVO _servicoVO = new ServicoVO();

        List<ProdutoVO> listaProd;
        ProdutoBO _produtoBO = new ProdutoBO();
        ProdutoVO _produtoVO = new ProdutoVO();

        public FrmPesquisaProdServ()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            PesquisaVO.nome = "";
            PesquisaVO.codigo = 0;
            PesquisaVO.tipo = "";
            this.Close();
        }

        private void FrmPesquisaProdServ_Load(object sender, EventArgs e)
        {
            txtNome.Text = PesquisaVO.nome;
            if (PesquisaVO.codigo > 0)
            {
                txtCodigo.Text = Convert.ToString(PesquisaVO.codigo);
            }
            if (PesquisaVO.tipo == "S")
            {
                lblTipo.Text = "SERVIÇO";
            }
            else//P
            {
                lblTipo.Text = "PRODUTO";
            }

            carregarGrid();
        }

        private void carregarGrid()
        {
            if (PesquisaVO.tipo == "S")
            {
                _servicoVO.descricao = PesquisaVO.nome;
                _servicoVO.pk_codigo = PesquisaVO.codigo;

                listaServ = _servicoBO.buscarServico(_servicoVO);

                dgvProdServ.Rows.Clear();
                for (int i = 0; i < listaServ.Count; i++)
                {
                    dgvProdServ.Rows.Add(listaServ[i].pk_codigo, listaServ[i].descricao, listaServ[i].valor);
                }
            }
            else//P
            {
                _produtoVO.descricao = PesquisaVO.nome;
                _produtoVO.pk_codigo = PesquisaVO.codigo;

                listaProd = _produtoBO.buscarProduto(_produtoVO);

                dgvProdServ.Rows.Clear();
                for (int i = 0; i < listaProd.Count; i++)
                {
                    dgvProdServ.Rows.Add(listaProd[i].pk_codigo, listaProd[i].descricao, listaProd[i].valor);
                }               
            }
        }

        private void dgvProdServ_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PesquisaVO.tipo == "S")
            {
                if (listaServ.Count > 0)
                {
                    PesquisaVO.codigo = Convert.ToInt32(dgvProdServ.Rows[dgvProdServ.CurrentRow.Index].Cells[0].Value);
                    PesquisaVO.nome = Convert.ToString(dgvProdServ.Rows[dgvProdServ.CurrentRow.Index].Cells[1].Value);
                    PesquisaVO.valor = Convert.ToDouble(dgvProdServ.Rows[dgvProdServ.CurrentRow.Index].Cells[2].Value);
                    this.Close();
                }
            }
            else//P
            {
                if (listaProd.Count > 0)
                {
                    PesquisaVO.codigo = Convert.ToInt32(dgvProdServ.Rows[dgvProdServ.CurrentRow.Index].Cells[0].Value);
                    PesquisaVO.nome = Convert.ToString(dgvProdServ.Rows[dgvProdServ.CurrentRow.Index].Cells[1].Value);
                    PesquisaVO.valor = Convert.ToDouble(dgvProdServ.Rows[dgvProdServ.CurrentRow.Index].Cells[2].Value);
                    this.Close();
                }
            }            
        }
    }
}
