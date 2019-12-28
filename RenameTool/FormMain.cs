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
        #region 私有字段
        private FilePathSet objFilePathSet = new FilePathSet();
        #endregion

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

        /// <summary>
        /// 窗体获取焦点时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Activated(object sender, EventArgs e)
        {
            listViewFile.Focus();
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

            //创建表格拖动排序标识
            listView.ListViewItemSorter = new ListViewIndexComparer();
        }

        /// <summary>
        /// 初始化文件列表筛选下拉框
        /// </summary>
        /// <param name="comboBox">下拉框控件</param>
        /// <param name="listView">文件列表控件</param>
        private void InitComboFileFilter(ComboBox comboBox, FilePathSet filePathSet = null)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Clear();
            comboBox.Items.Add("全部");
            if (filePathSet != null && filePathSet.CountExt() > 0)
            {
                foreach (string strExt in filePathSet.GetExtension())
                {
                    if (comboBox.Items.IndexOf(strExt) < 0)
                    {
                        comboBox.Items.Add(strExt);
                    }
                }
            }
            comboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 添加文件路径
        /// </summary>
        /// <param name="listView">文件列表控件</param>
        /// <param name="strPath">路径或路径数组</param>
        private void AddFilePath(params string[] strPath)
        {
            objFilePathSet.Add(strPath);
            InitComboFileFilter(comboFileFilter, objFilePathSet);
            AutoResizeColumnWidth(listViewFile);
        }

        /// <summary>
        /// 更新文件列表
        /// </summary>
        /// <param name="listView">文件列表控件</param>
        /// <param name="arrPath">路径或路径数组</param>
        private void UpdataListViewFile(ListView listView, Dictionary<string, string> dictPath)
        {
            listView.Items.Clear();
            if (dictPath == null)
            {
                return;
            }
            listView.BeginUpdate();
            foreach (KeyValuePair<string,string> item in dictPath)
            {
                string fileName = Path.GetFileNameWithoutExtension(item.Key);
                string fileExt = Path.GetExtension(item.Key);
                string newFileName = Path.GetFileNameWithoutExtension(item.Value);
                string newFileExt = Path.GetExtension(item.Value);
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = "准备";
                listViewItem.SubItems.Add(fileName);
                listViewItem.SubItems.Add(newFileName);
                listViewItem.SubItems.Add(fileExt);
                listViewItem.SubItems.Add(newFileExt);
                listViewItem.SubItems.Add(item.Key);
                listView.Items.Add(listViewItem);
            }
            listView.EndUpdate();
            AutoResizeColumnWidth(listViewFile);
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
                AddFilePath(ofd.FileNames);
            }
        }

        /// <summary>
        /// 清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearFile_Click(object sender, EventArgs e)
        {
            if (comboFileFilter.SelectedIndex == 0)
            {
                objFilePathSet.Clear();
                InitComboFileFilter(comboFileFilter, objFilePathSet);
            }
            else
            {
                objFilePathSet.RemoveExt(comboFileFilter.SelectedItem.ToString());
                InitComboFileFilter(comboFileFilter, objFilePathSet);
            }
        }

        /// <summary>
        /// 点击列表表头事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFile_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                return;
            }
            ListView listView = (ListView)sender;
            if (listView.Columns[e.Column].Tag == null)
            {
                listView.Columns[e.Column].Tag = true;
            }
            listView.Columns[e.Column].Tag = !((bool)listView.Columns[e.Column].Tag);
            listView.ListViewItemSorter = new ListViewSort(e.Column, listView.Columns[e.Column].Tag);
            //指定排序器并传送列索引与升序降序关键字
            listView.Sort();//对列表进行自定义排序
        }

        /// <summary>
        /// 启动拖拽，设置拖拽的数据和效果。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFile_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ListView listView = (ListView)sender;
            if (listView.SelectedItems.Count > 0)
            {
                Dictionary<ListViewItem, int> itemsCopy = new Dictionary<ListViewItem, int>();
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    itemsCopy.Add(item, item.Index);
                }
                listView.DoDragDrop(itemsCopy, DragDropEffects.Move);
            }
        }

        /// <summary>
        /// 拖拽进入ListView，判断拖拽的数据格式，并设置拖拽的效果。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFile_DragEnter(object sender, DragEventArgs e)
        {
            string[] sts = e.Data.GetFormats();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else if (sts.Length > 0 && sts[0].IndexOf("System.Windows.Forms.ListViewItem") > 0)
            {
                e.Effect = e.AllowedEffect;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 拖动经过ListView时，设置拖动的效果，显示拖放位置线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFile_DragOver(object sender, DragEventArgs e)
        {
            string[] sts = e.Data.GetFormats();
            ListView listView = (ListView)sender;
            if (sts.Length > 0 && sts[0].IndexOf("System.Windows.Forms.ListViewItem") > 0)
            {
                // 获得鼠标坐标  
                Point point = listView.PointToClient(new Point(e.X, e.Y));
                // 返回离鼠标最近的项目的索引  
                int index = listView.InsertionMark.NearestIndex(point);
                // 确定光标不在拖拽项目上  
                if (index > -1)
                {
                    Rectangle itemBounds = listView.GetItemRect(index);
                    if (point.X > itemBounds.Left + (itemBounds.Width / 2))
                    {
                        listView.InsertionMark.AppearsAfterItem = true;
                    }
                    else
                    {
                        listView.InsertionMark.AppearsAfterItem = false;
                    }
                }
                listView.InsertionMark.Index = index;
            }
        }

        /// <summary>
        /// 拖拽释放时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] sts = e.Data.GetFormats();
            ListView listView = (ListView)sender;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
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
                        AddFilePath(listPath.ToArray());
                    }));
                });
            }
            else if(sts.Length > 0 && sts[0].IndexOf("System.Windows.Forms.ListViewItem") > 0)
            { 
                // 返回插入标记的索引值  
                int index = listView.InsertionMark.Index;
                // 如果插入标记不可见，则退出.  
                if (index == -1)
                {
                    return;
                }
                // 如果插入标记在项目的右面，使目标索引值加一  
                if (listView.InsertionMark.AppearsAfterItem)
                {
                    index++;
                }

                // 返回拖拽项  
                Dictionary<ListViewItem, int> items = (Dictionary<ListViewItem, int>)e.Data.GetData(typeof(Dictionary<ListViewItem, int>));
                if (items == null)
                {
                    return;
                }
                foreach (var item in items)
                {
                    //在目标索引位置插入一个拖拽项目的副本   
                    listView.Items.Insert(index, (ListViewItem)item.Key.Clone());
                    // 移除拖拽项目的原文件  
                    listView.Items.Remove(item.Key);
                    if (item.Value >= index) index++;
                }            
            }
        }

        /// <summary>
        /// 当鼠标离开ListView时，移除插入标记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFile_DragLeave(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            listView.InsertionMark.Index = -1;
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
                    arrPath = Directory.GetDirectories(strPath);
                    foreach (string item in arrPath)
                    {
                        DirectoryInfo di = new DirectoryInfo(item);
                        if (!isHidden && (di.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                        {
                            continue;
                        }
                        GetDirectoryAllFileToList(item, listPath, isSubPath, isReadOnly, isHidden);
                    }
                }
            }
        }

        /// <summary>
        /// 选择文件过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboFileFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> dictPath;
            ComboBox comboBox = (ComboBox)sender;
            ListView listView = listViewFile;
            if (comboBox.SelectedIndex == 0)
            {
                dictPath = objFilePathSet.GetDictPath();
            }
            else
            {
                dictPath = objFilePathSet.GetDictPath(comboBox.SelectedItem.ToString());
            }
            UpdataListViewFile(listView, dictPath);
        }

        #endregion

        #region 文件命名规则窗口控件
        /// <summary>
        /// 文本输入框改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtText_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (radioTextPrefix.Tag == textBox.Tag)
            {
                radioTextPrefix.Checked = true;
            }
            else if(radioTextMiddle.Tag == textBox.Tag)
            {
                radioTextMiddle.Checked = true;
            }
            else if (radioTextPostfix.Tag == textBox.Tag)
            {
                radioTextPostfix.Checked = true;
            }
        }

        /// <summary>
        /// 正则输入框改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRegex_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (radioRegexPrefix.Tag == textBox.Tag)
            {
                radioRegexPrefix.Checked = true;
            }
            else if (radioRegexMiddle.Tag == textBox.Tag)
            {
                radioRegexMiddle.Checked = true;
            }
            else if (radioRegexPostfix.Tag == textBox.Tag)
            {
                radioRegexPostfix.Checked = true;
            }
        }

        /// <summary>
        /// 序号输入框改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numNumber_ValueChanged(object sender, EventArgs e)
        {
            Control num = (Control)sender;
            if (radioNumberPrefix.Tag == num.Tag)
            {
                radioNumberPrefix.Checked = true;
            }
            else if (radioNumberMiddle.Tag == num.Tag)
            {
                radioNumberMiddle.Checked = true;
            }
            else if (radioNumberPostfix.Tag == num.Tag)
            {
                radioNumberPostfix.Checked = true;
            }
        }

        /// <summary>
        /// 修改扩展名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEditExt_TextChanged(object sender, EventArgs e)
        {
            chkEditExt.Checked = true;
        }

        /// <summary>
        /// 执行命名规则按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSiteName_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dictPath;
            if (listViewFile.SelectedItems.Count > 1)
            {
                dictPath = new Dictionary<string, string>();
                for (int i = 0; i < listViewFile.SelectedItems.Count; i++)
                {
                    dictPath.Add(listViewFile.SelectedItems[i].SubItems[5].Text, "");
                }
            }
            else
            {
                dictPath = new Dictionary<string, string>();
                for (int i = 0; i < listViewFile.Items.Count; i++)
                {
                    dictPath.Add(listViewFile.Items[i].SubItems[5].Text, "");
                }
            }
            FilePathRule.Clear();
            FilePathRule.Add(GetFilePathRule(groupBoxPrefix, out string strErrorPrefix));
            FilePathRule.Add(GetFilePathRule(groupBoxMiddle, out string strErrorMiddle));
            FilePathRule.Add(GetFilePathRule(groupBoxPostfix, out string strErrorPostfix));
            FilePathRule.ForceExtension(chkEditExt.Checked, txtEditExt.Text);
            if (strErrorPrefix != "OK")
            {
                MessageBox.Show(strErrorPrefix, "文件名前缀错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (strErrorMiddle != "OK")
            {
                MessageBox.Show(strErrorMiddle, "文件名中间错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (strErrorPostfix != "OK")
            {
                MessageBox.Show(strErrorPostfix, "文件名后缀错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (FilePathRule.RuleCount() <= 0)
            {
                MessageBox.Show("无使能任何命名规格，请先配置命名规则。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dictPath.Count == 0)
            {
                MessageBox.Show("目标文件目录为空，请先导入文件。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FilePathRule.Rename(dictPath);
            foreach (KeyValuePair<string, string> item in dictPath)
            {
                objFilePathSet.Edit(item.Key, item.Value);
            }
            UpdataListViewFile(listViewFile, dictPath);
        }

        /// <summary>
        /// 获取GroupBox中的规则到FilePathRule类中
        /// </summary>
        /// <param name="groupRule">GroupBox控件</param>
        /// <param name="err">错误提示</param>
        /// <returns></returns>
        private FilePathRule GetFilePathRule(GroupBox groupRule, out string err)
        {
            err = "OK";
            string ruleName = groupRule.Tag.ToString();
            RadioButton radioText = GetGroupControl(groupRule, "radioText") as RadioButton;
            RadioButton radioRegex = GetGroupControl(groupRule, "radioRegex") as RadioButton;
            RadioButton radioNumber = GetGroupControl(groupRule, "radioNumber") as RadioButton;
            if (radioText.Checked)
            {
                TextBox textBox = GetGroupControl(groupRule, "txtText") as TextBox;
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    err = "OK";
                    return null;
                }
                else if (textBox.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                {
                    err = "文件名存在非法字符。";
                    return null;
                }
                return new FilePathRuleText(ruleName, textBox.Text);
            }
            else if (radioRegex.Checked)
            {
                TextBox textBox = GetGroupControl(groupRule, "txtRegex") as TextBox;
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    err = "OK";
                    return null;
                }
                return new FilePathRuleRegex(ruleName, (GetGroupControl(groupRule, "txtRegex") as TextBox).Text);
            }
            else if (radioNumber.Checked)
            {
                return new FilePathRuleNumber(ruleName, (GetGroupControl(groupRule, "numStart") as NumericUpDown).Value, (GetGroupControl(groupRule, "numStep") as NumericUpDown).Value, (GetGroupControl(groupRule, "chkSamp") as CheckBox).Checked);
            }
            else
            {
                err = "OK";
                return null;
            }
        }

        /// <summary>
        /// 从GroupBox中获取指定名字开头的控件
        /// </summary>
        /// <param name="group">GroupBox控件</param>
        /// <param name="name">控件名字或控件名字的一部分</param>
        /// <returns></returns>
        private Control GetGroupControl(GroupBox group, string name)
        {
            foreach (Control item in group.Controls)
            {
                if (item.Name.IndexOf(name) >= 0)
                {
                    return item;
                }
            }
            return null;
        }

        #endregion

        #region 重命名逻辑
        /// <summary>
        /// 开始重命名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartRun_Click(object sender, EventArgs e)
        {
            comboFileFilter.SelectedIndex = 0;
            Dictionary<string, string> dictPath = objFilePathSet.GetDictPath();
            string[] arrOldPath = dictPath.Keys.ToArray();
            progressRename.Maximum = arrOldPath.Length;
            foreach (string strOldPath in arrOldPath)
            {
                FilePathRename.Run(strOldPath, dictPath[strOldPath], out string err);
                if (string.IsNullOrEmpty(err))
                {
                    SetListViewFileStatus(listViewFile, strOldPath, "完成");
                    objFilePathSet.RemovePath(strOldPath);
                }
                else
                {
                    SetListViewFileStatus(listViewFile, strOldPath, "失败");
                }
                progressRename.PerformStep();
            }
            progressRename.Value = progressRename.Maximum;
            MessageBox.Show(string.Format("重命名完成，成功{0}个，失败{1}个。", (arrOldPath.Length - objFilePathSet.CountPath()), objFilePathSet.CountPath()), "重命名完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressRename.Value = 0;
        }

        /// <summary>
        /// 设置列表状态
        /// </summary>
        /// <param name="listView">列表控件</param>
        /// <param name="path">文件路径</param>
        /// <param name="strStatus">状态字符串</param>
        private void SetListViewFileStatus(ListView listView, string path, string strStatus)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (path == item.SubItems[5].Text)
                {
                    item.Text = strStatus;
                    return;
                }
            }
        }


        #endregion


    }
}
