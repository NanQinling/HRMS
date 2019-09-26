using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using Models;


namespace DAL
{
    public class UserInfoService
    {
        /// <summary>
        /// 根据whereSql查询机构
        /// </summary>
        /// <param name="whereSql"></param>
        /// <returns></returns>
        public List<UserInfo> GetUserListBySql(string whereSql)
        {
            string sql = "select 人员编号,姓名,性别,出生日期,身份证号,参加工作日期,加入华能系统日期,加入本单位日期,入职原因,入职学历,工资标识,工资账号,奖金标识,奖金账号,备注,拼音码,更改者,更改日期,操作原因名称 as 入职原因长文本,教育部门文本 as 入职学历长文本,a.银行名称 as 工资银行名称,b.银行名称 as 奖金银行名称 from emp_bas";
            sql += " left join bas_xinzeng on bas_xinzeng.ActR = emp_bas.入职原因";
            sql += " left join bas_edu on bas_edu.EE = emp_bas.入职学历";
            sql += " left join bas_bank a on a.银行代码 = emp_bas.工资标识";
            sql += " left join bas_bank b on b.银行代码 = emp_bas.奖金标识";

            sql += whereSql;

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<UserInfo> list = new List<UserInfo>();
            while (objReader.Read())
            {
                list.Add(new UserInfo()
                {
                    人员编号 = objReader["人员编号"].ToString(),
                    姓名 = objReader["姓名"].ToString(),
                    性别 = objReader["性别"].ToString(),
                    出生日期 = Convert.ToDateTime(objReader["出生日期"].ToString()),
                    身份证号 = objReader["身份证号"].ToString(),
                    参加工作日期 = Convert.ToDateTime(objReader["参加工作日期"].ToString()),
                    加入华能系统日期 = Convert.ToDateTime(objReader["加入华能系统日期"].ToString()),
                    加入本单位日期 = Convert.ToDateTime(objReader["加入本单位日期"].ToString()),
                    入职原因 = objReader["入职原因"].ToString(),
                    入职学历 = objReader["入职学历"].ToString(),
                    工资标识 = objReader["工资标识"].ToString(),
                    工资账号 = objReader["工资账号"].ToString(),
                    奖金标识 = objReader["奖金标识"].ToString(),
                    奖金账号 = objReader["奖金账号"].ToString(),
                    备注 = objReader["备注"].ToString(),
                    拼音码 = objReader["拼音码"].ToString(),
                    更改者 = objReader["更改者"].ToString(),
                    更改日期 = Convert.ToDateTime(objReader["更改日期"].ToString()),
                    入职原因长文本 = objReader["入职原因长文本"].ToString(),
                    入职学历长文本 = objReader["入职学历长文本"].ToString(),
                    工资银行名称 = objReader["工资银行名称"].ToString(),
                    奖金银行名称 = objReader["奖金银行名称"].ToString(),


                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 查询所有人员对象
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetUserInfoListAll()
        {
            string whereSql = string.Format(" order by 人员编号");
            return this.GetUserListBySql(whereSql);
        }

        ///// <summary>
        ///// 根据人员编号查询人员对象
        ///// </summary>
        ///// <returns></returns>
        //public List<UserInfo> GetUserInfoListByParentId(int intUserId)
        //{
        //    string whereSql = string.Format(" where 人员编号 = '{0}'", intUserId);
        //    return this.GetUserListBySql(whereSql);
        //}



        /// <summary>
        /// 查询单一人员对象
        /// </summary>
        /// <param name="current_date_gz"></param>
        /// <param name="UserInfoID"></param>
        /// <returns></returns>
        public UserInfo GetUserInfoByUserID(string strUserId)
        {
            string sql = "select 人员编号,姓名,性别,出生日期,身份证号,参加工作日期,加入华能系统日期,加入本单位日期,入职原因,入职学历,工资标识,工资账号,奖金标识,奖金账号,备注,拼音码,更改者,更改日期,操作原因名称 as 入职原因长文本,教育部门文本 as 入职学历长文本,a.银行名称 as 工资银行名称,b.银行名称 as 奖金银行名称 from emp_bas";
            sql += " left join bas_xinzeng on bas_xinzeng.ActR = emp_bas.入职原因";
            sql += " left join bas_edu on bas_edu.EE = emp_bas.入职学历";
            sql += " left join bas_bank a on a.银行代码 = emp_bas.工资标识";
            sql += " left join bas_bank b on b.银行代码 = emp_bas.奖金标识";
            sql += "  where 人员编号 = '{0}'";

            sql = string.Format(sql, strUserId);

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            UserInfo objUserInfo = null;

            if (objReader.Read())
            {
                objUserInfo = new UserInfo()
                {
                    人员编号 = objReader["人员编号"].ToString(),
                    姓名 = objReader["姓名"].ToString(),
                    性别 = objReader["性别"].ToString(),
                    出生日期 = Convert.ToDateTime(objReader["出生日期"].ToString()),
                    身份证号 = objReader["身份证号"].ToString(),
                    参加工作日期 = Convert.ToDateTime(objReader["参加工作日期"].ToString()),
                    加入华能系统日期 = Convert.ToDateTime(objReader["加入华能系统日期"].ToString()),
                    加入本单位日期 = Convert.ToDateTime(objReader["加入本单位日期"].ToString()),
                    入职原因 = objReader["入职原因"].ToString(),
                    入职学历 = objReader["入职学历"].ToString(),
                    工资标识 = objReader["工资标识"].ToString(),
                    工资账号 = objReader["工资账号"].ToString(),
                    奖金标识 = objReader["奖金标识"].ToString(),
                    奖金账号 = objReader["奖金账号"].ToString(),
                    备注 = objReader["备注"].ToString(),
                    拼音码 = objReader["拼音码"].ToString(),
                    更改者 = objReader["更改者"].ToString(),
                    更改日期 = Convert.ToDateTime(objReader["更改日期"].ToString()),
                    入职原因长文本 = objReader["入职原因长文本"].ToString(),
                    入职学历长文本 = objReader["入职学历长文本"].ToString(),
                    工资银行名称 = objReader["工资银行名称"].ToString(),
                    奖金银行名称 = objReader["奖金银行名称"].ToString(),

                };
            }
            objReader.Close();
            return objUserInfo;
        }


        /// <summary>
        /// 增加人员对象
        /// </summary>
        /// <param name="objUserInfo"></param>
        /// <returns></returns>
        public int Add(UserInfo objUserInfo)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into emp_bas (人员编号,姓名,性别,出生日期,身份证号,参加工作日期,加入华能系统日期,加入本单位日期,入职原因,入职学历,工资标识,工资账号,奖金标识,奖金账号,备注,拼音码,更改者,更改日期)");
            sqlBuilder.Append(" values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')");

            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objUserInfo.人员编号, objUserInfo.姓名, objUserInfo.性别, objUserInfo.出生日期, objUserInfo.身份证号, objUserInfo.参加工作日期, objUserInfo.加入华能系统日期, objUserInfo.加入本单位日期, objUserInfo.入职原因, objUserInfo.入职学历, objUserInfo.工资标识, objUserInfo.工资账号, objUserInfo.奖金标识, objUserInfo.奖金账号, objUserInfo.备注, objUserInfo.拼音码, objUserInfo.更改者, objUserInfo.更改日期);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 修改人员对象
        /// </summary>
        /// <param name="objUserInfo"></param>
        /// <returns></returns>
        public int Modify(UserInfo objUserInfo)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update emp_bas set 姓名 = '{0}',性别 = '{1}',出生日期 = '{2}',身份证号 = '{3}',参加工作日期 = '{4}',加入华能系统日期 = '{5}',加入本单位日期 = '{6}',入职原因 = '{7}',入职学历 = '{8}',工资标识 = '{9}',工资账号 = '{10}',奖金标识 = '{11}',奖金账号 = '{12}',备注 = '{13}',拼音码 = '{14}',更改者 = '{15}' ,更改日期 = '{16}'");
            sqlBuilder.Append(" where 人员编号 = '{17}'");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objUserInfo.姓名, objUserInfo.性别, objUserInfo.出生日期, objUserInfo.身份证号, objUserInfo.参加工作日期, objUserInfo.加入华能系统日期, objUserInfo.加入本单位日期, objUserInfo.入职原因, objUserInfo.入职学历, objUserInfo.工资标识, objUserInfo.工资账号, objUserInfo.奖金标识, objUserInfo.奖金账号, objUserInfo.备注, objUserInfo.拼音码, objUserInfo.更改者, objUserInfo.更改日期, objUserInfo.人员编号);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 删除人员对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string strUserId)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("delete from emp_bas");
            sqlBuilder.Append(" where 人员编号 = '{0}'");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), strUserId);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }





























        /// <summary>
        /// 获取银行列表下拉数据
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetAllBank()
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select id,银行代码 as 工资银行代码,银行名称 as 工资银行名称,银行代码 as 奖金银行代码,银行名称 as 奖金银行名称 from bas_bank order by 银行代码");

            string sql = string.Format(sqlBuilder.ToString());

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<UserInfo> list = new List<UserInfo>();
            while (objReader.Read())
            {
                list.Add(new UserInfo()
                {
                    //id = Convert.ToInt32(objReader["id"].ToString()),
                    工资银行代码 = objReader["工资银行代码"].ToString(),
                    工资银行名称 = objReader["工资银行名称"].ToString(),
                    奖金银行代码 = objReader["奖金银行代码"].ToString(),
                    奖金银行名称 = objReader["奖金银行名称"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }


        /// <summary>
        /// 获取入职原因下拉数据
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetAllXinZeng()
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select id,ActR,操作原因名称 as 入职原因长文本 from bas_xinzeng order by ActR");

            string sql = string.Format(sqlBuilder.ToString());

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<UserInfo> list = new List<UserInfo>();
            while (objReader.Read())
            {
                list.Add(new UserInfo()
                {
                    //id = Convert.ToInt32(objReader["id"].ToString()),
                    Actr = objReader["Actr"].ToString(),
                    入职原因长文本 = objReader["入职原因长文本"].ToString()
                });
            }
            objReader.Close();
            return list;
        }


        /// <summary>
        /// 获取学历下拉数据
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetAllXueLi()
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select id,ee,教育部门文本 as 入职学历长文本 from bas_edu order by ee");

            string sql = string.Format(sqlBuilder.ToString());

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<UserInfo> list = new List<UserInfo>();
            while (objReader.Read())
            {
                list.Add(new UserInfo()
                {
                    //id = Convert.ToInt32(objReader["id"].ToString()),
                    EE = objReader["ee"].ToString(),
                    入职学历长文本 = objReader["入职学历长文本"].ToString()
                });
            }
            objReader.Close();
            return list;
        }










    }
}
