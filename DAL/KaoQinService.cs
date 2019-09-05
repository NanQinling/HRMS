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
    public class KaoQinService
    {

        /// <summary>
        /// 查询所有考勤对象
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public List<KaoQin> GetAllKaoQin(string last_year_month)
        {
            string whereSql = string.Format(" where 考勤年月 = '{0}'", last_year_month);
            return this.GetKaoQinBySql(whereSql);
        }


        /// <summary>
        /// 根据部门名称查询考勤对象
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public List<KaoQin> GetKaoQinByDept(string last_year_month, string dept)
        {
            string whereSql = string.Format(" where 考勤年月 = '{0}' and 部门 = '{1}'", last_year_month, dept);
            return this.GetKaoQinBySql(whereSql);
        }

        /// <summary>
        /// 查询未报送考勤对象
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public List<KaoQin> GetNotSubmitKaoQin(string last_year_month)
        {
            string whereSql = string.Format(" where 考勤年月 = '{0}' and (issubmit = 0 or issubmit is null) ", last_year_month);
            return this.GetKaoQinBySql(whereSql);
        }

        /// <summary>
        /// 根据SQL语句查询考勤对象
        /// </summary>
        /// <param name="whereSql"></param>
        /// <returns></returns>
        private List<KaoQin> GetKaoQinBySql(string whereSql)
        {
            string sql = "select 考勤年月,部门,班组,人员编号,姓名,应出勤,实际出勤,出差,旷工,年假,事假,病假,正常调休,产假,陪产假,婚假,丧假,迟到早退次数,缺卡次数,工作日加班次数,休息日加班,节假日加班,休息日出差,夜间值班次数,夜间值班调休次数,打卡签到次数,工作时长,备注,更改者,更改日期,IsSubmit from imp_attendance";
            sql += whereSql;

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<KaoQin> list = new List<KaoQin>();
            while (objReader.Read())
            {
                list.Add(new KaoQin()
                {
                    考勤年月 = objReader["考勤年月"].ToString(),
                    部门 = objReader["部门"].ToString(),
                    班组 = objReader["班组"].ToString(),
                    人员编号 = objReader["人员编号"].ToString(),
                    姓名 = objReader["姓名"].ToString(),
                    应出勤 = Convert.ToDouble(objReader["应出勤"].ToString()),
                    实际出勤 = Convert.ToDouble(objReader["实际出勤"].ToString()),
                    出差 = Convert.ToDouble(objReader["出差"].ToString()),
                    旷工 = Convert.ToDouble(objReader["旷工"].ToString()),
                    年假 = Convert.ToDouble(objReader["年假"].ToString()),
                    事假 = Convert.ToDouble(objReader["事假"].ToString()),
                    病假 = Convert.ToDouble(objReader["病假"].ToString()),
                    正常调休 = Convert.ToDouble(objReader["正常调休"].ToString()),
                    产假 = Convert.ToDouble(objReader["产假"].ToString()),
                    陪产假 = Convert.ToDouble(objReader["陪产假"].ToString()),
                    婚假 = Convert.ToDouble(objReader["婚假"].ToString()),
                    丧假 = Convert.ToDouble(objReader["丧假"].ToString()),
                    迟到早退次数 = Convert.ToDouble(objReader["迟到早退次数"].ToString()),
                    缺卡次数 = Convert.ToDouble(objReader["缺卡次数"].ToString()),
                    工作日加班次数 = Convert.ToDouble(objReader["工作日加班次数"].ToString()),
                    休息日加班 = Convert.ToDouble(objReader["休息日加班"].ToString()),
                    节假日加班 = Convert.ToDouble(objReader["节假日加班"].ToString()),
                    休息日出差 = Convert.ToDouble(objReader["休息日出差"].ToString()),
                    夜间值班次数 = Convert.ToDouble(objReader["夜间值班次数"].ToString()),
                    夜间值班调休次数 = Convert.ToDouble(objReader["夜间值班调休次数"].ToString()),
                    打卡签到次数 = Convert.ToDouble(objReader["打卡签到次数"].ToString()),
                    工作时长 = Convert.ToDouble(objReader["工作时长"].ToString()),
                    备注 = objReader["备注"].ToString(),
                    更改者 = objReader["更改者"].ToString(),
                    更改日期 = Convert.ToDateTime(objReader["更改日期"].ToString()),
                    IsSubmit = objReader["IsSubmit"] is DBNull ? false : (bool)objReader["IsSubmit"]

                });
            }
            objReader.Close();
            return list;
        }




        /// <summary>
        /// 根据人员编号查询考勤对象
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public KaoQin GetKaoQinByUserId(string last_year_month, string userid)
        {
            string sql = "select 考勤年月,部门,班组,人员编号,姓名,应出勤,实际出勤,出差,旷工,年假,事假,病假,正常调休,产假,陪产假,婚假,丧假,迟到早退次数,缺卡次数,工作日加班次数,休息日加班,节假日加班,休息日出差,夜间值班次数,夜间值班调休次数,打卡签到次数,工作时长,备注,更改者,更改日期,IsSubmit from imp_attendance where 考勤年月 = '{0}' and 人员编号 = '{1}'";
            sql = string.Format(sql, last_year_month, userid);

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            KaoQin objKaoQin = null;
            if (objReader.Read())
            {
                objKaoQin = new KaoQin()
                {
                    考勤年月 = objReader["考勤年月"].ToString(),
                    部门 = objReader["部门"].ToString(),
                    班组 = objReader["班组"].ToString(),
                    人员编号 = objReader["人员编号"].ToString(),
                    姓名 = objReader["姓名"].ToString(),
                    应出勤 = Convert.ToDouble(objReader["应出勤"].ToString()),
                    实际出勤 = Convert.ToDouble(objReader["实际出勤"].ToString()),
                    出差 = Convert.ToDouble(objReader["出差"].ToString()),
                    旷工 = Convert.ToDouble(objReader["旷工"].ToString()),
                    年假 = Convert.ToDouble(objReader["年假"].ToString()),
                    事假 = Convert.ToDouble(objReader["事假"].ToString()),
                    病假 = Convert.ToDouble(objReader["病假"].ToString()),
                    正常调休 = Convert.ToDouble(objReader["正常调休"].ToString()),
                    产假 = Convert.ToDouble(objReader["产假"].ToString()),
                    陪产假 = Convert.ToDouble(objReader["陪产假"].ToString()),
                    婚假 = Convert.ToDouble(objReader["婚假"].ToString()),
                    丧假 = Convert.ToDouble(objReader["丧假"].ToString()),
                    迟到早退次数 = Convert.ToDouble(objReader["迟到早退次数"].ToString()),
                    缺卡次数 = Convert.ToDouble(objReader["缺卡次数"].ToString()),
                    工作日加班次数 = Convert.ToDouble(objReader["工作日加班次数"].ToString()),
                    休息日加班 = Convert.ToDouble(objReader["休息日加班"].ToString()),
                    节假日加班 = Convert.ToDouble(objReader["节假日加班"].ToString()),
                    休息日出差 = Convert.ToDouble(objReader["休息日出差"].ToString()),
                    夜间值班次数 = Convert.ToDouble(objReader["夜间值班次数"].ToString()),
                    夜间值班调休次数 = Convert.ToDouble(objReader["夜间值班调休次数"].ToString()),
                    打卡签到次数 = Convert.ToDouble(objReader["打卡签到次数"].ToString()),
                    工作时长 = Convert.ToDouble(objReader["工作时长"].ToString()),
                    备注 = objReader["备注"].ToString(),
                    更改者 = objReader["更改者"].ToString(),
                    更改日期 = Convert.ToDateTime(objReader["更改日期"].ToString()),
                    IsSubmit = objReader["IsSubmit"] is DBNull ? false : (bool)objReader["IsSubmit"]
                };
            }
            objReader.Close();
            return objKaoQin;
        }


        /// <summary>
        /// 校验考勤数据
        /// </summary>
        /// <param name="objKaoQin"></param>
        /// <returns></returns>
        public string CheckKaoQin(KaoQin objKaoQin)
        {
            StringBuilder err = new StringBuilder();

            if (objKaoQin.出差 > objKaoQin.实际出勤)
            {
                err.Append($"人员编号【{objKaoQin.人员编号}】，姓名【{objKaoQin.姓名}】出差天数不应大于实际出勤天数！\r\n");
            }
            if (objKaoQin.打卡签到次数 > objKaoQin.实际出勤)
            {
                err.Append($"人员编号【{objKaoQin.人员编号}】，姓名【{objKaoQin.姓名}】打卡签到次数不应大于实际出勤天数！\r\n");
            }
            if (objKaoQin.节假日加班 > 7)
            {
                err.Append($"人员编号【{objKaoQin.人员编号}】，姓名【{objKaoQin.姓名}】节假日加班不应大于7天！\r\n");
            }
            if (objKaoQin.正常调休 > objKaoQin.休息日加班 + objKaoQin.节假日加班 + objKaoQin.工作日加班次数)
            {
                err.Append($"人员编号【{objKaoQin.人员编号}】，姓名【{objKaoQin.姓名}】正常调休天数不应大于加班天数！\r\n");
            }

            if (objKaoQin.实际出勤 < objKaoQin.应出勤 + objKaoQin.休息日加班 + objKaoQin.节假日加班 + objKaoQin.休息日出差 - objKaoQin.旷工 - objKaoQin.年假 - objKaoQin.事假 - objKaoQin.病假 - objKaoQin.正常调休 - objKaoQin.产假 - objKaoQin.陪产假 - objKaoQin.婚假 - objKaoQin.丧假)
            {
                err.Append($"人员编号【{objKaoQin.人员编号}】，姓名【{objKaoQin.姓名}】实际出勤不能小于【应出勤】+【休息日加班】+【节假日加班】+【休息日出差】-【休假合计】！\r\n");
            }

            return err.ToString();
        }



        /// <summary>
        /// 增加考勤对象
        /// </summary>
        /// <param name="objKaoQin"></param>
        /// <returns></returns>
        public int InsertKaoQin(KaoQin objKaoQin)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into imp_attendance (考勤年月,部门,班组,人员编号,姓名,应出勤,实际出勤,出差,旷工,年假,事假,病假,正常调休,产假,陪产假,婚假,丧假,迟到早退次数,缺卡次数,工作日加班次数,休息日加班,节假日加班,休息日出差,夜间值班次数,夜间值班调休次数,打卡签到次数,工作时长,备注,更改者,更改日期,IsSubmit)");
            sqlBuilder.Append(" values ('{0}','{1}','{2}','{3}','{4}',{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},'{27}','{28}','{29}','{30}')");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objKaoQin.考勤年月, objKaoQin.部门, objKaoQin.班组, objKaoQin.人员编号, objKaoQin.姓名, objKaoQin.应出勤, objKaoQin.实际出勤, objKaoQin.出差, objKaoQin.旷工, objKaoQin.年假, objKaoQin.事假, objKaoQin.病假, objKaoQin.正常调休, objKaoQin.产假, objKaoQin.陪产假, objKaoQin.婚假, objKaoQin.丧假, objKaoQin.迟到早退次数, objKaoQin.缺卡次数, objKaoQin.工作日加班次数, objKaoQin.休息日加班, objKaoQin.节假日加班, objKaoQin.休息日出差, objKaoQin.夜间值班次数, objKaoQin.夜间值班调休次数, objKaoQin.打卡签到次数, objKaoQin.工作时长, objKaoQin.备注, objKaoQin.更改者, objKaoQin.更改日期, objKaoQin.IsSubmit);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 修改考勤对象
        /// </summary>
        /// <param name="objKaoQin"></param>
        /// <returns></returns>
        public int ModifyKaoQin(KaoQin objKaoQin)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("update imp_attendance set 应出勤 = {0},实际出勤 = {1},出差 = {2},旷工 = {3},年假 = {4},事假 = {5},病假 = {6},正常调休 = {7},产假 = {8},陪产假 = {9},婚假 = {10},丧假 = {11},迟到早退次数 = {12},缺卡次数 = {13},工作日加班次数 = {14},休息日加班 = {15},节假日加班 = {16},休息日出差 = {17},夜间值班次数 = {18},夜间值班调休次数 = {19},打卡签到次数 = {20},工作时长 = {21},备注 = '{22}',更改者 = '{23}',更改日期 = '{24}',IsSubmit = '{25}'");
            sqlBuilder.Append(" where 考勤年月 = '{26}' and 人员编号 = '{27}'");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objKaoQin.应出勤, objKaoQin.实际出勤, objKaoQin.出差, objKaoQin.旷工, objKaoQin.年假, objKaoQin.事假, objKaoQin.病假, objKaoQin.正常调休, objKaoQin.产假, objKaoQin.陪产假, objKaoQin.婚假, objKaoQin.丧假, objKaoQin.迟到早退次数, objKaoQin.缺卡次数, objKaoQin.工作日加班次数, objKaoQin.休息日加班, objKaoQin.节假日加班, objKaoQin.休息日出差, objKaoQin.夜间值班次数, objKaoQin.夜间值班调休次数, objKaoQin.打卡签到次数, objKaoQin.工作时长, objKaoQin.备注, objKaoQin.更改者, objKaoQin.更改日期, objKaoQin.IsSubmit, objKaoQin.考勤年月, objKaoQin.人员编号);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }



        /// <summary>
        ///根据部门名称查询考勤对象，返回DataTable，用于导出Excel。
        /// </summary>
        /// <param name="last_year_month"></param>
        /// <param name="dept"></param>
        /// <returns></returns>
        public DataTable ExportKaoQinByDept(string last_year_month, string dept)
        {
            string sql = "select ROW_NUMBER() over (order by id) as 序号,考勤年月,部门,班组,人员编号,姓名,应出勤,实际出勤,出差,旷工,年假,事假,病假,正常调休,产假,陪产假,婚假,丧假,迟到早退次数,缺卡次数,工作日加班次数,休息日加班,节假日加班,休息日出差,夜间值班次数,夜间值班调休次数,打卡签到次数,工作时长,备注 from imp_attendance where 考勤年月 = '{0}' and 部门 = '{1}'";
            sql = string.Format(sql, last_year_month, dept);
            DataTable dt_export = SQLHelper.GetDataTable(sql);
            return dt_export;
        }


        /// <summary>
        /// 将DataTable转成List，便于调用CheckKaoQin方法。
        /// </summary>
        /// <param name="dt_import"></param>
        /// <returns></returns>
        public List<KaoQin> DataTableToList(DataTable dt_import)
        {
            List<KaoQin> list = new List<KaoQin>();
            for (int i = 0; i < dt_import.Rows.Count; i++)
            {
                list.Add(new KaoQin()
                {
                    考勤年月 = dt_import.Rows[i]["考勤年月"].ToString(),
                    部门 = dt_import.Rows[i]["部门"].ToString(),
                    班组 = dt_import.Rows[i]["班组"].ToString(),
                    人员编号 = dt_import.Rows[i]["人员编号"].ToString(),
                    姓名 = dt_import.Rows[i]["姓名"].ToString(),
                    应出勤 = Convert.ToDouble(dt_import.Rows[i]["应出勤"].ToString()),
                    实际出勤 = Convert.ToDouble(dt_import.Rows[i]["实际出勤"].ToString()),
                    出差 = Convert.ToDouble(dt_import.Rows[i]["出差"].ToString()),
                    旷工 = Convert.ToDouble(dt_import.Rows[i]["旷工"].ToString()),
                    年假 = Convert.ToDouble(dt_import.Rows[i]["年假"].ToString()),
                    事假 = Convert.ToDouble(dt_import.Rows[i]["事假"].ToString()),
                    病假 = Convert.ToDouble(dt_import.Rows[i]["病假"].ToString()),
                    正常调休 = Convert.ToDouble(dt_import.Rows[i]["正常调休"].ToString()),
                    产假 = Convert.ToDouble(dt_import.Rows[i]["产假"].ToString()),
                    陪产假 = Convert.ToDouble(dt_import.Rows[i]["陪产假"].ToString()),
                    婚假 = Convert.ToDouble(dt_import.Rows[i]["婚假"].ToString()),
                    丧假 = Convert.ToDouble(dt_import.Rows[i]["丧假"].ToString()),
                    迟到早退次数 = Convert.ToDouble(dt_import.Rows[i]["迟到早退次数"].ToString()),
                    缺卡次数 = Convert.ToDouble(dt_import.Rows[i]["缺卡次数"].ToString()),
                    工作日加班次数 = Convert.ToDouble(dt_import.Rows[i]["工作日加班次数"].ToString()),
                    休息日加班 = Convert.ToDouble(dt_import.Rows[i]["休息日加班"].ToString()),
                    节假日加班 = Convert.ToDouble(dt_import.Rows[i]["节假日加班"].ToString()),
                    休息日出差 = Convert.ToDouble(dt_import.Rows[i]["休息日出差"].ToString()),
                    夜间值班次数 = Convert.ToDouble(dt_import.Rows[i]["夜间值班次数"].ToString()),
                    夜间值班调休次数 = Convert.ToDouble(dt_import.Rows[i]["夜间值班调休次数"].ToString()),
                    打卡签到次数 = Convert.ToDouble(dt_import.Rows[i]["打卡签到次数"].ToString()),
                    工作时长 = dt_import.Rows[i]["工作时长"] is DBNull ? 0 : Convert.ToDouble(dt_import.Rows[i]["工作时长"].ToString()),
                    备注 = dt_import.Rows[i]["备注"].ToString(),
                    //更改者 = dt_import.Rows[i]["更改者"].ToString(),
                    //更改日期 = Convert.ToDateTime(dt_import.Rows[i]["更改日期"].ToString())
                    IsSubmit = dt_import.Rows[i]["IsSubmit"] is DBNull ? false : (bool)dt_import.Rows[i]["IsSubmit"]



                });
            }
            return list;
        }


        /// <summary>
        ///根据部门名称查询考勤对象，返回DataTable，用于导出Excel打印。
        /// </summary>
        /// <param name="last_year_month"></param>
        /// <param name="dept"></param>
        /// <returns></returns>
        public DataTable ExportKaoQinPrint(string last_year_month, string dept)
        {
            string sql = "select ROW_NUMBER() over (order by id) as 序号,人员编号,姓名,应出勤,实际出勤,出差,旷工,年假,事假,病假,正常调休,产假,陪产假,婚假,丧假,迟到早退次数,缺卡次数,工作日加班次数,休息日加班,节假日加班,休息日出差,夜间值班次数,夜间值班调休次数,打卡签到次数,工作时长,'' as 本人签字,备注,考勤年月,部门,班组,更改日期 from imp_attendance where 考勤年月 = '{0}' and 部门 = '{1}'";
            sql = string.Format(sql, last_year_month, dept);
            DataTable dt_export = SQLHelper.GetDataTable(sql);
            return dt_export;
        }

        /// <summary>
        /// 将钉钉考勤数据导入数据库
        /// </summary>
        /// <param name="last_year_month"></param>
        /// <param name="current_year_month"></param>
        /// <param name="dt_import"></param>
        /// <returns></returns>
        public DataTable GetDingDingDataTable(string last_year_month, string current_year_month, DataTable dt_import)
        {
            //查找表格中的指定标题的列索引
            string[] strs = DataTableService.GetColumnsByDataTable(dt_import);
            var index = strs.ToList().IndexOf("应出勤天数");
            //将表格中没有数据的字段填充为0
            for (int i = 0; i < dt_import.Rows.Count; i++)
            {
                for (int j = index; j < dt_import.Columns.Count; j++)
                {
                    if (dt_import.Rows[i][j].ToString() == "")
                    {
                        dt_import.Rows[i][j] = "0";
                    }
                }
            }

            string sql = $"select ROW_NUMBER() over (order by emp_bas.id) as 序号,{last_year_month} as 考勤年月,'' as 部门,'' as 班组,emp_bas.人员编号,emp_bas.姓名,'' as 应出勤,'' as 实际出勤,'' as 出差,'' as 旷工,'' as 年假,'' as 事假,'' as 病假,'' as 正常调休,'' as 产假,'' as 陪产假,'' as 婚假,'' as 丧假,'' as 迟到早退次数,'' as 缺卡次数,'' as 工作日加班次数,'' as 休息日加班,'' as 节假日加班,'' as 休息日出差,'' as 夜间值班次数,'' as 夜间值班调休次数,'' as 打卡签到次数,'' as 工作时长,'' as 本人签字,'' as 备注 from emp_bas";
            sql += $" inner join emp_org on emp_bas.人员编号 = emp_org.人员编号";
            sql += $" where '{current_year_month}'+'01' between emp_org.开始日期 and emp_org.结束日期";
            DataTable dt_user = SQLHelper.GetDataTable(sql);

            for (int i = 0; i < dt_user.Rows.Count; i++)
            {
                for (int j = 0; j < dt_import.Rows.Count; j++)
                {
                    if (dt_user.Rows[i]["人员编号"].ToString() == dt_import.Rows[j]["工号"].ToString())
                    {
                        dt_user.Rows[i]["部门"] = dt_import.Rows[j]["部门"].ToString();
                        dt_user.Rows[i]["应出勤"] = dt_import.Rows[j]["应出勤天数"].ToString();
                        dt_user.Rows[i]["实际出勤"] = dt_import.Rows[j]["出勤天数"].ToString();
                        dt_user.Rows[i]["出差"] = dt_import.Rows[j]["出差时长"].ToString();
                        dt_user.Rows[i]["旷工"] = dt_import.Rows[j]["旷工天数"].ToString();
                        dt_user.Rows[i]["年假"] = dt_import.Rows[j]["年假"].ToString();
                        dt_user.Rows[i]["事假"] = dt_import.Rows[j]["事假"].ToString();
                        dt_user.Rows[i]["病假"] = dt_import.Rows[j]["病假"].ToString();
                        dt_user.Rows[i]["正常调休"] = dt_import.Rows[j]["调休"].ToString();
                        dt_user.Rows[i]["产假"] = dt_import.Rows[j]["产假"].ToString();
                        dt_user.Rows[i]["陪产假"] = dt_import.Rows[j]["陪产假"].ToString();
                        dt_user.Rows[i]["婚假"] = dt_import.Rows[j]["婚假"].ToString();
                        dt_user.Rows[i]["丧假"] = dt_import.Rows[j]["丧假"].ToString();
                        dt_user.Rows[i]["迟到早退次数"] = double.Parse(dt_import.Rows[j]["迟到次数"].ToString()) + double.Parse(dt_import.Rows[j]["早退次数"].ToString());
                        dt_user.Rows[i]["缺卡次数"] = double.Parse(dt_import.Rows[j]["上班缺卡次数"].ToString()) + double.Parse(dt_import.Rows[j]["下班缺卡次数"].ToString());
                        dt_user.Rows[i]["工作日加班次数"] = dt_import.Rows[j]["工作日加班"].ToString();
                        dt_user.Rows[i]["休息日加班"] = dt_import.Rows[j]["休息日加班"].ToString();
                        dt_user.Rows[i]["节假日加班"] = dt_import.Rows[j]["节假日加班"].ToString();
                        dt_user.Rows[i]["工作时长"] = dt_import.Rows[j]["工作时长"].ToString();
                    }
                }
            }


            if (dt_user.Columns.Contains("本人签字"))
            {
                dt_user.Columns.Remove("本人签字");
            }

            for (int i = 0; i < dt_user.Rows.Count; i++)
            {
                string StrA = dt_user.Rows[i]["部门"].ToString();
                char[] separator = { '-' };
                String[] splitstrings = new String[10];                                    //声明一个字符串数组
                splitstrings = StrA.Split(separator);
                if (dt_user.Rows[i]["部门"].ToString().Contains("-"))
                {
                    dt_user.Rows[i]["部门"] = splitstrings[0];

                    dt_user.Rows[i]["班组"] = splitstrings[1];
                }
            }
            return dt_user;
        }


        /// <summary>
        /// 增加考勤对象
        /// </summary>
        /// <param name="objKaoQin"></param>
        /// <returns></returns>
        public int InsertDD_YuanShi(DD_YuanShi objYuanShi)
        {
            //1、编写SQL语句
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("insert into DD_YuanShi (姓名,部门,工号,职位,UserId,考勤日期,考勤时间,打卡时间,打卡结果,打卡地址,打卡备注,异常打卡原因,打卡设备,管理员修改备注,管理员修改备注图片1)");
            sqlBuilder.Append(" values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')");
            //2、解析对象
            string sql = string.Format(sqlBuilder.ToString(), objYuanShi.姓名, objYuanShi.部门, objYuanShi.工号, objYuanShi.职位, objYuanShi.UserId, objYuanShi.考勤日期, objYuanShi.考勤时间, objYuanShi.打卡时间, objYuanShi.打卡结果, objYuanShi.打卡地址, objYuanShi.打卡备注, objYuanShi.异常打卡原因, objYuanShi.打卡设备, objYuanShi.管理员修改备注, objYuanShi.管理员修改备注图片1);
            //3、执行SQL语句，返回结果
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 将DataTable转成List，便于调用CheckKaoQin方法。
        /// </summary>
        /// <param name="dt_import"></param>
        /// <returns></returns>
        public List<DD_YuanShi> DataTableToList_YuanShi(DataTable dt_import)
        {
            List<DD_YuanShi> list = new List<DD_YuanShi>();
            for (int i = 0; i < dt_import.Rows.Count; i++)
            {
                list.Add(new DD_YuanShi()
                {
                    姓名 = dt_import.Rows[i]["姓名"].ToString(),
                    部门 = dt_import.Rows[i]["部门"].ToString(),
                    工号 = dt_import.Rows[i]["工号"].ToString(),
                    职位 = dt_import.Rows[i]["职位"].ToString(),
                    UserId = dt_import.Rows[i]["UserId"].ToString(),
                    考勤日期 = dt_import.Rows[i]["考勤日期"].ToString(),
                    考勤时间 = dt_import.Rows[i]["考勤时间"].ToString(),
                    打卡时间 = dt_import.Rows[i]["打卡时间"].ToString(),
                    打卡结果 = dt_import.Rows[i]["打卡结果"].ToString(),
                    打卡地址 = dt_import.Rows[i]["打卡地址"].ToString(),
                    打卡备注 = dt_import.Rows[i]["打卡备注"].ToString(),
                    异常打卡原因 = dt_import.Rows[i]["异常打卡原因"].ToString(),
                    打卡图片1 = dt_import.Rows[i]["打卡图片1"].ToString(),
                    打卡图片2 = dt_import.Rows[i]["打卡图片2"].ToString(),
                    打卡设备 = dt_import.Rows[i]["打卡设备"].ToString(),
                    管理员修改备注 = dt_import.Rows[i]["管理员修改备注"].ToString(),
                    管理员修改备注图片1 = dt_import.Rows[i]["管理员修改备注图片1"].ToString(),
                    管理员修改备注图片2 = dt_import.Rows[i]["管理员修改备注图片2"].ToString(),
                    管理员修改备注图片3 = dt_import.Rows[i]["管理员修改备注图片3"].ToString()

                });
            }
            return list;
        }






    }
}
