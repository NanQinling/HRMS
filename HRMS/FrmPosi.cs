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
    public partial class FrmPosi : Form
    {
        public FrmPosi()
        {
            InitializeComponent();

            //初始化岗位性质下拉框
            this.cmbPosiQuality.DataSource = objGangWeiService.GetAllGangWeiLevel();
            this.cmbPosiQuality.DisplayMember = "岗位性质长文本";
            this.cmbPosiQuality.ValueMember = "DT";
            this.cmbPosiQuality.SelectedIndex = -1;

            //初始化TreeView
            LoadPosiList();
            objControlService.DisabledGroupBoxItem(gbPosi);

        }

        private GangWeiService objGangWeiService = new GangWeiService();
        private ControlService objControlService = new DAL.ControlService();
        private MoveItemService objMoveItemService = new MoveItemService();
        private List<GangWei> nodeList = null;

        int nTreeViewId = 0;      //删除时使用
        bool bAdd = false;      //点保存时使用
        bool bModify = false;


        #region TreeView相关

        #region 使用递归的方式载入TreeView
        private void LoadPosiList()
        {
            this.nodeList = objGangWeiService.GetDeptAndGangWeiListAll(DateTime.Now);//加载所有的菜单节点信息

            tvPosiList.BeginUpdate();
            //创建一个根节点：
            this.tvPosiList.Nodes.Clear();//清空所有的节点
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "华能陕西渭南热电有限公司";
            rootNode.Tag = "0";//默认值,实际开发中可以根据需要设置
            //rootNode.ImageIndex = 0;//设置根节点显示的图片
            this.tvPosiList.Nodes.Add(rootNode);//将根节点添加到treeview根节点


            //基于递归方式添加所有子节点
            CreateChildNode(rootNode, 0);
            tvPosiList.EndUpdate();
            this.tvPosiList.Nodes[0].Expand();//将递归树一级目录展开
            //this.tvPosiList.ExpandAll();
        }

        private void CreateChildNode(TreeNode parentNode, int preId)
        {
            //找到所有以该节点为父节点的子项
            var nodes = from list in this.nodeList
                        where list.ParentID.Equals(preId)
                        select list;

            //循环创建该节点的所有子节点
            foreach (var item in nodes)
            {
                //创建新的节点并设置属性
                TreeNode node = new TreeNode();
                node.Text = item.职位名称.Substring(2);
                node.Tag = item.职位编码;

                //设置节点图标
                if (item.职位名称.Substring(0, 1) == "O")
                {
                    node.ImageIndex = 0;
                }
                else if (item.职位名称.Substring(0, 1) == "S")
                {
                    node.ImageIndex = 1;
                }
                else if (item.职位名称.Substring(0, 1) == "P")
                {
                    node.ImageIndex = 1;
                }

                parentNode.Nodes.Add(node);//父节点加入该子节点
                //调用递归实现子节点添加
                CreateChildNode(node, item.职位编码);
            }

        }
        #endregion



        private void tvPosiList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            objControlService.init_GroupBox(gbPosi);
            listView1.Items.Clear();
            //nListViewId = 0;

            if (e.Node.Level == 0)
            {
                nTreeViewId = 0;
            }
            else
            {
                //如果选中的是机构，则查看该机构下所有的岗位，并将其显示在ListView中
                //if (Convert.ToInt32(e.Node.Tag.ToString()) >= 50000000 && Convert.ToInt32(e.Node.Tag.ToString()) < 60000000)
                if (Convert.ToInt32(e.Node.Tag.ToString()) >= 1000 && Convert.ToInt32(e.Node.Tag.ToString()) < 10000)
                {
                    nTreeViewId = Convert.ToInt32(e.Node.Tag.ToString());
                    objGangWeiService.GetGangWeiListView(listView1, DateTime.Now, nTreeViewId);
                }
                //如果选中的是岗位，则查看该岗位并将其显示在GroupBox中
                if (Convert.ToInt32(e.Node.Tag.ToString()) >= 60000000 && Convert.ToInt32(e.Node.Tag.ToString()) < 70000000)
                {
                    nTreeViewId = Convert.ToInt32(e.Node.Tag.ToString());
                    GetPosiGroupBox(nTreeViewId);
                }
            }
            objControlService.DisabledGroupBoxItem(gbPosi);





        }


        #endregion

        #region ListView相关

        /// <summary>
        /// 未选中ListView列表中的行的时候，清空GroupBox并且将id的值清零；选中行时，id值就为该行的text值。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    //if (listView1.SelectedItems.Count == 0)
            //    //{
            //    //    nListViewId = 0;
            //    //    objControlService.init_GroupBox(gbPosi);
            //    //}
            //    //else
            //    //{
            //    //    ListViewItem lvi = listView1.SelectedItems[0];
            //    //    nListViewId = Convert.ToInt32(lvi.Text);
            //    //    GetPosiGroupBox(nListViewId);
            //    //}
        }


        #endregion

        #region GroupBox相关

        /// <summary>
        /// 根据节点的tag查询详细信息，并输出给GroupBox
        /// </summary>
        /// <param name="intPosiId"></param>
        private void GetPosiGroupBox(int intPosiId)
        {
            GangWei objGangWei = objGangWeiService.GetGangWeiByGangWeiID(DateTime.Now, intPosiId);
            this.txtFullName.Text = objGangWei.职位名称;
            this.txtShortName.Text = objGangWei.职位简称;
            this.cmbPosiQuality.Text = objGangWei.岗位性质长文本;
            this.txtXuLie.Text = objGangWei.岗位序列;
            this.cmbGangJi.Text = objGangWei.岗级;
            this.ckbIsTeShu.Checked = objGangWei.是否特殊岗位;
            this.ckbIsGuanJian.Checked = objGangWei.是否关键岗位;
            this.ckbIsYunXing.Checked = objGangWei.是否运行岗位;
            this.ckbIsXuni.Checked = objGangWei.是否虚拟岗位;
            this.txtParentDept.Text = objGangWei.ParentID.ToString();
            this.txtBeiZhu.Text = objGangWei.备注.ToString();
            this.txtStartDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objGangWei.开始日期.ToString()));
            this.txtEndDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objGangWei.结束日期.ToString()));
        }



        #endregion

        #region 增删改相关

        private void AddPosi()
        {
            bAdd = true;
            objControlService.init_GroupBox(gbPosi);
            objControlService.EnabledGroupBoxItem(gbPosi);
            this.txtXuLie.Text = "01";
            this.txtStartDate.Text = string.Format("{0:yyyy.MM.dd}", DateTime.Now);
            this.txtEndDate.Text = "9999.12.31";
        }

        private void tsbADD_Click(object sender, EventArgs e)
        {
            if (nTreeViewId >= 1000 && nTreeViewId < 10000)
            {
                AddPosi();
            }
            else
            {
                MessageBox.Show("请选择岗位所属机构！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tsbModify_Click(object sender, EventArgs e)
        {
            if (nTreeViewId >= 60000000 && nTreeViewId < 70000000)
            {
                bModify = true;
                objControlService.EnabledGroupBoxItem(gbPosi);
            }
            else
            {
                MessageBox.Show("请选择要修改的岗位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (bAdd == true)//新增数据
            {
                #region 数据验证

                #endregion

                #region 封装对象
                GangWei objGangWei = new GangWei()
                {
                    职位名称 = this.txtFullName.Text.Trim(),
                    职位简称 = this.txtShortName.Text.Trim(),
                    开始日期 = Convert.ToDateTime(this.txtStartDate.Text.Trim()),
                    结束日期 = Convert.ToDateTime(this.txtEndDate.Text.Trim()),
                    岗位性质 = this.cmbPosiQuality.SelectedValue.ToString(),
                    岗位序列 = this.txtXuLie.Text.Trim(),
                    岗级 = this.cmbGangJi.Text.Trim(),
                    是否特殊岗位 = this.ckbIsTeShu.Checked,
                    是否关键岗位 = this.ckbIsGuanJian.Checked,
                    是否运行岗位 = this.ckbIsYunXing.Checked,
                    是否虚拟岗位 = this.ckbIsXuni.Checked,
                    备注 = this.txtBeiZhu.Text.Trim(),
                    ParentID = nTreeViewId,
                    排序 = -1,
                    更改者 = Program.currentAdmin.username,
                    更改日期 = DateTime.Now
                };
                #endregion

                #region 调用后台数据访问对象添加数据
                try
                {
                    if (objGangWeiService.AddGangWei(objGangWei) == 1)
                    {
                        DialogResult result = MessageBox.Show("添加成功，是否继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            AddPosi();
                            LoadPosiList();//重新载入TreeView
                            listView1.Items.Clear();//清空ListView
                            objGangWeiService.GetGangWeiListView(listView1, DateTime.Now, nTreeViewId);//重新转入ListView
                        }
                        else
                        {
                            bAdd = false;
                            LoadPosiList();//重新载入TreeView
                            listView1.Items.Clear();//清空ListView
                            objControlService.init_GroupBox(gbPosi);//清空GroupBox
                            objGangWeiService.GetGangWeiListView(listView1, DateTime.Now, nTreeViewId);//重新转入ListView
                            objControlService.DisabledGroupBoxItem(gbPosi);//控件不可编辑
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
                GangWei objGangWei = new GangWei()
                {
                    职位编码 = nTreeViewId,
                    职位名称 = this.txtFullName.Text.Trim(),
                    职位简称 = this.txtShortName.Text.Trim(),
                    开始日期 = Convert.ToDateTime(this.txtStartDate.Text.Trim()),
                    结束日期 = Convert.ToDateTime(this.txtEndDate.Text.Trim()),
                    岗位性质 = this.cmbPosiQuality.SelectedValue.ToString(),
                    岗位序列 = this.txtXuLie.Text.Trim(),
                    岗级 = this.cmbGangJi.Text.Trim(),
                    是否特殊岗位 = this.ckbIsTeShu.Checked,
                    是否关键岗位 = this.ckbIsGuanJian.Checked,
                    是否运行岗位 = this.ckbIsYunXing.Checked,
                    是否虚拟岗位 = this.ckbIsXuni.Checked,
                    备注 = this.txtBeiZhu.Text.Trim(),
                    //ParentID = objGangWeiService.GetParentId(nTreeViewId),
                    ParentID = Convert.ToInt32(this.txtParentDept.Text.Trim()),
                    排序 = objGangWeiService.GetPosiSortID(nTreeViewId),
                    更改者 = Program.currentAdmin.username,
                    更改日期 = DateTime.Now

                };
                #endregion

                #region 调用后台数据访问对象修改数据
                try
                {
                    if (objGangWeiService.ModifyGangWeiByGangWeiID(objGangWei) == 1)
                    {
                        LoadPosiList();
                        objControlService.init_GroupBox(gbPosi);
                        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;//返回修改成功的信息
                        objControlService.DisabledGroupBoxItem(gbPosi);
                        bModify = false;
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
        private void tsbDingJie_Click(object sender, EventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {

            if (nTreeViewId >= 60000000 && nTreeViewId < 70000000)
            {

                DialogResult result = MessageBox.Show("确定要删除当前岗位吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel) return;
                //获取机构编号并删除
                try
                {
                    if (objGangWeiService.DeleteGangWeiByGangWeiID(nTreeViewId) == 1)
                    {
                        LoadPosiList();
                        objControlService.init_GroupBox(gbPosi);
                        MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;//返回修改成功的信息
                        objControlService.DisabledGroupBoxItem(gbPosi);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示");
                    throw;
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的岗位！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #endregion

        #region 排序相关

        private void btnMoveTop_Click(object sender, EventArgs e)
        {
            objMoveItemService.MoveListItemX(listView1, -2);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            objMoveItemService.MoveListItemX(listView1, -1);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            objMoveItemService.MoveListItemX(listView1, 1);
        }

        private void btnMoveBott_Click(object sender, EventArgs e)
        {
            objMoveItemService.MoveListItemX(listView1, 2);
        }

        private void btnMoveSave_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                objMoveItemService.ModifySortID("org_Posi", "排序", lvi.Index, "职位编码", lvi.Text);
            }
            LoadPosiList();//重新载入TreeView
            listView1.Items.Clear();//清空ListView
            objControlService.init_GroupBox(gbPosi);//清空GroupBox
            objGangWeiService.GetGangWeiListView(listView1, DateTime.Now, nTreeViewId);//重新转入ListView
            objControlService.DisabledGroupBoxItem(gbPosi);//控件不可编辑
        }


        #endregion


    }
}
