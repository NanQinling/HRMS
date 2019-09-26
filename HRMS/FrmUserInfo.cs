using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;

using DAL;


namespace HRMS
{
    public partial class FrmUserInfo : Form
    {
        public FrmUserInfo()
        {
            InitializeComponent();

            //初始化入职原因下拉框
            this.cmbRuZhiYuanYin.DataSource = objUserInfoService.GetAllXinZeng();
            this.cmbRuZhiYuanYin.DisplayMember = "入职原因长文本";
            this.cmbRuZhiYuanYin.ValueMember = "ActR";
            this.cmbRuZhiYuanYin.SelectedIndex = -1;

            //初始化入职学历下拉框
            this.cmbRuZhiXueLi.DataSource = objUserInfoService.GetAllXueLi();
            this.cmbRuZhiXueLi.DisplayMember = "入职学历长文本";
            this.cmbRuZhiXueLi.ValueMember = "EE";
            this.cmbRuZhiXueLi.SelectedIndex = -1;

            //初始化工资标识下拉框
            this.cmbGongZiBiaoShi.DataSource = objUserInfoService.GetAllBank();
            this.cmbGongZiBiaoShi.DisplayMember = "工资银行名称";
            this.cmbGongZiBiaoShi.ValueMember = "工资银行代码";
            this.cmbGongZiBiaoShi.SelectedIndex = -1;

            //初始化奖金标识下拉框
            this.cmbJiangJinBiaoShi.DataSource = objUserInfoService.GetAllBank();
            this.cmbJiangJinBiaoShi.DisplayMember = "奖金银行名称";
            this.cmbJiangJinBiaoShi.ValueMember = "奖金银行代码";
            this.cmbJiangJinBiaoShi.SelectedIndex = -1;


            init_dgvUserInfo();




        }

        private UserInfoService objUserInfoService = new DAL.UserInfoService();
        private ZuZhiFenPeiService objZuZhiFenPeiService = new DAL.ZuZhiFenPeiService();

        private ControlService objControlService = new DAL.ControlService();
        private PinYin objPinYinService = new PinYin();
        //private MoveItemService objMoveItemService = new DAL.MoveItemService();
        //private List<UserInfo> nodeList = null;


        bool bAdd = false;      //点保存时使用
        bool bModify = false;




        /// <summary>
        /// 加班表格初始化
        /// </summary>
        private void init_dgvUserInfo()
        {
            List<UserInfo> list = objUserInfoService.GetUserInfoListAll();
            SetDgvUserInfoFormat(list);
            objControlService.DisabledTabPageItem(tabPage1);
        }


        /// <summary>
        /// 设置表格显示格式
        /// </summary>
        /// <param name="list"></param>
        private void SetDgvUserInfoFormat(List<UserInfo> list)
        {
            this.dataGridView1.DataSource = list;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Columns[3].Frozen = true;

            ////禁止 DataGridView 点击 列标题 排序
            //for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            //{
            //    dgvKaoQin.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            //}

            ////隐藏不必要的列
            //for (int i = 0; i < dgvKaoQin.Columns.Count; i++)
            //{
            //    if (i == 0 || i == dgvKaoQin.Columns.Count - 1 || i == dgvKaoQin.Columns.Count - 2 || i == dgvKaoQin.Columns.Count - 3 || i == dgvKaoQin.Columns.Count - 4)
            //    {
            //        dgvKaoQin.Columns[i].Visible = false;
            //    }
            //    if (dgvKaoQin.Columns[i].Name == "部门")
            //    {
            //        dgvKaoQin.Columns[i].Visible = false;
            //    }
            //}
            ////调整列宽
            //for (int i = 0; i < dgvKaoQin.Columns.Count; i++)
            //{
            //    if (i == 1 || i == 2 || i == 3 || i == 25)
            //    {
            //        dgvKaoQin.Columns[i].Width = 80;
            //    }

            //    else if (i == 0 || (i >= 4 && i < 25))
            //    {
            //        dgvKaoQin.Columns[i].Width = 40;
            //    }
            //}
        }


