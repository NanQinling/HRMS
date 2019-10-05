using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using Models;


namespace DAL
{
    public class ZuZhiFenPeiService
    {
        /// <summary>
        /// 根据whereSql查询机构
        /// </summary>
        /// <param name = "whereSql" ></ param >
        /// < returns ></ returns >
        public List<ZuZhiFenPei> GetZuZhiFenPeiListBySql(string whereSql)
        {
            string sql = "select a.id,a.人员编号,a.开始日期,a.结束日期,a.人事范围,a.人事子范围,a.员工组,a.员工子组,a.工资范围,a.职位编码,a.备注,a.更改者,a.更改日期,b.姓名,c.EG,c.员工子组的名称,d.职位名称,f.机构名称 as 二级内设机构,e.机构名称 as 三级内设机构,e.内设机构层级 from emp_org a ";
            sql += " left join emp_bas b on b.人员编号 = a.人员编号";
            sql += " left join bas_subgroup c on c.EG = a.员工子组";
            sql += " left join org_posi d on d.职位编码 = a.职位编码";
            sql += " left join org_dept e on e.机构编号 = d.ParentID";
            sql += " left join org_dept f on f.机构编号 = e.ParentID";

            sql += whereSql;

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<ZuZhiFenPei> list = new List<ZuZhiFenPei>();
            while (objReader.Read())
            {
                list.Add(new ZuZhiFenPei()
                {
                    id = Convert.ToInt32(objReader["id"].ToString()),
                    人员编号 = objReader["人员编号"].ToString(),
                    开始日期 = Convert.ToDateTime(objReader["开始日期"].ToString()),
                    结束日期 = Convert.ToDateTime(objReader["结束日期"].ToString()),
                    人事范围 = objReader["人事范围"].ToString(),
                    人事子范围 = objReader["人事子范围"].ToString(),
                    员工组 = objReader["员工组"].ToString(),
                    员工子组 = objReader["员工子组"].ToString(),
                    工资范围 = objReader["工资范围"].ToString(),
                    职位编码 = Convert.ToInt32(objReader["职位编码"].ToString()),
                    备注 = objReader["备注"].ToString(),
                    更改者 = objReader["更改者"].ToString(),
                    更改日期 = Convert.ToDateTime(objReader["更改日期"].ToString()),
                    姓名 = objReader["姓名"].ToString(),
                    员工子组的名称 = objReader["员工子组的名称"].ToString(),
                    职位名称 = objReader["职位名称"].ToString(),
                    二级内设机构 = objReader["二级内设机构"].ToString(),
                    三级内设机构 = objReader["三级内设机构"].ToString(),
                    内设机构层级 = objReader["内设机构层级"].ToString(),

                });
            }
            objReader.Close();

            //如果是二级内设机构时，将三机内设机构的值赋给二级，并清空三级的值。
            foreach (var item in list)
            {
                if (item.内设机构层级 == "02")
                {
                    item.二级内设机构 = item.三级内设机构;
                    item.三级内设机构 = null;
                }
            }
            return list;
        }


        /// <summary>
        /// 根据人员编号查询人员对象
        /// </summary>
        /// <returns></returns>
        public List<ZuZhiFenPei> GetZuZhiFenPeiListByUserId(string strUserId)
        {
            string whereSql = string.Format(" where a.人员编号 = '{0}' order by 开始日期 desc", strUserId);
            return this.GetZuZhiFenPeiListBySql(whereSql);
        }




