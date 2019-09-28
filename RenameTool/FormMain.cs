using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            listView.HeaderStyle = ColumnHeaderStyle.Clickable;
            listView.View = View.Details;

            //创建列表头
            listView.Columns.Add("状态", 40, HorizontalAlignment.Left);
            listView.Columns.Add("原文件名", 80, HorizontalAlignment.Left);
            listView.Columns.Add("新文件名", 80, HorizontalAlignment.Left);
            listView.Columns.Add("原扩展名", 65, HorizontalAlignment.Left);
            listView.Columns.Add("新扩展名", 65, HorizontalAlignment.Left);
            listView.Columns.Add("文件路径", 100, HorizontalAlignment.Left);

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

        /// <summary>
        /// 添加文件列表
        /// </summary>
        /// <param name="listView">文件列表控件</param>
        /// <param name="strPath">路径或路径数组</param>
        private void AddListViewFile(ListView listView, params string[] strPath)
        {
            listView.BeginUpdate();
            foreach (string item in strPath)
            {
                if (IndexOfSubitemListView(listView,5,item) >= 0)
                {
                    continue;
                }
                string fileName = Path.GetFileNameWithoutExtension(item);
                string fileExt = Path.GetExtension(item);
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = listView.Items.Count.ToString();
                listViewItem.SubItems.Add(fileName);
                listViewItem.SubItems.Add(fileName);
                listViewItem.SubItems.Add(fileExt);
                listViewItem.SubItems.Add(fileExt);
                listViewItem.SubItems.Add(item);
                listView.Items.Add(listViewItem);
            }
            listView.EndUpdate();
            InitComboFileFilter(comboFileFilter, listView);
            AutoResizeColumnWidth(listView);
        }

        /// <summary>
        /// 获取列表某一列的元素位置
        /// </summary>
        /// <param name="listView">列表控件</param>
        /// <param name="index">列号</param>
        /// <param name="data">元素字符串</param>
        /// <returns>返回行号，未找到返回-1</returns>
        private int IndexOfSubitemListView(ListView listView, int index, string data)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                try
                {
                    if (listView.Items[i].SubItems[index].Text == data)
                    {
                        return i;
                    } 
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return -1;
        }

        /// <summary>
        /// 自动调整列表中的列宽
        /// </summary>
        /// <param name="lv">列表控件</param>
        private void AutoResizeColumnWidth(ListView lv)
        {
            int count = lv.Columns.Count;
            int MaxWidth = 0;
            Graphics graphics = lv.CreateGraphics();
            Font font = lv.Font;
            ListView.ListViewItemCollection items = lv.Items;

            string str;
            int width;

            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            for (int i = 0; i < count; i++)
            {
                str = lv.Columns[i].Text;
                MaxWidth = lv.Columns[i].Width;

                foreach (ListViewItem item in items)
                {
                    str = item.SubItems[i].Text;
                    width = (int)graphics.MeasureString(str, font).Width;
                    if (width > MaxWidth)
                    {
                        MaxWidth = width;
                    }
                }
                lv.Columns[i].Width = MaxWidth;
            }
        }
        #endregion

        #region 列表窗体相关控件
        /// <summary>
        /// 导入文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "添加文件";
            ofd.Filter = "所有文件|*.*";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                AddListViewFile(listViewFile, ofd.FileNames);
            }
        }

        /// <summary>
        /// 将元素拖拽到列表上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 拖拽完成时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFile_DragDrop(object sender, DragEventArgs e)
        {
            ListView listView = (ListView)sender;
            string[] arrPath = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            bool isSubPath = chkSubPath.Checked;
            bool isHidden = chkHidden.Checked;
            Task.Run(() =>
            {
                List<string> listPath = new List<string>();
                foreach (string strPath in arrPath)
                {
                    if (File.Exists(strPath))
                    {
                        listPath.Add(strPath);
                    }
                    else if (Directory.Exists(strPath))
                    {
                        GetDirectoryAllFileToList(strPath, listPath, isSubPath, false, isHidden);
                    }
                }
                this.Invoke(new Action(() =>
                {
                    AddListViewFile(listView, listPath.ToArray());
                }));
            });
        }

        /// <summary>
        /// 获取文件夹内全部文件到List中
        /// </summary>
        /// <param name="strPath">文件夹路径</param>
        /// <param name="listPath">返回的List对象</param>
        /// <param name="isSubPath">是否包含子目录</param>
        /// <param name="isReadOnly">是否包含只读文件</param>
        /// <param name="isHidden">是否包含隐藏文件</param>
        private void GetDirectoryAllFileToList(string strPath, List<string> listPath, bool isSubPath = true, bool isReadOnly = false, bool isHidden = false)
        {
            if (Directory.Exists(strPath))
            {
                string[] arrPath = Directory.GetFiles(strPath);
                foreach (string item in arrPath)
                {
                    FileInfo fi = new FileInfo(item);
                    if (!isReadOnly && (fi.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    {
                        continue;
                    }
                    if (!isHidden && (fi.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    {
                        continue;
                    }
                    listPath.Add(item);
                }
                if (isSubPath)
                {
                    arrPath = Directory.GetFiles(strPath);
                    foreach (string item in arrPath)
                    {
                        DirectoryInfo di = new DirectoryInfo(item);
                        if (!isHidden && (di.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                        {
                            continue;
                        }
                        GetDirectoryAllFileToList(item, listPath, isSubPath, isReadOnly, isHidden);
                    }
                }
            }
        }

        #endregion
    }
}
