using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAL
{
    public class ControlService
    {

        /// <summary>
        /// 根据datatable获得列名
        /// </summary>
        /// <param name="dt">表对象</param>
        /// <returns>返回结果的数据列数组</returns>
        public string[] GetColumnsByDataTable(DataTable dt)
        {
            string[] strColumns = null;

            if (dt.Columns.Count > 0)
            {
                int columnNum = 0;
                columnNum = dt.Columns.Count;
                strColumns = new string[columnNum];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    strColumns[i] = dt.Columns[i].ColumnName;
                }
            }
            return strColumns;
        }

        /// <summary>
        /// 初始化ListView
        /// </summary>
        public void LoadListView(ListView listView1)
        {
            //先清空ListView
            //listView1.Items.Clear();

            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            //listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            //listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            //listView1.Sorting = SortOrder.Ascending;
        }


        /// <summary>
        /// 清空GroupBox控件
        /// </summary>
        /// <param name="groupBox"></param>
        public void init_GroupBox(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
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



        public void DisabledGroupBoxItem(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                item.Enabled = false;
            }
        }


        public void EnabledGroupBoxItem(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                item.Enabled = true;
            }
        }


        /// <summary>
        /// 清空tabPage控件
        /// </summary>
        /// <param name="tabPage"></param>
        public void init_tabPage(TabPage tabPage)
        {
            foreach (Control item in tabPage.Controls)
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


        public void DisabledTabPageItem(TabPage tabPage)
        {
            foreach (Control item in tabPage.Controls)
            {
                item.Enabled = false;
            }
        }


        public void EnabledTabPageItem(TabPage tabPage)
        {
            foreach (Control item in tabPage.Controls)
            {
                item.Enabled = true;
            }
        }



    }
}
