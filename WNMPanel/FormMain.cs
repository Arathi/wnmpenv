using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.BZip2;
using SevenZip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace wnmpenv.WNMPanel
{
    public partial class FormMain : Form
    {
        Process nginx;
        Process mysqld;
        Process phpcgi;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnOpenPhpIniParser_Click(object sender, EventArgs e)
        {
            FormPhpIniParser formParser = new FormPhpIniParser();
            formParser.Show();
        }

        private void btnTestUnzip_Click(object sender, EventArgs e)
        {
        }

        private void deployNginx()
        {
            string path = Environment.CurrentDirectory;
            FastZip fzip = new FastZip();
            string zipFileName = path + @"\Archives\nginx-1.10.2.zip";
            string targetDir = path + @"\nginx";
            fzip.ExtractZip(zipFileName, targetDir, null);
        }

        private void deployMysqld()
        {
            string path = Environment.CurrentDirectory;
            string bz2FileName = path = @"\Archives\mariadb-5.5.54.tar.bz2";
            Stream inStream = new FileStream(bz2FileName, FileMode.Open);
            Stream outStream = new FileStream("", FileMode.Create);
            BZip2.Decompress(inStream, outStream, true);
        }

        private void deployPhp()
        {
            string path = Environment.CurrentDirectory;
            FastZip fzip = new FastZip();
            string zipFileName = path + @"\Archives\php-7.1.2-nts-Win32-VC14-x64.zip";
            string targetDir = path + @"\php";
            fzip.ExtractZip(zipFileName, targetDir, null);
        }

        private void btnNginxSwitch_Click(object sender, EventArgs e)
        {
            string curDir = Environment.CurrentDirectory;
            string workDir = curDir + @"\nginx";
            string nginxBin = workDir + @"\nginx.exe";

            ProcessStartInfo startInfo = new ProcessStartInfo("nginx.exe");
            startInfo.WorkingDirectory = workDir;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            if (nginx == null)
            {
                // 启动
                btnNginxSwitch.Text = "正在启动";
                btnNginxSwitch.Enabled = false;
                nginx = Process.Start(startInfo);
            }
            else
            {
                // 停止
                startInfo.Arguments = "-s stop";
                btnNginxSwitch.Text = "正在停止";
                Process.Start(startInfo);
                btnNginxSwitch.Enabled = false;
            }
        }

        private void btnNginxRestart_Click(object sender, EventArgs e)
        {
            if (nginx != null)
            {
                string curDir = Environment.CurrentDirectory;
                string workDir = curDir + @"\nginx";
                string nginxBin = workDir + @"\nginx.exe";

                ProcessStartInfo startInfo = new ProcessStartInfo("nginx.exe");
                startInfo.WorkingDirectory = workDir;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = "-s reload";

                Process.Start(startInfo);
                btnNginxRestart.Enabled = false;
            }
        }

        private void btnMysqldSwitch_Click(object sender, EventArgs e)
        {

        }

        private void btnPhpCgiSwitch_Click(object sender, EventArgs e)
        {
            string curDir = Environment.CurrentDirectory;
            string workDir = curDir + @"\php";
            string phpcgiBin = workDir + @"\php-cgi.exe";
            string phpIni = workDir + @"\php.ini";

            string cgiHost = "127.0.0.1";
            int cgiPort = 9000;

            ProcessStartInfo startInfo = new ProcessStartInfo(phpcgiBin);
            startInfo.WorkingDirectory = workDir;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            if (phpcgi == null)
            {
                // 启动
                startInfo.Arguments = "-b " + cgiHost + ":" + cgiPort + " -c " + phpIni;

                btnPhpCgiSwitch.Text = "正在启动";
                btnPhpCgiSwitch.Enabled = false;
                phpcgi = Process.Start(startInfo);
            }
            else
            {
                // 停止
                startInfo.FileName = "taskkill.exe";
                startInfo.Arguments = "/F /PID " + phpcgi.Id + " /T";
                btnPhpCgiSwitch.Text = "正在停止";
                Process.Start(startInfo);
                btnPhpCgiSwitch.Enabled = false;
            }
        }

        private void cron_Tick(object sender, EventArgs e)
        {
            if (nginx != null)
            {
                try
                {
                    Process process = Process.GetProcessById(nginx.Id);
                    if (process != null)
                    {
                        btnNginxSwitch.Text = "停止";
                        btnNginxRestart.Enabled = true;
                        btnNginxSwitch.Enabled = true;
                        labelNginx.Text = nginx.Id + "";
                    }
                }
                catch (ArgumentException ex)
                {
                    this.nginx = null;
                    btnNginxSwitch.Text = "启动";
                    btnNginxSwitch.Enabled = true;
                    btnNginxRestart.Enabled = false;
                    labelNginx.Text ="     ";
                }
            }
            else
            {
                btnNginxSwitch.Text = "启动";
                btnNginxSwitch.Enabled = true;
                btnNginxRestart.Enabled = false;
                labelNginx.Text = "     ";
            }

            if (mysqld != null)
            {
                try
                {
                    Process process = Process.GetProcessById(mysqld.Id);
                    if (process != null)
                    {
                        btnMysqldSwitch.Text = "停止";
                        btnMysqldRestart.Enabled = true;
                        btnMysqldSwitch.Enabled = true;
                        labelMysqld.Text = mysqld.Id + "";
                    }
                }
                catch (ArgumentException ex)
                {
                    this.mysqld = null;
                    btnMysqldSwitch.Text = "启动";
                    btnMysqldSwitch.Enabled = true;
                    btnMysqldRestart.Enabled = false;
                    labelMysqld.Text = "     ";
                }
            }
            else
            {
                btnMysqldSwitch.Text = "启动";
                btnMysqldSwitch.Enabled = true;
                btnMysqldRestart.Enabled = false;
                labelMysqld.Text = "     ";
            }

            if (phpcgi != null)
            {
                try
                {
                    Process process = Process.GetProcessById(phpcgi.Id);
                    if (process != null)
                    {
                        btnPhpCgiSwitch.Text = "停止";
                        btnPhpCgiRestart.Enabled = true;
                        btnPhpCgiSwitch.Enabled = true;
                        labelPhpCgi.Text = phpcgi.Id + "";
                    }
                }
                catch (ArgumentException ex)
                {
                    this.phpcgi = null;
                    btnPhpCgiSwitch.Text = "启动";
                    btnPhpCgiSwitch.Enabled = true;
                    btnPhpCgiRestart.Enabled = false;
                    labelPhpCgi.Text = "     ";
                }
            }
            else
            {
                btnPhpCgiSwitch.Text = "启动";
                btnPhpCgiSwitch.Enabled = true;
                btnPhpCgiRestart.Enabled = false;
                labelPhpCgi.Text = "     ";
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
