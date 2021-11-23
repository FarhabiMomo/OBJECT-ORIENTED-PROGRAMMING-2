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
using System.Data.Sql;

namespace WfaLoginForm
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

        private void btnClick_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-TQ3QIF0\MOMOSQL;Initial Catalog=varfall;User ID=sa;Password=MomoFarhabi15");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand("select * from Table_var;", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            this.label1.Text = ds.Tables[0].Rows[0][0].ToString();
            this.label2.Text = ds.Tables[0].Rows[0][2].ToString();
            sqlcon.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string query = "select * from Table_var where id='"+this.txtId.Text+"'and password='"+this.txtPassword.Text+"';";
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-TQ3QIF0\MOMOSQL;Initial Catalog=varfall;User ID=sa;Password=MomoFarhabi15");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(query, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count==1)
                  MessageBox.Show("LogIn Confirmed");
            else
            {
                    MessageBox.Show("LogIn Invalid");

            }

            // int count = 0;
            // while (count < ds.Tables[0].Rows.Count) {

            //     if (this.txtId.Text == ds.Tables[0].Rows[0][0].ToString()  && this.txtPassword.Text == ds.Tables[0].Rows[0][2].ToString() )
            //    MessageBox.Show("LogIn Confirmed");

            //    count++;
            // }


            sqlcon.Close();
        }
    }
}

