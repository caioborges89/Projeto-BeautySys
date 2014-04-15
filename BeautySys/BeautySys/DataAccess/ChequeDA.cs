using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BeautySys.Util;
using BeautySys.Classes;
using BeautySys.DataAccess;
using BeautySys.DataAccess.Util;
using System.Windows.Forms;

namespace BeautySys.DataAccess
{
    class ChequeDA
    {
         Funcoes _funcoes = new Funcoes();

        public bool gravarCheque(ChequeVO chequeVO)
        {
            try
            {
                string sql = @"INSERT INTO MEDIDA(PK_CODIGO,NRO,BANCO,FK_CLIENTE,DT_EMISSAO,DT_VENCIMENTO,VALOR,SITUACAO) 
                                   VALUES(@PK_CODIGO,@NRO,@BANCO,@FK_CLIENTE,@DT_EMISSAO,@DT_VENCIMENTO,@VALOR,@SITUACAO)";

                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("CHEQUE", "PK_CODIGO");
                cmd.Parameters.Add("@NRO", SqlDbType.Int).Value = chequeVO.nro;
                cmd.Parameters.Add("@BANCO", SqlDbType.Char).Value = chequeVO.banco;
                cmd.Parameters.Add("@FK_CLIENTE", SqlDbType.Int).Value = chequeVO.fk_cliente;
                cmd.Parameters.Add("@DT_EMISSAO", SqlDbType.SmallDateTime).Value = chequeVO.dt_emissao;
                cmd.Parameters.Add("@DT_VENCIMENTO", SqlDbType.SmallDateTime).Value = chequeVO.dt_vencimento;
                cmd.Parameters.Add("@VALOR", SqlDbType.Decimal).Value = chequeVO.valor;
                cmd.Parameters.Add("@SITUACAO", SqlDbType.Bit).Value = chequeVO.situacao;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool excluirCheque(ChequeVO chequeVO)
        {
            try
            {
                string sql = @"DELETE FROM CHEQUE WHERE PK_CODIGO = @PK_CODIGO";

                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = chequeVO.pk_codigo;
                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool alterarCheque(ChequeVO chequeVO)
        {
            try
            {
                string sql = @"UPDATE CHEQUE    SET 
                               NRO              = @NRO, 
                               BANCO            = @BANCO, 
                               FK_CLIENTE       = @FK_CLIENTE,
                               DT_EMISSAO       = @DT_EMISSAO,
                               DT_VENCIMENTO    = @DT_VENCIMENTO, 
                               VALOR            = @VALOR,
                               SITUACAO         = @SITUACAO 
                               WHERE PK_CODIGO  = @PK_CODIGO";

                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("CHEQUE", "PK_CODIGO");
                cmd.Parameters.Add("@NRO", SqlDbType.Int).Value = chequeVO.nro;
                cmd.Parameters.Add("@BANCO", SqlDbType.Char).Value = chequeVO.banco;
                cmd.Parameters.Add("@FK_CLIENTE", SqlDbType.Int).Value = chequeVO.fk_cliente;
                cmd.Parameters.Add("@DT_EMISSAO", SqlDbType.SmallDateTime).Value = chequeVO.dt_emissao;
                cmd.Parameters.Add("@DT_VENCIMENTO", SqlDbType.SmallDateTime).Value = chequeVO.dt_vencimento;
                cmd.Parameters.Add("@VALOR", SqlDbType.Decimal).Value = chequeVO.valor;
                cmd.Parameters.Add("@SITUACAO", SqlDbType.Bit).Value = chequeVO.situacao;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<ChequeVO> buscarCheque(ChequeVO chequeVO)
        {
            StringBuilder sb = new StringBuilder();
            List<ChequeVO> lista = new List<ChequeVO>();

            sb.Append("SELECT * FROM CHEQUE WHERE NOT PK_CODIGO IS NULL ");

            if (!string.IsNullOrEmpty(chequeVO.nro.ToString()))
                sb.Append("AND NRO LIKE '%" + chequeVO.nro + "%'");

            sb.Append(" ORDER BY NRO");

            string sql = Convert.ToString(sb);

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var cheque = new ChequeVO();
                    mapCheque(cheque, reader);
                    lista.Add(cheque);
                }
            }

            return lista;
        }

        private void mapCheque(ChequeVO chequeVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                chequeVO.pk_codigo = Convert.ToInt16( reader["PK_CODIGO"]);

            if (reader["NRO"] != DBNull.Value)
                chequeVO.nro = Convert.ToInt16(reader["NRO"]);

            if (reader["BANCO"] != DBNull.Value)
                chequeVO.banco = Convert.ToString(reader["BANCO"]);

            if (reader["FK_CLIENTE"] != DBNull.Value)
                chequeVO.fk_cliente = Convert.ToInt16(reader["FK_CLIENTE"]);

            if (reader["DT_EMISSAO"] != DBNull.Value)
                chequeVO.dt_emissao = Convert.ToDateTime(reader["DT_EMISSAO"]);

            if (reader["DT_VENCIMENTO"] != DBNull.Value)
                chequeVO.dt_vencimento = Convert.ToDateTime(reader["DT_VENCIMENTO"]);

            if (reader["VALOR"] != DBNull.Value)
                chequeVO.valor = Convert.ToDecimal(reader["VALOR"]);

            if (reader["SITUACAO"] != DBNull.Value)
                chequeVO.situacao = Convert.ToInt32(reader["SITUACAO"]);
        }
    }
    
}
