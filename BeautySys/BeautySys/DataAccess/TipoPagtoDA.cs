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
    class TipoPagtoDA
    {
        Funcoes _funcoes = new Funcoes();

        public List<TipoPagtoVO> buscarTipoPagto()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"SELECT * FROM TIPO_PAGTO WHERE NOT PK_CODIGO IS NULL ");

            sb.Append("ORDER BY DESCRICAO");

            string sql = Convert.ToString(sb);

            List<TipoPagtoVO> lista = new List<TipoPagtoVO>();

            using (IDataReader reader = SqlHelper.executeReader(sql))
            {
                while (reader.Read())
                {
                    var tipoPagto = new TipoPagtoVO();
                    mapTipoPagto(tipoPagto, reader);
                    lista.Add(tipoPagto);
                }
            }
            return lista;
        }

        private void mapTipoPagto(TipoPagtoVO tipoPagtoVO, IDataReader reader)
        {
            if (reader["PK_CODIGO"] != DBNull.Value)
                tipoPagtoVO.pk_codigo = Convert.ToInt32(reader["PK_CODIGO"]);

            if (reader["DESCRICAO"] != DBNull.Value)
                tipoPagtoVO.descricao = Convert.ToString(reader["DESCRICAO"]);
        }
    }
}
