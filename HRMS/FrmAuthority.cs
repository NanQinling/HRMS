using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DAL;
using Models;

namespace HRMS
{
    public partial class FrmAuthority : Form
    {

        private AdminService objAdminService = new DAL.AdminService();//创建数据访问类对象

        /// <summary>
        /// 加班表格初始化
        /// </summary>
        private void init_dgvAuthority()
        {
            List<Admin> list = objAdminService.GetAllAdmin();
            this.dataGridView1.DataSource = list;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            //this.dataGridView1.ReadOnly = true;
            this.dataGridView1.MultiSelect = false;
            //this.dataGridView1.Columns[3].Frozen = true;

            //禁止 DataGridView 点击 列标题 排序
            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //隐藏不必要的列
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].HeaderText == "id")
                {
                    dataGridView1.Columns[i].Visible = false;
                }
                if (dataGridView1.Columns[i].HeaderText == "deptid")
                {
                    dataGridView1.Columns[i].Visible = false;
                }
                if (dataGridView1.Columns[i].HeaderText == "pwd")
                {
                    dataGridView1.Columns[i].Visible = false;
                }
            }
        }

        /// <summary>
        /// 清空当前文本框
        /// </summary>
        private void init_gbAuthority()
        {
            foreach (Control item in this.groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;//不选择
                }
            }
        }

        ///// <summary>
        ///// 封装对象
        ///// </summary>
        //private Admin FengZhuangDuiXiang()
        //{
        //    Admin objAdmin = new Admin()
        //    {
        //        考勤年月 = Program.salaryDate.last_year_month,
        //        部门 = Program.currentAdmin.dept,
        //        班组 = this.txtBanZu.Text.Trim(),
        //        人员编号 = this.txtHnbh.Text.Trim(),
        //        姓名 = this.txtName.Text.Trim(),
        //        应出勤 = double.Parse(this.txtYingChuQin.Text),
        //        实际出勤 = double.Parse(this.txtShiJiChuQin.Text),
        //        出差 = double.Parse(this.txtChuChai.Text),
        //        旷工 = double.Parse(this.txtKuangGong.Text),
        //        年假 = double.Parse(this.txtNianJia.Text),
        //        事假 = double.Parse(this.txtShiJia.Text),
        //        病假 = double.Parse(this.txtBingJia.Text),
        //        正常调休 = double.Parse(this.txtZhengChangTiaoXiu.Text),
        //        产假 = double.Parse(this.txtChanJia.Text),
        //        陪产假 = double.Parse(this.txtPeiChanJia.Text),
        //        婚假 = double.Parse(this.txtHunJian.Text),
        //        丧假 = double.Parse(this.txtSangJia.Text),
        //        迟到早退次数 = double.Parse(this.txtChiDaoZaoTuiCiShu.Text),
        //        缺卡次数 = double.Parse(this.txtQueKaCiShu.Text),
        //        工作日加班次数 = double.Parse(this.txtGongZuoRiJiaBanCiShu.Text),
        //        休息日加班 = double.Parse(this.txtXiuXiRiJiaBan.Text),
        //        节假日加班 = double.Parse(this.txtJieJiaRiJiaBan.Text),
        //        休息日出差 = double.Parse(this.txtXiuXiRiChuChai.Text),
        //        夜间值班次数 = double.Parse(this.txtYeJianZhiBanCiShu.Text),
        //        夜间值班调休次数 = double.Parse(this.txtYeJianZhiBanTiaoXiuCiShu.Text),
        //        打卡签到次数 = double.Parse(this.txtDaKaQianDaoCiShu.Text),
        //        工作时长 = double.Parse(this.txtGongZuoShiChang.Text),
        //        备注 = this.txtBeiZhu.Text.Trim(),
        //        更改者 = Program.currentAdmin.username,
        //        更改日期 = DateTime.Now
        //    };
        //    return objAdmin;
        //}



        public FrmAuthority()
        {
            InitializeComponent();
            init_dgvAuthority();
            //#region 将txtbox控件同时添加一个KeyPress事件
            //this.txtYingChuQin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            //this.txtShiJiChuQin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            //this.txtChuChai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            //this.txtKuangGong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            //this.txtNianJia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            //this.txtShiJia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            //this.txtBingJia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);

            //#endregion
            //this.txtBeiZhu.MaxLength = 30;//设置备注txtBox最大字符为30
        }









    }
}
