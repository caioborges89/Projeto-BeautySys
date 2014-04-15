using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using BeautySys.DataAccess.Util;
using BeautySys.Classes;
using BeautySys.Util;

namespace BeautySys.DataAccess
{
    class UsuarioDA
    {
        Funcoes _funcoes = new Funcoes();
        UsuarioVO _usuarioVO = new UsuarioVO();

        public bool gravarUsuario(UsuarioVO usuarioVO)
        {
            try
            {
                string sql = @"INSERT INTO USUARIO(PK_CODIGO,NOME,SENHA,ULTIMO_ACESSO)
                             VALUES(@PK_CODIGO,@NOME,@SENHA,@ULTIMO_ACESSO)";
                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = _funcoes.novoCodigo("USUARIO","PK_CODIGO");
                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = usuarioVO.nome;
                cmd.Parameters.Add("@SENHA", SqlDbType.NVarChar).Value = usuarioVO.senha;
                cmd.Parameters.Add("@ULTIMO_ACESSO", SqlDbType.SmallDateTime).Value = usuarioVO.ultimo_acesso;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool excluirUsuario(UsuarioVO usuario)        
        {
            try
            {
                string sql = @"DELETE FROM USUARIO WHERE NOME = @NOME";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@NOME",SqlDbType.NVarChar).Value = usuario.nome;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<UsuarioVO> buscarUsuario(UsuarioVO value)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SELECT * FROM USUARIO WHERE NOT PK_CODIGO IS NULL ");

            if(!string.IsNullOrEmpty(value.nome) )
                sb.Append("AND NOME LIKE '%" + value.nome + "%'");
 
            sb.Append(" ORDER BY NOME");

            string sql = Convert.ToString(sb);

            List<UsuarioVO> lista = new List<UsuarioVO>();

            using(IDataReader reader = SqlHelper.executeReader(sql))
            {
                while(reader.Read())
                {
                    var usuario = new UsuarioVO();
                    mapUsuario(usuario,reader);
                    lista.Add(usuario);
                }
            }
            return lista;
        }

        private void mapUsuario(UsuarioVO usuarioVO, IDataReader reader)
        {
            //if (reader["PK_COD_USUARIO"] != DBNull.Value)
            if (reader["PK_CODIGO"] != DBNull.Value)
                usuarioVO.pk_codigo = Convert.ToInt32(reader["PK_CODIGO"]);

            if (reader["NOME"] != DBNull.Value)
                usuarioVO.nome = Convert.ToString (reader["NOME"]);

            if (reader["SENHA"] != DBNull.Value)
                usuarioVO.senha = Convert.ToString(reader["SENHA"]);

            if (reader["ULTIMO_ACESSO"] != DBNull.Value)
                usuarioVO.ultimo_acesso = Convert.ToDateTime(reader["ULTIMO_ACESSO"]);

        }
    }
}
