using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
