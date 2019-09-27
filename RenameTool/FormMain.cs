using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameTool
{
    public partial class FormMain : Form
    {
        #region 初始化相关
        /// <summary>
        /// 窗体构造函数
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载窗体函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text += @" V" + Application.ProductVersion.ToString();

            InitListViewFile(listViewFile);
            InitComboFileFilter(comboFileFilter);
        }

        #endregion

        #region 文件列表相关
        /// <summary>
        /// 初始化文件列表
        /// </summary>
        /// <param name="listView">文件列表控件</param>
        private void InitListViewFile(ListView listView)
        {
            //基本属性设置
            listView.Clear();
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.CheckBoxes = true;
            listView.HeaderStyle = ColumnHeaderStyle.Clickable;
            listView.View = View.Details;

            //创建列表头
            listView.Columns.Add("状态", 40, HorizontalAlignment.Left);
            listView.Columns.Add("原文件名", 80, HorizontalAlignment.Center);
            listView.Columns.Add("新文件名", 80, HorizontalAlignment.Center);
            listView.Columns.Add("原扩展名", 65, HorizontalAlignment.Center);
            listView.Columns.Add("新扩展名", 65, HorizontalAlignment.Center);
            listView.Columns.Add("文件路径", 100, HorizontalAlignment.Center);

            //自动列宽
            listView.Columns[5].Width = -2;//根据标题设置宽度
        }

        /// <summary>
        /// 初始化文件列表筛选下拉框
        /// </summary>
        /// <param name="comboBox">下拉框控件</param>
        /// <param name="listView">文件列表控件</param>
        private void InitComboFileFilter(ComboBox comboBox, ListView listView = null)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Clear();
            comboBox.Items.Add("全部");
            if (listView != null)
            {
                foreach (ListViewItem item in listView.Items)
                {
                    string strExt = item.SubItems[3].Text.Trim().ToLower();
                    if (comboBox.Items.IndexOf(strExt) < 0)
                    {
                        comboBox.Items.Add(strExt);
                    }
                }
            }
            comboBox.SelectedIndex = 0;
        }
        #endregion

    }
}
