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
                cmd.Parameters.Add("@DT_EMISSAO", SqlDbType.Date).Value = cReceberVO.dt_emissao.ToString("dd/MM/yyyy HH:mm:ss");
                cmd.Parameters.Add("@DT_VENCIMENTO", SqlDbType.Date).Value = cReceberVO.dt_vencimento.ToString("dd/MM/yyyy HH:mm:ss");
                cmd.Parameters.Add("VALOR", SqlDbType.Decimal).Value = cReceberVO.valor;
                //DT_PAGAMENTO
                if (!cReceberVO.dt_pagamento.ToString("dd/MM/yyyy").Equals("01/01/0001"))
                {
                    cmd.Parameters.Add("@DT_PAGAMENTO", SqlDbType.Date).Value = cReceberVO.dt_pagamento.ToString("dd/MM/yyyy HH:mm:ss");
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

        public bool excluirCReceber(CReceberVO cReceberVO)
        {
            try
            {
                string sql = @"DELETE FROM CRECEBER WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = cReceberVO.pk_codigo;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool alterarCReceber(CReceberVO cReceberVO)
        {
            try
            {
                string sql = "UPDATE CRECEBER SET DESCRICAO = @DESCRICAO, "; 

                //FK_COMANDA
                if (cReceberVO.fk_comanda > 0)
                {
                    sql = sql + "FK_COMANDA = @FK_COMANDA, ";
                }

                //NOTA_FISCAL
                if (cReceberVO.nota_fiscal > 0)
                {
                    sql = sql + "NOTA_FISCAL = @NOTA_FISCAL, ";
                }

                //SERIE
                if (!String.IsNullOrEmpty(cReceberVO.serie))
                {
                    sql = sql + "SERIE = @SERIE, ";
                }

                sql = sql + "FK_CLIENTE = @FK_CLIENTE, DT_EMISSAO = @DT_EMISSAO, DT_VENCIMENTO = @DTVENCIMENTO, VALOR = @VALOR, ";

                //DT_PAGAMENTO
                if (!cReceberVO.dt_pagamento.ToString("dd/MM/yyyy").Equals("01/01/0001"))
                {
                    sql = sql + "DT_PAGAMENTO = @DT_PAGAMENTO, ";
                }

                sql = sql + "FK_FORMA_PAGTO = @FK_FORMA_PAGTO ";

                sql = sql = "WHERE PK_CODIGO = @PK_CODIGO";

                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = cReceberVO.pk_codigo;
                //FK_COMANDA
                if (cReceberVO.fk_comanda > 0)
                {
                    cmd.Parameters.Add("@FK_COMANDA", SqlDbType.Int).Value = cReceberVO.fk_comanda;
                }
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
                cmd.Parameters.Add("@DT_EMISSAO", SqlDbType.SmallDateTime).Value = cReceberVO.dt_emissao.ToString("dd/MM/yyyy HH:mm:ss");
                cmd.Parameters.Add("@DT_VENCIMENTO", SqlDbType.SmallDateTime).Value = cReceberVO.dt_vencimento.ToString("dd/MM/yyyy HH:mm:ss");
                cmd.Parameters.Add("VALOR", SqlDbType.Decimal).Value = cReceberVO.valor;
                //DT_PAGAMENTO
                if (!cReceberVO.dt_pagamento.ToString("dd/MM/yyyy").Equals("01/01/0001"))
                {
                    cmd.Parameters.Add("@DT_PAGAMENTO", SqlDbType.SmallDateTime).Value = cReceberVO.dt_pagamento.ToString("dd/MM/yyyy HH:mm:ss");
                }
                cmd.Parameters.Add("@FK_FORMA_PAGTO", SqlDbType.Int).Value = cReceberVO.fk_forma_pagto;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CReceberVO> buscarCReceber(CReceberVO cReceberVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SELECT C.PK_CODIGO, C.FK_COMANDA, C.NOTA_FISCAL, C.SERIE, C.FK_CLIENTE, CLI.NOME AS CLIENTE, C.DT_EMISSAO, C.DT_VENCIMENTO, C.VALOR, C.DT_PAGAMENTO, C.FK_FORMA_PAGTO, F.DESCRICAO AS FORMA_PAGTO FROM CRECEBER C");
            sb.Append(" INNER JOIN CLIENTE CLI ON C.FK_CLIENTE = CLI.PK_CODIGO");
            sb.Append(" INNER JOIN FORMA_PAGTO F ON C.FK_FORMA_PAGTO = F.PK_CODIGO");
            sb.Append(" WHERE NOT C.PK_CODIGO IS NULL");

            if (!cReceberVO.dt_emissao.ToString("dd/MM/yyyy").Equals("01/01/0001"))
            {
                sb.Append(" AND C.DT_EMISSAO BETWEEN '" + cReceberVO.dt_emissao.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + cReceberVO.dt_emissao.ToString("dd/MM/yyyy") + " 23:59:59'");
            }

            if (!cReceberVO.dt_vencimento.ToString("dd/MM/yyyy").Equals("01/01/0001"))
            {
                sb.Append(" AND C.DT_VENCIMENTO BETWEEN '" + cReceberVO.dt_vencimento.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + cReceberVO.dt_vencimento.ToString("dd/MM/yyyy") + " 23:59:59'");
            }

            if (!cReceberVO.dt_pagamento.ToString("dd/MM/yyyy").Equals("01/01/0001"))
            {
                sb.Append(" AND C.DT_PAGAMENTO BETWEEN '" + cReceberVO.dt_pagamento.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + cReceberVO.dt_pagamento.ToString("dd/MM/yyyy") + " 23:59:59'");
            }
                
            sb.Append(" ORDER BY C.PK_CODIGO");

            string sql = Convert.ToString(sb);

            List<CReceberVO> lista = new List<CReceberVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var cReceber = new CReceberVO();
                    mapCReceber(cReceber, reader);
                    lista.Add(cReceber);
                }
            }
            return lista;
        }

        private void mapCReceber(CReceberVO cReceberVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                cReceberVO.pk_codigo = Convert.ToInt32(reader["PK_CODIGO"]);

            if (reader["FK_COMANDA"] != DBNull.Value)
                cReceberVO.fk_comanda = Convert.ToInt32(reader["FK_COMANDA"]);

            if (reader["NOTA_FISCAL"] != DBNull.Value)
                cReceberVO.nota_fiscal = Convert.ToInt32(reader["NOTA_FISCAL"]);

            if (reader["SERIE"] != DBNull.Value)
                cReceberVO.serie = Convert.ToString(reader["SERIE"]);

            if (reader["FK_CLIENTE"] != DBNull.Value)
                cReceberVO.fk_cliente = Convert.ToInt32(reader["FK_CLIENTE"]);

            if (reader["DT_EMISSAO"] != DBNull.Value)
                cReceberVO.dt_emissao = Convert.ToDateTime(reader["DT_EMISSAO"]);

            if (reader["DT_VENCIMENTO"] != DBNull.Value)
                cReceberVO.dt_vencimento = Convert.ToDateTime(reader["DT_VENCIMENTO"]);

            if (reader["VALOR"] != DBNull.Value)
                cReceberVO.valor = Convert.ToDecimal(reader["VALOR"]);

            if (reader["DT_PAGAMENTO"] != DBNull.Value)
                cReceberVO.dt_pagamento = Convert.ToDateTime(reader["DT_PAGAMENTO"]);

            if (reader["CLIENTE"] != DBNull.Value)
                cReceberVO.cliente = Convert.ToString(reader["CLIENTE"]);

            if (reader["FORMA_PAGTO"] != DBNull.Value)
                cReceberVO.forma_pagto = Convert.ToString(reader["FORMA_PAGTO"]);
        }
    }
}
