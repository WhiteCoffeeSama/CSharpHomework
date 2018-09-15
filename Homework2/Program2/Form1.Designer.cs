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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnAva = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnChg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.Font = new System.Drawing.Font("宋体", 12F);
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 20;
            this.lstBox.Location = new System.Drawing.Point(28, 26);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(767, 604);
            this.lstBox.TabIndex = 0;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("宋体", 12F);
            this.btnMax.Location = new System.Drawing.Point(824, 26);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(90, 40);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "最大值";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("宋体", 12F);
            this.btnMin.Location = new System.Drawing.Point(824, 104);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(90, 40);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "最小值";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnAva
            // 
            this.btnAva.Font = new System.Drawing.Font("宋体", 12F);
            this.btnAva.Location = new System.Drawing.Point(824, 184);
            this.btnAva.Name = "btnAva";
            this.btnAva.Size = new System.Drawing.Size(90, 40);
            this.btnAva.TabIndex = 3;
            this.btnAva.Text = "平均值";
            this.btnAva.UseVisualStyleBackColor = true;
            this.btnAva.Click += new System.EventHandler(this.btnAva_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSum.Location = new System.Drawing.Point(824, 266);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(90, 40);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "取和";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnChg
            // 
            this.btnChg.Font = new System.Drawing.Font("宋体", 12F);
            this.btnChg.Location = new System.Drawing.Point(824, 353);
            this.btnChg.Name = "btnChg";
            this.btnChg.Size = new System.Drawing.Size(90, 40);
            this.btnChg.TabIndex = 5;
            this.btnChg.Text = "更改";
            this.btnChg.UseVisualStyleBackColor = true;
            this.btnChg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 654);
            this.Controls.Add(this.btnChg);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnAva);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.lstBox);
            this.Name = "Form1";
            this.Text = "数组";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnAva;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnChg;
    }
}

