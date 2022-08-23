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
            button1.Text = "Button";
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Button Cliked";

            MessageBox.Show(textBox1.Text);
        }

        

        private void btn_next_form_Click(object sender, EventArgs e)
        {
            (new NextForm()).Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
