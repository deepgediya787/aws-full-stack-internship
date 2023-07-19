using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-I8VMEJ3;Initial Catalog=DESKTOP-I8VMEJ3;Integrated Security=True;Pooling=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into dbo values(@Name,@Email,@Contact,@feed) ", con);
               cmd.Parameters.AddWithValue("@Name",textBox1.Text);
               cmd.Parameters.AddWithValue("@Email",textBox2.Text);
               cmd.Parameters.AddWithValue("@Contact",Convert.ToInt64(textBox4.Text));
               cmd.Parameters.AddWithValue("@feed",textBox3.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                button1.BackColor = SystemColors.Window;
            
                
        }
    }
}
