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
    class CaixaSaidaDA
    {
        Funcoes _funcoes = new Funcoes();

        public bool gravarSaida(CaixaSaidaVO caixaSaidaVO)
        {
            try
            {
                string sql = @"INSERT INTO CAIXA_SAIDA(PK_CODIGO,DESCRICAO,VALOR,FK_CAIXA) 
                                VALUES(@PK_CODIGO,@DESCRICAO,@VALOR,(SELECT PK_CODIGO FROM CAIXA WHERE DT_HR_FECHAMENTO IS NULL))";
                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("CAIXA_SAIDA", "PK_CODIGO");
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = caixaSaidaVO.descricao;
                cmd.Parameters.Add("@VALOR", SqlDbType.Decimal).Value = caixaSaidaVO.valor;
                //cmd.Parameters.Add("@FK_CAIXA", SqlDbType.Int).Value = caixaEntradaVO.fk_caixa;

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
