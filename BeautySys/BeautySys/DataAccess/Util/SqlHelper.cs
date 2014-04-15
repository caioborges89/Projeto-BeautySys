using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BeautySys.DataAccess.Util
{
    class SqlHelper
    {
        private static SqlConnection _cnn;
        private static object _lock = new object();
        //public static string NOME_BANCO;

        public static string SERVIDOR = string.Empty;

        public static T executeScalar<T>(string cmdText)
        {

            var cmd = getCommand(cmdText);
            return executeScalar<T>(cmd);
        }

        public static T executeScalar<T>(SqlCommand cmd)
        {
            lock (_lock)
            {
                if (cmd.Connection == null)
                    cmd.Connection = getOpenConnection();
                else if (cmd.Connection.State == ConnectionState.Closed)
                    cmd.Connection.Open();

                System.Diagnostics.Debug.WriteLine(cmd.CommandText);

                cmd.Prepare();

                var obj = cmd.ExecuteScalar();

                if (obj == null || obj == DBNull.Value)
                    return default(T);

                closeConnection();

                if (typeof(T) == typeof(long))
                    obj = Convert.ToInt64(obj);
                else if (typeof(T) == typeof(string))
                    obj = Convert.ToString(obj);
                else if (typeof(T) == typeof(bool))
                    obj = Convert.ToBoolean(obj);


                return (T)obj;
            }

        }

        public static int executeNonQuery(string cmdText)
        {
            var cmd = getCommand(cmdText);
            int retorno = executeNonQuery(cmd);

            closeConnection();

            return retorno;

        }

        public static SqlDataReader executeReader(string cmdText)
        {
            var cmd = getCommand(cmdText);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public static int executeNonQuery(SqlCommand cmd)
        {
            lock (_lock)
            {
                if (cmd.Connection == null)
                    cmd.Connection = getOpenConnection();
                else if (cmd.Connection.State == ConnectionState.Closed)
                    cmd.Connection.Open();
                System.Diagnostics.Debug.WriteLine(cmd.CommandText);

                var obj = cmd.ExecuteNonQuery();

                closeConnection();

                return obj;
            }

        }

        public static SqlCommand getCommand(string cmdText)
        {
            System.Diagnostics.Debug.WriteLine(cmdText);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = cmdText;
            cmd.Connection = getOpenConnection();
            return cmd;
        }


        public static SqlConnection getOpenConnection()
        {
            try
            {
                if (_cnn == null)
                    _cnn = new SqlConnection();

                if (_cnn.State == System.Data.ConnectionState.Open)
                    return _cnn;

               // _cnn.ConnectionString = "Data Source= " + SERVIDOR + ";  Initial Catalog=BD_BEAUTY; User ID= user_beauty; Password=1234abcd; MultipleActiveResultSets = true;";

                _cnn.ConnectionString = "Server = " + SERVIDOR + "; Database = BD_BEAUTY; Trusted_Connection = True;MultipleActiveResultSets = true;";
                          
                _cnn.Open();

                return _cnn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //private static SqlCommand Login()
        public static SqlCommand Login()
        {

            var sql = new SqlCommand(@"IF EXISTS (SELECT * FROM sys.syslogins WHERE name = 'user_beauty')
	                                            BEGIN
		                                            DROP LOGIN user_beauty
	                                            END

                                            CREATE LOGIN [user_beauty] WITH PASSWORD=N'1234abcd', 
	                                            DEFAULT_DATABASE=[BD_BEAUTY], 
	                                            DEFAULT_LANGUAGE=[us_english], 
	                                            CHECK_EXPIRATION=OFF, 
	                                            CHECK_POLICY=OFF
                                            	

                                            DECLARE 
                                            @NAME VARCHAR(150),
                                            @SQL VARCHAR(MAX)

                                            DECLARE  CUR CURSOR FOR 
                                            select name from sys.databases where 
                                            name = 'BD_BEAUTY'

                                            OPEN CUR

                                            FETCH NEXT FROM CUR 
                                            INTO @NAME

                                            WHILE @@FETCH_STATUS = 0
                                            BEGIN 

	                                            SET @SQL = 'USE [' +@NAME + ']
                                            							
				                                            if  ISNULL((select USER_ID(''USER_BEAUTY'')),-1) <> -1
				                                            BEGIN
					                                            DROP USER [USER_BEAUTY]
				                                            END'
	                                            EXEC (@SQL)
                                            	
	                                            SET @SQL = 'USE [' +@NAME + '] 
				                                            CREATE USER [user_beauty] FOR LOGIN [user_beauty] WITH DEFAULT_SCHEMA=[dbo]
				                                            EXEC sp_addrolemember N''db_owner'', N''user_beauty'' '
                                            				
	                                            EXEC (@SQL)
                                            	
	                                            FETCH NEXT FROM CUR 
	                                            INTO @NAME
                                            END

                                            CLOSE CUR
                                            DEALLOCATE CUR");
            return sql;
        }

        public static void closeConnection()
        {
            try
            {
                if (_cnn != null)
                    if (_cnn.State == ConnectionState.Open)
                        _cnn.Close();
            }
            catch { }
        }
    }
}
