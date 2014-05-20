using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BeautySys.Util;
using BeautySys.Classes;
using BeautySys.DataAccess;
using BeautySys.DataAccess.Util;
using System.Windows.Forms;

namespace BeautySys.DataAccess
{  
    class SituacaoChequeDA
    {
        Funcoes _funcoes = new Funcoes();
        ChequeVO chequeVO = new ChequeVO();

        public bool gravarSituacaoCheque(SituacaoChequeVO situacaoChequeVO)
        {
            try
            {
                string sql = @"INSERT INTO SITUACAO_CHEQUE(PK_CODIGO,DESCRICAO) 
                               VALUES(@PK_CODIGO,@DESCRICAO)";

                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("SITUACAO_CHEQUE", "PK_CODIGO");
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = situacaoChequeVO.descricao;                

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool excluirSituacaoCheque(SituacaoChequeVO SituacaoChequeVO)
        {
            try
            {
                string sql = @"DELETE FROM SITUACAO_CHEQUE WHERE PK_CODIGO = @PK_CODIGO";

                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = SituacaoChequeVO.pk_codigo;
                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool alterarSituacaoCheque(SituacaoChequeVO SituacaoChequeVO)
        {
            try
            {
                string sql = @"UPDATE SITUACAO_CHEQUE    SET 
                               DESCRICAO        = @DESCRICAO
                               WHERE PK_CODIGO  = @PK_CODIGO";

                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("SITUACAO_CHEQUE", "PK_CODIGO");
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.Int).Value = SituacaoChequeVO.descricao;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<SituacaoChequeVO> buscarSituacaoCheque(SituacaoChequeVO situacaoChequeVO)
        {
            StringBuilder sb = new StringBuilder();
            List<SituacaoChequeVO> lista = new List<SituacaoChequeVO>();

            sb.Append("SELECT * FROM SITUACAO_CHEQUE WHERE NOT PK_CODIGO IS NULL ");

            string sql = Convert.ToString(sb);

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var situacaoCheque = new SituacaoChequeVO();
                    mapSituacaoCheque(situacaoCheque, reader);
                    lista.Add(situacaoCheque);
                }
            }

            return lista;
        }

        private void mapSituacaoCheque(SituacaoChequeVO situacaoChequeVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                situacaoChequeVO.pk_codigo = Convert.ToInt16(reader["PK_CODIGO"]);

            if (reader["DESCRICAO"] != DBNull.Value)
                situacaoChequeVO.descricao =  reader["DESCRICAO"].ToString();

        }
    }

    
}
