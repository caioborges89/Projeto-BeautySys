using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeautySys.DataAccess.Util;
using BeautySys.Classes;
using System.Data;
using System.Data.SqlClient;
using BeautySys.Util;

namespace BeautySys.DataAccess
{
    class LoginDA
    {
        public static string getLogin()
        {
            //***user
            //SqlCommand cmd = SqlHelper.Login();
            //SqlHelper.executeNonQuery(cmd);

            string sql = string.Format(@"SELECT * FROM USUARIO WHERE NOME = '{0}' AND SENHA = '{1}'", LoginVO.Usuario, Criptografia.criptografar(LoginVO.Senha));
            IDataReader dados = SqlHelper.executeReader(sql);

            if (dados.Read())
            {
                editarUltimoAcesso();
                return "Usuário Logado";
            }

            return null;
        }

        public static void editarUltimoAcesso()
        {
            string sql = @"UPDATE USUARIO SET ULTIMO_ACESSO = @DATA WHERE NOME = @USER";

            SqlCommand cmd = SqlHelper.getCommand(sql);

            cmd.Parameters.Add("@DATA", SqlDbType.SmallDateTime).Value = LoginVO.ultimoAcesso;
            cmd.Parameters.Add("@USER", SqlDbType.VarChar).Value = LoginVO.Usuario;

            SqlHelper.executeNonQuery(cmd);
        }
    }
}
