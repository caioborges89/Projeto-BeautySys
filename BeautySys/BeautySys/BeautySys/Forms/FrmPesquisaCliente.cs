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
    public partial class FrmPesquisaCliente : Form
    {
        List<ClienteVO> lista;
        ClienteBO _clienteBO = new ClienteBO();
        ClienteVO _clienteVO = new ClienteVO();

        public FrmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void FrmPesquisaCliente_Load(object sender, EventArgs e)
        {
            txtNome.Text = PesquisaVO.nome;
            if (PesquisaVO.codigo > 0)
            {
                txtCodigo.Text = Convert.ToString(PesquisaVO.codigo);
            }

            carregarGrid();
        }

        private void carregarGrid()
        {
            _clienteVO.nome = PesquisaVO.nome;
            _clienteVO.pk_codigo = PesquisaVO.codigo;

            lista = _clienteBO.buscarCliente(_clienteVO);

            dgvCliente.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvCliente.Rows.Add(lista[i].pk_codigo, lista[i].nome);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            PesquisaVO.nome = "";
            PesquisaVO.codigo = 0;
            this.Close();
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lista.Count > 0)
            {
                PesquisaVO.nome = Convert.ToString(dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[1].Value);
                PesquisaVO.codigo = Convert.ToInt32(dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[0].Value);
                this.Close();
            }
        }
    }
}
