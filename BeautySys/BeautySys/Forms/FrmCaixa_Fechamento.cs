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
    public partial class FrmCaixa_Fechamento : Form
    {
        CaixaBO _caixaBO = new CaixaBO();
        CaixaVO _caixaVO = new CaixaVO();

        public FrmCaixa_Fechamento()
        {
            InitializeComponent();
        }

        private void FrmCaixa_Fechamento_Load(object sender, EventArgs e)
        {
            _caixaVO = _caixaBO.verificarCaixa();

            if (_caixaVO == null)
            {
                MessageBox.Show("Não existe nenhum caixa aberto!", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                limparCampos();
            }
            else
            {
                dtpCaixa.Value = _caixaVO.dt_hr_abertura;
            }
        }

        private void limparCampos()
        {
            txtValor.Enabled = false;
            btnFechar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtValor.Text))
            {
                if (_caixaBO.fecharCaixa(preencherObjeto()))
                {
                    MessageBox.Show("Caixa fechado com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limparCampos();
                }
            }
            else
            {
                MessageBox.Show("Informe o valor final!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal CaixaVO preencherObjeto()
        {
            _caixaVO.dt_hr_fechamento = dtpCaixaFechamento.Value;
            _caixaVO.valor_final = Convert.ToDouble(txtValor.Text);
            return _caixaVO;
        }
    }
}
