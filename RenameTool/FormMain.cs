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
        }

        #endregion

        #region 文件列表相关
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
        #endregion

    }
}
