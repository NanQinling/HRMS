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

            init_UserInfoCombox();

            init_dgvUserInfo();
            objControlService.DisabledGroupBoxItem(groupBox1);

            objControlService.DisabledTabPageItem(tabPage1);
            objControlService.DisabledTabPageItem(tabPage2);




        }

        private void init_UserInfoCombox()
        {
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

            //初始化员工子组下拉框
            this.cmbYuanGongZiZu.DataSource = objZuZhiFenPeiService.GetAllYuanGonGZiZu();
            this.cmbYuanGongZiZu.DisplayMember = "员工子组的名称";
            this.cmbYuanGongZiZu.ValueMember = "EG";
            this.cmbYuanGongZiZu.SelectedIndex = -1;
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
        /// 人员名单dataGridView格初始化
        /// </summary>
        private void init_dgvUserInfo()
        {
            List<UserInfo> list = objUserInfoService.GetUserInfoListAll();
            SetDgvAllUserFormat(list);
            objControlService.DisabledTabPageItem(tabPage1);
        }


        /// <summary>
        /// 项目dataGridView格初始化
        /// </summary>
        private void init_dgvProject(string strUserId)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                List<UserInfo> list_Project = objUserInfoService.GetUserInfoListByUserId(strUserId);
                SetDgvUserInfoFormat(list_Project);
                objControlService.DisabledTabPageItem(tabPage1);
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                List<ZuZhiFenPei> list_Project = objZuZhiFenPeiService.GetZuZhiFenPeiListByUserId(strUserId);
                SetDgvZuZhiFenPeiFormat(list_Project);
                objControlService.DisabledTabPageItem(tabPage2);
            }

        }

        /// <summary>
        /// 设置表格显示格式
        /// </summary>
        /// <param name="list"></param>
        private void SetDgvAllUserFormat(List<UserInfo> list)
        {
            this.dgvAllUser.DataSource = list;
            this.dgvAllUser.AllowUserToAddRows = false;
            this.dgvAllUser.AllowUserToDeleteRows = false;
            this.dgvAllUser.ReadOnly = true;
            this.dgvAllUser.MultiSelect = false;
            this.dgvAllUser.Columns[3].Frozen = true;
            this.dgvAllUser.RowHeadersVisible = false;

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
        /// 设置表格显示格式
        /// </summary>
        /// <param name="list"></param>
        private void SetDgvUserInfoFormat(List<UserInfo> list)
        {
            this.dgvProject.DataSource = list;
            this.dgvProject.AllowUserToAddRows = false;
            this.dgvProject.AllowUserToDeleteRows = false;
            this.dgvProject.ReadOnly = true;
            this.dgvProject.MultiSelect = false;
            this.dgvProject.Columns[3].Frozen = true;
            this.dgvProject.RowHeadersVisible = false;

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

        private void SetDgvZuZhiFenPeiFormat(List<ZuZhiFenPei> list)
        {
            this.dgvProject.DataSource = list;
            this.dgvProject.AllowUserToAddRows = false;
            this.dgvProject.AllowUserToDeleteRows = false;
            this.dgvProject.ReadOnly = true;
            this.dgvProject.MultiSelect = false;
            this.dgvProject.Columns[3].Frozen = true;

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
        /// 根据dataGridView双击行数据查询人员组织信息
        /// </summary>
        /// <param name="strUserId"></param>
        private void GetUserInfoGroupBox(string strUserId)
        {
            ZuZhiFenPei objZuZhiFenPei = objZuZhiFenPeiService.GetZuZhiByUserID(DateTime.Now, strUserId);
            this.txtUserID.Text = objZuZhiFenPei.人员编号;
            this.txtViewName.Text = objZuZhiFenPei.姓名;
            this.txtZuZhiDanWei.Text = objZuZhiFenPei.二级内设机构 + objZuZhiFenPei.三级内设机构;
            this.txtRenShiFanWei.Text = objZuZhiFenPei.人事范围;
            this.txtYuanGongZu.Text = objZuZhiFenPei.员工组;
            this.txtZhiWei.Text = objZuZhiFenPei.职位名称;
            this.txtRenShiZiFanWei.Text = objZuZhiFenPei.人事子范围;
            this.txtYuanGongZiZu.Text = objZuZhiFenPei.员工子组的名称;
        }

        /// <summary>
        /// 根据dataGridView双击行数据查询人员信息
        /// </summary>
        /// <param name="strUserId"></param>
        private void GetUserInfotabPage(string strUserId)
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
        /// 根据dataGridView双击行数据查询组织分配
        /// </summary>
        /// <param name="strUserId"></param>
        private void GetZuZhiFenPeitabPage(string strUserId)
        {
            ZuZhiFenPei objZuZhiFenPei = objZuZhiFenPeiService.GetZuZhiByUserID(DateTime.Now, strUserId);
            this.txtZuZhiStartDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objZuZhiFenPei.开始日期.ToString()));
            this.txtZuZhiEndDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objZuZhiFenPei.结束日期.ToString()));
            this.txtTabRenShiFanWei.Text = objZuZhiFenPei.人事范围;
            this.txtTabRenShiZiFanWei.Text = objZuZhiFenPei.人事子范围;
            this.txtTabYuanGongZu.Text = objZuZhiFenPei.员工组;
            this.txtTabGongZiFanWei.Text = objZuZhiFenPei.工资范围;
            this.cmbYuanGongZiZu.Text = objZuZhiFenPei.员工子组的名称;
            this.txtTabZhiWeiBianMa.Text = objZuZhiFenPei.职位编码.ToString();
            this.txtTabZhiWei.Text = objZuZhiFenPei.职位名称;
            this.txtTabSuoShuErJiJiGou.Text = objZuZhiFenPei.二级内设机构;
            this.txtTabSuoShuSanJiJiGou.Text = objZuZhiFenPei.三级内设机构;

        }







        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //清空tabPage数据
            objControlService.init_tabPage(tabPage1);
            objControlService.init_tabPage(tabPage2);

            //根据DataGridView双击行，确定要修改的数据，并显示给GroupBox
            string userid = this.dgvAllUser.CurrentRow.Cells["人员编号"].Value.ToString();
            GetUserInfoGroupBox(userid);
            objControlService.DisabledGroupBoxItem(groupBox1);
            //根据选定的tabPage生成DgvProject数据
            init_dgvProject(userid);

        }




        /// <summary>
        /// 封装对象
        /// </summary>	
        private UserInfo FengZhuangDuiXiang_UserInfo()
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

        private ZuZhiFenPei FengZhuangDuiXiang_ZuZhi()
        {
            ZuZhiFenPei objZuZhiFenPei = new ZuZhiFenPei()
            {
                id = Convert.ToInt32(this.dgvProject.CurrentRow.Cells["id"].Value.ToString()),
                人员编号 = this.txtUserID.Text.Trim(),
                开始日期 = Convert.ToDateTime(this.txtZuZhiStartDate.Text.Trim()),
                结束日期 = Convert.ToDateTime(this.txtZuZhiEndDate.Text.Trim()),
                人事范围 = this.txtTabRenShiFanWei.Text.Trim(),
                人事子范围 = this.txtTabRenShiZiFanWei.Text.Trim(),
                员工组 = this.txtTabYuanGongZu.Text.Trim(),
                员工子组 = this.cmbYuanGongZiZu.SelectedIndex == -1 ? null : this.cmbYuanGongZiZu.SelectedValue.ToString(),
                工资范围 = this.txtTabGongZiFanWei.Text.Trim(),
                职位编码 = Convert.ToInt32(this.txtTabZhiWeiBianMa.Text.Trim()),
                备注 = this.txtTabZuZhiRemark.Text.Trim(),
                更改者 = Program.currentAdmin.username,
                更改日期 = DateTime.Now
            };
            return objZuZhiFenPei;
        }



        private void tsbADD_Click(object sender, EventArgs e)
        {
            bAdd = true;
            if (tabControl1.SelectedTab == tabPage1)
            {
                objControlService.init_tabPage(tabPage1);
                objControlService.EnabledTabPageItem(tabPage1);
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                objControlService.init_tabPage(tabPage2);
                objControlService.EnabledTabPageItem(tabPage2);
            }




        }

        private void tsbModify_Click(object sender, EventArgs e)
        {
            if (this.txtUserID.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择要修改的人员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bModify = true;
            if (tabControl1.SelectedTab == tabPage1)
            {
                objControlService.EnabledTabPageItem(tabPage1);
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                objControlService.EnabledTabPageItem(tabPage2);
            }
            //this.txtUserID.Enabled = false;




        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (bAdd == true)//新增数据
            {
                #region 数据验证

                #endregion

                #region 封装对象
                //UserInfo objUserInfo = FengZhuangDuiXiang_UserInfo();
                //ZuZhiFenPei objZuZhiFenPei = FengZhuangDuiXiang_ZuZhi();
                #endregion

                #region 调用后台数据访问对象添加数据
                try
                {
                    int intResult = 0;
                    if (tabControl1.SelectedTab == tabPage1)
                    {
                        UserInfo objUserInfo = FengZhuangDuiXiang_UserInfo();
                        intResult = objUserInfoService.Add(objUserInfo);
                    }
                    else if (tabControl1.SelectedTab == tabPage2)
                    {
                        ZuZhiFenPei objZuZhiFenPei = FengZhuangDuiXiang_ZuZhi();
                        intResult = objZuZhiFenPeiService.Add(objZuZhiFenPei);
                    }




                    if (intResult == 1)
                    {
                        DialogResult result = MessageBox.Show("添加成功，是否继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            tsbADD_Click(null, null);
                        }
                        else
                        {
                            bAdd = false;
                            if (tabControl1.SelectedTab == tabPage1)
                            {
                                objControlService.init_tabPage(tabPage1);
                                objControlService.DisabledTabPageItem(tabPage1);
                                init_dgvUserInfo();
                                init_dgvProject(this.txtUserID.Text.Trim());
                            }
                            else if (tabControl1.SelectedTab == tabPage2)
                            {
                                objControlService.init_tabPage(tabPage2);
                                objControlService.DisabledTabPageItem(tabPage2);
                                init_dgvProject(this.txtUserID.Text.Trim());
                            }
                            //init_dgvUserInfo();
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
                //UserInfo objUserInfo = FengZhuangDuiXiang_UserInfo();
                //ZuZhiFenPei objZuZhiFenPei = FengZhuangDuiXiang_ZuZhi();
                #endregion

                #region 调用后台数据访问对象修改数据
                try
                {
                    int intResult = 0;
                    if (tabControl1.SelectedTab == tabPage1)
                    {
                        UserInfo objUserInfo = FengZhuangDuiXiang_UserInfo();
                        intResult = objUserInfoService.Modify(objUserInfo);
                    }
                    else if (tabControl1.SelectedTab == tabPage2)
                    {
                        ZuZhiFenPei objZuZhiFenPei = FengZhuangDuiXiang_ZuZhi();
                        intResult = objZuZhiFenPeiService.Modify(objZuZhiFenPei);
                    }

                    if (intResult == 1)
                    {
                        bModify = false;

                        if (tabControl1.SelectedTab == tabPage1)
                        {
                            objControlService.init_tabPage(tabPage1);
                            objControlService.DisabledTabPageItem(tabPage1);
                            init_dgvUserInfo();
                            init_dgvProject(this.txtUserID.Text.Trim());
                        }
                        else if (tabControl1.SelectedTab == tabPage2)
                        {
                            objControlService.init_tabPage(tabPage2);
                            objControlService.DisabledTabPageItem(tabPage2);
                            init_dgvProject(this.txtUserID.Text.Trim());
                        }


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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<UserInfo> list = objUserInfoService.GetUserInfoByUserIdOrPYMOrName(this.txtSearch.Text);
            SetDgvAllUserFormat(list);
        }

        private void dgvProject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                string userid = this.txtUserID.Text.Trim();
                GetUserInfotabPage(userid);
                objControlService.DisabledTabPageItem(tabPage1);
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                string userid = this.txtUserID.Text.Trim();
                GetZuZhiFenPeitabPage(userid);
                objControlService.DisabledTabPageItem(tabPage2);
            }




        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userid = this.txtUserID.Text.Trim();
            init_dgvProject(userid);



        }








        private void btnSelectPosi_Click(object sender, EventArgs e)
        {

            Form frmSelectPosi = new FrmSelectPosi(set_posi);
            frmSelectPosi.MaximizeBox = false;
            frmSelectPosi.MinimizeBox = false;
            frmSelectPosi.StartPosition = FormStartPosition.CenterScreen;
            frmSelectPosi.ShowDialog();


        }

        void set_posi(int intPosiNum, string strPosiName, string strSuoShuErJiJiGou, string strSuoShuSanJiJiGou, string strGangWeiXingZhi)
        {
            txtTabZhiWeiBianMa.Text = intPosiNum.ToString();
            txtTabZhiWei.Text = strPosiName;
            txtTabSuoShuErJiJiGou.Text = strSuoShuErJiJiGou;
            txtTabSuoShuSanJiJiGou.Text = strSuoShuSanJiJiGou;
            cmbYuanGongZiZu.Text = strGangWeiXingZhi;

        }











    }
}
