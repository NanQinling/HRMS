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
    public delegate void DelTest(int intPosiNum, string strPosiName, string strSuoShuErJiJiGou, string strSuoShuSanJiJiGou, string strGangWeiXingZhi);


    public partial class FrmSelectPosi : Form
    {
        private DelTest _del;

        public FrmSelectPosi(DelTest del)
        {
            this._del = del;
            InitializeComponent();

            LoadPosiList();

        }




        int intPosiNum = 0;
        string strPosiName = string.Empty;


        private GangWeiService objGangWeiService = new GangWeiService();
        private List<GangWei> nodeList = null;







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

            if (e.Node.Level == 0)
            {
                return;
            }
            else
            {
                //如果选中的是机构，则查看该机构下所有的岗位，并将其显示在ListView中
                //if (Convert.ToInt32(e.Node.Tag.ToString()) >= 50000000 && Convert.ToInt32(e.Node.Tag.ToString()) < 60000000)
                if (Convert.ToInt32(e.Node.Tag.ToString()) >= 1000 && Convert.ToInt32(e.Node.Tag.ToString()) < 10000)
                {
                    return;
                }
                //如果选中的是岗位，则查看该岗位并将其显示在GroupBox中
                if (Convert.ToInt32(e.Node.Tag.ToString()) >= 60000000 && Convert.ToInt32(e.Node.Tag.ToString()) < 70000000)
                {
                    intPosiNum = Convert.ToInt32(e.Node.Tag.ToString());
                    strPosiName = e.Node.Text;
                }
            }


        }




        #endregion


        private void tvPosiList_DoubleClick(object sender, EventArgs e)
        {
            if (intPosiNum >= 60000000 && intPosiNum < 70000000)
            {
                GangWei objGangWei = objGangWeiService.GetGangWeiByGangWeiID(DateTime.Now, intPosiNum);

                string strSuoShuErJiJiGou = objGangWei.所属二级机构;
                string strSuoShuSanJiJiGou = objGangWei.所属三级机构;
                string strGangWeiXingZhi = objGangWei.岗位性质长文本;

                this._del(intPosiNum, strPosiName, strSuoShuErJiJiGou, strSuoShuSanJiJiGou, strGangWeiXingZhi);


                this.Close();

            }
        }
    }
}
