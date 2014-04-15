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
    public partial class FrmCReceber : Form
    {
        List<CReceberVO> lista;
        CReceberBO _cReceberBO = new CReceberBO();
        CReceberVO _cReceberVO = new CReceberVO();

        public FrmCReceber()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCReceber_Load(object sender, EventArgs e)
        {
            string dt_pagto = "";
            string notaFiscal = "";
            limparCampos();

            lista = _cReceberBO.buscarCReceber(new CReceberVO());

            dgvCReceber.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                if (!lista[i].dt_pagamento.ToString("dd/MM/yyyy").Equals("01/01/0001"))
                {
                    dt_pagto = lista[i].dt_pagamento.ToString("dd/MM/yyyy");
                }
                else
                {
                    dt_pagto = "";
                }
                //NOTA_FICAL
                if (lista[i].nota_fiscal > 0)
                {
                    notaFiscal = Convert.ToString(lista[i].nota_fiscal);
                }
                else
                {
                    notaFiscal = "";
                }

                dgvCReceber.Rows.Add(lista[i].pk_codigo, lista[i].cliente, lista[i].valor, lista[i].dt_vencimento.ToString("dd/MM/yyyy"), lista[i].dt_emissao.ToString("dd/MM/yyyy"), dt_pagto, lista[i].fk_comanda, lista[i].forma_pagto, notaFiscal, lista[i].serie);
            }
        }

        private void limparCampos()
        {

        }


    }
}
