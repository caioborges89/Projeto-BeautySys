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
    class TipoServicoDA
    {
        Funcoes _funcoes = new Funcoes();

        public bool gravarTipoServico(TipoServicoVO tipoServicoVO)
        {
            try
            {
                string sql = @"INSERT INTO TIPO_SERVICO(PK_CODIGO,DESCRICAO)
                             VALUES(@PK_CODIGO,@DESCRICAO)";
                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("TIPO_SERVICO", "PK_CODIGO");
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = tipoServicoVO.descricao;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool excluirTipoServico(TipoServicoVO tipoServicoVO)
        {
            try
            {
                string sql = @"DELETE FROM TIPO_SERVICO WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = tipoServicoVO.pk_codigo;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool alterarTipoServico(TipoServicoVO tipoServicoVO)
        {
            try
            {
                string sql = @"UPDATE TIPO_SERVICO SET DESCRICAO = @DESCRICAO WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = tipoServicoVO.pk_codigo;
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = tipoServicoVO.descricao;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TipoServicoVO> buscarTipoServico(TipoServicoVO tipoServicoVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SELECT * FROM TIPO_SERVICO WHERE NOT PK_CODIGO IS NULL ");

            if (!string.IsNullOrEmpty(tipoServicoVO.descricao))
                sb.Append("AND DESCRICAO LIKE '%" + tipoServicoVO.descricao + "%'");

            sb.Append(" ORDER BY DESCRICAO");

            string sql = Convert.ToString(sb);

            List<TipoServicoVO> lista = new List<TipoServicoVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var tipoServico = new TipoServicoVO();
                    mapTipoServico(tipoServico, reader);
                    lista.Add(tipoServico);
                }
            }
            return lista;
        }

        private void mapTipoServico(TipoServicoVO tipoServicoVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                tipoServicoVO.pk_codigo = Convert.ToInt32(reader["PK_CODIGO"]);

            if (reader["DESCRICAO"] != DBNull.Value)
                tipoServicoVO.descricao = Convert.ToString(reader["DESCRICAO"]);
        }
    }
}
