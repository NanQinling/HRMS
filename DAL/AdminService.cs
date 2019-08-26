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
        public Admin AdminLogin(Admin objAdmin)
        {
            string sql = "select tbl_user.id,tbl_user.deptid,org_dept.机构简称 as dept,tbl_user.UserId,emp_bas.姓名 as username,tbl_user.attendance,tbl_user.overtime,tbl_user.evaluation,tbl_user.assessment from tbl_user";
            sql += " inner join org_dept on org_dept.机构编号 = tbl_user.deptid";
            sql += " inner join emp_bas on emp_bas.人员编号 = tbl_user.UserId";
            sql += " where tbl_user.userid={0} and tbl_user.pwd='{1}'";
            sql += " order by tbl_user.DeptID";
            sql = string.Format(sql, objAdmin.userid, objAdmin.pwd);
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
                    objAdmin.Attendance = Convert.ToBoolean(objReader["attendance"].ToString());
                    objAdmin.Overtime = Convert.ToBoolean(objReader["overtime"].ToString());
                    objAdmin.Evaluation = Convert.ToBoolean(objReader["evaluation"].ToString());
                    objAdmin.Assessment = Convert.ToBoolean(objReader["assessment"].ToString());
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
            sqlBuilder.Append("select tbl_user.id,cast(tbl_user.deptid as int) as ParentID,tbl_user.deptid,org_dept.机构简称 as Dept,cast(tbl_user.UserId as int) as userid,emp_bas.姓名 as Username,tbl_user.Attendance, tbl_user.Overtime, tbl_user.Evaluation, tbl_user.Assessment,0 as 排序 from tbl_user");
            sqlBuilder.Append(" inner join org_dept on org_dept.机构编号 = tbl_user.deptid");
            sqlBuilder.Append(" inner join emp_bas on emp_bas.人员编号 = tbl_user.UserId");
            sqlBuilder.Append(" union all select 机构编号 as id,parentid, 机构编号 as deptid, 机构简称 as dept,机构编号 as userid,机构简称 as username,cast(0 as bit) as Attendance,cast(0 as bit) as overtime,cast(0 as bit) as evaluation,cast(0 as bit) as assessment, 排序 from org_dept where ParentID = 0 and '{0}' between 开始日期 and 结束日期 order by ParentID, 排序");

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
                    Attendance = (bool)objReader["attendance"],
                    Overtime = (bool)objReader["Overtime"],
                    Evaluation = (bool)objReader["Evaluation"],
                    Assessment = (bool)objReader["Assessment"],
                    开始日期 = (DateTime)objReader["开始日期"],
                    结束日期 = (DateTime)objReader["结束日期"],
                    备注 = objReader["备注"].ToString(),
                    更改者 = objReader["备注"].ToString(),
                    更改日期 = (DateTime)objReader["更改日期"],

                    //Attendance = Convert.ToInt32(objReader["Attendance"].ToString()) == 1 ? true : false,
                    //Overtime = Convert.ToInt32(objReader["Overtime"].ToString()) == 1 ? true : false,
                    //Evaluation = Convert.ToInt32(objReader["Evaluation"].ToString()) == 1 ? true : false,
                    //Assessment = Convert.ToInt32(objReader["Assessment"].ToString()) == 1 ? true : false,
                    ParentID = Convert.ToInt32(objReader["ParentID"].ToString()),
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
        public Admin GetAdminByID(int id)
        {
            string sql = "select tbl_user.id,tbl_user.deptid,org_dept.机构简称 as dept,tbl_user.UserId,emp_bas.姓名 as username,tbl_user.attendance,tbl_user.overtime,tbl_user.evaluation,tbl_user.assessment from tbl_user";
            sql += " inner join org_dept on org_dept.机构编号 = tbl_user.deptid";
            sql += " inner join emp_bas on emp_bas.人员编号 = tbl_user.UserId";
            sql += " order by tbl_user.DeptID";
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
                    Attendance = Convert.ToBoolean(objReader["attendance"].ToString()),
                    Overtime = Convert.ToBoolean(objReader["overtime"].ToString()),
                    Evaluation = Convert.ToBoolean(objReader["evaluation"].ToString()),
                    Assessment = Convert.ToBoolean(objReader["assessment"].ToString())
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
        public int InsertAdmin(Admin objAdmin)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into tbl_user (deptid,userid,pwd,attendance,overtime,evaluation,assessment)");
            sqlBuilder.Append(" values ('{0}','{1}','{2}',{3},{4},{5},{6})");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objAdmin.deptid, objAdmin.userid, objAdmin.Attendance, objAdmin.Overtime, objAdmin.Evaluation, objAdmin.Assessment);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 修改管理员
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public int ModifyAdmin(Admin objAdmin)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update tbl_user set deptid = '{0}',userid = '{1}',pwd = '{2}',attendance = {3},overtime = {4},evaluation = {5},assessment = {6}");
            sqlBuilder.Append(" where id = {7}");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objAdmin.deptid, objAdmin.userid, objAdmin.Attendance, objAdmin.Overtime, objAdmin.Evaluation, objAdmin.Assessment, objAdmin.id);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }






















    }
}
