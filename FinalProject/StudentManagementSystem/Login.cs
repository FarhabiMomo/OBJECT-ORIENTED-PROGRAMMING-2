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


namespace StudentManagementSystem
{
    public partial class Login : Form
    {

        private DataAccess da3 = new DataAccess();
        private DataSet Ds3 { get; set; }
        private string sqlQurey3 { get; set; }
         DataTable dt = new DataTable();


        public Login()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         
        private void LoginButton_Click(object sender, EventArgs e)
        {

           

            try 
            {

                if (cmbUser.Text == "Admin")
                {
                    this.sqlQurey3 = @"select * from admin where id='" + this.txtUserID.Text + "' and password='" + this.txtPassword.Text + "';";

                    Ds3 = this.da3.ExecuteQuery(sqlQurey3);

                    if (Ds3.Tables[0].Rows.Count == 1)
                    {

                        MessageBox.Show("Successful Login");
                        Home fm1 = new Home();
                        fm1.Visible = true;

                    }
                }

                else if (cmbUser.Text=="Student") 
                {
                    
                    
                        this.sqlQurey3 = @"select * from studentinfo where id='" + this.txtUserID.Text + "' and password ='" + this.txtPassword.Text + "';";

                        Ds3 = this.da3.ExecuteQuery(sqlQurey3);

                        if (Ds3.Tables[0].Rows.Count == 1)
                        {

                            MessageBox.Show("Successful Login");
                            ShowStudentInfo ssi1 = new ShowStudentInfo(this);
                            ssi1.Visible = true;


                        }
                                     
                }

                else if (cmbUser.Text == "Teacher")
                {


                    this.sqlQurey3 = @"select * from teachertable where id='" + this.txtUserID.Text + "' and password ='" + this.txtPassword.Text + "';";

                    Ds3 = this.da3.ExecuteQuery(sqlQurey3);

                    if (Ds3.Tables[0].Rows.Count == 1)
                    {

                        MessageBox.Show("Successful Login");
                        ShowTeacherInfo t1 = new ShowTeacherInfo(this);                     
                        t1.Visible = true;


                    }

                }

                else
                {
                    MessageBox.Show("Wrong user");
                }
                

            }
            catch (Exception E1)
            {
                MessageBox.Show("Error");
            
            }


        }
        

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.txtUserID.Text = "";
            this.txtPassword.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
