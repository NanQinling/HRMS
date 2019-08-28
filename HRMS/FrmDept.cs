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
            this.cmbJiGouLevel.DisplayMember = "机构层级";
            this.cmbJiGouLevel.ValueMember = "DT";
            this.cmbJiGouLevel.SelectedIndex = -1;

            //初始化treeview
            LoadDeptList();

        }

        int id = 0;      //删除时使用
        int maxDeptID = 0;       //创建新机构时使用
        int currentParentID = 0;     //创建同级机构时使用
        int maxParentSortID = 0;     //创建同级机构时使用
        int currentDeptID = 0;       //创建下级机构时使用
        int maxChildSortID = 0;      //创建下级机构时使用
        bool bAdd = false;      //点保存时使用


        private JiGouService objJiGouService = new JiGouService();
        private List<JiGou> nodeList = null;


        /// <summary>
        /// 清空当前文本框
        /// </summary>
        private void init_gbDept()
        {
            foreach (Control item in this.gbDept.Controls)
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

        private void LoadDeptList()
        {
            this.nodeList = objJiGouService.GetAllJiGou(DateTime.Now);//加载所有的菜单节点信息

            //创建一个根节点：
            this.tvDeptList.Nodes.Clear();//清空所有的节点
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "华能陕西渭南热电有限公司";
            rootNode.Tag = "0";//默认值,实际开发中可以根据需要设置
            //rootNode.ImageIndex = 0;//设置根节点显示的图片
            this.tvDeptList.Nodes.Add(rootNode);//将根节点添加到treeview根节点


            //基于递归方式添加所有子节点
            CreateChildNode(rootNode, 0);
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

        private void TvDeptList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level >= 1)
            {
                #region 点选表格中的一行时，把内容送到编辑区

                id = Convert.ToInt32(e.Node.Tag.ToString());//查询、删除时使用

                JiGou objJiGou = objJiGouService.GetJiGouByJiGouID(DateTime.Now, id); //查询创建对象
                this.txtJiGouID.Text = objJiGou.机构编号.ToString();
                this.cmbJiGouLevel.Text = objJiGou.机构层级.ToString();
                this.txtJiGouFullName.Text = objJiGou.机构名称.ToString();
                this.txtJiGouShortName.Text = objJiGou.机构简称.ToString();
                this.txtParentID.Text = objJiGou.ParentID.ToString();
                this.txtBeiZhu.Text = objJiGou.备注.ToString();
                this.txtStartDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objJiGou.开始日期.ToString()));
                this.txtEndDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objJiGou.结束日期.ToString()));
                this.txtSort.Text = objJiGou.排序.ToString();

                //给当前机构编号最大值赋值
                maxDeptID = objJiGouService.GetMaxDeptID();
                //给新设同级机构编号赋值
                currentParentID = Convert.ToInt32(objJiGou.ParentID.ToString());
                maxParentSortID = Convert.ToInt32(objJiGouService.GetMaxSortID(objJiGou.ParentID));
                //给新设下级机构编号赋值
                currentDeptID = Convert.ToInt32(objJiGou.机构编号.ToString());
                maxChildSortID = Convert.ToInt32(objJiGouService.GetMaxSortID(objJiGou.机构编号));
                //点保存时使用
                bAdd = false;

                #endregion
            }
            else
            {
                init_gbDept();
            }

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbADDParent_Click(object sender, EventArgs e)
        {
            init_gbDept();
            maxDeptID += 1;
            this.txtJiGouID.Text = maxDeptID.ToString();
            maxParentSortID += 1;
            this.txtSort.Text = maxParentSortID.ToString();
            this.txtParentID.Text = currentParentID.ToString();
            this.txtStartDate.Text = string.Format("{0:yyyy.MM.dd}", DateTime.Now);
            this.txtEndDate.Text = "9999.12.31";
            bAdd = true;
        }

        private void tsbADDChild_Click(object sender, EventArgs e)
        {
            init_gbDept();
            maxDeptID += 1;
            this.txtJiGouID.Text = maxDeptID.ToString();
            maxChildSortID += 1;
            this.txtSort.Text = maxChildSortID.ToString();
            this.txtParentID.Text = currentDeptID.ToString();
            this.txtStartDate.Text = string.Format("{0:yyyy.MM.dd}", DateTime.Now);
            this.txtEndDate.Text = "9999.12.31";
            bAdd = true;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (bAdd == true)//新增数据
            {
                #region 数据验证

                #endregion

                #region 封装对象
                JiGou objJiGou = new JiGou()
                {
                    机构编号 = Convert.ToInt32(this.txtJiGouID.Text),
                    内设机构层级 = this.cmbJiGouLevel.SelectedValue.ToString(),
                    机构名称 = this.txtJiGouFullName.Text.Trim(),
                    机构简称 = this.txtJiGouShortName.Text.Trim(),
                    ParentID = Convert.ToInt32(this.txtParentID.Text),
                    开始日期 = Convert.ToDateTime(this.txtStartDate.Text.Trim()),
                    结束日期 = Convert.ToDateTime(this.txtEndDate.Text.Trim()),
                    排序 = Convert.ToInt32(this.txtSort.Text.Trim()),
                    备注 = this.txtBeiZhu.Text.Trim(),
                    更改者 = Program.currentAdmin.username,
                    更改日期 = DateTime.Now
                };
                #endregion

                #region 数据验证
                try
                {
                    if (objJiGouService.AddJiGou(objJiGou) == 1)
                    {
                        DialogResult result = MessageBox.Show("添加成功，是否继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            maxDeptID += 1;
                            this.txtJiGouID.Text = maxDeptID.ToString();
                            this.txtJiGouFullName.Focus();
                        }
                        else
                        {
                            bAdd = false;
                        }
                        LoadDeptList();
                        init_gbDept();//清空用户的输入 
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
            else//修改数据
            {
                #region 数据验证

                #endregion

                #region 封装对象
                JiGou objJiGou = new JiGou()
                {
                    机构编号 = Convert.ToInt32(this.txtJiGouID.Text.Trim()),
                    内设机构层级 = this.cmbJiGouLevel.SelectedValue.ToString(),
                    机构名称 = this.txtJiGouFullName.Text.Trim(),
                    机构简称 = this.txtJiGouShortName.Text.Trim(),
                    ParentID = Convert.ToInt32(this.txtParentID.Text),
                    开始日期 = Convert.ToDateTime(this.txtStartDate.Text.Trim()),
                    结束日期 = Convert.ToDateTime(this.txtEndDate.Text.Trim()),
                    排序 = Convert.ToInt32(this.txtSort.Text.Trim()),
                    备注 = this.txtBeiZhu.Text.Trim(),
                    更改者 = Program.currentAdmin.username,
                    更改日期 = DateTime.Now
                };
                #endregion

                #region 调用后台数据访问对象添加数据
                try
                {
                    if (objJiGouService.ModifyJiGouByJiGouID(objJiGou) == 1)
                    {
                        LoadDeptList();
                        init_gbDept();//清空用户的输入 
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

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            //if (this.dgvJiGou.RowCount == 0)
            //{
            //    MessageBox.Show("没有任何要删除的信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (this.dgvJiGou.CurrentRow == null)
            //{
            //    MessageBox.Show("请选择要删除的内设机构信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            DialogResult result = MessageBox.Show("确定要删除当前内设机构吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取机构编号并删除
            try
            {
                if (objJiGouService.DeleteJiGouByJiGouID(id) == 1)
                {
                    LoadDeptList();
                    init_gbDept();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
                throw;
            }

        }



        private void TsbMoveUp_Click(object sender, EventArgs e)
        {
            #region 上移
            //if (null == tvDeptList.SelectedNode)
            //{

            //    return;

            //}

            //TreeNode node = tvDeptList.SelectedNode;

            //TreeNode prevNode = node.PrevNode;

            //if (null != prevNode)
            //{

            //    TreeNode newNode = (TreeNode)node.Clone();

            //    if (null == node.Parent)
            //    {

            //        tvDeptList.Nodes.Insert(prevNode.Index, newNode);

            //    }
            //    else
            //    {

            //        node.Parent.Nodes.Insert(prevNode.Index, newNode);

            //    }

            //    node.Remove();

            //    tvDeptList.SelectedNode = newNode;

            //}
            #endregion

            //1、获取当前行数据排序编号



        }

        private void TsbMoveDown_Click(object sender, EventArgs e)
        {
            #region 下移
            //if (null == tvDeptList.SelectedNode)
            //{

            //    return;

            //}

            //TreeNode node = tvDeptList.SelectedNode;

            //TreeNode nextNode = node.NextNode;

            //if (null != nextNode)
            //{

            //    TreeNode newNode = (TreeNode)node.Clone();

            //    if (null == node.Parent)
            //    {

            //        tvDeptList.Nodes.Insert(nextNode.Index + 1, newNode);

            //    }
            //    else
            //    {

            //        node.Parent.Nodes.Insert(nextNode.Index + 1, newNode);

            //    }

            //    node.Remove();

            //    tvDeptList.SelectedNode = newNode;

            //}
            #endregion

        }






    }
}
