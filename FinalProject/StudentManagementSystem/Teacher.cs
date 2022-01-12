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
    public partial class Teacher : Form
    {
        private DataAccess Da = new DataAccess();
        private DataSet Ds2 { get; set; }
        private string sqlQurey { get; set; }
        public Teacher()
        {
            InitializeComponent();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            tcTeacher.Visible = true;
            tcTeacher.SelectedIndex = 0;
        }

        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            tcTeacher.Visible = true;
            tcTeacher.SelectedIndex = 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtTeacherName.Text) || String.IsNullOrEmpty(this.txtGuardian.Text) || String.IsNullOrEmpty(this.txtAge.Text) || String.IsNullOrEmpty(this.txtNumber.Text) || String.IsNullOrEmpty(this.txtEmail.Text) || String.IsNullOrEmpty(this.txtAddress.Text))
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
            this.sqlQurey = @"select* from teachertable where id = '" + this.txtId.Text + "';";
            Ds2 = this.Da.ExecuteQuery(sqlQurey);
            this.dgvTeacherInfo.AutoGenerateColumns = false;
            this.dgvTeacherInfo.DataSource = Ds2.Tables[0];
        }

        private void btnAllInfo_Click(object sender, EventArgs e)
        {
            this.sqlQurey = @"select* from teachertable where id = '" + this.txtId.Text + "';";
            Ds2 = this.Da.ExecuteQuery(sqlQurey);
            this.dgvTeacherInfo.AutoGenerateColumns = false;
            this.dgvTeacherInfo.DataSource = Ds2.Tables[0];
        }

        private bool InvalidToInsert()
        {
            if (String.IsNullOrEmpty(this.txtInputId.Text) || String.IsNullOrEmpty(this.txtTeacherName.Text) || String.IsNullOrEmpty(this.txtAge.Text) || String.IsNullOrEmpty(this.txtGuardian.Text) || String.IsNullOrEmpty(this.txtNumber.Text) || String.IsNullOrEmpty(this.txtEmail.Text) || String.IsNullOrEmpty(this.txtAddress.Text) || String.IsNullOrEmpty(this.txtFees.Text) || String.IsNullOrEmpty(this.txtPassword.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnSubmitTeacherInfo_Click(object sender, EventArgs e)
        {
            try
            {
                AutoGenarateID();
                bool decision = InvalidToInsert();
                if (decision)
                {
                    this.sqlQurey = @"insert into teachertable
         values('" + this.txtInputId.Text + "', '" + this.txtTeacherName.Text + "'," + this.txtAge.Text + ", '" + this.txtGuardian.Text + "', '" + txtNumber.Text + "', '" + this.txtEmail.Text + "', '" + this.txtAddress.Text + "', '" + this.dtpJoin.Text + "', " + this.txtFees.Text + ",'" + this.txtPassword.Text + "', '" + this.cmboxSelectDepartment.SelectedValue + "');";

                    int row = this.Da.ExecuteUpdateQuery(sqlQurey);
                    if (row == 1)
                    {
                        MessageBox.Show("teacher insert Successfull");
                        this.txtTeacherName.Text = "";
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
                        MessageBox.Show("Teacher Data Insert Error");
                    }

                }
                else
                {
                    MessageBox.Show("Insert All the values");
                }


            }

            catch (Exception eee)

            {
                MessageBox.Show(" Insert all The Values properly " + eee.Message.ToString());

            }
        }


        private void AutoGenarateID()
        {
            this.sqlQurey = @"select * from teachertable order by id desc;";
            this.Ds2 = this.Da.ExecuteQuery(sqlQurey);
            string previousId = this.Ds2.Tables[0].Rows[0][0].ToString();
            string[] temp = previousId.Split('t');
            int serial = Convert.ToInt32(temp[1]);
            string nextID = "t" + (++serial).ToString("000");
            this.txtInputId.Text = nextID;
            // MessageBox.Show(nextID);

        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