        public ZuZhiFenPei GetZuZhiByUserID(DateTime dateTime, string strUserId)
        {
            string sql = "select a.id,a.人员编号,a.开始日期,a.结束日期,a.人事范围,a.人事子范围,a.员工组,a.员工子组,a.工资范围,a.职位编码,a.备注,a.更改者,a.更改日期,b.姓名,c.EG,c.员工子组的名称,d.职位名称,f.机构名称 as 二级内设机构,e.机构名称 as 三级内设机构,e.内设机构层级 from emp_org a ";
            sql += " left join emp_bas b on b.人员编号 = a.人员编号";
            sql += " left join bas_subgroup c on c.EG = a.员工子组";
            sql += " left join org_posi d on d.职位编码 = a.职位编码";
            sql += " left join org_dept e on e.机构编号 = d.ParentID";
            sql += " left join org_dept f on f.机构编号 = e.ParentID";

            sql += "  where '{0}' between a.开始日期 and a.结束日期 and a.人员编号 = '{1}' ";

            sql = string.Format(sql, dateTime, strUserId);

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            ZuZhiFenPei objZuZhiFenPei = null;

            if (objReader.Read())
            {
                objZuZhiFenPei = new ZuZhiFenPei()
                {
                    id = Convert.ToInt32(objReader["id"].ToString()),
                    人员编号 = objReader["人员编号"].ToString(),
                    开始日期 = Convert.ToDateTime(objReader["开始日期"].ToString()),
                    结束日期 = Convert.ToDateTime(objReader["结束日期"].ToString()),
                    人事范围 = objReader["人事范围"].ToString(),
                    人事子范围 = objReader["人事子范围"].ToString(),
                    员工组 = objReader["员工组"].ToString(),
                    员工子组 = objReader["员工子组"].ToString(),
                    工资范围 = objReader["工资范围"].ToString(),
                    职位编码 = Convert.ToInt32(objReader["职位编码"].ToString()),
                    备注 = objReader["备注"].ToString(),
                    更改者 = objReader["更改者"].ToString(),
                    更改日期 = Convert.ToDateTime(objReader["更改日期"].ToString()),
                    姓名 = objReader["姓名"].ToString(),
                    员工子组的名称 = objReader["员工子组的名称"].ToString(),
                    职位名称 = objReader["职位名称"].ToString(),
                    二级内设机构 = objReader["二级内设机构"].ToString(),
                    三级内设机构 = objReader["三级内设机构"].ToString(),
                    内设机构层级 = objReader["内设机构层级"].ToString(),


                };
            }
            objReader.Close();

            //如果是二级内设机构时，将三机内设机构的值赋给二级，并清空三级的值。
            if (objZuZhiFenPei.内设机构层级 == "02")
            {
                objZuZhiFenPei.二级内设机构 = objZuZhiFenPei.三级内设机构;
                objZuZhiFenPei.三级内设机构 = null;
            }

            return objZuZhiFenPei;
        }


        /// <summary>
        /// 增加人员对象
        /// </summary>
        /// <param name="objZuZhiFenPei"></param>
        /// <returns></returns>
        public int Add(ZuZhiFenPei objZuZhiFenPei)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into emp_org (人员编号,开始日期,结束日期,人事范围,人事子范围,员工组,员工子组,工资范围,职位编码,备注,更改者,更改日期)");
            sqlBuilder.Append(" values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}','{10}','{11}')");

            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objZuZhiFenPei.人员编号, objZuZhiFenPei.开始日期, objZuZhiFenPei.结束日期, objZuZhiFenPei.人事范围, objZuZhiFenPei.人事子范围, objZuZhiFenPei.员工组, objZuZhiFenPei.员工子组, objZuZhiFenPei.工资范围, objZuZhiFenPei.职位编码, objZuZhiFenPei.备注, objZuZhiFenPei.更改者, objZuZhiFenPei.更改日期);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 修改人员对象
        /// </summary>
        /// <param name="objZuZhiFenPei"></param>
        /// <returns></returns>
        public int Modify(ZuZhiFenPei objZuZhiFenPei)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update emp_org set 人员编号 = '{0}',开始日期 = '{1}',结束日期 = '{2}',人事范围 = '{3}',人事子范围 = '{4}',员工组 = '{5}',员工子组 = '{6}',工资范围 = '{7}',职位编码 = {8},备注 = '{9}',更改者 = '{10}',更改日期 = '{11}'");
            sqlBuilder.Append(" where id = {12}");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objZuZhiFenPei.人员编号, objZuZhiFenPei.开始日期, objZuZhiFenPei.结束日期, objZuZhiFenPei.人事范围, objZuZhiFenPei.人事子范围, objZuZhiFenPei.员工组, objZuZhiFenPei.员工子组, objZuZhiFenPei.工资范围, objZuZhiFenPei.职位编码, objZuZhiFenPei.备注, objZuZhiFenPei.更改者, objZuZhiFenPei.更改日期, objZuZhiFenPei.id);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 删除人员对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int intID)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("delete from emp_org");
            sqlBuilder.Append(" where id = {0}");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), intID);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }



        /// <summary>
        /// 获取入职原因下拉数据
        /// </summary>
        /// <returns></returns>
        public List<ZuZhiFenPei> GetAllYuanGonGZiZu()
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select id,EG,员工子组的名称 from bas_subgroup order by EG");

            string sql = string.Format(sqlBuilder.ToString());

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<ZuZhiFenPei> list = new List<ZuZhiFenPei>();
            while (objReader.Read())
            {
                list.Add(new ZuZhiFenPei()
                {
                    //id = Convert.ToInt32(objReader["id"].ToString()),
                    EG = objReader["eg"].ToString(),
                    员工子组的名称 = objReader["员工子组的名称"].ToString()
                });
            }
            objReader.Close();
            return list;
        }

  









    }
}
