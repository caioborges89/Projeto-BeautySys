using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BeautySys.Classes;
using BeautySys.DataAccess.Util;
using BeautySys.Util;

namespace BeautySys.DataAccess
{
    class CReceberDA
    {
        Funcoes _funcoes = new Funcoes();

        public bool gravarCReceber(CReceberVO cReceberVO)
        {
            try
            {           
                string sql = "INSERT INTO CRECEBER(PK_CODIGO,FK_COMANDA,";
                string sql2 = "VALUES(@PK_CODIGO,@FK_COMANDA,";

                //NOTA_FISCAL
                if (cReceberVO.nota_fiscal > 0)
                {
                    sql = sql + "NOTA_FISCAL,";
                    sql2 = sql2 + "@NOTA_FISCAL,";
                }

                //SERIE
                if (!String.IsNullOrEmpty(cReceberVO.serie))
                {
                    sql = sql + "SERIE,";
                    sql2 = sql2 + "@SERIE,";
                }

                sql = sql + "FK_CLIENTE,DT_EMISSAO,DT_VENCIMENTO,VALOR,";
                sql2 = sql2 + "@FK_CLIENTE,@DT_EMISSAO,@DT_VENCIMENTO,@VALOR,";

                //DT_PAGAMENTO
                if (!cReceberVO.dt_pagamento.ToString("dd/MM/yyyy").Equals("01/01/0001"))
                {
                    sql = sql + "DT_PAGAMENTO,";
                    sql2 = sql2 + "@DT_PAGAMENTO,";
                }

                sql = sql + "FK_FORMA_PAGTO) ";
                sql2 = sql2 + "@FK_FORMA_PAGTO)";

                sql = sql + sql2;

                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("CRECEBER", "PK_CODIGO");
                cmd.Parameters.Add("@FK_COMANDA", SqlDbType.Int).Value = cReceberVO.fk_comanda;
                //NOTA_FICAL
                if (cReceberVO.nota_fiscal > 0)
                {
                    cmd.Parameters.Add("@NOTA_FISCAL", SqlDbType.Int).Value = cReceberVO.nota_fiscal;
                }
                else 
                //SERIE
                if (!String.IsNullOrEmpty(cReceberVO.serie))
                {
                    cmd.Parameters.Add("@SERIE", SqlDbType.VarChar).Value = cReceberVO.serie;
                }            
                cmd.Parameters.Add("@FK_CLIENTE", SqlDbType.Int).Value = cReceberVO.fk_cliente;
                cmd.Parameters.Add("@DT_EMISSAO", SqlDbType.Date).Value = cReceberVO.dt_emissao.ToString("dd/MM/yyyy");
                cmd.Parameters.Add("@DT_VENCIMENTO", SqlDbType.Date).Value = cReceberVO.dt_vencimento.ToString("dd/MM/yyyy");
                cmd.Parameters.Add("VALOR", SqlDbType.Decimal).Value = cReceberVO.valor;
                //DT_PAGAMENTO
                if (!cReceberVO.dt_pagamento.ToString("dd/MM/yyyy").Equals("01/01/0001"))
                {
                    cmd.Parameters.Add("@DT_PAGAMENTO", SqlDbType.Date).Value = cReceberVO.dt_pagamento.ToString("dd/MM/yyyy");
                }
                cmd.Parameters.Add("@FK_FORMA_PAGTO", SqlDbType.Int).Value = cReceberVO.fk_forma_pagto;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
