namespace HttpClient
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
            this.btn_GetElec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GetElec
            // 
            this.btn_GetElec.Location = new System.Drawing.Point(39, 70);
            this.btn_GetElec.Name = "btn_GetElec";
            this.btn_GetElec.Size = new System.Drawing.Size(138, 92);
            this.btn_GetElec.TabIndex = 1;
            this.btn_GetElec.Text = "获取电场仪数据";
            this.btn_GetElec.UseVisualStyleBackColor = true;
            this.btn_GetElec.Click += new System.EventHandler(this.btn_GetElec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 198);
            this.Controls.Add(this.btn_GetElec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GetElec;

    }
}

