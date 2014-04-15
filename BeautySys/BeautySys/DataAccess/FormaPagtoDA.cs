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
    class FormaPagtoDA
    {
        Funcoes _funcoes = new Funcoes();

        public bool gravarFormaPagto(FormaPagtoVO formaPagtoVO)
        {
            try
            {
                string sql = @"INSERT INTO FORMA_PAGTO(PK_CODIGO,DESCRICAO,FK_TIPO) 
                                VALUES(@PK_CODIGO,@DESCRICAO,@FK_TIPO)";
                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("FORMA_PAGTO", "PK_CODIGO"); ;
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = formaPagtoVO.descricao;
                cmd.Parameters.Add("@FK_TIPO", SqlDbType.Int).Value = formaPagtoVO.fk_tipo;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool excluirFormaPagto(FormaPagtoVO formaPagtoVO)
        {
            try
            {
                string sql = @"DELETE FROM FORMA_PAGTO WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.VarChar).Value = formaPagtoVO.pk_codigo;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool alterarFormaPagto(FormaPagtoVO formaPagtoVO)
        {
            try
            {
                string sql = @"UPDATE FORMA_PAGTO SET DESCRICAO = @DESCRICAO, FK_TIPO = @FK_TIPO WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = formaPagtoVO.pk_codigo;
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = formaPagtoVO.descricao;
                cmd.Parameters.Add("@FK_TIPO", SqlDbType.Int).Value = formaPagtoVO.fk_tipo;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FormaPagtoVO> buscarFormaPagto(FormaPagtoVO formaPagtoVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SELECT F.PK_CODIGO, F.DESCRICAO, T.DESCRICAO AS TIPO FROM FORMA_PAGTO F ");
            sb.Append("INNER JOIN TIPO_PAGTO T ON F.FK_TIPO = T.PK_CODIGO ");
            sb.Append("WHERE NOT F.PK_CODIGO IS NULL");

            if (formaPagtoVO.pk_codigo > 0)
                sb.Append(" AND F.PK_CODIGO = '" + formaPagtoVO.pk_codigo + "'");

            if (!string.IsNullOrEmpty(formaPagtoVO.descricao))
                sb.Append(" AND F.DESCRICAO = '" + formaPagtoVO.descricao + "'");

            sb.Append(" ORDER BY F.DESCRICAO");

            string sql = Convert.ToString(sb);

            List<FormaPagtoVO> lista = new List<FormaPagtoVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var formaPagto = new FormaPagtoVO();
                    mapformaPagto(formaPagto, reader);
                    lista.Add(formaPagto);
                }
            }
            return lista;
        }

        private void mapformaPagto(FormaPagtoVO formaPagtoVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                formaPagtoVO.pk_codigo = Convert.ToInt32(reader["PK_CODIGO"]);

            if (reader["DESCRICAO"] != DBNull.Value)
                formaPagtoVO.descricao = Convert.ToString(reader["DESCRICAO"]);

            if (reader["TIPO"] != DBNull.Value)
                formaPagtoVO.tipo = Convert.ToString(reader["TIPO"]);
        }
    }
}
