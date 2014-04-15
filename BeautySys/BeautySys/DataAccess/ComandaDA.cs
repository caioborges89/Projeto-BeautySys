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
    class ComandaDA
    {
        public bool gravarComanda(ComandaVO comandaVO)
        {
            try
            {
                string sql = @"INSERT INTO COMANDA(PK_CODIGO,DATA,FK_CLIENTE,FK_PROFISSIONAL,OBS,VALOR,FK_FORMA_PAGTO,DESC_TOTAL) 
                                VALUES(@PK_CODIGO,@DATA,@FK_CLIENTE,@FK_PROFISSIONAL,@OBS,@VALOR,@FK_FORMA_PAGTO,@DESC_TOTAL)";
                SqlCommand cmd = SqlHelper.getCommand(sql);
                cmd.Parameters.Add("@PK_CODIGO", SqlDbType.Int).Value = comandaVO.pk_codigo;
                cmd.Parameters.Add("@DATA", SqlDbType.SmallDateTime).Value = comandaVO.data.ToString("dd/MM/yyyy HH:mm:ss");
                cmd.Parameters.Add("@FK_CLIENTE", SqlDbType.NVarChar).Value = comandaVO.fk_cliente;
                cmd.Parameters.Add("@FK_PROFISSIONAL", SqlDbType.NVarChar).Value = comandaVO.fk_profissional;
                cmd.Parameters.Add("@OBS", SqlDbType.NVarChar).Value = comandaVO.obs;
                cmd.Parameters.Add("@VALOR", SqlDbType.Decimal).Value = comandaVO.valor;
                cmd.Parameters.Add("@FK_FORMA_PAGTO", SqlDbType.Int).Value = comandaVO.fk_forma_pagto;
                cmd.Parameters.Add("@DESC_TOTAL", SqlDbType.Decimal).Value = comandaVO.desc_total;

                SqlHelper.executeNonQuery(cmd);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
