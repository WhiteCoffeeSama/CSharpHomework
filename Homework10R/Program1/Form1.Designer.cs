namespace Program1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxToSearch = new System.Windows.Forms.ComboBox();
            this.textBoxToSearch = new System.Windows.Forms.TextBox();
            this.buttonToSearch = new System.Windows.Forms.Button();
            this.buttonToRefresh = new System.Windows.Forms.Button();
            this.buttonToAdd = new System.Windows.Forms.Button();
            this.buttonToDelete = new System.Windows.Forms.Button();
            this.buttonToChange = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelOfCheckedID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxToSearch
            // 
            this.comboBoxToSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxToSearch.Font = new System.Drawing.Font("宋体", 22F);
            this.comboBoxToSearch.FormattingEnabled = true;
            this.comboBoxToSearch.Location = new System.Drawing.Point(12, 12);
            this.comboBoxToSearch.Name = "comboBoxToSearch";
            this.comboBoxToSearch.Size = new System.Drawing.Size(163, 45);
            this.comboBoxToSearch.TabIndex = 0;
            // 
            // textBoxToSearch
            // 
            this.textBoxToSearch.Font = new System.Drawing.Font("宋体", 20F);
            this.textBoxToSearch.Location = new System.Drawing.Point(242, 11);
            this.textBoxToSearch.Name = "textBoxToSearch";
            this.textBoxToSearch.Size = new System.Drawing.Size(386, 46);
            this.textBoxToSearch.TabIndex = 1;
            // 
            // buttonToSearch
            // 
            this.buttonToSearch.Font = new System.Drawing.Font("宋体", 20F);
            this.buttonToSearch.Location = new System.Drawing.Point(697, 12);
            this.buttonToSearch.Name = "buttonToSearch";
            this.buttonToSearch.Size = new System.Drawing.Size(146, 46);
            this.buttonToSearch.TabIndex = 2;
            this.buttonToSearch.Text = "Search";
            this.buttonToSearch.UseVisualStyleBackColor = true;
            this.buttonToSearch.Click += new System.EventHandler(this.buttonToSearch_Click);
            // 
            // buttonToRefresh
            // 
            this.buttonToRefresh.Font = new System.Drawing.Font("宋体", 20F);
            this.buttonToRefresh.Location = new System.Drawing.Point(898, 12);
            this.buttonToRefresh.Name = "buttonToRefresh";
            this.buttonToRefresh.Size = new System.Drawing.Size(146, 46);
            this.buttonToRefresh.TabIndex = 3;
            this.buttonToRefresh.Text = "ReFresh";
            this.buttonToRefresh.UseVisualStyleBackColor = true;
            this.buttonToRefresh.Click += new System.EventHandler(this.buttonToRefresh_Click);
            // 
            // buttonToAdd
            // 
            this.buttonToAdd.Font = new System.Drawing.Font("宋体", 20F);
            this.buttonToAdd.Location = new System.Drawing.Point(12, 626);
            this.buttonToAdd.Name = "buttonToAdd";
            this.buttonToAdd.Size = new System.Drawing.Size(146, 46);
            this.buttonToAdd.TabIndex = 4;
            this.buttonToAdd.Text = "Add";
            this.buttonToAdd.UseVisualStyleBackColor = true;
            this.buttonToAdd.Click += new System.EventHandler(this.buttonToAdd_Click);
            // 
            // buttonToDelete
            // 
            this.buttonToDelete.Font = new System.Drawing.Font("宋体", 20F);
            this.buttonToDelete.Location = new System.Drawing.Point(164, 625);
            this.buttonToDelete.Name = "buttonToDelete";
            this.buttonToDelete.Size = new System.Drawing.Size(146, 47);
            this.buttonToDelete.TabIndex = 5;
            this.buttonToDelete.Text = "Delete";
            this.buttonToDelete.UseVisualStyleBackColor = true;
            this.buttonToDelete.Click += new System.EventHandler(this.buttonToDelete_Click);
            // 
            // buttonToChange
            // 
            this.buttonToChange.Font = new System.Drawing.Font("宋体", 20F);
            this.buttonToChange.Location = new System.Drawing.Point(898, 626);
            this.buttonToChange.Name = "buttonToChange";
            this.buttonToChange.Size = new System.Drawing.Size(146, 47);
            this.buttonToChange.TabIndex = 6;
            this.buttonToChange.Text = "Change";
            this.buttonToChange.UseVisualStyleBackColor = true;
            this.buttonToChange.Click += new System.EventHandler(this.buttonToChange_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(453, 556);
            this.dataGridView1.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "List";
            this.bindingSource1.DataSource = typeof(Program0.OrderService);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.goodDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.goodsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(471, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(573, 556);
            this.dataGridView2.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // goodDataGridViewTextBoxColumn
            // 
            this.goodDataGridViewTextBoxColumn.DataPropertyName = "Good";
            this.goodDataGridViewTextBoxColumn.HeaderText = "Good";
            this.goodDataGridViewTextBoxColumn.Name = "goodDataGridViewTextBoxColumn";
            this.goodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.bindingSource1;
            // 
            // labelOfCheckedID
            // 
            this.labelOfCheckedID.AutoSize = true;
            this.labelOfCheckedID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ID", true));
            this.labelOfCheckedID.Font = new System.Drawing.Font("宋体", 20F);
            this.labelOfCheckedID.Location = new System.Drawing.Point(465, 633);
            this.labelOfCheckedID.Name = "labelOfCheckedID";
            this.labelOfCheckedID.Size = new System.Drawing.Size(0, 34);
            this.labelOfCheckedID.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 684);
            this.Controls.Add(this.labelOfCheckedID);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonToChange);
            this.Controls.Add(this.buttonToDelete);
            this.Controls.Add(this.buttonToAdd);
            this.Controls.Add(this.buttonToRefresh);
            this.Controls.Add(this.buttonToSearch);
            this.Controls.Add(this.textBoxToSearch);
            this.Controls.Add(this.comboBoxToSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxToSearch;
        private System.Windows.Forms.TextBox textBoxToSearch;
        private System.Windows.Forms.Button buttonToSearch;
        private System.Windows.Forms.Button buttonToRefresh;
        private System.Windows.Forms.Button buttonToAdd;
        private System.Windows.Forms.Button buttonToDelete;
        private System.Windows.Forms.Button buttonToChange;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelOfCheckedID;
    }
}

