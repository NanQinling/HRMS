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

        public FrmAuthority()
        {
            InitializeComponent();

            //初始化treeview
            LoadDeptList();
        }

        private AdminService objAdminService = new AdminService();
        private List<Admin> nodeList = null;


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
            this.nodeList = objAdminService.GetAllAdmin(DateTime.Now);//加载所有的菜单节点信息

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
                node.Text = item.username;
                node.Tag = item.userid;

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
                CreateChildNode(node, Convert.ToInt32(item.userid));
            }

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tvDeptList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level >= 1)
            {
                #region 点选表格中的一行时，把内容送到编辑区

                int id = Convert.ToInt32(e.Node.Tag.ToString());//查询、删除时使用

                Admin objAdmin = objAdminService.GetAdminByID(id); //查询创建对象
                //this.txtJiGouID.Text = objJiGou.机构编号.ToString();
                //this.cmbJiGouLevel.Text = objJiGou.机构层级.ToString();
                //this.txtJiGouFullName.Text = objJiGou.机构名称.ToString();
                //this.txtJiGouShortName.Text = objJiGou.机构简称.ToString();
                //this.txtParentID.Text = objJiGou.ParentID.ToString();
                //this.txtBeiZhu.Text = objJiGou.备注.ToString();
                //this.txtStartDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objJiGou.开始日期.ToString()));
                //this.txtEndDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objJiGou.结束日期.ToString()));
                //this.txtSort.Text = objJiGou.排序.ToString();

                ////给当前机构编号最大值赋值
                //maxDeptID = objJiGouService.GetMaxDeptID();
                ////给新设同级机构编号赋值
                //currentParentID = Convert.ToInt32(objJiGou.ParentID.ToString());
                //maxParentSortID = Convert.ToInt32(objJiGouService.GetMaxSortID(objJiGou.ParentID));
                ////给新设下级机构编号赋值
                //currentDeptID = Convert.ToInt32(objJiGou.机构编号.ToString());
                //maxChildSortID = Convert.ToInt32(objJiGouService.GetMaxSortID(objJiGou.机构编号));
                ////点保存时使用
                //bAdd = false;

                #endregion
            }
            else
            {
                init_gbDept();
            }
        }
    }
}
