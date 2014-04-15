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
    public partial class FrmCliente : Form
    {
        List<ClienteVO> lista;
        ClienteBO _clienteBO = new ClienteBO();
        ClienteVO _clienteVO = new ClienteVO();

        EstadoBO _estadoBO = new EstadoBO();
        EstadoVO _estadoVO = new EstadoVO();
        CidadeBO _cidadeBO = new CidadeBO();
        CidadeVO _cidadeVO = new CidadeVO();

        public FrmCliente()
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

        private void cboUF_SelectedValueChanged(object sender, EventArgs e)
        {
            preencherComboCidade();
        }

        private void preencherComboCidade()
        {
            //if (!String.IsNullOrEmpty((cboUF.SelectedItem as EstadoVO).uf))
            //{
            if (!String.IsNullOrEmpty(cboUF.Text))
            {
                _cidadeVO.fk_uf = (cboUF.SelectedItem as EstadoVO).uf;//estado selecionado
                var list = _cidadeBO.buscarCidade(_cidadeVO);
                list.Insert(0, new CidadeVO());
                cboCidade.DataSource = list;
                cboCidade.DisplayMember = "NOME";
                cboCidade.ValueMember = "PK_CODIGO";
            }
            else
            {
                cboCidade.DataSource = null;
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            limparCampos();

            lista = _clienteBO.buscarCliente(new ClienteVO());

            dgvCliente.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvCliente.Rows.Add(lista[i].pk_codigo, lista[i].nome);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (validarCampos())         
            {
                //_clienteVO.nome = txtNome.Text;
                //lista = _clienteBO.buscarCliente(_clienteVO);

                //if (lista.Count == 0)
                //{
                    if (_clienteBO.gravarCliente(preencherObjeto()))
                    {
                        MessageBox.Show("Cliente cadastrado com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparCampos();

                        frmCliente_Load(null, null);
                    }
                //}
                //else
                //{
                    //MessageBox.Show("Cliente Inválido! Cliente ja cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            else
            {
                MessageBox.Show("Preencha o NOME antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            dtpDtNasc.Value = DateTime.Now;
            txtCPF.Text = "";
            txtRG.Text = "";
            txtCep.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            if (!String.IsNullOrEmpty(cboUF.Text))
            {
                cboUF.SelectedIndex = -1;
            }            
            //cboCidade.SelectedValue = lista[0].fk_cidade;
            txtObs.Text = "";
        }

        internal ClienteVO preencherObjeto()
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
                _clienteVO.pk_codigo = Convert.ToInt32(txtCodigo.Text);
            _clienteVO.nome  = txtNome.Text;
            _clienteVO.telefone = txtTelefone.Text;
            _clienteVO.celular = txtCelular.Text;
            _clienteVO.email = txtEmail.Text;
            _clienteVO.dt_nascto = dtpDtNasc.Value;
            _clienteVO.cpf = txtCPF.Text;
            _clienteVO.rg = txtRG.Text;
            _clienteVO.dt_cad = DateTime.Now;
            _clienteVO.cep = txtCep.Text;
            _clienteVO.endereco = txtEndereco.Text;
            _clienteVO.numero = txtNumero.Text;
            _clienteVO.complemento = txtComplemento.Text;
            _clienteVO.bairro = txtBairro.Text;
            _clienteVO.fk_cidade = (cboCidade.SelectedItem as CidadeVO).pk_codigo;
            _clienteVO.obs = txtObs.Text;            
            
            return _clienteVO;
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _clienteVO.pk_codigo = Convert.ToInt32(dgvCliente.Rows[dgvCliente.CurrentRow.Index].Cells[0].Value);
            lista = _clienteBO.buscarCliente(_clienteVO);
            if (lista.Count > 0)
            {
                txtCodigo.Text = lista[0].pk_codigo.ToString();
                txtNome.Text = lista[0].nome;
                txtTelefone.Text = lista[0].telefone;
                txtCelular.Text = lista[0].celular;
                txtEmail.Text = lista[0].email;
                dtpDtNasc.Value = lista[0].dt_nascto;
                txtCPF.Text = lista[0].cpf;
                txtRG.Text = lista[0].rg;
                txtCep.Text = lista[0].cep;
                txtEndereco.Text = lista[0].endereco;
                txtNumero.Text = lista[0].numero;
                txtComplemento.Text = lista[0].complemento;
                txtBairro.Text = lista[0].bairro;
                if (!string.IsNullOrEmpty(lista[0].uf))
                {
                    cboUF.Text = lista[0].uf;
                    cboCidade.SelectedValue = lista[0].fk_cidade;
                }               
                txtObs.Text = lista[0].obs;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um Cliente antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _clienteBO.alterarCliente(preencherObjeto());

            MessageBox.Show("Cliente alterado com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmCliente_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um Cliente antes de excluir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este Cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            //_cidadeVO.pk_codigo = Convert.ToInt32(dgvCidade.Rows[dgvCidade.CurrentRow.Index].Cells[0].Value);

            _clienteBO.excluirCliente(preencherObjeto());

            MessageBox.Show("Cliente excluído com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparCampos();

            frmCliente_Load(null, null);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
