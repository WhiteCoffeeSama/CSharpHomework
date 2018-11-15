using System;
using System.Windows.Forms;

namespace Program2
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingOrderService = new System.Windows.Forms.BindingSource(this.components);
            this.panelShowList = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonToChange = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.delOrder = new System.Windows.Forms.Button();
            this.addNewOrder = new System.Windows.Forms.Button();
            this.labelSelectedText = new System.Windows.Forms.Label();
            this.labelSelectedRow = new System.Windows.Forms.Label();
            this.buttonToSearch = new System.Windows.Forms.Button();
            this.textBoxToSearch = new System.Windows.Forms.TextBox();
            this.comboBoxToSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingOrderService)).BeginInit();
            this.panelShowList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("宋体", 25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1065, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎来到CC的商店";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.clientDataGridViewTextBoxColumn,
            this.goodDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.Tel,
            this.ID});
            this.dataGridView1.DataSource = this.listBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 404);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodDataGridViewTextBoxColumn
            // 
            this.goodDataGridViewTextBoxColumn.DataPropertyName = "Good";
            this.goodDataGridViewTextBoxColumn.HeaderText = "Good";
            this.goodDataGridViewTextBoxColumn.Name = "goodDataGridViewTextBoxColumn";
            this.goodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // listBindingSource
            // 
            this.listBindingSource.DataSource = this.bindingOrderService;
            // 
            // bindingOrderService
            // 
            this.bindingOrderService.DataMember = "List";
            this.bindingOrderService.DataSource = typeof(Program1.OrderService);
            // 
            // panelShowList
            // 
            this.panelShowList.Controls.Add(this.button2);
            this.panelShowList.Controls.Add(this.button1);
            this.panelShowList.Controls.Add(this.buttonToChange);
            this.panelShowList.Controls.Add(this.labelID);
            this.panelShowList.Controls.Add(this.delOrder);
            this.panelShowList.Controls.Add(this.addNewOrder);
            this.panelShowList.Controls.Add(this.labelSelectedText);
            this.panelShowList.Controls.Add(this.labelSelectedRow);
            this.panelShowList.Controls.Add(this.buttonToSearch);
            this.panelShowList.Controls.Add(this.textBoxToSearch);
            this.panelShowList.Controls.Add(this.comboBoxToSearch);
            this.panelShowList.Controls.Add(this.dataGridView1);
            this.panelShowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowList.Location = new System.Drawing.Point(0, 42);
            this.panelShowList.Name = "panelShowList";
            this.panelShowList.Size = new System.Drawing.Size(1065, 615);
            this.panelShowList.TabIndex = 2;
            this.panelShowList.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShowList_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 22F);
            this.button2.Location = new System.Drawing.Point(903, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "HTML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(727, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Re";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonToChange
            // 
            this.buttonToChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonToChange.Font = new System.Drawing.Font("华文琥珀", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonToChange.Location = new System.Drawing.Point(412, 533);
            this.buttonToChange.Name = "buttonToChange";
            this.buttonToChange.Size = new System.Drawing.Size(113, 39);
            this.buttonToChange.TabIndex = 10;
            this.buttonToChange.Text = "Chan";
            this.buttonToChange.UseVisualStyleBackColor = true;
            this.buttonToChange.Click += new System.EventHandler(this.buttonToChange_Click);
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID.AutoSize = true;
            this.labelID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listBindingSource, "ID", true));
            this.labelID.Location = new System.Drawing.Point(872, 574);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(55, 15);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "label2";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // delOrder
            // 
            this.delOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delOrder.Font = new System.Drawing.Font("华文琥珀", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delOrder.Location = new System.Drawing.Point(224, 533);
            this.delOrder.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.delOrder.Name = "delOrder";
            this.delOrder.Size = new System.Drawing.Size(115, 39);
            this.delOrder.TabIndex = 8;
            this.delOrder.Text = "Del";
            this.delOrder.UseVisualStyleBackColor = true;
            this.delOrder.Click += new System.EventHandler(this.delOrder_Click);
            // 
            // addNewOrder
            // 
            this.addNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewOrder.Font = new System.Drawing.Font("华文琥珀", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addNewOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addNewOrder.Location = new System.Drawing.Point(28, 533);
            this.addNewOrder.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.addNewOrder.Name = "addNewOrder";
            this.addNewOrder.Size = new System.Drawing.Size(115, 39);
            this.addNewOrder.TabIndex = 7;
            this.addNewOrder.Text = "New";
            this.addNewOrder.UseVisualStyleBackColor = true;
            this.addNewOrder.Click += new System.EventHandler(this.addNewOrder_Click);
            // 
            // labelSelectedText
            // 
            this.labelSelectedText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSelectedText.AutoSize = true;
            this.labelSelectedText.Font = new System.Drawing.Font("宋体", 20F);
            this.labelSelectedText.Location = new System.Drawing.Point(218, 477);
            this.labelSelectedText.Name = "labelSelectedText";
            this.labelSelectedText.Size = new System.Drawing.Size(83, 34);
            this.labelSelectedText.TabIndex = 6;
            this.labelSelectedText.Text = "选中";
            this.labelSelectedText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSelectedRow
            // 
            this.labelSelectedRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSelectedRow.AutoSize = true;
            this.labelSelectedRow.Font = new System.Drawing.Font("宋体", 20F);
            this.labelSelectedRow.ForeColor = System.Drawing.Color.Black;
            this.labelSelectedRow.Location = new System.Drawing.Point(22, 477);
            this.labelSelectedRow.Margin = new System.Windows.Forms.Padding(3, 0, 0, 30);
            this.labelSelectedRow.Name = "labelSelectedRow";
            this.labelSelectedRow.Size = new System.Drawing.Size(100, 34);
            this.labelSelectedRow.TabIndex = 5;
            this.labelSelectedRow.Text = "类型:";
            // 
            // buttonToSearch
            // 
            this.buttonToSearch.AutoSize = true;
            this.buttonToSearch.Font = new System.Drawing.Font("宋体", 20F);
            this.buttonToSearch.Location = new System.Drawing.Point(598, 5);
            this.buttonToSearch.Name = "buttonToSearch";
            this.buttonToSearch.Size = new System.Drawing.Size(107, 44);
            this.buttonToSearch.TabIndex = 4;
            this.buttonToSearch.Text = "查询";
            this.buttonToSearch.UseVisualStyleBackColor = true;
            this.buttonToSearch.Click += new System.EventHandler(this.buttonToSearch_Click);
            // 
            // textBoxToSearch
            // 
            this.textBoxToSearch.Font = new System.Drawing.Font("宋体", 20F);
            this.textBoxToSearch.Location = new System.Drawing.Point(232, 5);
            this.textBoxToSearch.Margin = new System.Windows.Forms.Padding(232, 3, 3, 3);
            this.textBoxToSearch.Name = "textBoxToSearch";
            this.textBoxToSearch.Size = new System.Drawing.Size(335, 46);
            this.textBoxToSearch.TabIndex = 3;
            // 
            // comboBoxToSearch
            // 
            this.comboBoxToSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToSearch.Font = new System.Drawing.Font("宋体", 22F);
            this.comboBoxToSearch.FormattingEnabled = true;
            this.comboBoxToSearch.Location = new System.Drawing.Point(28, 4);
            this.comboBoxToSearch.Name = "comboBoxToSearch";
            this.comboBoxToSearch.Size = new System.Drawing.Size(169, 45);
            this.comboBoxToSearch.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 657);
            this.Controls.Add(this.panelShowList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CC的商店！";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingOrderService)).EndInit();
            this.panelShowList.ResumeLayout(false);
            this.panelShowList.PerformLayout();
            this.ResumeLayout(false);

        }

        private void panelShowList_Paint(object sender, PaintEventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingOrderService;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource listBindingSource;
        private System.Windows.Forms.Panel panelShowList;
        private System.Windows.Forms.TextBox textBoxToSearch;
        private System.Windows.Forms.ComboBox comboBoxToSearch;
        private System.Windows.Forms.Button buttonToSearch;
        private System.Windows.Forms.Label labelSelectedRow;
        private System.Windows.Forms.Label labelSelectedText;
        private System.Windows.Forms.Button addNewOrder;
        private System.Windows.Forms.Button delOrder;
        private Label labelID;
        private Button buttonToChange;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Tel;
        private DataGridViewTextBoxColumn ID;
        private Button button2;
    }
}

