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
    class TipoProdutoDA
    {
        Funcoes _funcoes = new Funcoes();

        public bool gravarTipoProduto(TipoProdutoVO tipoProdutoVO)
        {
            try
            {
                string sql = @"INSERT INTO TIPO_PRODUTO(PK_CODIGO,DESCRICAO)
                             VALUES(@PK_CODIGO,@DESCRICAO)";
                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("TIPO_PRODUTO", "PK_CODIGO");
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = tipoProdutoVO.descricao;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool excluirTipoProduto(TipoProdutoVO tipoProdutoVO)
        {
            try
            {
                string sql = @"DELETE FROM TIPO_PRODUTO WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = tipoProdutoVO.pk_codigo;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool alterarTipoProduto(TipoProdutoVO tipoProdutoVO)
        {
            try
            {
                string sql = @"UPDATE TIPO_PRODUTO SET DESCRICAO = @DESCRICAO WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = tipoProdutoVO.pk_codigo;
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = tipoProdutoVO.descricao;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TipoProdutoVO> buscarTipoProduto(TipoProdutoVO tipoProdutoVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SELECT * FROM TIPO_PRODUTO WHERE NOT PK_CODIGO IS NULL ");

            if (!string.IsNullOrEmpty(tipoProdutoVO.descricao))
                sb.Append("AND DESCRICAO LIKE '%" + tipoProdutoVO.descricao + "%'");

            sb.Append(" ORDER BY DESCRICAO");

            string sql = Convert.ToString(sb);

            List<TipoProdutoVO> lista = new List<TipoProdutoVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var tipoProduto = new TipoProdutoVO();
                    mapTipoProduto(tipoProduto, reader);
                    lista.Add(tipoProduto);
                }
            }
            return lista;
        }

        private void mapTipoProduto(TipoProdutoVO tipoProdutoVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                tipoProdutoVO.pk_codigo = Convert.ToInt32(reader["PK_CODIGO"]);

            if (reader["DESCRICAO"] != DBNull.Value)
                tipoProdutoVO.descricao = Convert.ToString(reader["DESCRICAO"]);
        }
    }
}
