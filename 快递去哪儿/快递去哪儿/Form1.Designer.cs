namespace csxto
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSingle = new System.Windows.Forms.TabPage();
            this.groupBoxSingle5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSingle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSingle3 = new System.Windows.Forms.GroupBox();
            this.buttonSingle = new System.Windows.Forms.Button();
            this.groupBoxSingle2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSingleCompany = new System.Windows.Forms.ComboBox();
            this.labelSingleCompany = new System.Windows.Forms.Label();
            this.groupBoxSingle1 = new System.Windows.Forms.GroupBox();
            this.textBoxSingleID = new System.Windows.Forms.TextBox();
            this.labelSingleID = new System.Windows.Forms.Label();
            this.tabPageDouble = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelProject = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelProjectAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelInspired = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelInspiredAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelSingleCompanyP = new System.Windows.Forms.Label();
            this.labelSingleIDP = new System.Windows.Forms.Label();
            this.labelSingleStatusP = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageSingle.SuspendLayout();
            this.groupBoxSingle5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingle)).BeginInit();
            this.groupBoxSingle3.SuspendLayout();
            this.groupBoxSingle2.SuspendLayout();
            this.groupBoxSingle1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageSingle);
            this.tabControlMain.Controls.Add(this.tabPageDouble);
            this.tabControlMain.Location = new System.Drawing.Point(13, 13);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(759, 323);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageSingle
            // 
            this.tabPageSingle.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSingle.Controls.Add(this.groupBox4);
            this.tabPageSingle.Controls.Add(this.groupBoxSingle5);
            this.tabPageSingle.Controls.Add(this.groupBoxSingle3);
            this.tabPageSingle.Controls.Add(this.groupBoxSingle2);
            this.tabPageSingle.Controls.Add(this.groupBoxSingle1);
            this.tabPageSingle.Location = new System.Drawing.Point(4, 22);
            this.tabPageSingle.Name = "tabPageSingle";
            this.tabPageSingle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSingle.Size = new System.Drawing.Size(751, 297);
            this.tabPageSingle.TabIndex = 0;
            this.tabPageSingle.Text = "单件查询";
            // 
            // groupBoxSingle5
            // 
            this.groupBoxSingle5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSingle5.Controls.Add(this.dataGridViewSingle);
            this.groupBoxSingle5.Location = new System.Drawing.Point(6, 113);
            this.groupBoxSingle5.Name = "groupBoxSingle5";
            this.groupBoxSingle5.Size = new System.Drawing.Size(739, 178);
            this.groupBoxSingle5.TabIndex = 4;
            this.groupBoxSingle5.TabStop = false;
            this.groupBoxSingle5.Text = "详细溯源";
            // 
            // dataGridViewSingle
            // 
            this.dataGridViewSingle.AllowUserToAddRows = false;
            this.dataGridViewSingle.AllowUserToDeleteRows = false;
            this.dataGridViewSingle.AllowUserToResizeRows = false;
            this.dataGridViewSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSingle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSingle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSingle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewSingle.Location = new System.Drawing.Point(7, 21);
            this.dataGridViewSingle.MultiSelect = false;
            this.dataGridViewSingle.Name = "dataGridViewSingle";
            this.dataGridViewSingle.ReadOnly = true;
            this.dataGridViewSingle.RowHeadersVisible = false;
            this.dataGridViewSingle.RowTemplate.Height = 23;
            this.dataGridViewSingle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSingle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSingle.ShowCellErrors = false;
            this.dataGridViewSingle.ShowCellToolTips = false;
            this.dataGridViewSingle.ShowEditingIcon = false;
            this.dataGridViewSingle.ShowRowErrors = false;
            this.dataGridViewSingle.Size = new System.Drawing.Size(726, 151);
            this.dataGridViewSingle.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "时间";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 60F;
            this.Column2.HeaderText = "地点和跟踪进度";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBoxSingle3
            // 
            this.groupBoxSingle3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSingle3.Controls.Add(this.buttonSingle);
            this.groupBoxSingle3.Location = new System.Drawing.Point(533, 7);
            this.groupBoxSingle3.Name = "groupBoxSingle3";
            this.groupBoxSingle3.Size = new System.Drawing.Size(212, 49);
            this.groupBoxSingle3.TabIndex = 3;
            this.groupBoxSingle3.TabStop = false;
            this.groupBoxSingle3.Text = "3.开始查询";
            // 
            // buttonSingle
            // 
            this.buttonSingle.Location = new System.Drawing.Point(6, 17);
            this.buttonSingle.Name = "buttonSingle";
            this.buttonSingle.Size = new System.Drawing.Size(203, 23);
            this.buttonSingle.TabIndex = 0;
            this.buttonSingle.Text = "查询";
            this.buttonSingle.UseVisualStyleBackColor = true;
            this.buttonSingle.Click += new System.EventHandler(this.buttonSingle_Click);
            // 
            // groupBoxSingle2
            // 
            this.groupBoxSingle2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSingle2.Controls.Add(this.comboBoxSingleCompany);
            this.groupBoxSingle2.Controls.Add(this.labelSingleCompany);
            this.groupBoxSingle2.Location = new System.Drawing.Point(270, 7);
            this.groupBoxSingle2.Name = "groupBoxSingle2";
            this.groupBoxSingle2.Size = new System.Drawing.Size(257, 49);
            this.groupBoxSingle2.TabIndex = 2;
            this.groupBoxSingle2.TabStop = false;
            this.groupBoxSingle2.Text = "2.选择快递公司";
            // 
            // comboBoxSingleCompany
            // 
            this.comboBoxSingleCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSingleCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSingleCompany.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxSingleCompany.FormattingEnabled = true;
            this.comboBoxSingleCompany.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBoxSingleCompany.Location = new System.Drawing.Point(108, 17);
            this.comboBoxSingleCompany.Name = "comboBoxSingleCompany";
            this.comboBoxSingleCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxSingleCompany.Size = new System.Drawing.Size(143, 20);
            this.comboBoxSingleCompany.TabIndex = 1;
            // 
            // labelSingleCompany
            // 
            this.labelSingleCompany.AutoSize = true;
            this.labelSingleCompany.Location = new System.Drawing.Point(7, 21);
            this.labelSingleCompany.Name = "labelSingleCompany";
            this.labelSingleCompany.Size = new System.Drawing.Size(101, 12);
            this.labelSingleCompany.TabIndex = 0;
            this.labelSingleCompany.Text = "请选择快递公司：";
            // 
            // groupBoxSingle1
            // 
            this.groupBoxSingle1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSingle1.Controls.Add(this.textBoxSingleID);
            this.groupBoxSingle1.Controls.Add(this.labelSingleID);
            this.groupBoxSingle1.Location = new System.Drawing.Point(6, 6);
            this.groupBoxSingle1.Name = "groupBoxSingle1";
            this.groupBoxSingle1.Size = new System.Drawing.Size(258, 50);
            this.groupBoxSingle1.TabIndex = 0;
            this.groupBoxSingle1.TabStop = false;
            this.groupBoxSingle1.Text = "1.输入快递单号";
            // 
            // textBoxSingleID
            // 
            this.textBoxSingleID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSingleID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxSingleID.Location = new System.Drawing.Point(108, 18);
            this.textBoxSingleID.Name = "textBoxSingleID";
            this.textBoxSingleID.Size = new System.Drawing.Size(144, 21);
            this.textBoxSingleID.TabIndex = 1;
            // 
            // labelSingleID
            // 
            this.labelSingleID.AutoSize = true;
            this.labelSingleID.Location = new System.Drawing.Point(7, 21);
            this.labelSingleID.Name = "labelSingleID";
            this.labelSingleID.Size = new System.Drawing.Size(101, 12);
            this.labelSingleID.TabIndex = 0;
            this.labelSingleID.Text = "请输入快递单号：";
            // 
            // tabPageDouble
            // 
            this.tabPageDouble.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageDouble.Location = new System.Drawing.Point(4, 22);
            this.tabPageDouble.Name = "tabPageDouble";
            this.tabPageDouble.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDouble.Size = new System.Drawing.Size(751, 297);
            this.tabPageDouble.TabIndex = 1;
            this.tabPageDouble.Text = "批量查询";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelProject,
            this.toolStripStatusLabelProjectAddress,
            this.toolStripStatusLabelInspired,
            this.toolStripStatusLabelInspiredAddress});
            this.statusStrip.Location = new System.Drawing.Point(0, 339);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelProject
            // 
            this.toolStripStatusLabelProject.Name = "toolStripStatusLabelProject";
            this.toolStripStatusLabelProject.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabelProject.Text = "项目地址：";
            // 
            // toolStripStatusLabelProjectAddress
            // 
            this.toolStripStatusLabelProjectAddress.IsLink = true;
            this.toolStripStatusLabelProjectAddress.Name = "toolStripStatusLabelProjectAddress";
            this.toolStripStatusLabelProjectAddress.Size = new System.Drawing.Size(239, 17);
            this.toolStripStatusLabelProjectAddress.Text = "https://github.com/Sharuru/Csharp-xto/";
            this.toolStripStatusLabelProjectAddress.Click += new System.EventHandler(this.toolStripStatusLabelProjectAddress_Click);
            // 
            // toolStripStatusLabelInspired
            // 
            this.toolStripStatusLabelInspired.Name = "toolStripStatusLabelInspired";
            this.toolStripStatusLabelInspired.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabelInspired.Text = "启发于：";
            // 
            // toolStripStatusLabelInspiredAddress
            // 
            this.toolStripStatusLabelInspiredAddress.IsLink = true;
            this.toolStripStatusLabelInspiredAddress.Name = "toolStripStatusLabelInspiredAddress";
            this.toolStripStatusLabelInspiredAddress.Size = new System.Drawing.Size(195, 17);
            this.toolStripStatusLabelInspiredAddress.Text = "https://github.com/XadillaX/xto/";
            this.toolStripStatusLabelInspiredAddress.Click += new System.EventHandler(this.toolStripStatusLabelInspiredAddress_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelSingleStatusP);
            this.groupBox4.Controls.Add(this.labelSingleIDP);
            this.groupBox4.Controls.Add(this.labelSingleCompanyP);
            this.groupBox4.Location = new System.Drawing.Point(7, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(738, 44);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "信息概览";
            // 
            // labelSingleCompanyP
            // 
            this.labelSingleCompanyP.AutoSize = true;
            this.labelSingleCompanyP.Location = new System.Drawing.Point(270, 21);
            this.labelSingleCompanyP.Name = "labelSingleCompanyP";
            this.labelSingleCompanyP.Size = new System.Drawing.Size(65, 12);
            this.labelSingleCompanyP.TabIndex = 0;
            this.labelSingleCompanyP.Text = "快递公司：";
            // 
            // labelSingleIDP
            // 
            this.labelSingleIDP.AutoSize = true;
            this.labelSingleIDP.Location = new System.Drawing.Point(6, 21);
            this.labelSingleIDP.Name = "labelSingleIDP";
            this.labelSingleIDP.Size = new System.Drawing.Size(65, 12);
            this.labelSingleIDP.TabIndex = 1;
            this.labelSingleIDP.Text = "快递单号：";
            // 
            // labelSingleStatusP
            // 
            this.labelSingleStatusP.AutoSize = true;
            this.labelSingleStatusP.Location = new System.Drawing.Point(530, 21);
            this.labelSingleStatusP.Name = "labelSingleStatusP";
            this.labelSingleStatusP.Size = new System.Drawing.Size(65, 12);
            this.labelSingleStatusP.TabIndex = 2;
            this.labelSingleStatusP.Text = "快递状态：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "快递去哪儿";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSingle.ResumeLayout(false);
            this.groupBoxSingle5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingle)).EndInit();
            this.groupBoxSingle3.ResumeLayout(false);
            this.groupBoxSingle2.ResumeLayout(false);
            this.groupBoxSingle2.PerformLayout();
            this.groupBoxSingle1.ResumeLayout(false);
            this.groupBoxSingle1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSingle;
        private System.Windows.Forms.TabPage tabPageDouble;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProject;
        private System.Windows.Forms.GroupBox groupBoxSingle1;
        private System.Windows.Forms.TextBox textBoxSingleID;
        private System.Windows.Forms.Label labelSingleID;
        private System.Windows.Forms.GroupBox groupBoxSingle2;
        private System.Windows.Forms.ComboBox comboBoxSingleCompany;
        private System.Windows.Forms.Label labelSingleCompany;
        private System.Windows.Forms.GroupBox groupBoxSingle3;
        private System.Windows.Forms.Button buttonSingle;
        private System.Windows.Forms.GroupBox groupBoxSingle5;
        private System.Windows.Forms.DataGridView dataGridViewSingle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProjectAddress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInspired;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInspiredAddress;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelSingleStatusP;
        private System.Windows.Forms.Label labelSingleIDP;
        private System.Windows.Forms.Label labelSingleCompanyP;
    }
}

