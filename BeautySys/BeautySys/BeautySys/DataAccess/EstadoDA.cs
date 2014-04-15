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
    class EstadoDA
    {
        Funcoes _funcoes = new Funcoes();

        public bool gravarEstado(EstadoVO estadoVO)
        {
            try
            {
                string sql = @"INSERT INTO ESTADO(UF, NOME)
                             VALUES(@UF,@NOME)";
                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@UF", SqlDbType.VarChar).Value = estadoVO.uf;
                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = estadoVO.nome;

                SqlHelper.executeNonQuery(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool excluirEstado(EstadoVO estadoVO)
        {
            try
            {
                string sql = @"DELETE FROM ESTADO WHERE UF = @UF";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@UF", SqlDbType.VarChar).Value = estadoVO.uf;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool alterarEstado(EstadoVO estadoVO)
        {
            try
            {
                string sql = @"UPDATE ESTADO SET NOME = @NOME WHERE UF = @UF";
                SqlCommand cmd = SqlHelper.getCommand(sql);

                cmd.Parameters.Add("@UF", SqlDbType.VarChar).Value = estadoVO.uf;
                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = estadoVO.nome;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EstadoVO> buscarEstado(EstadoVO estadoVO)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SELECT * FROM ESTADO WHERE NOT UF IS NULL ");

            if (!string.IsNullOrEmpty(estadoVO.uf))
                sb.Append("AND UF LIKE '%" + estadoVO.uf + "%'");

            sb.Append(" ORDER BY NOME");

            string sql = Convert.ToString(sb);

            List<EstadoVO> lista = new List<EstadoVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var estado = new EstadoVO();
                    mapEstado(estado, reader);
                    lista.Add(estado);
                }
            }
            return lista;
        }

        private void mapEstado(EstadoVO estadoVO, IDataReader reader)
        {
            if (reader["UF"] != DBNull.Value)
                estadoVO.uf = Convert.ToString(reader["UF"]);

            if (reader["NOME"] != DBNull.Value)
                estadoVO.nome = Convert.ToString(reader["NOME"]);
        }
    }
}
