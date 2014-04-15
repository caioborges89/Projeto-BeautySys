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
    class CidadeDA
    {
        Funcoes _funcoes = new Funcoes();

        public bool gravarCidade(CidadeVO cidadeVO)
        {
            try
            {
                string sql = @"INSERT INTO CIDADE(PK_CODIGO,IBGE,NOME,FK_UF)
                             VALUES(@PK_CODIGO,@IBGE,@NOME,@FK_UF)";
                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("CIDADE", "PK_CODIGO");
                cmd.Parameters.Add("@IBGE", SqlDbType.Int).Value = cidadeVO.ibge;
                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = cidadeVO.nome;
                cmd.Parameters.Add("@FK_UF", SqlDbType.VarChar).Value = cidadeVO.fk_uf;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool excluirCidade(CidadeVO cidadeVO)
        {
            try
            {
                string sql = @"DELETE FROM CIDADE WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = cidadeVO.pk_codigo;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool alterarCidade(CidadeVO cidadeVO)
        {
            try
            {
                string sql = @"UPDATE CIDADE SET NOME = @NOME, IBGE = @IBGE, FK_UF = @FK_UF WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = cidadeVO.pk_codigo;
                cmd.Parameters.Add("@IBGE", SqlDbType.Int).Value = cidadeVO.ibge;
                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = cidadeVO.nome;
                cmd.Parameters.Add("@FK_UF", SqlDbType.VarChar).Value = cidadeVO.fk_uf;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CidadeVO> buscarCidade(CidadeVO cidadeVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SELECT * FROM CIDADE WHERE NOT PK_CODIGO IS NULL");

            if (!string.IsNullOrEmpty(cidadeVO.nome))
                sb.Append(" AND NOME = '" + cidadeVO.nome + "'");

            if (!string.IsNullOrEmpty(cidadeVO.fk_uf))
                sb.Append(" AND FK_UF = '" + cidadeVO.fk_uf + "'");

            if (cidadeVO.pk_codigo > 0)
                sb.Append(" AND PK_CODIGO = '" + cidadeVO.pk_codigo + "'");

            sb.Append(" ORDER BY NOME");

            string sql = Convert.ToString(sb);

            List<CidadeVO> lista = new List<CidadeVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var cidade = new CidadeVO();
                    mapCidade(cidade, reader);
                    lista.Add(cidade);
                }
            }
            return lista;
        }

        private void mapCidade(CidadeVO cidadeVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                cidadeVO.pk_codigo = Convert.ToInt32(reader["PK_CODIGO"]);

            if (reader["IBGE"] != DBNull.Value)
                cidadeVO.ibge = Convert.ToInt32(reader["IBGE"]);

            if (reader["NOME"] != DBNull.Value)
                cidadeVO.nome = Convert.ToString(reader["NOME"]);

            if (reader["FK_UF"] != DBNull.Value)
                cidadeVO.fk_uf = Convert.ToString(reader["FK_UF"]);
        }
    }
}
