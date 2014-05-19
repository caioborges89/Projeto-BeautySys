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
    class FluxoCaixaDA
    {
        public List<FluxoCaixaVO> buscarComanda(FluxoCaixaVO comandaVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SET LANGUAGE PORTUGUESE
                        SELECT C.PK_CODIGO AS NUMERO, CLI.NOME AS CLIENTE, C.VALOR FROM COMANDA C
                        INNER JOIN CLIENTE CLI ON C.FK_CLIENTE = CLI.PK_CODIGO ");
            sb.Append(" WHERE C.DATA BETWEEN '" + comandaVO.dt_inicial.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + comandaVO.dt_final.ToString("dd/MM/yyyy") + " 23:59:59'");
            sb.Append(" AND C.CANCELADO = 0");

            sb.Append(" ORDER BY 1");

            string sql = Convert.ToString(sb);

            List<FluxoCaixaVO> lista = new List<FluxoCaixaVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var comanda = new FluxoCaixaVO();
                    mapFluxoCaixa(comanda, reader);
                    lista.Add(comanda);
                }
            }
            return lista;
        }

        public List<FluxoCaixaVO> buscarComandaCancelada(FluxoCaixaVO comandaVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SET LANGUAGE PORTUGUESE
                        SELECT C.PK_CODIGO AS NUMERO, CLI.NOME AS CLIENTE, C.VALOR FROM COMANDA C
                        INNER JOIN CLIENTE CLI ON C.FK_CLIENTE = CLI.PK_CODIGO ");
            sb.Append(" WHERE C.DATA BETWEEN '" + comandaVO.dt_inicial.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + comandaVO.dt_final.ToString("dd/MM/yyyy") + " 23:59:59'");
            sb.Append(" AND C.CANCELADO = 1");

            sb.Append(" ORDER BY 1");

            string sql = Convert.ToString(sb);

            List<FluxoCaixaVO> lista = new List<FluxoCaixaVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var comanda = new FluxoCaixaVO();
                    mapFluxoCaixa(comanda, reader);
                    lista.Add(comanda);
                }
            }
            return lista;
        }

        public List<FluxoCaixaVO> buscarCReceber(FluxoCaixaVO comandaVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SET LANGUAGE PORTUGUESE
                        SELECT CR.PK_CODIGO AS NUMERO, CLI.NOME AS CLIENTE, CR.VALOR AS VALOR FROM CRECEBER CR
                        LEFT JOIN COMANDA COM ON CR.FK_COMANDA = COM.PK_CODIGO
                        LEFT JOIN CLIENTE CLI ON COM.FK_CLIENTE = CLI.PK_CODIGO ");
            sb.Append(" WHERE CR.DT_PAGAMENTO BETWEEN '" + comandaVO.dt_inicial.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + comandaVO.dt_final.ToString("dd/MM/yyyy") + " 23:59:59'");

            sb.Append(" ORDER BY 1");

            string sql = Convert.ToString(sb);

            List<FluxoCaixaVO> lista = new List<FluxoCaixaVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var comanda = new FluxoCaixaVO();
                    mapFluxoCaixa(comanda, reader);
                    lista.Add(comanda);
                }
            }
            return lista;
        }

        public List<FluxoCaixaVO> buscarTotalCReceber(FluxoCaixaVO comandaVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SET LANGUAGE PORTUGUESE
                        SELECT SUM(VALOR) AS TOTAL FROM CRECEBER CR");
            sb.Append(" WHERE CR.DT_PAGAMENTO BETWEEN '" + comandaVO.dt_inicial.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + comandaVO.dt_final.ToString("dd/MM/yyyy") + " 23:59:59'");

            string sql = Convert.ToString(sb);

            List<FluxoCaixaVO> lista = new List<FluxoCaixaVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var comanda = new FluxoCaixaVO();
                    if (reader["TOTAL"] != DBNull.Value)
                        comanda.total = Convert.ToDouble(reader["TOTAL"]);
                    lista.Add(comanda);
                }
            }
            return lista;
        }

        public List<FluxoCaixaVO> buscarTotalComanda(FluxoCaixaVO comandaVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SET LANGUAGE PORTUGUESE
                        SELECT SUM(VALOR) AS TOTAL FROM COMANDA C");
            sb.Append(" WHERE C.DATA BETWEEN '" + comandaVO.dt_inicial.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + comandaVO.dt_final.ToString("dd/MM/yyyy") + " 23:59:59'");
            sb.Append(" AND C.CANCELADO = 0");

            string sql = Convert.ToString(sb);

            List<FluxoCaixaVO> lista = new List<FluxoCaixaVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var comanda = new FluxoCaixaVO();
                    if (reader["TOTAL"] != DBNull.Value)
                        comanda.total = Convert.ToDouble(reader["TOTAL"]);
                    lista.Add(comanda);
                }
            }
            return lista;
        }

        public List<FluxoCaixaVO> buscarTotalCaixaEntrada(FluxoCaixaVO comandaVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SET LANGUAGE PORTUGUESE
                        SELECT SUM(VALOR) AS TOTAL FROM CAIXA_ENTRADA CE
                        INNER JOIN CAIXA C ON CE.FK_CAIXA = C.PK_CODIGO");
            sb.Append(" WHERE C.DT_HR_ABERTURA BETWEEN '" + comandaVO.dt_inicial.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + comandaVO.dt_final.ToString("dd/MM/yyyy") + " 23:59:59'");

            string sql = Convert.ToString(sb);

            List<FluxoCaixaVO> lista = new List<FluxoCaixaVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var comanda = new FluxoCaixaVO();
                    if (reader["TOTAL"] != DBNull.Value)
                        comanda.total = Convert.ToDouble(reader["TOTAL"]);
                    lista.Add(comanda);
                }
            }
            return lista;
        }

        public List<FluxoCaixaVO> buscarTotalCaixaSaida(FluxoCaixaVO comandaVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SET LANGUAGE PORTUGUESE
                        SELECT SUM(VALOR) AS TOTAL FROM CAIXA_SAIDA CS
                        INNER JOIN CAIXA C ON CS.FK_CAIXA = C.PK_CODIGO");
            sb.Append(" WHERE C.DT_HR_ABERTURA BETWEEN '" + comandaVO.dt_inicial.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + comandaVO.dt_final.ToString("dd/MM/yyyy") + " 23:59:59'");

            string sql = Convert.ToString(sb);

            List<FluxoCaixaVO> lista = new List<FluxoCaixaVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var comanda = new FluxoCaixaVO();
                    if (reader["TOTAL"] != DBNull.Value)
                        comanda.total = Convert.ToDouble(reader["TOTAL"]);
                    lista.Add(comanda);
                }
            }
            return lista;
        }

        public List<FluxoCaixaVO> buscarTotalCaixaAbertura(FluxoCaixaVO comandaVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SET LANGUAGE PORTUGUESE
                        SELECT SUM(VALOR_INICIAL) AS TOTAL FROM CAIXA C");
            sb.Append(" WHERE C.DT_HR_ABERTURA BETWEEN '" + comandaVO.dt_inicial.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + comandaVO.dt_final.ToString("dd/MM/yyyy") + " 23:59:59'");

            string sql = Convert.ToString(sb);

            List<FluxoCaixaVO> lista = new List<FluxoCaixaVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var comanda = new FluxoCaixaVO();
                    if (reader["TOTAL"] != DBNull.Value)
                        comanda.total = Convert.ToDouble(reader["TOTAL"]);
                    lista.Add(comanda);
                }
            }
            return lista;
        }

        private void mapFluxoCaixa(FluxoCaixaVO fluxoCaixaVO, IDataReader reader)
        {
            if (reader["NUMERO"] != DBNull.Value)
                fluxoCaixaVO.numero = Convert.ToInt32(reader["NUMERO"]);

            if (reader["CLIENTE"] != DBNull.Value)
                fluxoCaixaVO.cliente = Convert.ToString(reader["CLIENTE"]);

            if (reader["VALOR"] != DBNull.Value)
                fluxoCaixaVO.valor = Convert.ToDouble(reader["VALOR"]);

            //if (reader["TOTAL"] != DBNull.Value)
            //    fluxoCaixaVO.total = Convert.ToDouble(reader["TOTAL"]);
        }
    }
}
