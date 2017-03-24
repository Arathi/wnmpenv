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
            this.components = new System.ComponentModel.Container();
            this.btnOpenPhpIniParser = new System.Windows.Forms.Button();
            this.btnTestUnzip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNginxSwitch = new System.Windows.Forms.Button();
            this.btnMysqldSwitch = new System.Windows.Forms.Button();
            this.btnPhpCgiSwitch = new System.Windows.Forms.Button();
            this.btnNginxRestart = new System.Windows.Forms.Button();
            this.btnMysqldRestart = new System.Windows.Forms.Button();
            this.btnPhpCgiRestart = new System.Windows.Forms.Button();
            this.cron = new System.Windows.Forms.Timer(this.components);
            this.btnNginxConfig = new System.Windows.Forms.Button();
            this.btnStartAll = new System.Windows.Forms.Button();
            this.btnMysqlConfig = new System.Windows.Forms.Button();
            this.btnLocalhost = new System.Windows.Forms.Button();
            this.btnMysqlConsole = new System.Windows.Forms.Button();
            this.btnVersionSwitch = new System.Windows.Forms.Button();
            this.labelNginx = new System.Windows.Forms.Label();
            this.labelMysqld = new System.Windows.Forms.Label();
            this.labelPhpCgi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenPhpIniParser
            // 
            this.btnOpenPhpIniParser.Location = new System.Drawing.Point(272, 85);
            this.btnOpenPhpIniParser.Name = "btnOpenPhpIniParser";
            this.btnOpenPhpIniParser.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPhpIniParser.TabIndex = 0;
            this.btnOpenPhpIniParser.Text = "编辑配置";
            this.btnOpenPhpIniParser.UseVisualStyleBackColor = true;
            this.btnOpenPhpIniParser.Click += new System.EventHandler(this.btnOpenPhpIniParser_Click);
            // 
            // btnTestUnzip
            // 
            this.btnTestUnzip.Location = new System.Drawing.Point(355, 120);
            this.btnTestUnzip.Name = "btnTestUnzip";
            this.btnTestUnzip.Size = new System.Drawing.Size(74, 23);
            this.btnTestUnzip.TabIndex = 1;
            this.btnTestUnzip.Text = "自动部署";
            this.btnTestUnzip.UseVisualStyleBackColor = true;
            this.btnTestUnzip.Click += new System.EventHandler(this.btnTestUnzip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "nginx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "mysqld";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "php-cgi";
            // 
            // btnNginxSwitch
            // 
            this.btnNginxSwitch.Location = new System.Drawing.Point(110, 18);
            this.btnNginxSwitch.Name = "btnNginxSwitch";
            this.btnNginxSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnNginxSwitch.TabIndex = 5;
            this.btnNginxSwitch.Text = "启动";
            this.btnNginxSwitch.UseVisualStyleBackColor = true;
            this.btnNginxSwitch.Click += new System.EventHandler(this.btnNginxSwitch_Click);
            // 
            // btnMysqldSwitch
            // 
            this.btnMysqldSwitch.Location = new System.Drawing.Point(110, 51);
            this.btnMysqldSwitch.Name = "btnMysqldSwitch";
            this.btnMysqldSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnMysqldSwitch.TabIndex = 6;
            this.btnMysqldSwitch.Text = "启动";
            this.btnMysqldSwitch.UseVisualStyleBackColor = true;
            this.btnMysqldSwitch.Click += new System.EventHandler(this.btnMysqldSwitch_Click);
            // 
            // btnPhpCgiSwitch
            // 
            this.btnPhpCgiSwitch.Location = new System.Drawing.Point(110, 85);
            this.btnPhpCgiSwitch.Name = "btnPhpCgiSwitch";
            this.btnPhpCgiSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnPhpCgiSwitch.TabIndex = 7;
            this.btnPhpCgiSwitch.Text = "启动";
            this.btnPhpCgiSwitch.UseVisualStyleBackColor = true;
            this.btnPhpCgiSwitch.Click += new System.EventHandler(this.btnPhpCgiSwitch_Click);
            // 
            // btnNginxRestart
            // 
            this.btnNginxRestart.Enabled = false;
            this.btnNginxRestart.Location = new System.Drawing.Point(191, 18);
            this.btnNginxRestart.Name = "btnNginxRestart";
            this.btnNginxRestart.Size = new System.Drawing.Size(75, 23);
            this.btnNginxRestart.TabIndex = 8;
            this.btnNginxRestart.Text = "重启";
            this.btnNginxRestart.UseVisualStyleBackColor = true;
            this.btnNginxRestart.Click += new System.EventHandler(this.btnNginxRestart_Click);
            // 
            // btnMysqldRestart
            // 
            this.btnMysqldRestart.Enabled = false;
            this.btnMysqldRestart.Location = new System.Drawing.Point(191, 51);
            this.btnMysqldRestart.Name = "btnMysqldRestart";
            this.btnMysqldRestart.Size = new System.Drawing.Size(75, 23);
            this.btnMysqldRestart.TabIndex = 9;
            this.btnMysqldRestart.Text = "重启";
            this.btnMysqldRestart.UseVisualStyleBackColor = true;
            // 
            // btnPhpCgiRestart
            // 
            this.btnPhpCgiRestart.Enabled = false;
            this.btnPhpCgiRestart.Location = new System.Drawing.Point(191, 85);
            this.btnPhpCgiRestart.Name = "btnPhpCgiRestart";
            this.btnPhpCgiRestart.Size = new System.Drawing.Size(75, 23);
            this.btnPhpCgiRestart.TabIndex = 10;
            this.btnPhpCgiRestart.Text = "重启";
            this.btnPhpCgiRestart.UseVisualStyleBackColor = true;
            // 
            // cron
            // 
            this.cron.Enabled = true;
            this.cron.Interval = 500;
            this.cron.Tick += new System.EventHandler(this.cron_Tick);
            // 
            // btnNginxConfig
            // 
            this.btnNginxConfig.Location = new System.Drawing.Point(272, 18);
            this.btnNginxConfig.Name = "btnNginxConfig";
            this.btnNginxConfig.Size = new System.Drawing.Size(75, 23);
            this.btnNginxConfig.TabIndex = 11;
            this.btnNginxConfig.Text = "编辑配置";
            this.btnNginxConfig.UseVisualStyleBackColor = true;
            // 
            // btnStartAll
            // 
            this.btnStartAll.Location = new System.Drawing.Point(110, 120);
            this.btnStartAll.Name = "btnStartAll";
            this.btnStartAll.Size = new System.Drawing.Size(75, 23);
            this.btnStartAll.TabIndex = 12;
            this.btnStartAll.Text = "全部启动";
            this.btnStartAll.UseVisualStyleBackColor = true;
            // 
            // btnMysqlConfig
            // 
            this.btnMysqlConfig.Location = new System.Drawing.Point(272, 51);
            this.btnMysqlConfig.Name = "btnMysqlConfig";
            this.btnMysqlConfig.Size = new System.Drawing.Size(75, 23);
            this.btnMysqlConfig.TabIndex = 13;
            this.btnMysqlConfig.Text = "编辑配置";
            this.btnMysqlConfig.UseVisualStyleBackColor = true;
            // 
            // btnLocalhost
            // 
            this.btnLocalhost.Location = new System.Drawing.Point(353, 18);
            this.btnLocalhost.Name = "btnLocalhost";
            this.btnLocalhost.Size = new System.Drawing.Size(75, 23);
            this.btnLocalhost.TabIndex = 14;
            this.btnLocalhost.Text = "打开首页";
            this.btnLocalhost.UseVisualStyleBackColor = true;
            // 
            // btnMysqlConsole
            // 
            this.btnMysqlConsole.Location = new System.Drawing.Point(353, 51);
            this.btnMysqlConsole.Name = "btnMysqlConsole";
            this.btnMysqlConsole.Size = new System.Drawing.Size(75, 23);
            this.btnMysqlConsole.TabIndex = 15;
            this.btnMysqlConsole.Text = "控制台";
            this.btnMysqlConsole.UseVisualStyleBackColor = true;
            // 
            // btnVersionSwitch
            // 
            this.btnVersionSwitch.Location = new System.Drawing.Point(354, 85);
            this.btnVersionSwitch.Name = "btnVersionSwitch";
            this.btnVersionSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnVersionSwitch.TabIndex = 16;
            this.btnVersionSwitch.Text = "切换版本";
            this.btnVersionSwitch.UseVisualStyleBackColor = true;
            // 
            // labelNginx
            // 
            this.labelNginx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNginx.Location = new System.Drawing.Point(67, 23);
            this.labelNginx.Name = "labelNginx";
            this.labelNginx.Size = new System.Drawing.Size(37, 14);
            this.labelNginx.TabIndex = 17;
            this.labelNginx.Text = "     ";
            // 
            // labelMysqld
            // 
            this.labelMysqld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMysqld.Location = new System.Drawing.Point(66, 56);
            this.labelMysqld.Name = "labelMysqld";
            this.labelMysqld.Size = new System.Drawing.Size(37, 14);
            this.labelMysqld.TabIndex = 18;
            this.labelMysqld.Text = "     ";
            // 
            // labelPhpCgi
            // 
            this.labelPhpCgi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPhpCgi.Location = new System.Drawing.Point(67, 90);
            this.labelPhpCgi.Name = "labelPhpCgi";
            this.labelPhpCgi.Size = new System.Drawing.Size(37, 14);
            this.labelPhpCgi.TabIndex = 19;
            this.labelPhpCgi.Text = "     ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 156);
            this.Controls.Add(this.labelPhpCgi);
            this.Controls.Add(this.labelMysqld);
            this.Controls.Add(this.labelNginx);
            this.Controls.Add(this.btnVersionSwitch);
            this.Controls.Add(this.btnMysqlConsole);
            this.Controls.Add(this.btnLocalhost);
            this.Controls.Add(this.btnMysqlConfig);
            this.Controls.Add(this.btnStartAll);
            this.Controls.Add(this.btnNginxConfig);
            this.Controls.Add(this.btnPhpCgiRestart);
            this.Controls.Add(this.btnMysqldRestart);
            this.Controls.Add(this.btnNginxRestart);
            this.Controls.Add(this.btnPhpCgiSwitch);
            this.Controls.Add(this.btnMysqldSwitch);
            this.Controls.Add(this.btnNginxSwitch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestUnzip);
            this.Controls.Add(this.btnOpenPhpIniParser);
            this.Name = "FormMain";
            this.Text = "WNMPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPhpIniParser;
        private System.Windows.Forms.Button btnTestUnzip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNginxSwitch;
        private System.Windows.Forms.Button btnMysqldSwitch;
        private System.Windows.Forms.Button btnPhpCgiSwitch;
        private System.Windows.Forms.Button btnNginxRestart;
        private System.Windows.Forms.Button btnMysqldRestart;
        private System.Windows.Forms.Button btnPhpCgiRestart;
        private System.Windows.Forms.Timer cron;
        private System.Windows.Forms.Button btnNginxConfig;
        private System.Windows.Forms.Button btnStartAll;
        private System.Windows.Forms.Button btnMysqlConfig;
        private System.Windows.Forms.Button btnLocalhost;
        private System.Windows.Forms.Button btnMysqlConsole;
        private System.Windows.Forms.Button btnVersionSwitch;
        private System.Windows.Forms.Label labelNginx;
        private System.Windows.Forms.Label labelMysqld;
        private System.Windows.Forms.Label labelPhpCgi;
    }
}

