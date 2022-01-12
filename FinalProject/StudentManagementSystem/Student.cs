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

namespace StudentManagementSystem
{
    public partial class Student : Form
    {
       

        private DataAccess Da = new DataAccess();
        private DataSet Ds1 { get; set; }
        private string sqlQurey { get; set; }


        public Student()
        {
            InitializeComponent();
            AutoGenarateID();
        }     

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            tcStudent.Visible = true;
            tcStudent.SelectedIndex = 0;
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            tcStudent.Visible = true;
            tcStudent.SelectedIndex = 1;
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            tcStudent.Visible = true;
            tcStudent.SelectedIndex = 2;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.txtStudentName.Text) || String.IsNullOrEmpty(this.txtGuardian.Text) || String.IsNullOrEmpty(this.txtAge.Text) || String.IsNullOrEmpty(this.txtNumber.Text) || String.IsNullOrEmpty(this.txtEmail.Text) || String.IsNullOrEmpty(this.txtAddress.Text))
            {
                this.pnlEducation.Visible = false;
                MessageBox.Show("Please Insert All the Values");
            }
            else 
            {
                this.pnlEducation.Visible = true;
                MessageBox.Show("Now Please Complete rest of this form");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            this.sqlQurey=@"select* from studentinfo where id = '"+this.txtId.Text +"';";
            Ds1 = this.Da.ExecuteQuery(sqlQurey);
            this.dgvStudentsInfo.AutoGenerateColumns = false;
            this.dgvStudentsInfo.DataSource = Ds1.Tables[0];

        }

        private void btnAllInfo_Click_1(object sender, EventArgs e)
        {
            this.sqlQurey = @"select * from studentinfo;";

            Ds1 = this.Da.ExecuteQuery(sqlQurey);
            this.dgvStudentsInfo.AutoGenerateColumns = false;
            this.dgvStudentsInfo.DataSource = Ds1.Tables[0];
        }

        private bool InvalidToInsert()
        {
            if (String.IsNullOrEmpty(this.txtInputId.Text) || String.IsNullOrEmpty(this.txtStudentName.Text) || String.IsNullOrEmpty(this.txtAge.Text) || String.IsNullOrEmpty(this.txtGuardian.Text) || String.IsNullOrEmpty(this.txtNumber.Text) || String.IsNullOrEmpty(this.txtEmail.Text) || String.IsNullOrEmpty(this.txtAddress.Text) || String.IsNullOrEmpty(this.txtFees.Text) || String.IsNullOrEmpty(this.txtPassword.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnSubmitStudentInfo_Click(object sender, EventArgs e)
        {
            try
            {
                bool decision = InvalidToInsert();
                if (decision) 
                {
                    this.sqlQurey = @"insert into studentinfo
         values('" + this.txtInputId.Text + "', '" + this.txtStudentName.Text + "'," + this.txtAge.Text + ", '" + this.txtGuardian.Text + "', '" + txtNumber.Text + "', '" + this.txtEmail.Text + "', '" + this.txtAddress.Text + "', '" + this.dtpJoin.Text + "', '" + this.dtpEnd.Text + "', " + this.txtFees.Text + ",'" + this.txtPassword.Text + "');";

                    int row = this.Da.ExecuteUpdateQuery(sqlQurey);
                    if (row == 1)
                    {
                        MessageBox.Show("Student insert Successfull");
                        this.txtStudentName.Text = "";
                        this.txtAge.Text = "";
                        this.txtGuardian.Text = "";
                        this.txtNumber.Text = "";
                        this.txtEmail.Text = "";
                        this.txtAddress.Text = "";
                        this.txtFees.Text = "";
                        this.txtPassword.Text = "";

                        AutoGenarateID();
                    }
                    else
                    {
                        MessageBox.Show("Student Data Insert Error");
                    }

                }
                else
                {
                    MessageBox.Show("Insert All the values");
                }


            }

            catch (Exception eee) 
            
            {
                MessageBox.Show(" Insert all The Values properly "+eee.Message.ToString());

            }
        }
        private void AutoGenarateID()
        {
            this.sqlQurey = @"select * from studentinfo order by id desc;";
            this.Ds1 = this.Da.ExecuteQuery(sqlQurey);
            string previousId = this.Ds1.Tables[0].Rows[0][0].ToString();
            string[] temp = previousId.Split('s');
            int serial = Convert.ToInt32(temp[1]);
            string nextID = "s" + (++serial).ToString("000");
            this.txtInputId.Text = nextID;
           // MessageBox.Show(nextID);

        }
    }
}
