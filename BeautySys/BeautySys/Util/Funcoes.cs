using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using BeautySys.DataAccess.Util;

namespace BeautySys.Util
{
    class Funcoes
    {
        public int novoCodigo(string nomeTabela, string nomeCampo)
        {
            try
            {
                int codigo;
                string sql = "SELECT MAX(" + nomeCampo + ") + 1 AS CODIGO FROM " + nomeTabela ;
                IDataReader reader = SqlHelper.executeReader(sql);

                reader.Read();

                if (reader["CODIGO"] != DBNull.Value)
                {
                    codigo = Convert.ToInt32(reader["CODIGO"]);
                }
                else
                {
                    codigo = 1;
                }

                //if (reader.Read())
                //{
                //    codigo = Convert.ToInt32(reader["CODIGO"]);
                //}
                //else
                //{
                //    codigo = 1;
                //}
                return codigo;
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }       
            
            
        }
    }
}
