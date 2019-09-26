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
    public partial class FrmDept : Form
    {
        public FrmDept()
        {
            InitializeComponent();

            //初始化机构层级下拉框
            this.cmbJiGouLevel.DataSource = objJiGouService.GetAllDeptLevel();
            this.cmbJiGouLevel.DisplayMember = "机构类型长文本";
            this.cmbJiGouLevel.ValueMember = "DT";
            this.cmbJiGouLevel.SelectedIndex = -1;

            //初始化treeview
            LoadDeptList();
            objControlService.DisabledGroupBoxItem(gbDept);

        }


        private JiGouService objJiGouService = new DAL.JiGouService();
        private ControlService objControlService = new DAL.ControlService();
        private MoveItemService objMoveItemService = new DAL.MoveItemService();
        private List<JiGou> nodeList = null;

        int nTreeViewId = 0;      //删除时使用
        //int nListViewId = 0;
        int intParentId;

        bool bAdd = false;      //点保存时使用
        bool bModify = false;

        #region TreeView相关

        #region 使用递归的方式载入TreeView
        private void LoadDeptList()
        {
            this.nodeList = objJiGouService.GetJiGouListAll(DateTime.Now);//加载所有的菜单节点信息

            tvDeptList.BeginUpdate();
            //创建一个根节点：
            this.tvDeptList.Nodes.Clear();//清空所有的节点
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "华能陕西渭南热电有限公司";
            rootNode.Tag = "0";//默认值,实际开发中可以根据需要设置
            //rootNode.ImageIndex = 0;//设置根节点显示的图片
            this.tvDeptList.Nodes.Add(rootNode);//将根节点添加到treeview根节点


            //基于递归方式添加所有子节点
            CreateChildNode(rootNode, 0);
            tvDeptList.EndUpdate();
            this.tvDeptList.Nodes[0].Expand();//将递归树一级目录展开
            //this.tvDeptList.ExpandAll();
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
                node.Text = item.机构简称;
                node.Tag = item.机构编号;

                ////设置节点图标
                //if (item.ParentId == "0")
                //{
                //    node.ImageIndex = 1;
                //}
                //else
                //{
                //    node.ImageIndex = 3;
                //}

                parentNode.Nodes.Add(node);//父节点加入该子节点
                //调用递归实现子节点添加
                CreateChildNode(node, item.机构编号);
            }

        }
        #endregion

        /// <summary>
        /// 单击TreeView节点时获取当前节点的ID，用于后面查询该节点的信息及删除该节点。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TvDeptList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            objControlService.init_GroupBox(gbDept);
            listView1.Items.Clear();
            //nListViewId = 0;

            if (e.Node.Level == 0)
            {
                nTreeViewId = 0;
            }
            if (e.Node.Level >= 1)
            {
                nTreeViewId = Convert.ToInt32(e.Node.Tag.ToString());
                GetDeptGroupBox(nTreeViewId);
            }

            objControlService.DisabledGroupBoxItem(gbDept);
            objJiGouService.GetJiGouListView(listView1, DateTime.Now, nTreeViewId);

        }



        #endregion

        #region ListView相关

        /// <summary>
        /// 未选中ListView列表中的行的时候，清空GroupBox并且将id的值清零；选中行时，id值就为该行的text值。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count == 0)
            //{
            //    nListViewId = 0;
            //    objControlService.init_GroupBox(gbDept);
            //}
            //else
            //{
            //    ListViewItem lvi = listView1.SelectedItems[0];
            //    nListViewId = Convert.ToInt32(lvi.Text);
            //    GetDeptGroupBox(nListViewId);
            //}
        }

        #endregion

        #region GroupBox相关

        /// <summary>
        /// 根据节点的tag查询详细信息，并输出给GroupBox
        /// </summary>
        /// <param name="intDeptId"></param>
        private void GetDeptGroupBox(int intDeptId)
        {
            JiGou objJiGou = objJiGouService.GetJiGouByJiGouID(DateTime.Now, intDeptId); //查询创建对象
            this.cmbJiGouLevel.Text = objJiGou.机构类型长文本.ToString();
            this.txtJiGouFullName.Text = objJiGou.机构名称.ToString();
            this.txtJiGouShortName.Text = objJiGou.机构简称.ToString();
            this.txtChengLiRiQi.Text = objJiGou.成立日期.ToString();
            this.txtChengLiWenHao.Text = objJiGou.成立文号.ToString();
            this.ckbIsXuNiZuZhi.Checked = objJiGou.是否虚拟组织;
            this.ckbIsGuaKaoZuZhi.Checked = objJiGou.是否挂靠组织;
            this.txtBeiZhu.Text = objJiGou.备注.ToString();
            this.txtStartDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objJiGou.开始日期.ToString()));
            this.txtEndDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objJiGou.结束日期.ToString()));
        }



        #endregion

        #region 增删改相关

        /// <summary>
        /// 判断是添加同级还是下级机构，自动获取ParentId号。
        /// </summary>
        /// <param name="bIsTongJi">True：同级，False：下级</param>
        private void AddDept(bool bIsTongJi)
        {
            bAdd = true;
            objControlService.init_GroupBox(gbDept);
            objControlService.EnabledGroupBoxItem(gbDept);
            intParentId = objJiGouService.GetParentId(bIsTongJi, nTreeViewId);
            this.txtStartDate.Text = string.Format("{0:yyyy.MM.dd}", DateTime.Now);
            this.txtEndDate.Text = "9999.12.31";

            tsbModify.Enabled = false;
            tsbADDParent.Enabled = false;
            tsbADDChild.Enabled = false;
        }



        private void tsbADDParent_Click(object sender, EventArgs e)
        {
            AddDept(true);
        }

        private void tsbADDChild_Click(object sender, EventArgs e)
        {
            AddDept(false);
        }

        private void TsbModify_Click(object sender, EventArgs e)
        {
            bModify = true;
            objControlService.EnabledGroupBoxItem(gbDept);

            tsbModify.Enabled = false;
            tsbADDParent.Enabled = false;
            tsbADDChild.Enabled = false;

        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (bAdd == true)//新增数据
            {
                #region 数据验证
                if (this.txtJiGouFullName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入机构名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (this.txtJiGouShortName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入机构简称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (this.cmbJiGouLevel.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请选择机构层级！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (this.txtBeiZhu.Text.Trim().Length > 30)
                {
                    MessageBox.Show("备注内容不能超过30个字符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                #region 封装对象
                JiGou objJiGou = new JiGou()
                {
                    机构名称 = this.txtJiGouFullName.Text.Trim(),
                    机构简称 = this.txtJiGouShortName.Text.Trim(),
                    开始日期 = Convert.ToDateTime(this.txtStartDate.Text.Trim()),
                    结束日期 = Convert.ToDateTime(this.txtEndDate.Text.Trim()),
                    成立日期 = this.txtChengLiRiQi.Text.Trim(),
                    成立文号 = this.txtChengLiWenHao.Text.Trim(),
                    内设机构层级 = this.cmbJiGouLevel.SelectedValue.ToString(),
                    是否虚拟组织 = this.ckbIsXuNiZuZhi.Checked,
                    是否挂靠组织 = this.ckbIsGuaKaoZuZhi.Checked,
                    备注 = this.txtBeiZhu.Text.Trim(),
                    ParentID = intParentId,
                    排序 = -1,
                    更改者 = Program.currentAdmin.username,
                    更改日期 = DateTime.Now
                };
                #endregion

                #region 调用后台数据访问对象添加数据
                try
                {
                    if (objJiGouService.AddJiGou(objJiGou) == 1)
                    {
                        LoadDeptList();
                        objControlService.init_GroupBox(gbDept);
                        MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;//返回修改成功的信息
                        objControlService.DisabledGroupBoxItem(gbDept);
                        bAdd = false;

                        tsbModify.Enabled = true;
                        tsbADDParent.Enabled = true;
                        tsbADDChild.Enabled = true;

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
                if (this.txtJiGouFullName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入机构名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (this.txtJiGouShortName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请输入机构简称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (this.cmbJiGouLevel.Text.Trim().Length == 0)
                {
                    MessageBox.Show("请选择机构层级！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (this.txtBeiZhu.Text.Trim().Length > 30)
                {
                    MessageBox.Show("备注内容不能超过30个字符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                #region 封装对象
                JiGou objJiGou = new JiGou()
                {
                    机构编号 = nTreeViewId,
                    机构名称 = this.txtJiGouFullName.Text.Trim(),
                    机构简称 = this.txtJiGouShortName.Text.Trim(),
                    开始日期 = Convert.ToDateTime(this.txtStartDate.Text.Trim()),
                    结束日期 = Convert.ToDateTime(this.txtEndDate.Text.Trim()),
                    成立日期 = this.txtChengLiRiQi.Text.Trim(),
                    成立文号 = this.txtChengLiWenHao.Text.Trim(),
                    内设机构层级 = this.cmbJiGouLevel.SelectedValue.ToString(),
                    是否虚拟组织 = this.ckbIsXuNiZuZhi.Checked,
                    是否挂靠组织 = this.ckbIsGuaKaoZuZhi.Checked,
                    备注 = this.txtBeiZhu.Text.Trim(),
                    ParentID = objJiGouService.GetParentId(true, nTreeViewId),
                    排序 = objJiGouService.GetDeptSortID(nTreeViewId),
                    更改者 = Program.currentAdmin.username,
                    更改日期 = DateTime.Now
                };
                #endregion

                #region 调用后台数据访问对象修改数据
                try
                {
                    if (objJiGouService.ModifyJiGouByJiGouID(objJiGou) == 1)
                    {
                        LoadDeptList();
                        objControlService.init_GroupBox(gbDept);
                        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;//返回修改成功的信息
                        objControlService.DisabledGroupBoxItem(gbDept);
                        bModify = false;

                        tsbModify.Enabled = true;
                        tsbADDParent.Enabled = true;
                        tsbADDChild.Enabled = true;
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
        private void tspDingJie_Click(object sender, EventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (nTreeViewId == 0)
            {
                MessageBox.Show("没有任何要删除的内设机构信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("确定要删除当前内设机构吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取机构编号并删除
            try
            {
                if (objJiGouService.DeleteJiGouByJiGouID(nTreeViewId) == 1)
                {
                    LoadDeptList();
                    objControlService.init_GroupBox(gbDept);
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;//返回修改成功的信息
                    objControlService.DisabledGroupBoxItem(gbDept);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
                throw;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region 排序相关

        private void BtnMoveTop_Click(object sender, EventArgs e)
        {
            objMoveItemService.MoveListItemX(listView1, -2);
        }
        private void BtnMoveUp_Click(object sender, EventArgs e)
        {
            objMoveItemService.MoveListItemX(listView1, -1);
        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {
            objMoveItemService.MoveListItemX(listView1, 1);
        }

        private void BtnMoveBott_Click(object sender, EventArgs e)
        {
            objMoveItemService.MoveListItemX(listView1, 2);
        }

        private void BtnMoveSave_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                objMoveItemService.ModifySortID("org_dept", "排序", lvi.Index, "机构编号", lvi.Text);
            }
            LoadDeptList();//重新载入TreeView
            listView1.Items.Clear();//清空ListView
            objControlService.init_GroupBox(gbDept);//清空GroupBox
            objJiGouService.GetJiGouListView(listView1, DateTime.Now, nTreeViewId);//重新载入ListView
            objControlService.DisabledGroupBoxItem(gbDept);//控件不可编辑

        }






        #endregion


    }
}
