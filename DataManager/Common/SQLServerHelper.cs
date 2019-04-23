using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace DataManager.Common
{
    public static class SQLServerHelper
    {
        private static SqlConnection conn;
        static SQLServerHelper()
        {
            if (conn == null)
            {
                conn = new SqlConnection();
                conn.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["SqlStr"].ToString();
            }
        }

        /// <summary>
        /// 查询返回DataTable
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandText = sql;
                if (parameters != null && parameters.Length > 0)
                {
                    sqlCmd.Parameters.AddRange(parameters);
                }
                sqlCmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Loger.WriteLog(ex);
                return null;
            }
        }

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static bool ExecSql(string sql, SqlParameter[] parameters)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandText = sql;
                if (parameters != null && parameters.Length>0)
                {
                    sqlCmd.Parameters.AddRange(parameters);
                }

                sqlCmd.Connection = conn;
                if (sqlCmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Loger.WriteLog(ex);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 以事务方式执行SQL语句
        /// </summary>
        /// <param name="listsqls">SQL语句list</param>
        /// <param name="listparameters">参数列表list</param>
        /// <returns>成功返回true 否则返回false</returns>
        public static bool ExecSqlByTran(List<string> listsqls, List<SqlParameter[]> listparameters)
        {
            if (listsqls == null || listparameters == null || listsqls.Count <= 0 || listparameters.Count <= 0 || listsqls.Count != listparameters.Count)
            {
                return false;
            }
            else
            {

                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    for (int i = 0; i < listsqls.Count; i++)
                    {
                        SqlCommand sqlCmd = new SqlCommand();
                        sqlCmd.CommandText = listsqls[i];
                        sqlCmd.Parameters.AddRange(listparameters[i]);
                        sqlCmd.Connection = conn;
                        sqlCmd.Transaction = tran;
                        sqlCmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    conn.Close();
                    return true;
                }
                catch(Exception ex)
                {
                    Loger.WriteLog(ex);
                    tran.Rollback();
                    conn.Close();
                    return false;
                }
                
            }
        }

    }
}
