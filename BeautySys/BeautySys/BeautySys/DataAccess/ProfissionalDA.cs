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
    class ProfissionalDA
    {
        Funcoes _funcoes = new Funcoes();

        public bool gravarProfissional(ProfissionalVO profissionalVO)
        {
            try
            {
                string sql = @"INSERT INTO PROFISSIONAL(PK_CODIGO,NOME,TELEFONE,CELULAR,EMAIL,DT_NASCTO,CPF,RG,DT_CAD,CEP,ENDERECO,NUMERO,COMPLEMENTO,BAIRRO,FK_CIDADE,OBS) 
                             VALUES(@PK_CODIGO,@NOME,@TELEFONE,@CELULAR,@EMAIL,@DT_NASCTO,@CPF,@RG,@DT_CAD,@CEP,@ENDERECO,@NUMERO,@COMPLEMENTO,@BAIRRO,@FK_CIDADE,@OBS)";
                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("profissional", "PK_CODIGO");
                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = profissionalVO.nome;
                cmd.Parameters.Add("@TELEFONE", SqlDbType.NVarChar).Value = profissionalVO.telefone;
                cmd.Parameters.Add("@CELULAR", SqlDbType.NVarChar).Value = profissionalVO.celular;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = profissionalVO.email;
                cmd.Parameters.Add("@DT_NASCTO", SqlDbType.Date).Value = profissionalVO.dt_nascto.ToString("dd/MM/yyyy");
                cmd.Parameters.Add("@CPF", SqlDbType.NVarChar).Value = profissionalVO.cpf;
                cmd.Parameters.Add("@RG", SqlDbType.NVarChar).Value = profissionalVO.rg;
                cmd.Parameters.Add("@DT_CAD", SqlDbType.SmallDateTime).Value = profissionalVO.dt_cad.ToString("dd/MM/yyyy");
                cmd.Parameters.Add("@CEP", SqlDbType.NVarChar).Value = profissionalVO.cep;
                cmd.Parameters.Add("@ENDERECO", SqlDbType.NVarChar).Value = profissionalVO.endereco;
                cmd.Parameters.Add("@NUMERO", SqlDbType.NVarChar).Value = profissionalVO.numero;
                cmd.Parameters.Add("@COMPLEMENTO", SqlDbType.NVarChar).Value = profissionalVO.complemento;
                cmd.Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = profissionalVO.bairro;
                cmd.Parameters.Add("@FK_CIDADE", SqlDbType.Int).Value = profissionalVO.fk_cidade;
                cmd.Parameters.Add("@OBS", SqlDbType.NVarChar).Value = profissionalVO.obs;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool excluirProfissional(ProfissionalVO profissionalVO)
        {
            try
            {
                string sql = @"DELETE FROM PROFISSIONAL WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = profissionalVO.pk_codigo;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool alterarProfissional(ProfissionalVO profissionalVO)
        {
            try
            {
                string sql = @"UPDATE PROFISSIONAL SET NOME = @NOME, TELEFONE = @TELEFONE, CELULAR = @CELULAR, EMAIL = @EMAIL, DT_NASCTO = @DT_NASCTO, CPF = @CPF, RG = @RG, DT_CAD = @DT_CAD, CEP = @CEP, ENDERECO = @ENDERECO, NUMERO = @NUMERO, COMPLEMENTO = @COMPLEMENTO, BAIRRO = @BAIRRO, FK_CIDADE = @FK_CIDADE, OBS = @OBS WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = profissionalVO.pk_codigo;
                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = profissionalVO.nome;
                cmd.Parameters.Add("@TELEFONE", SqlDbType.NVarChar).Value = profissionalVO.telefone;
                cmd.Parameters.Add("@CELULAR", SqlDbType.NVarChar).Value = profissionalVO.celular;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = profissionalVO.email;
                cmd.Parameters.Add("@DT_NASCTO", SqlDbType.Date).Value = profissionalVO.dt_nascto;
                cmd.Parameters.Add("@CPF", SqlDbType.NVarChar).Value = profissionalVO.cpf;
                cmd.Parameters.Add("@RG", SqlDbType.NVarChar).Value = profissionalVO.rg;
                cmd.Parameters.Add("@DT_CAD", SqlDbType.SmallDateTime).Value = profissionalVO.dt_cad;
                cmd.Parameters.Add("@CEP", SqlDbType.NVarChar).Value = profissionalVO.cep;
                cmd.Parameters.Add("@ENDERECO", SqlDbType.NVarChar).Value = profissionalVO.endereco;
                cmd.Parameters.Add("@NUMERO", SqlDbType.NVarChar).Value = profissionalVO.numero;
                cmd.Parameters.Add("@COMPLEMENTO", SqlDbType.NVarChar).Value = profissionalVO.complemento;
                cmd.Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = profissionalVO.bairro;
                cmd.Parameters.Add("@FK_CIDADE", SqlDbType.Int).Value = profissionalVO.fk_cidade;
                cmd.Parameters.Add("@OBS", SqlDbType.NVarChar).Value = profissionalVO.obs;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProfissionalVO> buscarProfissional(ProfissionalVO profissionalVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SELECT C.PK_CODIGO, C.NOME, C.TELEFONE, C.CELULAR, C.EMAIL, C.DT_NASCTO, C.CPF, C.RG, C.DT_CAD, C.CEP, C.ENDERECO, C.NUMERO, C.COMPLEMENTO, C.BAIRRO, C.FK_CIDADE, C.OBS, CID.FK_UF AS UF  FROM PROFISSIONAL C LEFT JOIN CIDADE CID ON C.FK_CIDADE = CID.PK_CODIGO WHERE NOT C.PK_CODIGO IS NULL ");

            if (profissionalVO.pk_codigo > 0)
                sb.Append("AND C.PK_CODIGO = '" + profissionalVO.pk_codigo + "'");

            if (!string.IsNullOrEmpty(profissionalVO.nome))
                sb.Append("AND C.NOME LIKE '%" + profissionalVO.nome + "%'");

            sb.Append(" ORDER BY NOME");

            string sql = Convert.ToString(sb);

            List<ProfissionalVO> lista = new List<ProfissionalVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var profissional = new ProfissionalVO();
                    mapProfissional(profissional, reader);
                    lista.Add(profissional);
                }
            }
            return lista;
        }

        private void mapProfissional(ProfissionalVO profissionalVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                profissionalVO.pk_codigo = Convert.ToInt32(reader["PK_CODIGO"]);

            if (reader["NOME"] != DBNull.Value)
                profissionalVO.nome = Convert.ToString(reader["NOME"]);

            if (reader["TELEFONE"] != DBNull.Value)
                profissionalVO.telefone = Convert.ToString(reader["TELEFONE"]);

            if (reader["CELULAR"] != DBNull.Value)
                profissionalVO.celular = Convert.ToString(reader["CELULAR"]);

            if (reader["EMAIL"] != DBNull.Value)
                profissionalVO.email = Convert.ToString(reader["EMAIL"]);

            if (reader["DT_NASCTO"] != DBNull.Value)
                profissionalVO.dt_nascto = Convert.ToDateTime(reader["DT_NASCTO"]);

            if (reader["CPF"] != DBNull.Value)
                profissionalVO.cpf = Convert.ToString(reader["CPF"]);

            if (reader["RG"] != DBNull.Value)
                profissionalVO.rg = Convert.ToString(reader["RG"]);

            if (reader["DT_CAD"] != DBNull.Value)
                profissionalVO.dt_cad = Convert.ToDateTime(reader["DT_CAD"]);

            if (reader["CEP"] != DBNull.Value)
                profissionalVO.cep = Convert.ToString(reader["CEP"]);

            if (reader["ENDERECO"] != DBNull.Value)
                profissionalVO.endereco = Convert.ToString(reader["ENDERECO"]);

            if (reader["NUMERO"] != DBNull.Value)
                profissionalVO.numero = Convert.ToString(reader["NUMERO"]);

            if (reader["COMPLEMENTO"] != DBNull.Value)
                profissionalVO.complemento = Convert.ToString(reader["COMPLEMENTO"]);

            if (reader["BAIRRO"] != DBNull.Value)
                profissionalVO.bairro = Convert.ToString(reader["BAIRRO"]);

            if (reader["FK_CIDADE"] != DBNull.Value)
                profissionalVO.fk_cidade = Convert.ToInt32(reader["FK_CIDADE"]);

            if (reader["OBS"] != DBNull.Value)
                profissionalVO.obs = Convert.ToString(reader["OBS"]);

            if (reader["UF"] != DBNull.Value)
                profissionalVO.uf = Convert.ToString(reader["UF"]);
        }
    }
}
