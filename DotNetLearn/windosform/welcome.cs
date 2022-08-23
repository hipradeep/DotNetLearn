using System;
using System.Windows.Forms;

namespace DotNetLearn.windosform
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            //to chnage background color of form
            //this.BackColor=System.Drawing.Color.Cyan;
            //this.BackColor=Color.Red;
            this.Text = "Welcome To DotNet";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
