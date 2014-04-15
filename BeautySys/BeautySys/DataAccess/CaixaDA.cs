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
    class CaixaDA
    {
        Funcoes _funcoes = new Funcoes();

        public bool abrirCaixa(CaixaVO caixaVO)
        {
            try
            {
                string sql = @"INSERT INTO CAIXA(PK_CODIGO,DT_HR_ABERTURA,VALOR_INICIAL) 
                                VALUES(@PK_CODIGO,@DT_HR_ABERTURA,@VALOR_INICIAL)";
                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("CAIXA", "PK_CODIGO");
                //cmd.Parameters.Add("@DT_HR_ABERTURA", SqlDbType.Date).Value = caixaVO.dt_hr_abertura.ToString("dd/MM/yyyy HH:mm:ss");
                cmd.Parameters.Add("@DT_HR_ABERTURA", SqlDbType.SmallDateTime).Value = caixaVO.dt_hr_abertura.ToString("dd/MM/yyyy HH:mm:ss");
                cmd.Parameters.Add("@VALOR_INICIAL", SqlDbType.Decimal).Value = caixaVO.valor_inicial;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public CaixaVO verificarCaixa()
        {
            try
            {
                string sql = "SET LANGUAGE PORTUGUESE ";
                sql = sql + "SELECT * FROM CAIXA WHERE DT_HR_FECHAMENTO IS NULL";
                
                //List<CaixaVO> lista = new List<CaixaVO>();

                using (IDataReader reader = SqlHelper.executeReader(sql))
                {
                    while (reader.Read())
                    {
                        var caixa = new CaixaVO();
                        mapCaixa(caixa, reader);
                        //lista.Add(caixa);
                        return caixa;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool verificarCaixaHoje()
        {
            try
            {
                string sql = "SET LANGUAGE PORTUGUESE ";
                sql = sql + "SELECT * FROM CAIXA WHERE DT_HR_ABERTURA BETWEEN '" + DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59' AND DT_HR_FECHAMENTO IS NULL";
                
                List<CaixaVO> lista = new List<CaixaVO>();

                using (IDataReader reader = SqlHelper.executeReader(sql))
                {
                    while (reader.Read())
                    {                        
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool verificarCaixaAbertoFechadoHoje()
        {
            try
            {
                string sql = "SET LANGUAGE PORTUGUESE ";
                sql = sql + "SELECT * FROM CAIXA WHERE DT_HR_ABERTURA BETWEEN '" + DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59' ";
                sql = sql + "AND NOT DT_HR_FECHAMENTO IS NULL";

                List<CaixaVO> lista = new List<CaixaVO>();

                using (IDataReader reader = SqlHelper.executeReader(sql))
                {
                    while (reader.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void mapCaixa(CaixaVO caixaVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                caixaVO.pk_codigo = Convert.ToInt32(reader["PK_CODIGO"]);

            if (reader["DT_HR_ABERTURA"] != DBNull.Value)
                caixaVO.dt_hr_abertura = Convert.ToDateTime(reader["DT_HR_ABERTURA"]);
        }

        public bool fecharCaixa(CaixaVO caixaVO)
        {
            try
            {
                string sql = @"UPDATE CAIXA SET DT_HR_FECHAMENTO = @DT_HR_FECHAMENTO, VALOR_FINAL = @VALOR_FINAL WHERE DT_HR_FECHAMENTO IS NULL";

                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@DT_HR_FECHAMENTO", SqlDbType.SmallDateTime).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                cmd.Parameters.Add("@VALOR_FINAL", SqlDbType.Decimal).Value = caixaVO.valor_final;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool reabrirCaixa()
        {
            try
            {
                string sql = @"SET LANGUAGE PORTUGUESE ";
                sql = sql + "UPDATE CAIXA SET DT_HR_FECHAMENTO = NULL, VALOR_FINAL = '0.00' ";
                sql = sql + "WHERE DT_HR_ABERTURA BETWEEN '" + DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:01' AND '" + DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59' ";
                sql = sql + "AND NOT DT_HR_FECHAMENTO IS NULL";

                SqlCommand cmd = SqlHelper.getCommand(sql);

                //cmd.Parameters.Add("@DT_HR_FECHAMENTO", SqlDbType.SmallDateTime).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                //cmd.Parameters.Add("@VALOR_FINAL", SqlDbType.Decimal).Value = caixaVO.valor_final;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
    }
}
