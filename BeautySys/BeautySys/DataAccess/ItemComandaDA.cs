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
    class ItemComandaDA
    {
        Funcoes _funcoes = new Funcoes();

        public bool gravarItemComanda(ItemComandaVO itemComandaVO)
        {
            try
            {
                string sql = @"INSERT INTO ITEM_COMANDA(PK_CODIGO,FK_COMANDA,COD_PROD_SERV,PROD_SERV,QUANTIDADE,VALOR_UNITARIO,VALOR,DESC_ITEM) 
                                VALUES(@PK_CODIGO,@FK_COMANDA,@COD_PROD_SERV,@PROD_SERV,@QUANTIDADE,@VALOR_UNITARIO,@VALOR,@DESC_ITEM)";
                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("ITEM_COMANDA", "PK_CODIGO");
                cmd.Parameters.Add("@FK_COMANDA", SqlDbType.Int).Value = itemComandaVO.fk_comanda;
                cmd.Parameters.Add("@COD_PROD_SERV", SqlDbType.Int).Value = itemComandaVO.cod_prod_serv;
                cmd.Parameters.Add("@PROD_SERV", SqlDbType.Char).Value = itemComandaVO.prod_serv;
                cmd.Parameters.Add("@QUANTIDADE", SqlDbType.Decimal).Value = itemComandaVO.quantidade;
                cmd.Parameters.Add("@VALOR_UNITARIO", SqlDbType.Decimal).Value = itemComandaVO.valor_unitario;
                cmd.Parameters.Add("@VALOR", SqlDbType.Decimal).Value = itemComandaVO.valor;
                cmd.Parameters.Add("@DESC_ITEM", SqlDbType.Decimal).Value = itemComandaVO.desc_item;

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
