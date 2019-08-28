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

        int id = 0;
        bool bAdd = false;      //点保存时使用



        private AdminService objAdminService = new AdminService();
        private JiGouService objJiGouService = new JiGouService();
        private List<Admin> nodeList = null;


        /// <summary>
        /// 清空当前文本框
        /// </summary>
        private void init_groupBox()
        {
            foreach (Control item in this.groupBox.Controls)
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
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;//不选择
                }
            }
        }

        //所有控件不可编辑
        private void item_disabled()
        {
            foreach (Control item in this.groupBox.Controls)
            {
                item.Enabled = false;
            }
        }

        //所有控件可编辑
        private void item_able()
        {
            foreach (Control item in this.groupBox.Controls)
            {
                item.Enabled = true;
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
            this.tvDeptList.ExpandAll();
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
                node.Tag = item.id;

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
            if (e.Node.Level == 1)
            {
                init_groupBox();

                int deptid = Convert.ToInt32(e.Node.Tag.ToString());//查询、删除时使用
                JiGou objJiGou = objJiGouService.GetJiGouByJiGouID(DateTime.Now, deptid); //查询创建对象
                this.txtDeptId.Text = objJiGou.机构编号.ToString();
                this.txtDept.Text = objJiGou.机构简称.ToString();
                item_disabled();



            }
            else if (e.Node.Level == 2)
            {
                #region 点选表格中的一行时，把内容送到编辑区

                id = Convert.ToInt32(e.Node.Tag.ToString());//查询、删除时使用

                Admin objAdmin = objAdminService.GetAdminByID(DateTime.Now, id); //查询创建对象
                this.txtDeptId.Text = objAdmin.deptid.ToString();
                this.txtDept.Text = objAdmin.dept.ToString();
                this.txtUserId.Text = objAdmin.userid.ToString();
                this.txtUserName.Text = objAdmin.username.ToString();
                this.ckbAttendance.Checked = objAdmin.Attendance;
                this.ckbOvertime.Checked = objAdmin.Overtime;
                this.ckbEvaluation.Checked = objAdmin.Evaluation;
                this.ckbAssessment.Checked = objAdmin.Assessment;
                this.txtBeiZhu.Text = objAdmin.备注.ToString();
                this.txtStartDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objAdmin.开始日期.ToString()));
                this.txtEndDate.Text = string.Format("{0:yyyy.MM.dd}", Convert.ToDateTime(objAdmin.结束日期.ToString()));

                item_able();
                this.txtDeptId.Enabled = false;
                this.txtDept.Enabled = false;

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
                init_groupBox();
                item_disabled();
            }
        }

        private void tsbADD_Click(object sender, EventArgs e)
        {
            item_able();
            this.txtDeptId.Enabled = false;
            this.txtDept.Enabled = false;
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
                Admin objAdmin = new Admin()
                {
                    deptid = Convert.ToInt32(this.txtDeptId.Text.Trim()),
                    dept = this.txtDept.Text.Trim(),
                    userid = this.txtUserId.Text.Trim(),
                    username = this.txtUserName.Text.Trim(),
                    pwd = "SAP123",
                    Attendance = this.ckbAttendance.Checked ? true : false,
                    Overtime = this.ckbOvertime.Checked ? true : false,
                    Evaluation = this.ckbEvaluation.Checked ? true : false,
                    Assessment = this.ckbAssessment.Checked ? true : false,
                    开始日期 = Convert.ToDateTime(this.txtStartDate.Text.Trim()),
                    结束日期 = Convert.ToDateTime(this.txtEndDate.Text.Trim()),
                    备注 = this.txtBeiZhu.Text.Trim(),
                    更改者 = Program.currentAdmin.username,
                    更改日期 = DateTime.Now
                };
                #endregion

                #region 数据验证
                try
                {
                    if (objAdminService.AddAdmin(objAdmin) == 1)
                    {
                        DialogResult result = MessageBox.Show("添加成功，是否继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            //maxDeptID += 1;
                            //this.txtJiGouID.Text = maxDeptID.ToString();
                            //this.txtJiGouFullName.Focus();
                        }
                        else
                        {
                            bAdd = false;
                        }
                        LoadDeptList();
                        init_groupBox();//清空用户的输入 
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
                Admin objAdmin = new Admin()
                {
                    id = id,
                    deptid = Convert.ToInt32(this.txtDeptId.Text.Trim()),
                    dept = this.txtDept.Text.Trim(),
                    userid = this.txtUserId.Text.Trim(),
                    username = this.txtUserName.Text.Trim(),
                    Attendance = this.ckbAttendance.Checked ? true : false,
                    Overtime = this.ckbOvertime.Checked ? true : false,
                    Evaluation = this.ckbEvaluation.Checked ? true : false,
                    Assessment = this.ckbAssessment.Checked ? true : false,
                    开始日期 = Convert.ToDateTime(this.txtStartDate.Text.Trim()),
                    结束日期 = Convert.ToDateTime(this.txtEndDate.Text.Trim()),
                    备注 = this.txtBeiZhu.Text.Trim(),
                    更改者 = Program.currentAdmin.username,
                    更改日期 = DateTime.Now
                };
                #endregion

                #region 调用后台数据访问对象添加数据
                try
                {
                    if (objAdminService.ModifyAdminbyId(objAdmin) == 1)
                    {
                        LoadDeptList();
                        init_groupBox();//清空用户的输入 
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
                if (objAdminService.DeleteAdminByID(id) == 1)
                {
                    LoadDeptList();
                    init_groupBox();
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
