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
    public partial class FrmCaixa_Abertura : Form
    {
        CaixaBO _caixaBO = new CaixaBO();
        CaixaVO _caixaVO = new CaixaVO();

        public FrmCaixa_Abertura()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtValor.Text))
            {
                if (_caixaBO.abrirCaixa(preencherObjeto()))
                {
                    MessageBox.Show("Caixa aberto com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limparCampos();
                }
            }
            else
            {
                MessageBox.Show("Informe o valor inicial!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal CaixaVO preencherObjeto()
        {
            _caixaVO.dt_hr_abertura = dtpData.Value;
            _caixaVO.valor_inicial = Convert.ToDouble(txtValor.Text);
            return _caixaVO;
        }

        private void limparCampos()
        {
            txtValor.Enabled = false;
            btnAbrir.Enabled = false;
        }

        private void FrmCaixa_Abertura_Load(object sender, EventArgs e)
        {
            CaixaVO _caixaVOaux = new CaixaVO();

            _caixaVOaux = _caixaBO.verificarCaixa();

            if (!(_caixaVOaux == null))
            {
                MessageBox.Show("Já existe um caixa aberto!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparCampos();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
