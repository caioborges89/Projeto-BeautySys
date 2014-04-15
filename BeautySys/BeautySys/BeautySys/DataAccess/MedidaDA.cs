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
    class MedidaDA
    {
        Funcoes _funcoes = new Funcoes();

        public bool gravarMedida(MedidaVO medidaVO)
        {
            try
            {
                string sql = @"INSERT INTO MEDIDA(PK_MEDIDA,NOME) VALUES(@PK_MEDIDA,@NOME)";

                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_MEDIDA", SqlDbType.VarChar).Value = _funcoes.novoCodigo("MEDIDA", "PK_MEDIDA");
                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = medidaVO.nome;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool excluirMedida(MedidaVO servicoVO)
        {
            try
            {
                string sql = @"DELETE FROM MEDIDA WHERE PK_MEDIDA = @PK_MEDIDA";

                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_MEDIDA", SqlDbType.VarChar).Value = servicoVO.pk_medida;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool alterarMedida(MedidaVO medidaVO)
        {
            try
            {
                string sql = @"UPDATE MEDIDA SET NOME = @NOME WHERE PK_MEDIDA = @PK_MEDIDA";

                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@PK_MEDIDA", SqlDbType.VarChar).Value = medidaVO.pk_medida;
                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = medidaVO.nome;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<MedidaVO> buscarMedida(MedidaVO medidaVO)
        {
            StringBuilder sb = new StringBuilder();
            List<MedidaVO> lista = new List<MedidaVO>();

            sb.Append("SELECT * FROM MEDIDA WHERE NOT PK_MEDIDA IS NULL ");

            if (!string.IsNullOrEmpty(medidaVO.nome))
                sb.Append("AND NOME LIKE '%" + medidaVO.nome + "%'");

            sb.Append(" ORDER BY NOME");

            string sql = Convert.ToString(sb);

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var medida = new MedidaVO();
                    mapMedida(medida, reader);
                    lista.Add(medida);
                }
            }

            return lista;
        }

        private void mapMedida(MedidaVO medidaVO, IDataReader reader)
        {
            if (reader["PK_MEDIDA"] != DBNull.Value)
                medidaVO.pk_medida = Convert.ToString(reader["PK_MEDIDA"]);

            if (reader["NOME"] != DBNull.Value)
                medidaVO.nome = Convert.ToString(reader["NOME"]);
        }
    }
}
