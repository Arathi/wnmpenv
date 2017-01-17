using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wnmpenv.PhpIniParser;

namespace wnmpenv.WNMPanel
{
    public partial class FormPhpIniParser : Form
    {
        private PhpIni php_ini;

        public FormPhpIniParser()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog.FileName;
                php_ini = new PhpIni(openFileDialog.FileName);
                int result = php_ini.Parse();
                if (result == 0)
                {
                    BuildContextMenuStrip();
                    btnRebuild.Enabled = true;
                    btnAlter.Enabled = true;
                }
            }
        }

        private void btnRebuild_Click(object sender, EventArgs e)
        {
            if (php_ini == null)
            {
                return;
            }

            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string file = saveFileDialog.FileName;
                php_ini.Rebuild();
                php_ini.Save(file);
                MessageBox.Show("保存成功", "提示");
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            int result = php_ini.Parse();
            if (result != PhpIni.PARSE_SUCCESS)
            {
                MessageBox.Show("解析失败", "错误");
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            // contextMenuStrip
            // contextMenuStrip.Show();
        }

        private void BuildContextMenuStrip()
        {
            contextMenuStrip.Items.Clear();
            foreach (Section section in php_ini.Sections)
            {
                ToolStripDropDownItem item = new ToolStripMenuItem();
                // ToolStripMenuItem menuItem = new ToolStripMenuItem(section.Name);
                // ToolStripDropDown item = new ToolStripDropDown();
                item.Text = section.Name;
                if (section.Properties.Count()>0)
                {
                    foreach (int propertyIndex in section.PropertyNameIndex.Values)
                    {
                        Property property = section.Properties[propertyIndex];
                        if (property.DescriptionOnly) continue;

                        ToolStripDropDownItem subitem = new ToolStripMenuItem();
                        subitem.Text = property.Key;
                        subitem.ToolTipText = property.Description;
                        item.DropDownItems.Add(property.Key);
                    }
                    if (section.Name == "PHP")
                    {
                        SectionPHP secPhp = (SectionPHP)section;
                        ToolStripDropDownItem subitem = new ToolStripMenuItem();
                        subitem.Text = "extensions";
                        foreach (string extName in secPhp.Extensions.Keys)
                        {
                            subitem.DropDownItems.Add(extName);
                        }
                        item.DropDownItems.Add(subitem);
                    }
                }
                contextMenuStrip.Items.Add(item);
            }
        }
    }
}
