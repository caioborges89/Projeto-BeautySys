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
    public partial class FrmProfissional : Form
    {
        List<ProfissionalVO> lista;
        ProfissionalBO _profissionalBO = new ProfissionalBO();
        ProfissionalVO _profissionalVO = new ProfissionalVO();

        EstadoBO _estadoBO = new EstadoBO();
        EstadoVO _estadoVO = new EstadoVO();
        CidadeBO _cidadeBO = new CidadeBO();
        CidadeVO _cidadeVO = new CidadeVO();

        public FrmProfissional()
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

        private void Profissional_Load(object sender, EventArgs e)
        {
            limparCampos();

            lista = _profissionalBO.buscarProfissional(new ProfissionalVO());

            dgvProfissional.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvProfissional.Rows.Add(lista[i].pk_codigo, lista[i].nome);
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

        internal ProfissionalVO preencherObjeto()
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
                _profissionalVO.pk_codigo = Convert.ToInt32(txtCodigo.Text);
            _profissionalVO.nome = txtNome.Text;
            _profissionalVO.telefone = txtTelefone.Text;
            _profissionalVO.celular = txtCelular.Text;
            _profissionalVO.email = txtEmail.Text;
            _profissionalVO.dt_nascto = dtpDtNasc.Value;
            _profissionalVO.cpf = txtCPF.Text;
            _profissionalVO.rg = txtRG.Text;
            _profissionalVO.dt_cad = DateTime.Now;
            _profissionalVO.cep = txtCep.Text;
            _profissionalVO.endereco = txtEndereco.Text;
            _profissionalVO.numero = txtNumero.Text;
            _profissionalVO.complemento = txtComplemento.Text;
            _profissionalVO.bairro = txtBairro.Text;
            _profissionalVO.fk_cidade = (cboCidade.SelectedItem as CidadeVO).pk_codigo;
            _profissionalVO.obs = txtObs.Text;

            return _profissionalVO;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                _profissionalVO.nome = txtNome.Text;
                lista = _profissionalBO.buscarProfissional(_profissionalVO);

                if (lista.Count == 0)
                {
                    if (_profissionalBO.gravarProfissional(preencherObjeto()))
                    {
                        MessageBox.Show("Profissional cadastrado com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limparCampos();

                        Profissional_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Profissional Inválido! Profissional ja cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o NOME antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um Profissional antes de alterar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _profissionalBO.alterarProfissional(preencherObjeto());

            MessageBox.Show("Profissional alterado com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Profissional_Load(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um Profissional antes de excluir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este Profissional?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            _profissionalBO.excluirProfissional(preencherObjeto());

            MessageBox.Show("Profissional excluído com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparCampos();

            Profissional_Load(null, null);
        }

        private void dgvProfissional_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _profissionalVO.pk_codigo = Convert.ToInt32(dgvProfissional.Rows[dgvProfissional.CurrentRow.Index].Cells[0].Value);
            lista = _profissionalBO.buscarProfissional(_profissionalVO);
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
        
    }
}
