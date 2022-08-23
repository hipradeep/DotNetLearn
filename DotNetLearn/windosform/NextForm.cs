using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetLearn.windosform
{
    public partial class NextForm : Form
    {
        public NextForm()
        {
            InitializeComponent();

        }

        private void NextForm_Load(object sender, EventArgs e)
        {
            
               
                listBox2.Items.Add("Four");
                listBox2.Items.Add("Five");
                //Combobox
               
                combo_box.Items.Add("Thurday");
                combo_box.Items.Add("Friday");
                combo_box.Items.Add("Saterday");
            
        }

        private void combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(combo_box.SelectedItem.ToString()+" Selected");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox2.SelectedItem.ToString() + " Selected");
        }
    }
}
