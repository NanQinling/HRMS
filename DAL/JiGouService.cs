using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 考勤数据访问类
    /// </summary>
    public class JiGouService
    {
        /// <summary>
        /// 查询所有组织（部门、班组）对象
        /// </summary>
        /// <param name="current_date_gz"></param>
        /// <returns></returns>
        public List<JiGou> GetAllJiGou(DateTime dateTime)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select 机构编号,机构名称,机构简称,机构类型长文本 as 机构层级,开始日期,结束日期,成立日期,成立文号,内设机构层级, 是否虚拟组织, 是否挂靠组织, 备注, ParentID, 排序, 更改者, 更改日期 from org_dept");
            sqlBuilder.Append(" inner join bas_Dept on bas_Dept.DT = org_dept.内设机构层级");
            sqlBuilder.Append(" where '{0}' between 开始日期 and 结束日期 order by ParentID,排序");

            string sql = string.Format(sqlBuilder.ToString(), dateTime);

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<JiGou> list = new List<JiGou>();
            while (objReader.Read())
            {
                list.Add(new JiGou()
                {
                    机构编号 = Convert.ToInt32(objReader["机构编号"].ToString()),
                    机构名称 = objReader["机构名称"].ToString(),
                    机构简称 = objReader["机构简称"].ToString(),
                    机构层级 = objReader["机构层级"].ToString(),
                    开始日期 = Convert.ToDateTime(objReader["开始日期"].ToString()),
                    结束日期 = Convert.ToDateTime(objReader["结束日期"].ToString()),
                    成立日期 = objReader["成立日期"].ToString(),
                    成立文号 = objReader["成立文号"].ToString(),
                    内设机构层级 = objReader["内设机构层级"].ToString(),
                    是否虚拟组织 = objReader["是否虚拟组织"].ToString(),
                    是否挂靠组织 = objReader["是否挂靠组织"].ToString(),
                    备注 = objReader["备注"].ToString(),
                    ParentID = Convert.ToInt32(objReader["ParentID"].ToString()),
                    排序 = Convert.ToInt32(objReader["排序"].ToString()),
                    更改者 = objReader["更改者"].ToString(),
                    更改日期 = Convert.ToDateTime(objReader["更改日期"].ToString())
                });
            }
            objReader.Close();
            return list;
        }


        /// <summary>
        /// 查询单一组织（部门、班组）对象
        /// </summary>
        /// <param name="current_date_gz"></param>
        /// <param name="JiGouID"></param>
        /// <returns></returns>
        public JiGou GetJiGouByJiGouID(DateTime dateTime, int id)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select 机构编号,机构名称,机构简称,机构类型长文本 as 机构层级,开始日期,结束日期,成立日期,成立文号,内设机构层级, 是否虚拟组织, 是否挂靠组织, 备注, ParentID, 排序, 更改者, 更改日期 from org_dept");
            sqlBuilder.Append(" inner join bas_Dept on bas_Dept.DT = org_dept.内设机构层级");
            sqlBuilder.Append(" where '{0}' between 开始日期 and 结束日期 and 机构编号 = {1} order by ParentID,排序");

            string sql = string.Format(sqlBuilder.ToString(), dateTime, id);

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            JiGou objJiGou = null;

            if (objReader.Read())
            {
                objJiGou = new JiGou()
                {
                    机构编号 = Convert.ToInt32(objReader["机构编号"].ToString()),
                    机构名称 = objReader["机构名称"].ToString(),
                    机构简称 = objReader["机构简称"].ToString(),
                    机构层级 = objReader["机构层级"].ToString(),
                    开始日期 = Convert.ToDateTime(objReader["开始日期"].ToString()),
                    结束日期 = Convert.ToDateTime(objReader["结束日期"].ToString()),
                    成立日期 = objReader["成立日期"].ToString(),
                    成立文号 = objReader["成立文号"].ToString(),
                    内设机构层级 = objReader["内设机构层级"].ToString(),
                    是否虚拟组织 = objReader["是否虚拟组织"].ToString(),
                    是否挂靠组织 = objReader["是否挂靠组织"].ToString(),
                    备注 = objReader["备注"].ToString(),
                    ParentID = Convert.ToInt32(objReader["ParentID"].ToString()),
                    排序 = Convert.ToInt32(objReader["排序"].ToString()),
                    更改者 = objReader["更改者"].ToString(),
                    更改日期 = Convert.ToDateTime(objReader["更改日期"].ToString())
                };
            }
            objReader.Close();
            return objJiGou;
        }


        /// <summary>
        /// 增加机构对象
        /// </summary>
        /// <param name="objJiGou"></param>
        /// <returns></returns>
        public int AddJiGou(JiGou objJiGou)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into org_dept (机构名称,机构简称,开始日期,结束日期,成立日期,成立文号,内设机构层级,是否虚拟组织,是否挂靠组织,备注,ParentID,排序,更改者,更改日期)");
            sqlBuilder.Append(" values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',{10},{11},'{12}','{13}')");

            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objJiGou.机构名称, objJiGou.机构简称, objJiGou.开始日期, objJiGou.结束日期, objJiGou.成立日期, objJiGou.成立文号, objJiGou.内设机构层级, objJiGou.是否虚拟组织, objJiGou.是否挂靠组织, objJiGou.备注, objJiGou.ParentID, objJiGou.排序, objJiGou.更改者, objJiGou.更改日期);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }


        /// <summary>
        /// 修改机构对象
        /// </summary>
        /// <param name="objJiGou"></param>
        /// <returns></returns>
        public int ModifyJiGouByJiGouID(JiGou objJiGou)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update org_dept set 内设机构层级 = '{0}',机构名称 = '{1}',机构简称 = '{2}',ParentID = {3},备注 = '{4}',开始日期 = '{5}',结束日期 = '{6}',排序 = {7},更改者 = '{8}',更改日期 = '{9}',成立日期 = '{10}',成立文号 = '{11}',是否虚拟组织 = '{12}',是否挂靠组织 = '{13}'");
            sqlBuilder.Append(" where 机构编号 = {14}");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objJiGou.内设机构层级, objJiGou.机构名称, objJiGou.机构简称, objJiGou.ParentID, objJiGou.备注, objJiGou.开始日期, objJiGou.结束日期, objJiGou.排序, objJiGou.更改者, objJiGou.更改日期, objJiGou.成立日期, objJiGou.成立文号, objJiGou.是否虚拟组织, objJiGou.是否挂靠组织, objJiGou.机构编号);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 删除机构对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteJiGouByJiGouID(int id)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("delete from org_dept");
            sqlBuilder.Append(" where 机构编号 = {0}");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), id);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }


        /// <summary>
        /// 获取机构编号最大值
        /// </summary>
        /// <returns></returns>
        public int GetMaxDeptID()
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select max(机构编号) from org_dept");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString());
            //3、执行SQL语句，返回结果
            return Convert.ToInt32(SQLHelper.GetSingleResult(sql));
        }


        public int GetMaxSortID(int id)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select max(排序) from org_dept");
            sqlBuilder.Append(" where ParentID = {0}");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), id);
            //3、执行SQL语句，返回结果
            if (SQLHelper.GetSingleResult(sql) == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            }
        }




        public List<bas_Dept> GetAllDeptLevel()
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select id,dt,机构类型长文本 as 机构层级 from bas_dept");

            string sql = string.Format(sqlBuilder.ToString());

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<bas_Dept> list = new List<bas_Dept>();
            while (objReader.Read())
            {
                list.Add(new bas_Dept()
                {
                    id = Convert.ToInt32(objReader["id"].ToString()),
                    DT = objReader["DT"].ToString(),
                    机构层级 = objReader["机构层级"].ToString()
                });
            }
            objReader.Close();
            return list;
        }




    }



}
