using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BeautySys.Util;
using BeautySys.Classes;
using BeautySys.DataAccess.Util;
using System.Windows.Forms;

namespace BeautySys.DataAccess
{
    class ProdutoDA
    {
        Funcoes _funcoes = new Funcoes();

        /// <summary>
        /// Método que faz a gravação dos dados do produto
        /// no banco de dados.
        /// </summary>
        /// <param name="produtoVO"></param>
        /// <returns></returns>
        public bool gravarProduto(ProdutoVO produtoVO)
        {
            try
            {
                string sql = @"INSERT INTO PRODUTO(PK_CODIGO,DESCRICAO,FK_TIPO_PRODUTO,
                             FK_MEDIDA,QTDE_ESTOQUE,ESTOQUE_MINIMO,VALOR,CUSTO,DESC_MAX,COMISSAO,OBS)
                             VALUES(@PK_CODIGO,@DESCRICAO,@FK_TIPO_PRODUTO,@FK_MEDIDA,@QTDE_ESTOQUE,
                             @ESTOQUE_MINIMO,@VALOR,@CUSTO,@DESC_MAX,@COMISSAO,@OBS)";

                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("PRODUTO", "PK_CODIGO");
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = produtoVO.descricao;
                cmd.Parameters.Add("@FK_TIPO_PRODUTO", SqlDbType.Int).Value = produtoVO.fk_tipo_produto;
                cmd.Parameters.Add("@FK_MEDIDA", SqlDbType.VarChar).Value = produtoVO.fk_medida;
                cmd.Parameters.Add("@QTDE_ESTOQUE", SqlDbType.Decimal).Value = produtoVO.qtde_estoque;
                cmd.Parameters.Add("@ESTOQUE_MINIMO", SqlDbType.Int).Value = produtoVO.estoque_minimo;
                cmd.Parameters.Add("@VALOR", SqlDbType.Decimal).Value = produtoVO.valor;
                cmd.Parameters.Add("@CUSTO", SqlDbType.Decimal).Value = produtoVO.custo;
                cmd.Parameters.Add("@DESC_MAX", SqlDbType.Decimal).Value = produtoVO.desc_max;
                cmd.Parameters.Add("@COMISSAO", SqlDbType.Decimal).Value = produtoVO.comissao;
                cmd.Parameters.Add("@OBS", SqlDbType.NVarChar).Value = produtoVO.obs;

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
        /// <param name="produtoVO"></param>
        /// <returns></returns>
        public bool  excluirProduto(ProdutoVO produtoVO)
        {
            try
            {
                string sql = @"DELETE FROM PRODUTO WHERE PK_CODIGO = @PK_CODIGO";

                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = produtoVO.pk_codigo;

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
        /// <param name="produtoVO"></param>
        /// <returns></returns>
        public bool alterarProduto(ProdutoVO produtoVO)
        {
            try
            {
                string sql = @"UPDATE PRODUTO SET 
                               DESCRICAO         = @DESCRICAO,                                 
                               FK_TIPO_PRODUTO = @FK_TIPO_PRODUTO,
                               FK_MEDIDA         = @FK_MEDIDA,   
                               QTDE_ESTOQUE      = @QTDE_ESTOQUE,
                               ESTOQUE_MINIMO    = @ESTOQUE_MINIMO,
                               VALOR             = @VALOR,
                               CUSTO             = @CUSTO,
                               DESC_MAX          = @DESC_MAX,
                               COMISSAO          = @COMISSAO,
                               OBS               = @OBS
                                WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = produtoVO.descricao;
                cmd.Parameters.Add("@FK_TIPO_PRODUTO", SqlDbType.Int).Value = produtoVO.fk_tipo_produto;
                cmd.Parameters.Add("@FK_MEDIDA", SqlDbType.VarChar).Value = produtoVO.fk_medida;
                cmd.Parameters.Add("@QTDE_ESTOQUE", SqlDbType.Decimal).Value = produtoVO.qtde_estoque;
                cmd.Parameters.Add("@ESTOQUE_MINIMO", SqlDbType.Int).Value = produtoVO.estoque_minimo;
                cmd.Parameters.Add("@VALOR", SqlDbType.Decimal).Value = produtoVO.valor;
                cmd.Parameters.Add("@CUSTO", SqlDbType.Decimal).Value = produtoVO.custo;
                cmd.Parameters.Add("@DESC_MAX", SqlDbType.Decimal).Value = produtoVO.desc_max;
                cmd.Parameters.Add("@COMISSAO", SqlDbType.Decimal).Value = produtoVO.comissao;
                cmd.Parameters.Add("@OBS", SqlDbType.NVarChar).Value = produtoVO.obs;
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = produtoVO.pk_codigo;

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
        /// Método que realiza a busca do produto
        /// </summary>
        /// <param name="produtoVO"></param>
        /// <returns></returns>
        public List<ProdutoVO> buscarProduto(ProdutoVO produtoVO)
        {
            StringBuilder sb = new StringBuilder();
            List<ProdutoVO> lista = new List<ProdutoVO>();

            sb.Append("SELECT P.PK_CODIGO, P.DESCRICAO, P.FK_TIPO_PRODUTO, P.FK_MEDIDA, P.QTDE_ESTOQUE, P.ESTOQUE_MINIMO, P.VALOR, P.CUSTO, P.DESC_MAX, P.COMISSAO, P.OBS FROM PRODUTO P");
            //sb.Append(" INNER JOIN TIPO_PRODUTO T ON P.FK_TIPO_PRODUTO = T.PK_CODIGO");
            //sb.Append(" INNER JOIN MEDIDA M ON P.FK_MEDIDA = M.PK_MEDIDA");
            sb.Append(" WHERE NOT P.PK_CODIGO IS NULL");

            if (produtoVO.pk_codigo > 0)
                sb.Append(" AND P.PK_CODIGO = '" + produtoVO.pk_codigo + "'");

            if (!string.IsNullOrEmpty(produtoVO.descricao))
                sb.Append(" AND P.DESCRICAO LIKE '%" + produtoVO.descricao + "%'");

            sb.Append(" ORDER BY DESCRICAO");

            string sql = Convert.ToString(sb);

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var produto = new ProdutoVO();
                    mapProduto(produto, reader);
                    lista.Add(produto);
                }
            }

            return lista;
        }

        private void mapProduto(ProdutoVO produtoVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                produtoVO.pk_codigo = Convert.ToInt32(reader["PK_CODIGO"]);

            if (reader["DESCRICAO"] != DBNull.Value)
                produtoVO.descricao = Convert.ToString(reader["DESCRICAO"]);

            if (reader["FK_TIPO_PRODUTO"] != DBNull.Value)
                produtoVO.fk_tipo_produto = Convert.ToInt32(reader["FK_TIPO_PRODUTO"]);

            if (reader["FK_MEDIDA"] != DBNull.Value)
                produtoVO.fk_medida = Convert.ToString(reader["FK_MEDIDA"]);

            if (reader["QTDE_ESTOQUE"] != DBNull.Value)
                produtoVO.qtde_estoque = Convert.ToDecimal(reader["QTDE_ESTOQUE"]);

            if (reader["ESTOQUE_MINIMO"] != DBNull.Value)
                produtoVO.estoque_minimo = Convert.ToInt32(reader["ESTOQUE_MINIMO"]);

            if (reader["VALOR"] != DBNull.Value)
                produtoVO.valor = Convert.ToDecimal(reader["VALOR"]);

            if (reader["CUSTO"] != DBNull.Value)
                produtoVO.custo = Convert.ToDecimal(reader["CUSTO"]);

            if (reader["DESC_MAX"] != DBNull.Value)
                produtoVO.desc_max = Convert.ToDecimal(reader["DESC_MAX"]);

            if (reader["COMISSAO"] != DBNull.Value)
                produtoVO.comissao = Convert.ToDecimal(reader["COMISSAO"]);

            if (reader["OBS"] != DBNull.Value)
                produtoVO.obs = Convert.ToString(reader["OBS"]);            

        }

    }
}
