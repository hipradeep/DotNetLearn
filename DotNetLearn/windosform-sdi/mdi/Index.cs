using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetLearn.windosform.mdi
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
           // this.IsMdiContainer = true;
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting s = new Setting();
            s.MdiParent = this;
            s.Show();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools t = new Tools();
            t.MdiParent = this;
            t.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
