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
    /// 管理员数据访问类
    /// </summary>
    public class AdminService
    {
        /// <summary>
        /// 根据用户名或密码登录
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public Admin AdminLogin(Admin objAdmin, DateTime dateTime)
        {
            string sql = "select id,deptid,dept,userid,username,attendance,overtime,evaluation,assessment,开始日期,结束日期,备注,更改者,更改日期 from tbl_user";
            sql += " where userid='{0}' and pwd='{1}' and '{2}' between 开始日期 and 结束日期";
            sql += " order by DeptID";
            sql = string.Format(sql, objAdmin.userid, objAdmin.pwd, dateTime);
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                if (objReader.Read())
                {
                    objAdmin.id = Convert.ToInt32(objReader["id"].ToString());
                    objAdmin.deptid = Convert.ToInt32(objReader["deptid"].ToString());
                    objAdmin.dept = objReader["dept"].ToString();
                    objAdmin.userid = objReader["userid"].ToString();
                    objAdmin.username = objReader["username"].ToString();
                    objAdmin.Attendance = objReader["Attendance"] is DBNull ? false : (bool)objReader["Attendance"];
                    objAdmin.Overtime = objReader["Overtime"] is DBNull ? false : (bool)objReader["Overtime"];
                    objAdmin.Evaluation = objReader["Evaluation"] is DBNull ? false : (bool)objReader["Evaluation"];
                    objAdmin.Assessment = objReader["Assessment"] is DBNull ? false : (bool)objReader["Assessment"];
                    objAdmin.开始日期 = (DateTime)objReader["开始日期"];
                    objAdmin.结束日期 = (DateTime)objReader["结束日期"];
                    objAdmin.备注 = objReader["备注"].ToString();
                    objAdmin.更改者 = objReader["更改者"].ToString();
                    objAdmin.更改日期 = (DateTime)objReader["更改日期"];
                }
                else
                {
                    objAdmin = null;
                }
                objReader.Close();
                return objAdmin;
            }
            catch (Exception ex)
            {
                throw new Exception("数据访问发生异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 根据登录账号修改登录密码
        /// </summary>
        /// <param name="loginId"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public int ModifyPwd(String newPwd, string loginId)
        {
            string sql = "update tbl_user set pwd = '{0}' where userid = '{1}'";
            sql = string.Format(sql, newPwd, loginId);
            return SQLHelper.Update(sql);
        }




        /// <summary>
        /// 获取所有的登录部门对象
        /// </summary>
        /// <returns></returns>
        public List<Admin> GetAllDepts()
        {
            string sql = "select distinct deptid,org_dept.机构简称 as dept,org_dept.排序 from tbl_user";
            sql += " inner join org_dept on tbl_user.deptid = org_dept.机构编号";
            sql += " order by 排序";

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Admin> list = new List<Admin>();
            while (objReader.Read())
            {
                list.Add(new Admin()
                {
                    dept = objReader["dept"].ToString(),
                    deptid = Convert.ToInt32(objReader["deptid"].ToString())
                });
            }
            objReader.Close();
            return list;
        }




        /// <summary>
        /// 查询所有管理员
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public List<Admin> GetAllAdmin(DateTime dateTime)
        {

            StringBuilder sqlBuilder = new StringBuilder();
            //sqlBuilder.Append("select id,DeptId as ParentID,DeptId,Dept,cast(UserId as int) as UserId,UserName,Attendance, Overtime, Evaluation, Assessment,开始日期,结束日期,备注,0 as 排序 from tbl_user where '{0}' between 开始日期 and 结束日期");
            //sqlBuilder.Append(" union all select 机构编号 as id,ParentID, 机构编号 as DeptId, 机构简称 as Dept,机构编号 as UserId,机构简称 as UserName,cast(0 as bit) as Attendance,cast(0 as bit) as overtime,cast(0 as bit) as evaluation,cast(0 as bit) as assessment,开始日期,结束日期,备注,排序 from org_dept where ParentID = 0 and '{0}' between 开始日期 and 结束日期 order by ParentID, 排序");

            sqlBuilder.Append("select id,DeptId as ParentID,DeptId,Dept,UserId,UserName,Attendance, Overtime, Evaluation, Assessment,开始日期,结束日期,备注,0 as 排序 from tbl_user where '{0}' between 开始日期 and 结束日期");
            sqlBuilder.Append(" union all select 机构编号 as id,ParentID, 机构编号 as DeptId, 机构简称 as Dept,机构编号 as UserId,机构简称 as UserName,cast(0 as bit) as Attendance,cast(0 as bit) as overtime,cast(0 as bit) as evaluation,cast(0 as bit) as assessment,开始日期,结束日期,备注,排序 from org_dept where ParentID = 0 and '{0}' between 开始日期 and 结束日期 order by ParentID, 排序");
            string sql = string.Format(sqlBuilder.ToString(), dateTime);
            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<Admin> list = new List<Admin>();
            while (objReader.Read())
            {
                list.Add(new Admin()
                {
                    id = Convert.ToInt32(objReader["id"].ToString()),
                    deptid = Convert.ToInt32(objReader["deptid"].ToString()),
                    dept = objReader["dept"].ToString(),
                    userid = objReader["userid"].ToString(),
                    username = objReader["username"].ToString(),
                    Attendance = objReader["Attendance"] is DBNull ? false : (bool)objReader["Attendance"],
                    Overtime = objReader["Overtime"] is DBNull ? false : (bool)objReader["Overtime"],
                    Evaluation = objReader["Evaluation"] is DBNull ? false : (bool)objReader["Evaluation"],
                    Assessment = objReader["Assessment"] is DBNull ? false : (bool)objReader["Assessment"],
                    开始日期 = (DateTime)objReader["开始日期"],
                    结束日期 = (DateTime)objReader["结束日期"],
                    备注 = objReader["备注"].ToString(),
                    //更改者 = objReader["更改者"].ToString(),
                    //更改日期 = (DateTime)objReader["更改日期"],
                    ParentID = (int)objReader["ParentID"]
                });
            }
            objReader.Close();
            return list;
        }


        /// <summary>
        /// 查询所有管理员
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public Admin GetAdminByID(DateTime dateTime, int id)
        {
            string sql = "select id,deptid,dept,userid,username,attendance,overtime,evaluation,assessment,开始日期,结束日期,备注,更改者,更改日期 from tbl_user";
            sql += " where id='{0}' and '{1}' between 开始日期 and 结束日期";
            sql = string.Format(sql, id, dateTime);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Admin objAdmin = null;
            if (objReader.Read())
            {
                objAdmin = new Admin()
                {
                    id = Convert.ToInt32(objReader["id"].ToString()),
                    deptid = Convert.ToInt32(objReader["deptid"].ToString()),
                    dept = objReader["dept"].ToString(),
                    userid = objReader["userid"].ToString(),
                    username = objReader["username"].ToString(),
                    Attendance = objReader["Attendance"] is DBNull ? false : (bool)objReader["Attendance"],
                    Overtime = objReader["Overtime"] is DBNull ? false : (bool)objReader["Overtime"],
                    Evaluation = objReader["Evaluation"] is DBNull ? false : (bool)objReader["Evaluation"],
                    Assessment = objReader["Assessment"] is DBNull ? false : (bool)objReader["Assessment"],
                    开始日期 = (DateTime)objReader["开始日期"],
                    结束日期 = (DateTime)objReader["结束日期"],
                    备注 = objReader["备注"].ToString(),
                };
            }
            objReader.Close();
            return objAdmin;
        }


        /// <summary>
        /// 增加管理员
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public int AddAdmin(Admin objAdmin)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into tbl_user (deptid,dept,userid,username,attendance,overtime,evaluation,assessment,开始日期,结束日期,备注,更改者,更改日期,pwd)");
            sqlBuilder.Append(" values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objAdmin.deptid, objAdmin.dept, objAdmin.userid, objAdmin.username, objAdmin.Attendance, objAdmin.Overtime, objAdmin.Evaluation, objAdmin.Assessment, objAdmin.开始日期, objAdmin.结束日期, objAdmin.备注, objAdmin.更改者, objAdmin.更改日期, objAdmin.pwd);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 修改管理员
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public int ModifyAdminbyId(Admin objAdmin)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update tbl_user set deptid = {0},dept = '{1}',userid = '{2}',username = '{3}',attendance = '{4}',overtime = '{5}',evaluation = '{6}',assessment = '{7}',开始日期 = '{8}',结束日期 = '{9}',备注 = '{10}',更改者 = '{11}',更改日期 = '{12}'");
            sqlBuilder.Append(" where id = {13}");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objAdmin.deptid, objAdmin.dept, objAdmin.userid, objAdmin.username, objAdmin.Attendance, objAdmin.Overtime, objAdmin.Evaluation, objAdmin.Assessment, objAdmin.开始日期, objAdmin.结束日期, objAdmin.备注, objAdmin.更改者, objAdmin.更改日期, objAdmin.id);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 删除管理员对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteAdminByID(int id)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("delete from tbl_user");
            sqlBuilder.Append(" where id = {0}");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), id);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }



















    }
}
