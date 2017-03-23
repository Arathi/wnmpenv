using ICSharpCode.SharpZipLib.Zip;
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

namespace wnmpenv.WNMPanel
{
    public partial class FormMain : Form
    {
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
            string path = Environment.CurrentDirectory;
            FastZip fzip = new FastZip();
            string zipFileName = @"D:\Workspace\undsf\wnmpenv\WNMPanel\bin\Debug\Archives\php-7.1.2-nts-Win32-VC14-x64.zip";
            string targetDir = @"D:\Workspace\undsf\wnmpenv\WNMPanel\bin\Debug\php";
            string filter = null;
            fzip.ExtractZip(zipFileName, targetDir, filter);
        }
    }
}