        /// <summary>
        /// 根据dataGridView查询详细信息，tabPage1
        /// </summary>
        /// <param name="intUserId"></param>
        private void GetUserInfotabPage1(string strUserId)
        {
            UserInfo objUserInfo = objUserInfoService.GetUserInfoByUserID(strUserId);
            this.txtUserID.Text = objUserInfo.人员编号;
            this.txtName.Text = objUserInfo.姓名;
            this.cmbSex.Text = objUserInfo.性别;
            this.txtBirthday.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objUserInfo.出生日期.ToString()));
            this.txtIDNumber.Text = objUserInfo.身份证号;
            this.txtWorkingDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objUserInfo.参加工作日期.ToString()));
            this.txtJoinHNDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objUserInfo.加入华能系统日期.ToString()));
            this.txtJoinOurEnterpriseDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objUserInfo.加入本单位日期.ToString()));
            this.cmbRuZhiYuanYin.Text = objUserInfo.入职原因长文本;
            this.cmbRuZhiXueLi.Text = objUserInfo.入职学历长文本;
            this.cmbGongZiBiaoShi.Text = objUserInfo.工资银行名称;
            this.txtSalaryBankAccountNumber.Text = objUserInfo.工资账号;
            this.cmbJiangJinBiaoShi.Text = objUserInfo.奖金银行名称;
            this.txtbounsBankAccountNumber.Text = objUserInfo.奖金账号;
            this.txtRemark.Text = objUserInfo.备注.ToString();

        }


        /// <summary>
        /// 根据dataGridView查询详细信息，并输出给GroupBox
        /// </summary>
        /// <param name="intUserId"></param>
        private void GetUserInfoGroupBox(string strUserId)
        {
            ZuZhiFenPei objZuZhiFenPei = objZuZhiFenPeiService.GetZuZhiByUserID(DateTime.Now, strUserId);
            this.txtUserID.Text = objZuZhiFenPei.人员编号;
            this.txtViewName.Text = objZuZhiFenPei.姓名;
            this.txtZuZhiDanWei.Text = objZuZhiFenPei.组织单位;
            this.txtRenShiFanWei.Text = objZuZhiFenPei.人事范围;
            this.txtYuanGongZu.Text = objZuZhiFenPei.员工组;
            this.txtZhiWei.Text = objZuZhiFenPei.职位名称;
            this.txtRenShiZiFanWei.Text = objZuZhiFenPei.人事子范围;
            this.txtYuanGongZiZu.Text = objZuZhiFenPei.员工子组的名称;
        }







        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objControlService.init_tabPage(tabPage1);
            string userid = this.dataGridView1.CurrentRow.Cells["人员编号"].Value.ToString();
            GetUserInfotabPage1(userid);
            objControlService.DisabledTabPageItem(tabPage1);
            GetUserInfoGroupBox(userid);
        }




        /// <summary>
        /// 封装对象
        /// </summary>
        private UserInfo FengZhuangDuiXiang()
        {
            UserInfo objUserInfo = new UserInfo()
            {
                人员编号 = this.txtUserID.Text.Trim(),
                姓名 = this.txtName.Text.Trim(),
                性别 = this.cmbSex.Text.Trim(),
                出生日期 = Convert.ToDateTime(this.txtBirthday.Text.Trim()),
                身份证号 = this.txtIDNumber.Text.Trim(),
                参加工作日期 = Convert.ToDateTime(this.txtWorkingDate.Text.Trim()),
                加入华能系统日期 = Convert.ToDateTime(this.txtJoinHNDate.Text.Trim()),
                加入本单位日期 = Convert.ToDateTime(this.txtJoinOurEnterpriseDate.Text.Trim()),
                入职原因 = this.cmbRuZhiYuanYin.SelectedIndex == -1 ? null : this.cmbRuZhiYuanYin.SelectedValue.ToString(),
                入职学历 = this.cmbRuZhiXueLi.SelectedIndex == -1 ? null : this.cmbRuZhiXueLi.SelectedValue.ToString(),
                工资标识 = this.cmbGongZiBiaoShi.SelectedIndex == -1 ? null : this.cmbGongZiBiaoShi.SelectedValue.ToString(),
                工资账号 = this.txtSalaryBankAccountNumber.Text.Trim(),
                奖金标识 = this.cmbJiangJinBiaoShi.SelectedIndex == -1 ? null : this.cmbJiangJinBiaoShi.SelectedValue.ToString(),
                奖金账号 = this.txtbounsBankAccountNumber.Text.Trim(),
                备注 = this.txtRemark.Text.Trim(),
                拼音码 = objPinYinService.GetFirstLetter(this.txtName.Text.Trim()),
                更改者 = Program.currentAdmin.username,
                更改日期 = DateTime.Now
            };
            return objUserInfo;
        }




        private void tsbADD_Click(object sender, EventArgs e)
        {
            bAdd = true;
            objControlService.init_tabPage(tabPage1);
            objControlService.EnabledTabPageItem(tabPage1);



        }

        private void tsbModify_Click(object sender, EventArgs e)
        {
            if (this.txtUserID.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择要修改的人员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bModify = true;
            objControlService.EnabledTabPageItem(tabPage1);
            this.txtUserID.Enabled = false;




        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (bAdd == true)//新增数据
            {
                #region 数据验证

                #endregion

                #region 封装对象
                UserInfo objUserInfo = FengZhuangDuiXiang();
                #endregion

                #region 调用后台数据访问对象添加数据
                try
                {
                    if (objUserInfoService.Add(objUserInfo) == 1)
                    {
                        DialogResult result = MessageBox.Show("添加成功，是否继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            tsbADD_Click(null, null);
                        }
                        else
                        {
                            bAdd = false;
                            objControlService.init_tabPage(tabPage1);
                            objControlService.DisabledTabPageItem(tabPage1);
                            init_dgvUserInfo();
                        }
                    }
                    else
                    {
                        MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                #endregion
            }
            if (bModify == true)//修改数据
            {
                #region 数据验证

                #endregion

                #region 封装对象
                UserInfo objUserInfo = FengZhuangDuiXiang();
                #endregion

                #region 调用后台数据访问对象修改数据
                try
                {
                    if (objUserInfoService.Modify(objUserInfo) == 1)
                    {
                        bModify = false;
                        objControlService.init_tabPage(tabPage1);
                        objControlService.DisabledTabPageItem(tabPage1);
                        init_dgvUserInfo();
                        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;//返回修改成功的信息
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                #endregion
            }




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (this.txtUserID.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择要删除的人员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"人员删除后将不可恢复，确定要删除人员编号【{this.txtUserID.Text.Trim()}】，姓名【{this.txtName.Text.Trim()}】吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取机构编号并删除
            try
            {
                if (objUserInfoService.Delete(this.txtUserID.Text.Trim()) == 1)
                {
                    objControlService.init_tabPage(tabPage1);
                    objControlService.DisabledTabPageItem(tabPage1);
                    init_dgvUserInfo();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
                throw;
            }

        }
    }
}
