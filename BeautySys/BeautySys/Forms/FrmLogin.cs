using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BeautySys.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;
using BeautySys.Classes;
using BeautySys.Business;
using BeautySys.DataAccess.Util;

namespace BeautySys
{
    public partial class Form1 : Form
    {
        LoginBO _loginBO = new LoginBO();

        public Form1()
        {
            InitializeComponent();
            RegistryKey registro = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\BeautySys\Login");
            if (registro != null)
            {
                txbServer.Text = registro.GetValue("SERVIDOR").ToString();
                txbUsuario.Text = registro.GetValue("USUARIO").ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "BeautySys - Versão: "  + Application.ProductVersion; 
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(txbServer.Text))
                {
                    MessageBox.Show("Campo SERVER em branco!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (String.IsNullOrEmpty(txbUsuario.Text) || String.IsNullOrEmpty(txbSenha.Text))
                    {
                        MessageBox.Show("Preencha usuario e senha!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        preencherObjeto();
                        SqlHelper.SERVIDOR = LoginVO.Servidor;

                        var retorno = _loginBO.getLogin();
                        if (retorno != null)
                        {
                            RegistryKey registro = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\BeautySys\Login");
                            registro.SetValue("SERVIDOR", txbServer.Text);
                            registro.SetValue("USUARIO", txbUsuario.Text);

                            FrmPrincipal frmPricipal = new FrmPrincipal();
                            frmPricipal.ShowDialog();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 53:
                        MessageBox.Show("Falha ao conectar banco de dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    //case 18456:
                    //    MessageBox.Show("Falha de Logon user_beauty!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    break;                        

                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
            }
        }

        public void preencherObjeto()
        {
            //variáveis STATIC
            LoginVO.Servidor = txbServer.Text;
            LoginVO.Usuario = txbUsuario.Text.ToUpper();
            LoginVO.Senha = txbSenha.Text;
            LoginVO.ultimoAcesso = DateTime.Now;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Dispose();
            Application.Exit();
        }

        private void txbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtOk.PerformClick();
            }
        }

    }
}
