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
    class ServicoDA
    {
        Funcoes _funcoes = new Funcoes();

        /// <summary>
        /// Método que faz a gravação dos dados do produto
        /// no banco de dados.
        /// </summary>
        /// <param name="servicoVO"></param>
        /// <returns></returns>
        public bool gravarServico(ServicoVO servicoVO)
        {
            try
            {
                string sql = @"INSERT INTO SERVICO(PK_CODIGO,DESCRICAO,FK_TIPO_SERVICO,
                             VALOR,CUSTO,DESC_MAX,DURACAO,COMISSAO,OBS)
                             VALUES(@PK_CODIGO,@DESCRICAO,@FK_TIPO_SERVICO,@VALOR,@CUSTO,
                             @DESC_MAX,@DURACAO,@COMISSAO,@OBS)";

                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("SERVICO", "PK_CODIGO");
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = servicoVO.descricao;
                cmd.Parameters.Add("@FK_TIPO_SERVICO", SqlDbType.Int).Value = servicoVO.fk_tipo_servico;
                cmd.Parameters.Add("@VALOR", SqlDbType.Decimal).Value = servicoVO.valor;
                cmd.Parameters.Add("@CUSTO", SqlDbType.Decimal).Value = servicoVO.custo;
                cmd.Parameters.Add("@DESC_MAX", SqlDbType.Decimal).Value = servicoVO.desc_max;
                cmd.Parameters.Add("@DURACAO", SqlDbType.Int).Value = servicoVO.duracao;
                cmd.Parameters.Add("@COMISSAO", SqlDbType.Decimal).Value = servicoVO.comissao;
                cmd.Parameters.Add("@OBS", SqlDbType.NVarChar).Value = servicoVO.obs;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Método que exclui um produto
        /// </summary>
        /// <param name="servicoVO"></param>
        /// <returns></returns>
        public bool excluirServico(ServicoVO servicoVO)
        {
            try
            {
                string sql = @"DELETE FROM SERVICO WHERE PK_CODIGO = @PK_CODIGO";

                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = servicoVO.pk_codigo;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Método que realiza a alteração de
        /// um produto cadastrado no sistema
        /// </summary>
        /// <param name="servicoVO"></param>
        /// <returns></returns>
        public bool alterarServico(ServicoVO servicoVO)
        {
            try
            {
                string sql = @"UPDATE SERVICO SET 
                               DESCRICAO         = @DESCRICAO,                                 
                               FK_TIPO_SERVICO   = @FK_TIPO_SERVICO,
                               VALOR             = @VALOR,
                               CUSTO             = @CUSTO,
                               DESC_MAX          = @DESC_MAX,
                               DURACAO           = @DURACAO,
                               COMISSAO          = @COMISSAO,
                               OBS               = @OBS
                               WHERE PK_CODIGO   = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = servicoVO.pk_codigo;
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = servicoVO.descricao;
                cmd.Parameters.Add("@FK_TIPO_SERVICO", SqlDbType.Int).Value = servicoVO.fk_tipo_servico;
                cmd.Parameters.Add("@VALOR", SqlDbType.Decimal).Value = servicoVO.valor;
                cmd.Parameters.Add("@CUSTO", SqlDbType.Decimal).Value = servicoVO.custo;
                cmd.Parameters.Add("@DESC_MAX", SqlDbType.Decimal).Value = servicoVO.desc_max;
                cmd.Parameters.Add("@DURACAO", SqlDbType.Int).Value = servicoVO.duracao;
                cmd.Parameters.Add("@COMISSAO", SqlDbType.Decimal).Value = servicoVO.comissao;
                cmd.Parameters.Add("@OBS", SqlDbType.NVarChar).Value = servicoVO.obs;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Método que realiza a busca do produto.
        /// </summary>
        /// <param name="servicoVO"></param>
        /// <returns></returns>
        public List<ServicoVO> buscarServico(ServicoVO servicoVO)
        {
            StringBuilder sb = new StringBuilder();
            List<ServicoVO> lista = new List<ServicoVO>();

            sb.Append("SELECT * FROM SERVICO WHERE NOT PK_CODIGO IS NULL ");

            if (servicoVO.pk_codigo > 0)
                sb.Append(" AND PK_CODIGO = '" + servicoVO.pk_codigo + "'");

            if (!string.IsNullOrEmpty(servicoVO.descricao))
                sb.Append("AND DESCRICAO LIKE '%" + servicoVO.descricao + "%'");

            sb.Append(" ORDER BY DESCRICAO");

            string sql = Convert.ToString(sb);

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var servico = new ServicoVO();
                    mapServico(servico, reader);
                    lista.Add(servico);
                }
            }

            return lista;
        }

        private void mapServico(ServicoVO servicoVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                servicoVO.pk_codigo = Convert.ToInt32(reader["PK_CODIGO"]);

            if (reader["DESCRICAO"] != DBNull.Value)
                servicoVO.descricao = Convert.ToString(reader["DESCRICAO"]);

            if (reader["FK_TIPO_SERVICO"] != DBNull.Value)
                servicoVO.fk_tipo_servico = Convert.ToInt32(reader["FK_TIPO_SERVICO"]);

            if (reader["VALOR"] != DBNull.Value)
                servicoVO.valor = Convert.ToDecimal(reader["VALOR"]);

            if (reader["CUSTO"] != DBNull.Value)
                servicoVO.custo = Convert.ToDecimal(reader["CUSTO"]);

            if (reader["DESC_MAX"] != DBNull.Value)
                servicoVO.desc_max = Convert.ToDecimal(reader["DESC_MAX"]);

            if (reader["DURACAO"] != DBNull.Value)
                servicoVO.duracao = Convert.ToInt32(reader["DURACAO"]);

            if (reader["COMISSAO"] != DBNull.Value)
                servicoVO.comissao = Convert.ToDecimal(reader["COMISSAO"]);

            if (reader["OBS"] != DBNull.Value)
                servicoVO.obs = Convert.ToString(reader["OBS"]);

        }
    }
}
