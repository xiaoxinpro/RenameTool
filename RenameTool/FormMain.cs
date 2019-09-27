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
        }

        #endregion

    }
}
