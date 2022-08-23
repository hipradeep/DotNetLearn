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
            // MessageBox.Show(listBox2.SelectedItem.ToString() + " Selected");
            StringBuilder sb = new StringBuilder();
           foreach(object item in listBox2.SelectedItems)
            {
                sb.Append(item.ToString() + " ");
            }
            MessageBox.Show(sb.ToString());
        }

        private void clear_selection_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btn_select_img_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                // image file path  
                pic_label.Text = open.FileName;
            }
        }
    }
}
