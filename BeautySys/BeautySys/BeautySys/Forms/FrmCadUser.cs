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
    public partial class FrmCadUser : Form
    {
        List<UsuarioVO> lista;
        UsuarioBO _usuarioBO = new UsuarioBO();
        UsuarioVO _usuarioVO = new UsuarioVO();

        public FrmCadUser()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadUser_Load(object sender, EventArgs e)
        {
            lista = _usuarioBO.busca(new UsuarioVO());

            dgvUsuario.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvUsuario.Rows.Add(lista[i].nome, lista[i].ultimo_acesso);
            }
        }

        internal UsuarioVO preencherObjeto()
        {
            _usuarioVO.nome = txbUsuario.Text.ToUpper();
            _usuarioVO.senha = Criptografia.criptografar(txbSenha.Text);
            _usuarioVO.ultimo_acesso = DateTime.Now;
            return _usuarioVO;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells[0].Value.Equals("ADMINISTRADOR"))
            {
                MessageBox.Show("Usuário Inválido! Usuário ADMINISTRADOR não pode ser excluído!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells[0].Value.Equals(LoginVO.Usuario))
            {
                MessageBox.Show("Usuário Inválido! Este usuário está logado no sistema, utilize outro usuário!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este usuário?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            //excluir
            _usuarioVO.nome = Convert.ToString(dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells[0].Value);

            _usuarioBO.excluirUsuario(_usuarioVO);

            MessageBox.Show("Usuário excluído com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmCadUser_Load(null, null);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbUsuario.Text) || String.IsNullOrEmpty(txbSenha.Text) || String.IsNullOrEmpty(txbSenhaConfirma.Text))
            {
                MessageBox.Show("Preencha todos os dados antes de gravar!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txbUsuario.Text.Trim().ToUpper().Equals("ADMINISTRADOR"))
                {
                    MessageBox.Show("Nome de usuário inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txbSenha.Text == txbSenhaConfirma.Text)
                    {
                        //verifica se o nome de usuario ja existe no sistema
                        _usuarioVO.nome = txbUsuario.Text;
                        lista = _usuarioBO.busca(_usuarioVO);

                        if (lista.Count == 0)
                        {
                            if (_usuarioBO.gravarUsuario(preencherObjeto()))
                            {
                                MessageBox.Show("Usuário cadastrado com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txbUsuario.Text = "";
                                txbSenhaConfirma.Text = "";
                                txbSenha.Text = "";

                                FrmCadUser_Load(null, null);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário Inválido! Usuário ja cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Confirmação de Senha incorreta!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbSenhaConfirma.Focus();
                    }
                }
            }
        }
    }
}
