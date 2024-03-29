﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;//引入读取配置文件类所在的命名空间


namespace DAL
{
    /// <summary>
    /// 数据库访问类
    /// </summary>
    public class SQLHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        /// <summary>
        /// 执行增、删、改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                //写入系统日志

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        /// <summary>
        /// 获取单一结果查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                //写入系统日志

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 返回一个结果集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //写入系统日志
                conn.Close();
                throw ex;
            }
        }

        /// <summary>
        /// 执行查询返回一个DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);//创建数据适配器对象
            DataSet ds = new DataSet();//创建一个内存数据集
            try
            {
                conn.Open();
                da.Fill(ds, "No1");//使用数据适配器填充数据集
                return ds.Tables["No1"];
            }
            catch (Exception ex)
            {
                //将错误信息写入日志...

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        /// <summary>
        /// 使用sqlbulkcopy将表格导入数据库
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dt_import"></param>
        public static void ImportToSql(string tableName, DataTable dt_import)
        {

            SqlBulkCopy sqlbulkcopy = new SqlBulkCopy(connString, SqlBulkCopyOptions.UseInternalTransaction);
            try
            {
                sqlbulkcopy.DestinationTableName = tableName;
                for (int i = 0; i < dt_import.Columns.Count; i++)
                {
                    sqlbulkcopy.ColumnMappings.Add(dt_import.Columns[i].ColumnName, dt_import.Columns[i].ColumnName);
                }
                sqlbulkcopy.WriteToServer(dt_import);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
