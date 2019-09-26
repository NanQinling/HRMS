using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;

namespace DAL
{
    public class GangWeiService
    {
        /// <summary>
        /// 根据whereSql查询岗位
        /// </summary>
        /// <param name="whereSql"></param>
        /// <returns></returns>
        public List<GangWei> GetGangWeiListBySql(string whereSql)
        {
            string sql = "select 职位编码,'S '+职位名称 as 职位名称,职位简称,开始日期,结束日期,岗位性质,岗位序列,岗级,是否特殊岗位,是否关键岗位,是否运行岗位,是否虚拟岗位,备注,ParentID,排序,更改者,更改日期,岗位性质长文本 from org_posi";
            sql += " inner join bas_posi_quality on bas_posi_quality.DT = org_posi.岗位性质";
            sql += whereSql;

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<GangWei> list = new List<GangWei>();
            while (objReader.Read())
            {
                list.Add(new GangWei()
                {
                    职位编码 = Convert.ToInt32(objReader["职位编码"].ToString()),
                    职位名称 = objReader["职位名称"].ToString(),
                    职位简称 = objReader["职位简称"].ToString(),
                    开始日期 = Convert.ToDateTime(objReader["开始日期"].ToString()),
                    结束日期 = Convert.ToDateTime(objReader["结束日期"].ToString()),
                    岗位性质 = objReader["岗位性质"].ToString(),
                    岗位序列 = objReader["岗位序列"].ToString(),
                    岗级 = objReader["岗级"].ToString(),
                    是否特殊岗位 = objReader["是否特殊岗位"] is DBNull ? false : (bool)objReader["是否特殊岗位"],
                    是否关键岗位 = objReader["是否关键岗位"] is DBNull ? false : (bool)objReader["是否关键岗位"],
                    是否运行岗位 = objReader["是否运行岗位"] is DBNull ? false : (bool)objReader["是否运行岗位"],
                    是否虚拟岗位 = objReader["是否虚拟岗位"] is DBNull ? false : (bool)objReader["是否虚拟岗位"],
                    备注 = objReader["备注"].ToString(),
                    ParentID = Convert.ToInt32(objReader["ParentID"].ToString()),
                    排序 = objReader["排序"] is DBNull ? 0 : Convert.ToInt32(objReader["排序"].ToString()),
                    更改者 = objReader["更改者"].ToString(),
                    更改日期 = Convert.ToDateTime(objReader["更改日期"].ToString()),
                    岗位性质长文本 = objReader["岗位性质长文本"].ToString()
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 查询所有岗位对象
        /// </summary>
        /// <param name="dateTime">时间</param>
        /// <returns></returns>
        public List<GangWei> GetGangWeiListAll(DateTime dateTime)
        {
            string whereSql = string.Format(" where '{0}' between 开始日期 and 结束日期 order by ParentId,排序", dateTime);
            return this.GetGangWeiListBySql(whereSql);
        }

        /// <summary>
        /// 根据ParentId查询岗位对象
        /// </summary>
        /// <param name="dateTime">时间</param>
        /// <param name="ParentId">岗位所在机构编号</param>
        /// <returns></returns>
        public List<GangWei> GetGangWeiListByParentId(DateTime dateTime, int ParentId)
        {
            string whereSql = string.Format(" where '{0}' between 开始日期 and 结束日期 and ParentId = {1} order by ParentId,排序", dateTime, ParentId);
            return this.GetGangWeiListBySql(whereSql);
        }


        /// <summary>
        /// 查询机构、岗位、人员对象
        /// </summary>
        /// <param name="dateTime">时间</param>
        /// <returns></returns>
        public List<GangWei> GetDeptAndGangWeiListAll(DateTime dateTime)
        {

            string whereSql = " where '{0}' between 开始日期 and 结束日期";

            whereSql += " union all select 机构编号,'O '+机构名称,机构简称,开始日期,结束日期,null as 岗位性质,null as 岗位序列,null as 岗级,null as 是否特殊岗位,null as 是否关键岗位,null as 是否运行岗位,null as 是否虚拟岗位,备注,ParentID,排序,更改者,更改日期,null as 岗位性质文本 from org_dept where '{1}' between 开始日期 and 结束日期";
            whereSql += " union all select emp_org.人员编号,'P '+emp_bas.姓名,emp_bas.姓名,开始日期,结束日期,null as 岗位性质,null as 岗位序列,null as 岗级,null as 是否特殊岗位,null as 是否关键岗位,null as 是否运行岗位,null as 是否虚拟岗位,emp_org.备注, 职位编码 as ParentID,排序,emp_org.更改者,emp_org.更改日期,null as 岗位性质文本 from emp_org";
            whereSql += " inner join emp_bas on emp_bas.人员编号 = emp_org.人员编号 ";
            whereSql += " where '{2}' between 开始日期 and 结束日期 order by ParentId,排序";


            whereSql = string.Format(whereSql, dateTime, dateTime, dateTime);
            return this.GetGangWeiListBySql(whereSql);
        }




        /// <summary>
        /// 查询单一组织岗位对象
        /// </summary>
        /// <param name="current_date_gz"></param>
        /// <param name="id">岗位编码</param>
        /// <returns></returns>
        public GangWei GetGangWeiByGangWeiID(DateTime dateTime, int id)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select 职位编码,职位名称,职位简称,开始日期,结束日期,岗位性质,岗位序列,岗级, 是否特殊岗位, 是否关键岗位,是否运行岗位,是否虚拟岗位, 备注, ParentID, 排序, 更改者, 更改日期, 岗位性质长文本 from org_posi");
            sqlBuilder.Append(" inner join bas_posi_quality on bas_posi_quality.DT = org_posi.岗位性质");
            sqlBuilder.Append(" where '{0}' between 开始日期 and 结束日期 and 职位编码 = {1}");

            string sql = string.Format(sqlBuilder.ToString(), dateTime, id);

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            GangWei objGangWei = null;

            if (objReader.Read())
            {
                objGangWei = new GangWei()
                {
                    职位编码 = Convert.ToInt32(objReader["职位编码"].ToString()),
                    职位名称 = objReader["职位名称"].ToString(),
                    职位简称 = objReader["职位简称"].ToString(),
                    开始日期 = Convert.ToDateTime(objReader["开始日期"].ToString()),
                    结束日期 = Convert.ToDateTime(objReader["结束日期"].ToString()),
                    岗位性质 = objReader["岗位性质"].ToString(),
                    岗位序列 = objReader["岗位序列"].ToString(),
                    岗级 = objReader["岗级"].ToString(),
                    是否特殊岗位 = objReader["是否特殊岗位"] is DBNull ? false : (bool)objReader["是否特殊岗位"],
                    是否关键岗位 = objReader["是否关键岗位"] is DBNull ? false : (bool)objReader["是否关键岗位"],
                    是否运行岗位 = objReader["是否运行岗位"] is DBNull ? false : (bool)objReader["是否运行岗位"],
                    是否虚拟岗位 = objReader["是否虚拟岗位"] is DBNull ? false : (bool)objReader["是否虚拟岗位"],
                    备注 = objReader["备注"].ToString(),
                    ParentID = Convert.ToInt32(objReader["ParentID"].ToString()),
                    排序 = objReader["排序"] is DBNull ? 0 : Convert.ToInt32(objReader["排序"].ToString()),
                    更改者 = objReader["更改者"].ToString(),
                    更改日期 = Convert.ToDateTime(objReader["更改日期"].ToString()),
                    岗位性质长文本 = objReader["岗位性质长文本"].ToString()
                };
            }
            objReader.Close();
            return objGangWei;
        }

        /// <summary>
        /// 增加岗位对象
        /// </summary>
        /// <param name="objGangWei"></param>
        /// <returns></returns>
        public int AddGangWei(GangWei objGangWei)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into org_posi (职位名称,职位简称,开始日期,结束日期,岗位性质,岗位序列,岗级,是否特殊岗位,是否关键岗位,是否运行岗位,是否虚拟岗位,备注,ParentID,排序,更改者,更改日期)");
            sqlBuilder.Append(" values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}',{12},{13},'{14}','{15}')");

            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objGangWei.职位名称, objGangWei.职位简称, objGangWei.开始日期, objGangWei.结束日期, objGangWei.岗位性质, objGangWei.岗位序列, objGangWei.岗级, objGangWei.是否特殊岗位, objGangWei.是否关键岗位, objGangWei.是否运行岗位, objGangWei.是否虚拟岗位, objGangWei.备注, objGangWei.ParentID, objGangWei.排序, objGangWei.更改者, objGangWei.更改日期);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 修改岗位对象
        /// </summary>
        /// <param name="objGangWei"></param>
        /// <returns></returns>
        public int ModifyGangWeiByGangWeiID(GangWei objGangWei)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update org_posi set 职位名称 = '{0}',职位简称 = '{1}',开始日期 = '{2}',结束日期 = '{3}',岗位性质 = '{4}',岗位序列 = '{5}',岗级 = '{6}',是否特殊岗位 = '{7}',是否关键岗位 = '{8}',是否运行岗位 = '{9}',是否虚拟岗位 = '{10}',备注 = '{11}',ParentID = {12},排序 = {13},更改者 = '{14}',更改日期 = '{15}'");
            sqlBuilder.Append(" where 职位编码 = {16}");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objGangWei.职位名称, objGangWei.职位简称, objGangWei.开始日期, objGangWei.结束日期, objGangWei.岗位性质, objGangWei.岗位序列, objGangWei.岗级, objGangWei.是否特殊岗位, objGangWei.是否关键岗位, objGangWei.是否运行岗位, objGangWei.是否虚拟岗位, objGangWei.备注, objGangWei.ParentID, objGangWei.排序, objGangWei.更改者, objGangWei.更改日期, objGangWei.职位编码);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 删除机构对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteGangWeiByGangWeiID(int id)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("delete from org_posi");
            sqlBuilder.Append(" where 职位编码 = {0}");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), id);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }


        /// <summary>
        /// 获取上级机构编号
        /// </summary>
        /// <param name="bIsTongJi">是否同级机构</param>
        /// <param name="intPosiId">当前机构编号</param>
        /// <returns></returns>
        public int GetParentId(int intPosiId)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();

            sqlBuilder.Append("select ParentId from org_posi");
            sqlBuilder.Append(" where 职位编码 = {0}");

            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), intPosiId);
            //3、执行SQL语句，返回结果
            return Convert.ToInt32(SQLHelper.GetSingleResult(sql));
        }

        /// <summary>
        /// 获取机构排序号
        /// </summary>
        /// <returns></returns>
        public int GetPosiSortID(int intPosiId)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select 排序 from org_posi");
            sqlBuilder.Append(" where 职位编码 = {0}");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), intPosiId);
            //3、执行SQL语句，返回结果
            return Convert.ToInt32(SQLHelper.GetSingleResult(sql));
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<GangWei> GetAllGangWeiLevel()
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select id,dt,岗位性质长文本 from bas_posi_quality");

            string sql = string.Format(sqlBuilder.ToString());

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<GangWei> list = new List<GangWei>();
            while (objReader.Read())
            {
                list.Add(new GangWei()
                {
                    id = Convert.ToInt32(objReader["id"].ToString()),
                    dt = objReader["dt"].ToString(),
                    岗位性质长文本 = objReader["岗位性质长文本"].ToString()
                });
            }
            objReader.Close();
            return list;
        }




        /// <summary>
        /// 根据机构编号获取岗位ListView
        /// </summary>
        /// <param name="listView1"></param>
        /// <param name="dateTime"></param>
        /// <param name="ParentId"></param>

        public void GetGangWeiListView(ListView listView1, DateTime dateTime, int ParentId)
        {
            List<GangWei> objGangWei = GetGangWeiListByParentId(dateTime, ParentId);

            foreach (var item in objGangWei)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.职位编码.ToString();
                lvi.SubItems.Add(item.职位名称);
                lvi.SubItems.Add(item.职位简称);
                lvi.SubItems.Add(item.排序.ToString());
                lvi.SubItems.Add(item.开始日期.ToString("yyyy.MM.dd"));
                lvi.SubItems.Add(item.结束日期.ToString("yyyy.MM.dd"));
                lvi.SubItems.Add(item.备注.ToString());
                listView1.Items.Add(lvi);
            }
        }









    }
}
