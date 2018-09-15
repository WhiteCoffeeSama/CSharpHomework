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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("宋体", 18F);
            this.txtNum.Location = new System.Drawing.Point(169, 82);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(230, 42);
            this.txtNum.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.AllowDrop = true;
            this.listBox.BackColor = System.Drawing.SystemColors.Window;
            this.listBox.Font = new System.Drawing.Font("宋体", 18F);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 30;
            this.listBox.Location = new System.Drawing.Point(2, 224);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(796, 184);
            this.listBox.TabIndex = 2;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(424, 150);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(129, 37);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "求素数";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.txtNum);
            this.Name = "Form1";
            this.Text = "求素数";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnGet;
    }
}

