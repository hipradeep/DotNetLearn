using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DotNetLearn.windowsform_mysql
{
    public partial class StudentNew : Form
    {
        public StudentNew()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MySqlConnection cn = new MySqlConnection("server=localhost;database=sakila;User ID=root;Password=cdac123");

            //cn.Open();

            //MySqlCommand cmd = new MySqlCommand("Select * from actor;", cn);

            //MySqlDataReader rdr = cmd.ExecuteReader();
            //BindingSource source = new BindingSource();
            //source.DataSource = rdr;

            //dataGridView1.DataSource = source;
            //// dataGridView1.DataBind();
            //cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
