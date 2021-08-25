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

namespace Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RKTL3GM;Initial Catalog=Registration;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Registration(ID, Surname, FirstName, Gender) values('"+ txtID.Text + "', '" + txtSurname.Text +"', '" + txtFirstName.Text + "', '"+ txtGender.Text +"')", con);

            int i = cmd.ExecuteNonQuery();
            if(i!=0)
            {
                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
