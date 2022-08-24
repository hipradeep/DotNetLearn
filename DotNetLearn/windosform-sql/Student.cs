using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetLearn.windosform_sql
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server=LAPTOP-FDS4NDV9\\SQLEXPRESS;database=HiPradeep;User ID=sa;Password=cdac123");
            cn.Open();
            //sql queries
            SqlCommand cmd = new SqlCommand("Select * from student;", cn);
          
            SqlDataReader rdr = cmd.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = rdr;
            dataGridView1.DataSource = source;

            //dataGridView1.DataBind();

            cn.Close();
        }
    
    }
}
