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
    class ClienteDA
    {
        Funcoes _funcoes = new Funcoes();

        public bool gravarCliente(ClienteVO clienteVO)
        {
            try
            {
                string sql = @"INSERT INTO CLIENTE(PK_CODIGO,NOME,TELEFONE,CELULAR,EMAIL,DT_NASCTO,CPF,RG,DT_CAD,CEP,ENDERECO,NUMERO,COMPLEMENTO,BAIRRO,FK_CIDADE,OBS) 
                             VALUES(@PK_CODIGO,@NOME,@TELEFONE,@CELULAR,@EMAIL,@DT_NASCTO,@CPF,@RG,@DT_CAD,@CEP,@ENDERECO,@NUMERO,@COMPLEMENTO,@BAIRRO,@FK_CIDADE,@OBS)";
                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("CLIENTE", "PK_CODIGO");
                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = clienteVO.nome;
                cmd.Parameters.Add("@TELEFONE", SqlDbType.NVarChar).Value = clienteVO.telefone;
                cmd.Parameters.Add("@CELULAR", SqlDbType.NVarChar).Value = clienteVO.celular;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = clienteVO.email;
                cmd.Parameters.Add("@DT_NASCTO", SqlDbType.Date).Value = clienteVO.dt_nascto.ToString("dd/MM/yyyy");
                cmd.Parameters.Add("@CPF", SqlDbType.NVarChar).Value = clienteVO.cpf;
                cmd.Parameters.Add("@RG", SqlDbType.NVarChar).Value = clienteVO.rg;
                cmd.Parameters.Add("@DT_CAD", SqlDbType.SmallDateTime).Value = clienteVO.dt_cad.ToString("dd/MM/yyyy");
                cmd.Parameters.Add("@CEP", SqlDbType.NVarChar).Value = clienteVO.cep;
                cmd.Parameters.Add("@ENDERECO", SqlDbType.NVarChar).Value = clienteVO.endereco;
                cmd.Parameters.Add("@NUMERO", SqlDbType.NVarChar).Value = clienteVO.numero;
                cmd.Parameters.Add("@COMPLEMENTO", SqlDbType.NVarChar).Value = clienteVO.complemento;
                cmd.Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = clienteVO.bairro;
                cmd.Parameters.Add("@FK_CIDADE", SqlDbType.Int).Value = clienteVO.fk_cidade;
                cmd.Parameters.Add("@OBS", SqlDbType.NVarChar).Value = clienteVO.obs;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool excluirCliente(ClienteVO clienteVO)
        {
            try
            {
                string sql = @"DELETE FROM CLIENTE WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = clienteVO.pk_codigo;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool alterarCliente(ClienteVO clienteVO)
        {
            try
            {
                string sql = @"UPDATE CLIENTE SET NOME = @NOME, TELEFONE = @TELEFONE, CELULAR = @CELULAR, EMAIL = @EMAIL, DT_NASCTO = @DT_NASCTO, CPF = @CPF, RG = @RG, DT_CAD = @DT_CAD, CEP = @CEP, ENDERECO = @ENDERECO, NUMERO = @NUMERO, COMPLEMENTO = @COMPLEMENTO, BAIRRO = @BAIRRO, FK_CIDADE = @FK_CIDADE, OBS = @OBS WHERE PK_CODIGO = @PK_CODIGO";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = clienteVO.pk_codigo;
                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = clienteVO.nome;
                cmd.Parameters.Add("@TELEFONE", SqlDbType.NVarChar).Value = clienteVO.telefone;
                cmd.Parameters.Add("@CELULAR", SqlDbType.NVarChar).Value = clienteVO.celular;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = clienteVO.email;
                cmd.Parameters.Add("@DT_NASCTO", SqlDbType.Date).Value = clienteVO.dt_nascto;
                cmd.Parameters.Add("@CPF", SqlDbType.NVarChar).Value = clienteVO.cpf;
                cmd.Parameters.Add("@RG", SqlDbType.NVarChar).Value = clienteVO.rg;
                cmd.Parameters.Add("@DT_CAD", SqlDbType.SmallDateTime).Value = clienteVO.dt_cad;
                cmd.Parameters.Add("@CEP", SqlDbType.NVarChar).Value = clienteVO.cep;
                cmd.Parameters.Add("@ENDERECO", SqlDbType.NVarChar).Value = clienteVO.endereco;
                cmd.Parameters.Add("@NUMERO", SqlDbType.NVarChar).Value = clienteVO.numero;
                cmd.Parameters.Add("@COMPLEMENTO", SqlDbType.NVarChar).Value = clienteVO.complemento;
                cmd.Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = clienteVO.bairro;
                cmd.Parameters.Add("@FK_CIDADE", SqlDbType.Int).Value = clienteVO.fk_cidade;
                cmd.Parameters.Add("@OBS", SqlDbType.NVarChar).Value = clienteVO.obs;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ClienteVO> buscarCliente(ClienteVO clienteVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SELECT C.PK_CODIGO, C.NOME, C.TELEFONE, C.CELULAR, C.EMAIL, C.DT_NASCTO, C.CPF, C.RG, C.DT_CAD, C.CEP, C.ENDERECO, C.NUMERO, C.COMPLEMENTO, C.BAIRRO, C.FK_CIDADE, C.OBS, CID.FK_UF AS UF  FROM CLIENTE C LEFT JOIN CIDADE CID ON C.FK_CIDADE = CID.PK_CODIGO WHERE NOT C.PK_CODIGO IS NULL ");

            if (clienteVO.pk_codigo > 0)
                sb.Append("AND C.PK_CODIGO = '" + clienteVO.pk_codigo + "'");

            if (!string.IsNullOrEmpty(clienteVO.nome))
                sb.Append("AND C.NOME LIKE '%" + clienteVO.nome + "%'");

            sb.Append(" ORDER BY NOME");

            string sql = Convert.ToString(sb);

            List<ClienteVO> lista = new List<ClienteVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var cliente = new ClienteVO();
                    mapCliente(cliente, reader);
                    lista.Add(cliente);
                }
            }
            return lista;
        }

        private void mapCliente(ClienteVO clienteVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                clienteVO.pk_codigo = Convert.ToInt32(reader["PK_CODIGO"]);

            if (reader["NOME"] != DBNull.Value)
                clienteVO.nome = Convert.ToString(reader["NOME"]);

            if (reader["TELEFONE"] != DBNull.Value)
                clienteVO.telefone = Convert.ToString(reader["TELEFONE"]);

            if (reader["CELULAR"] != DBNull.Value)
                clienteVO.celular = Convert.ToString(reader["CELULAR"]);

            if (reader["EMAIL"] != DBNull.Value)
                clienteVO.email = Convert.ToString(reader["EMAIL"]);

            if (reader["DT_NASCTO"] != DBNull.Value)
                clienteVO.dt_nascto = Convert.ToDateTime(reader["DT_NASCTO"]);

            if (reader["CPF"] != DBNull.Value)
                clienteVO.cpf = Convert.ToString(reader["CPF"]);

            if (reader["RG"] != DBNull.Value)
                clienteVO.rg = Convert.ToString(reader["RG"]);

            if (reader["DT_CAD"] != DBNull.Value)
                clienteVO.dt_cad = Convert.ToDateTime(reader["DT_CAD"]);

            if (reader["CEP"] != DBNull.Value)
                clienteVO.cep = Convert.ToString(reader["CEP"]);

            if (reader["ENDERECO"] != DBNull.Value)
                clienteVO.endereco = Convert.ToString(reader["ENDERECO"]);

            if (reader["NUMERO"] != DBNull.Value)
                clienteVO.numero = Convert.ToString(reader["NUMERO"]);

            if (reader["COMPLEMENTO"] != DBNull.Value)
                clienteVO.complemento = Convert.ToString(reader["COMPLEMENTO"]);

            if (reader["BAIRRO"] != DBNull.Value)
                clienteVO.bairro = Convert.ToString(reader["BAIRRO"]);

            if (reader["FK_CIDADE"] != DBNull.Value)
                clienteVO.fk_cidade = Convert.ToInt32(reader["FK_CIDADE"]);

            if (reader["OBS"] != DBNull.Value)
                clienteVO.obs = Convert.ToString(reader["OBS"]);

            if (reader["UF"] != DBNull.Value)
                clienteVO.uf = Convert.ToString(reader["UF"]);
        }
    }
}
