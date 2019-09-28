namespace RenameTool
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.btnSiteName = new System.Windows.Forms.Button();
            this.groupBoxPostfix = new System.Windows.Forms.GroupBox();
            this.chkSampPostfix = new System.Windows.Forms.CheckBox();
            this.numStepPostfix = new System.Windows.Forms.NumericUpDown();
            this.numStartPostfix = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRegexPostfix = new System.Windows.Forms.TextBox();
            this.txtTextPostfix = new System.Windows.Forms.TextBox();
            this.radioNumberPostfix = new System.Windows.Forms.RadioButton();
            this.radioRegexPostfix = new System.Windows.Forms.RadioButton();
            this.radioTextPostfix = new System.Windows.Forms.RadioButton();
            this.groupBoxMiddle = new System.Windows.Forms.GroupBox();
            this.chkSampMiddle = new System.Windows.Forms.CheckBox();
            this.numStepMiddle = new System.Windows.Forms.NumericUpDown();
            this.numStartMiddle = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegexMiddle = new System.Windows.Forms.TextBox();
            this.txtTextMiddle = new System.Windows.Forms.TextBox();
            this.radioNumberMiddle = new System.Windows.Forms.RadioButton();
            this.radioRegexMiddle = new System.Windows.Forms.RadioButton();
            this.radioTextMiddle = new System.Windows.Forms.RadioButton();
            this.groupBoxFileNamePrefix = new System.Windows.Forms.GroupBox();
            this.chkSampPrefix = new System.Windows.Forms.CheckBox();
            this.numStepPrefix = new System.Windows.Forms.NumericUpDown();
            this.numStartPrefix = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegexPrefix = new System.Windows.Forms.TextBox();
            this.txtTextPrefix = new System.Windows.Forms.TextBox();
            this.radioNumberPrefix = new System.Windows.Forms.RadioButton();
            this.radioRegexPrefix = new System.Windows.Forms.RadioButton();
            this.radioTextPrefix = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.chkSubPath = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.progressRename = new System.Windows.Forms.ProgressBar();
            this.btnStartRun = new System.Windows.Forms.Button();
            this.comboFileFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewFile = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBoxPostfix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStepPostfix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPostfix)).BeginInit();
            this.groupBoxMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStepMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMiddle)).BeginInit();
            this.groupBoxFileNamePrefix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStepPrefix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPrefix)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.btnSiteName);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxPostfix);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxMiddle);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxFileNamePrefix);
            this.splitContainerMain.Panel1.Controls.Add(this.textBox1);
            this.splitContainerMain.Panel1.Controls.Add(this.label8);
            this.splitContainerMain.Panel1MinSize = 180;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.chkHidden);
            this.splitContainerMain.Panel2.Controls.Add(this.chkSubPath);
            this.splitContainerMain.Panel2.Controls.Add(this.button1);
            this.splitContainerMain.Panel2.Controls.Add(this.btnAddFile);
            this.splitContainerMain.Panel2.Controls.Add(this.progressRename);
            this.splitContainerMain.Panel2.Controls.Add(this.btnStartRun);
            this.splitContainerMain.Panel2.Controls.Add(this.comboFileFilter);
            this.splitContainerMain.Panel2.Controls.Add(this.label1);
            this.splitContainerMain.Panel2.Controls.Add(this.listViewFile);
            this.splitContainerMain.Panel2MinSize = 320;
            this.splitContainerMain.Size = new System.Drawing.Size(684, 461);
            this.splitContainerMain.SplitterDistance = 200;
            this.splitContainerMain.TabIndex = 0;
            // 
            // btnSiteName
            // 
            this.btnSiteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiteName.Location = new System.Drawing.Point(12, 424);
            this.btnSiteName.Name = "btnSiteName";
            this.btnSiteName.Size = new System.Drawing.Size(179, 30);
            this.btnSiteName.TabIndex = 28;
            this.btnSiteName.Text = "执行命名规则";
            this.btnSiteName.UseVisualStyleBackColor = true;
            // 
            // groupBoxPostfix
            // 
            this.groupBoxPostfix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPostfix.Controls.Add(this.chkSampPostfix);
            this.groupBoxPostfix.Controls.Add(this.numStepPostfix);
            this.groupBoxPostfix.Controls.Add(this.numStartPostfix);
            this.groupBoxPostfix.Controls.Add(this.label6);
            this.groupBoxPostfix.Controls.Add(this.label7);
            this.groupBoxPostfix.Controls.Add(this.txtRegexPostfix);
            this.groupBoxPostfix.Controls.Add(this.txtTextPostfix);
            this.groupBoxPostfix.Controls.Add(this.radioNumberPostfix);
            this.groupBoxPostfix.Controls.Add(this.radioRegexPostfix);
            this.groupBoxPostfix.Controls.Add(this.radioTextPostfix);
            this.groupBoxPostfix.Location = new System.Drawing.Point(3, 262);
            this.groupBoxPostfix.Name = "groupBoxPostfix";
            this.groupBoxPostfix.Size = new System.Drawing.Size(194, 128);
            this.groupBoxPostfix.TabIndex = 0;
            this.groupBoxPostfix.TabStop = false;
            this.groupBoxPostfix.Text = "文件名后缀";
            // 
            // chkSampPostfix
            // 
            this.chkSampPostfix.AutoSize = true;
            this.chkSampPostfix.Location = new System.Drawing.Point(32, 101);
            this.chkSampPostfix.Name = "chkSampPostfix";
            this.chkSampPostfix.Size = new System.Drawing.Size(48, 16);
            this.chkSampPostfix.TabIndex = 25;
            this.chkSampPostfix.Tag = "Postfix";
            this.chkSampPostfix.Text = "等宽";
            this.chkSampPostfix.UseVisualStyleBackColor = true;
            // 
            // numStepPostfix
            // 
            this.numStepPostfix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numStepPostfix.Location = new System.Drawing.Point(119, 98);
            this.numStepPostfix.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numStepPostfix.Name = "numStepPostfix";
            this.numStepPostfix.Size = new System.Drawing.Size(69, 21);
            this.numStepPostfix.TabIndex = 26;
            this.numStepPostfix.Tag = "Postfix";
            this.numStepPostfix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStepPostfix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numStartPostfix
            // 
            this.numStartPostfix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numStartPostfix.Location = new System.Drawing.Point(119, 73);
            this.numStartPostfix.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numStartPostfix.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numStartPostfix.Name = "numStartPostfix";
            this.numStartPostfix.Size = new System.Drawing.Size(69, 21);
            this.numStartPostfix.TabIndex = 24;
            this.numStartPostfix.Tag = "Postfix";
            this.numStartPostfix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStartPostfix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Tag = "Postfix";
            this.label6.Text = "步长：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 2;
            this.label7.Tag = "Postfix";
            this.label7.Text = "起始：";
            // 
            // txtRegexPostfix
            // 
            this.txtRegexPostfix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegexPostfix.Location = new System.Drawing.Point(88, 46);
            this.txtRegexPostfix.Name = "txtRegexPostfix";
            this.txtRegexPostfix.Size = new System.Drawing.Size(100, 21);
            this.txtRegexPostfix.TabIndex = 22;
            this.txtRegexPostfix.Tag = "Postfix";
            // 
            // txtTextPostfix
            // 
            this.txtTextPostfix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextPostfix.Location = new System.Drawing.Point(88, 19);
            this.txtTextPostfix.Name = "txtTextPostfix";
            this.txtTextPostfix.Size = new System.Drawing.Size(100, 21);
            this.txtTextPostfix.TabIndex = 20;
            this.txtTextPostfix.Tag = "Postfix";
            // 
            // radioNumberPostfix
            // 
            this.radioNumberPostfix.AutoSize = true;
            this.radioNumberPostfix.Location = new System.Drawing.Point(9, 75);
            this.radioNumberPostfix.Name = "radioNumberPostfix";
            this.radioNumberPostfix.Size = new System.Drawing.Size(83, 16);
            this.radioNumberPostfix.TabIndex = 23;
            this.radioNumberPostfix.Tag = "Postfix";
            this.radioNumberPostfix.Text = "显示序号：";
            this.radioNumberPostfix.UseVisualStyleBackColor = true;
            // 
            // radioRegexPostfix
            // 
            this.radioRegexPostfix.AutoSize = true;
            this.radioRegexPostfix.Location = new System.Drawing.Point(9, 48);
            this.radioRegexPostfix.Name = "radioRegexPostfix";
            this.radioRegexPostfix.Size = new System.Drawing.Size(83, 16);
            this.radioRegexPostfix.TabIndex = 21;
            this.radioRegexPostfix.Tag = "Postfix";
            this.radioRegexPostfix.Text = "正则匹配：";
            this.radioRegexPostfix.UseVisualStyleBackColor = true;
            // 
            // radioTextPostfix
            // 
            this.radioTextPostfix.AutoSize = true;
            this.radioTextPostfix.Location = new System.Drawing.Point(9, 21);
            this.radioTextPostfix.Name = "radioTextPostfix";
            this.radioTextPostfix.Size = new System.Drawing.Size(83, 16);
            this.radioTextPostfix.TabIndex = 19;
            this.radioTextPostfix.Tag = "Postfix";
            this.radioTextPostfix.Text = "文本内容：";
            this.radioTextPostfix.UseVisualStyleBackColor = true;
            // 
            // groupBoxMiddle
            // 
            this.groupBoxMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMiddle.Controls.Add(this.chkSampMiddle);
            this.groupBoxMiddle.Controls.Add(this.numStepMiddle);
            this.groupBoxMiddle.Controls.Add(this.numStartMiddle);
            this.groupBoxMiddle.Controls.Add(this.label4);
            this.groupBoxMiddle.Controls.Add(this.label5);
            this.groupBoxMiddle.Controls.Add(this.txtRegexMiddle);
            this.groupBoxMiddle.Controls.Add(this.txtTextMiddle);
            this.groupBoxMiddle.Controls.Add(this.radioNumberMiddle);
            this.groupBoxMiddle.Controls.Add(this.radioRegexMiddle);
            this.groupBoxMiddle.Controls.Add(this.radioTextMiddle);
            this.groupBoxMiddle.Location = new System.Drawing.Point(3, 133);
            this.groupBoxMiddle.Name = "groupBoxMiddle";
            this.groupBoxMiddle.Size = new System.Drawing.Size(194, 128);
            this.groupBoxMiddle.TabIndex = 0;
            this.groupBoxMiddle.TabStop = false;
            this.groupBoxMiddle.Text = "文件名中间";
            // 
            // chkSampMiddle
            // 
            this.chkSampMiddle.AutoSize = true;
            this.chkSampMiddle.Location = new System.Drawing.Point(32, 101);
            this.chkSampMiddle.Name = "chkSampMiddle";
            this.chkSampMiddle.Size = new System.Drawing.Size(48, 16);
            this.chkSampMiddle.TabIndex = 17;
            this.chkSampMiddle.Tag = "Middle";
            this.chkSampMiddle.Text = "等宽";
            this.chkSampMiddle.UseVisualStyleBackColor = true;
            // 
            // numStepMiddle
            // 
            this.numStepMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numStepMiddle.Location = new System.Drawing.Point(119, 98);
            this.numStepMiddle.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numStepMiddle.Name = "numStepMiddle";
            this.numStepMiddle.Size = new System.Drawing.Size(69, 21);
            this.numStepMiddle.TabIndex = 18;
            this.numStepMiddle.Tag = "Middle";
            this.numStepMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStepMiddle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numStartMiddle
            // 
            this.numStartMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numStartMiddle.Location = new System.Drawing.Point(119, 73);
            this.numStartMiddle.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numStartMiddle.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numStartMiddle.Name = "numStartMiddle";
            this.numStartMiddle.Size = new System.Drawing.Size(69, 21);
            this.numStartMiddle.TabIndex = 16;
            this.numStartMiddle.Tag = "Middle";
            this.numStartMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStartMiddle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Tag = "Middle";
            this.label4.Text = "步长：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Tag = "Middle";
            this.label5.Text = "起始：";
            // 
            // txtRegexMiddle
            // 
            this.txtRegexMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegexMiddle.Location = new System.Drawing.Point(88, 46);
            this.txtRegexMiddle.Name = "txtRegexMiddle";
            this.txtRegexMiddle.Size = new System.Drawing.Size(100, 21);
            this.txtRegexMiddle.TabIndex = 14;
            this.txtRegexMiddle.Tag = "Middle";
            // 
            // txtTextMiddle
            // 
            this.txtTextMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextMiddle.Location = new System.Drawing.Point(88, 19);
            this.txtTextMiddle.Name = "txtTextMiddle";
            this.txtTextMiddle.Size = new System.Drawing.Size(100, 21);
            this.txtTextMiddle.TabIndex = 12;
            this.txtTextMiddle.Tag = "Middle";
            // 
            // radioNumberMiddle
            // 
            this.radioNumberMiddle.AutoSize = true;
            this.radioNumberMiddle.Location = new System.Drawing.Point(9, 75);
            this.radioNumberMiddle.Name = "radioNumberMiddle";
            this.radioNumberMiddle.Size = new System.Drawing.Size(83, 16);
            this.radioNumberMiddle.TabIndex = 15;
            this.radioNumberMiddle.Tag = "Middle";
            this.radioNumberMiddle.Text = "显示序号：";
            this.radioNumberMiddle.UseVisualStyleBackColor = true;
            // 
            // radioRegexMiddle
            // 
            this.radioRegexMiddle.AutoSize = true;
            this.radioRegexMiddle.Location = new System.Drawing.Point(9, 48);
            this.radioRegexMiddle.Name = "radioRegexMiddle";
            this.radioRegexMiddle.Size = new System.Drawing.Size(83, 16);
            this.radioRegexMiddle.TabIndex = 13;
            this.radioRegexMiddle.Tag = "Middle";
            this.radioRegexMiddle.Text = "正则匹配：";
            this.radioRegexMiddle.UseVisualStyleBackColor = true;
            // 
            // radioTextMiddle
            // 
            this.radioTextMiddle.AutoSize = true;
            this.radioTextMiddle.Location = new System.Drawing.Point(9, 21);
            this.radioTextMiddle.Name = "radioTextMiddle";
            this.radioTextMiddle.Size = new System.Drawing.Size(83, 16);
            this.radioTextMiddle.TabIndex = 11;
            this.radioTextMiddle.Tag = "Middle";
            this.radioTextMiddle.Text = "文本内容：";
            this.radioTextMiddle.UseVisualStyleBackColor = true;
            // 
            // groupBoxFileNamePrefix
            // 
            this.groupBoxFileNamePrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFileNamePrefix.Controls.Add(this.chkSampPrefix);
            this.groupBoxFileNamePrefix.Controls.Add(this.numStepPrefix);
            this.groupBoxFileNamePrefix.Controls.Add(this.numStartPrefix);
            this.groupBoxFileNamePrefix.Controls.Add(this.label3);
            this.groupBoxFileNamePrefix.Controls.Add(this.label2);
            this.groupBoxFileNamePrefix.Controls.Add(this.txtRegexPrefix);
            this.groupBoxFileNamePrefix.Controls.Add(this.txtTextPrefix);
            this.groupBoxFileNamePrefix.Controls.Add(this.radioNumberPrefix);
            this.groupBoxFileNamePrefix.Controls.Add(this.radioRegexPrefix);
            this.groupBoxFileNamePrefix.Controls.Add(this.radioTextPrefix);
            this.groupBoxFileNamePrefix.Location = new System.Drawing.Point(3, 4);
            this.groupBoxFileNamePrefix.Name = "groupBoxFileNamePrefix";
            this.groupBoxFileNamePrefix.Size = new System.Drawing.Size(194, 128);
            this.groupBoxFileNamePrefix.TabIndex = 0;
            this.groupBoxFileNamePrefix.TabStop = false;
            this.groupBoxFileNamePrefix.Text = "文件名前缀";
            // 
            // chkSampPrefix
            // 
            this.chkSampPrefix.AutoSize = true;
            this.chkSampPrefix.Location = new System.Drawing.Point(32, 101);
            this.chkSampPrefix.Name = "chkSampPrefix";
            this.chkSampPrefix.Size = new System.Drawing.Size(48, 16);
            this.chkSampPrefix.TabIndex = 9;
            this.chkSampPrefix.Tag = "Prefix";
            this.chkSampPrefix.Text = "等宽";
            this.chkSampPrefix.UseVisualStyleBackColor = true;
            // 
            // numStepPrefix
            // 
            this.numStepPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numStepPrefix.Location = new System.Drawing.Point(119, 98);
            this.numStepPrefix.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numStepPrefix.Name = "numStepPrefix";
            this.numStepPrefix.Size = new System.Drawing.Size(69, 21);
            this.numStepPrefix.TabIndex = 10;
            this.numStepPrefix.Tag = "Prefix";
            this.numStepPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStepPrefix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numStartPrefix
            // 
            this.numStartPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numStartPrefix.Location = new System.Drawing.Point(119, 73);
            this.numStartPrefix.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numStartPrefix.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numStartPrefix.Name = "numStartPrefix";
            this.numStartPrefix.Size = new System.Drawing.Size(69, 21);
            this.numStartPrefix.TabIndex = 8;
            this.numStartPrefix.Tag = "Prefix";
            this.numStartPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStartPrefix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Tag = "Prefix";
            this.label3.Text = "步长：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Tag = "Prefix";
            this.label2.Text = "起始：";
            // 
            // txtRegexPrefix
            // 
            this.txtRegexPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegexPrefix.Location = new System.Drawing.Point(88, 46);
            this.txtRegexPrefix.Name = "txtRegexPrefix";
            this.txtRegexPrefix.Size = new System.Drawing.Size(100, 21);
            this.txtRegexPrefix.TabIndex = 6;
            this.txtRegexPrefix.Tag = "Prefix";
            // 
            // txtTextPrefix
            // 
            this.txtTextPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextPrefix.Location = new System.Drawing.Point(88, 19);
            this.txtTextPrefix.Name = "txtTextPrefix";
            this.txtTextPrefix.Size = new System.Drawing.Size(100, 21);
            this.txtTextPrefix.TabIndex = 4;
            this.txtTextPrefix.Tag = "Prefix";
            // 
            // radioNumberPrefix
            // 
            this.radioNumberPrefix.AutoSize = true;
            this.radioNumberPrefix.Location = new System.Drawing.Point(9, 75);
            this.radioNumberPrefix.Name = "radioNumberPrefix";
            this.radioNumberPrefix.Size = new System.Drawing.Size(83, 16);
            this.radioNumberPrefix.TabIndex = 7;
            this.radioNumberPrefix.Tag = "Prefix";
            this.radioNumberPrefix.Text = "显示序号：";
            this.radioNumberPrefix.UseVisualStyleBackColor = true;
            // 
            // radioRegexPrefix
            // 
            this.radioRegexPrefix.AutoSize = true;
            this.radioRegexPrefix.Location = new System.Drawing.Point(9, 48);
            this.radioRegexPrefix.Name = "radioRegexPrefix";
            this.radioRegexPrefix.Size = new System.Drawing.Size(83, 16);
            this.radioRegexPrefix.TabIndex = 5;
            this.radioRegexPrefix.Tag = "Prefix";
            this.radioRegexPrefix.Text = "正则匹配：";
            this.radioRegexPrefix.UseVisualStyleBackColor = true;
            // 
            // radioTextPrefix
            // 
            this.radioTextPrefix.AutoSize = true;
            this.radioTextPrefix.Location = new System.Drawing.Point(9, 21);
            this.radioTextPrefix.Name = "radioTextPrefix";
            this.radioTextPrefix.Size = new System.Drawing.Size(83, 16);
            this.radioTextPrefix.TabIndex = 3;
            this.radioTextPrefix.Tag = "Prefix";
            this.radioTextPrefix.Text = "文本内容：";
            this.radioTextPrefix.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(83, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 21);
            this.textBox1.TabIndex = 27;
            this.textBox1.Tag = "Prefix";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "规则连接符：";
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.Location = new System.Drawing.Point(151, 37);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(72, 16);
            this.chkHidden.TabIndex = 102;
            this.chkHidden.Text = "包含隐藏";
            this.chkHidden.UseVisualStyleBackColor = true;
            // 
            // chkSubPath
            // 
            this.chkSubPath.AutoSize = true;
            this.chkSubPath.Checked = true;
            this.chkSubPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubPath.Location = new System.Drawing.Point(61, 37);
            this.chkSubPath.Name = "chkSubPath";
            this.chkSubPath.Size = new System.Drawing.Size(84, 16);
            this.chkSubPath.TabIndex = 101;
            this.chkSubPath.Text = "包含子目录";
            this.chkSubPath.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 100;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(3, 33);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(52, 23);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "导入";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // progressRename
            // 
            this.progressRename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressRename.Location = new System.Drawing.Point(61, 6);
            this.progressRename.Name = "progressRename";
            this.progressRename.Size = new System.Drawing.Size(333, 21);
            this.progressRename.TabIndex = 4;
            // 
            // btnStartRun
            // 
            this.btnStartRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartRun.Location = new System.Drawing.Point(400, 4);
            this.btnStartRun.Name = "btnStartRun";
            this.btnStartRun.Size = new System.Drawing.Size(77, 52);
            this.btnStartRun.TabIndex = 99;
            this.btnStartRun.Text = "开始重命名";
            this.btnStartRun.UseVisualStyleBackColor = true;
            // 
            // comboFileFilter
            // 
            this.comboFileFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFileFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFileFilter.FormattingEnabled = true;
            this.comboFileFilter.Items.AddRange(new object[] {
            "全部"});
            this.comboFileFilter.Location = new System.Drawing.Point(282, 34);
            this.comboFileFilter.Name = "comboFileFilter";
            this.comboFileFilter.Size = new System.Drawing.Size(112, 20);
            this.comboFileFilter.TabIndex = 2;
            this.comboFileFilter.SelectedIndexChanged += new System.EventHandler(this.comboFileFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件筛选：";
            // 
            // listViewFile
            // 
            this.listViewFile.AllowDrop = true;
            this.listViewFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFile.HideSelection = false;
            this.listViewFile.Location = new System.Drawing.Point(3, 62);
            this.listViewFile.Name = "listViewFile";
            this.listViewFile.Size = new System.Drawing.Size(474, 392);
            this.listViewFile.TabIndex = 0;
            this.listViewFile.UseCompatibleStateImageBehavior = false;
            this.listViewFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewFile_DragDrop);
            this.listViewFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewFile_DragEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.splitContainerMain);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件批量重命名工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBoxPostfix.ResumeLayout(false);
            this.groupBoxPostfix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStepPostfix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPostfix)).EndInit();
            this.groupBoxMiddle.ResumeLayout(false);
            this.groupBoxMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStepMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMiddle)).EndInit();
            this.groupBoxFileNamePrefix.ResumeLayout(false);
            this.groupBoxFileNamePrefix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStepPrefix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPrefix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Button btnSiteName;
        private System.Windows.Forms.GroupBox groupBoxPostfix;
        private System.Windows.Forms.CheckBox chkSampPostfix;
        private System.Windows.Forms.NumericUpDown numStepPostfix;
        private System.Windows.Forms.NumericUpDown numStartPostfix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRegexPostfix;
        private System.Windows.Forms.TextBox txtTextPostfix;
        private System.Windows.Forms.RadioButton radioNumberPostfix;
        private System.Windows.Forms.RadioButton radioRegexPostfix;
        private System.Windows.Forms.RadioButton radioTextPostfix;
        private System.Windows.Forms.GroupBox groupBoxMiddle;
        private System.Windows.Forms.CheckBox chkSampMiddle;
        private System.Windows.Forms.NumericUpDown numStepMiddle;
        private System.Windows.Forms.NumericUpDown numStartMiddle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegexMiddle;
        private System.Windows.Forms.TextBox txtTextMiddle;
        private System.Windows.Forms.RadioButton radioNumberMiddle;
        private System.Windows.Forms.RadioButton radioRegexMiddle;
        private System.Windows.Forms.RadioButton radioTextMiddle;
        private System.Windows.Forms.GroupBox groupBoxFileNamePrefix;
        private System.Windows.Forms.CheckBox chkSampPrefix;
        private System.Windows.Forms.NumericUpDown numStepPrefix;
        private System.Windows.Forms.NumericUpDown numStartPrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegexPrefix;
        private System.Windows.Forms.TextBox txtTextPrefix;
        private System.Windows.Forms.RadioButton radioNumberPrefix;
        private System.Windows.Forms.RadioButton radioRegexPrefix;
        private System.Windows.Forms.RadioButton radioTextPrefix;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ProgressBar progressRename;
        private System.Windows.Forms.Button btnStartRun;
        private System.Windows.Forms.ComboBox comboFileFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewFile;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.CheckBox chkSubPath;
        private System.Windows.Forms.Button button1;
    }
}

