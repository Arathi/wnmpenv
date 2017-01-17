namespace wnmpenv.WNMPanel
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
            this.btnOpenPhpIniParser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenPhpIniParser
            // 
            this.btnOpenPhpIniParser.Location = new System.Drawing.Point(151, 217);
            this.btnOpenPhpIniParser.Name = "btnOpenPhpIniParser";
            this.btnOpenPhpIniParser.Size = new System.Drawing.Size(126, 23);
            this.btnOpenPhpIniParser.TabIndex = 0;
            this.btnOpenPhpIniParser.Text = "打开php.ini解析器";
            this.btnOpenPhpIniParser.UseVisualStyleBackColor = true;
            this.btnOpenPhpIniParser.Click += new System.EventHandler(this.btnOpenPhpIniParser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOpenPhpIniParser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPhpIniParser;
    }
}

