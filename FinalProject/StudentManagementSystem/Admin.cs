using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Admin : Form
    {
        private DataAccess Da2 = new DataAccess();
        private DataSet Ds2 { get; set; }
        private string SqlQurey2 { get; set; }


        public Admin()
        {
            InitializeComponent();
            AutoGenarateID();
        }

        private void btnAdminShow_Click(object sender, EventArgs e)
        {
            this.SqlQurey2 = @"select * from admin;";
            Ds2 = this.Da2.ExecuteQuery(SqlQurey2);
            this.dgvAdminInfo.AutoGenerateColumns = false;
            this.dgvAdminInfo.DataSource = Ds2.Tables[0];
        }

        private bool InvalidToInsert() 
        {
            if (String.IsNullOrEmpty(this.txtAdminID.Text) || String.IsNullOrEmpty(this.txtAdminPass.Text) || String.IsNullOrEmpty(this.txtAdminName.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private bool InvalidToInsertStudent()
        {
            if (String.IsNullOrEmpty(this.txtActualStudentID.Text) || String.IsNullOrEmpty(this.txtUpdateStudentName.Text) || String.IsNullOrEmpty(this.txtUpdateStudentAge.Text) || String.IsNullOrEmpty(this.txtUpdateGaurdian.Text) || String.IsNullOrEmpty(this.txtUpdateStudentNumber.Text) || String.IsNullOrEmpty(this.txtUpdateStudentMail.Text) || String.IsNullOrEmpty(this.txtUpdateStudentAddress.Text) || String.IsNullOrEmpty(this.txtUpdateStudentFees.Text) || String.IsNullOrEmpty(this.txtUpdateStudentPassword.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private bool InvalidToInsertTeacher()
        {
            if (String.IsNullOrEmpty(this.txtTeacherId.Text) || String.IsNullOrEmpty(this.txtTeacherName.Text) || String.IsNullOrEmpty(this.txtTeacherAge.Text) || String.IsNullOrEmpty(this.txtGaurdianName.Text) || String.IsNullOrEmpty(this.txtTeacherNumber.Text) || String.IsNullOrEmpty(this.txtEmail.Text) || String.IsNullOrEmpty(this.txtAddress.Text) || String.IsNullOrEmpty(this.txtFees.Text) || String.IsNullOrEmpty(this.txtPassword.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnAdminOk_Click(object sender, EventArgs e)
        {
           

            try
            {
                bool decision = this.InvalidToInsert();
                if (decision)
                {
                    this.SqlQurey2 = @"select* from admin where id = '" + this.txtAdminID.Text + "';";
                   DataTable dt = this.Da2.ExecuteQueryTable(this.SqlQurey2);

                    if (dt.Rows.Count == 1)
                    {
                        //Update operation
                        this.SqlQurey2 = @"update admin
                                        set password ='"+this.txtAdminPass.Text+@"',
                                        name= '"+this.txtAdminName.Text+@"'
                                        where id ='"+this.txtAdminID.Text+"';";
                        int row = this.Da2.ExecuteUpdateQuery(SqlQurey2);
                        if (row == 1)
                        {
                            MessageBox.Show("Admin Data Update Successfull");

                            this.txtAdminPass.Text = "";
                            this.txtAdminName.Text = "";
                            AutoGenarateID();
                        }
                        else
                        {
                            MessageBox.Show("Admin Data Update Error");
                        }
                    }
                    else if (dt.Rows.Count==0)
                    {


                        //For Insert
                        this.SqlQurey2 = @"insert into admin
               values('" + this.txtAdminID.Text + "', '" + this.txtAdminPass.Text + "', '" + this.txtAdminName.Text + "');";

                        int row = this.Da2.ExecuteUpdateQuery(SqlQurey2);
                        if (row == 1)
                        {
                            MessageBox.Show("Admin insert Successfull");

                            this.txtAdminPass.Text = "";
                            this.txtAdminName.Text = "";
                            AutoGenarateID();
                        }
                        else
                        {
                            MessageBox.Show("Admin Data Insert Error");
                        }


                    }

                   
                }

                else
                {
                    MessageBox.Show("Please insert All the values");
                }             
            }


            catch (Exception exc)
            {
                MessageBox.Show(" Insert all The Values properly " +exc.Message.ToString());

            }
        }

        private void btnStudentUpdating_Click(object sender, EventArgs e)
        {
            tcAdministration.Visible = true;
            tcAdministration.SelectedIndex = 0;
        }

        private void btnTeacherUpdating_Click(object sender, EventArgs e)
        {
            tcAdministration.Visible = true;
            tcAdministration.SelectedIndex = 1;
        }

        private void btnAdminAdding_Click(object sender, EventArgs e)
        {
            tcAdministration.Visible = true;
            tcAdministration.SelectedIndex = 2;
            AutoGenarateID();
        }

        private void btnAdminUpdating_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            this.SqlQurey2 = @"select* from admin where id = '" + this.txtAdminSearch.Text + "';";
            Ds2 = this.Da2.ExecuteQuery(SqlQurey2);
            this.dgvAdminInfo.AutoGenerateColumns = false;
            this.dgvAdminInfo.DataSource = Ds2.Tables[0];
        }

        private void btnDeleteSearch_Click(object sender, EventArgs e)
        {
            this.SqlQurey2 = @"select* from admin where id = '" + this.txtDeleteSearch.Text + "';";
            Ds2 = this.Da2.ExecuteQuery(SqlQurey2);
            this.dgvDeleteUpdate.AutoGenerateColumns = false;
            this.dgvDeleteUpdate.DataSource = Ds2.Tables[0];
        }

        private void btnShowAllAdmin_Click(object sender, EventArgs e)
        {
            this.SqlQurey2 = @"select * from admin;";
            Ds2 = this.Da2.ExecuteQuery(SqlQurey2);
            this.dgvDeleteUpdate.AutoGenerateColumns = false;
            this.dgvDeleteUpdate.DataSource = Ds2.Tables[0];
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                
                string id = this.dgvDeleteUpdate.CurrentRow.Cells[0].Value.ToString();
                string name = this.dgvDeleteUpdate.CurrentRow.Cells[2].Value.ToString();
                this.SqlQurey2 = @"delete from admin where id='"+id+"';";
                int row = Da2.ExecuteUpdateQuery(SqlQurey2);
                if (row == 1)
                {
                    MessageBox.Show(name+" has been Successfully Remove");

                }
                else 
                {
                    MessageBox.Show("Fail Delate Operation ");
                }
                MessageBox.Show(id);
            }

            catch (Exception exc) 
            
            {
                MessageBox.Show("Error " + exc.Message.ToString());
            }
        }

        private void AutoGenarateID() 
        {
            this.SqlQurey2 = @"select * from admin order by id desc;";
            this.Ds2=this.Da2.ExecuteQuery(SqlQurey2);
            string previousId = this.Ds2.Tables[0].Rows[0][0].ToString();
            string[] temp = previousId.Split('a');
            int serial = Convert.ToInt32(temp[1]);
           
            string nextID = "a" + (++serial).ToString("000");
            this.txtAdminID.Text = nextID; ;
           
        
        }

        private void dgvAdminInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtAdminID.Text = this.dgvAdminInfo.CurrentRow.Cells[0].Value.ToString();
            this.txtAdminName.Text = this.dgvAdminInfo.CurrentRow.Cells[2].Value.ToString();
            this.txtAdminPass.Text = this.dgvAdminInfo.CurrentRow.Cells[1].Value.ToString();
        }

        private void tpAdmin_Click(object sender, EventArgs e)
        {
            AutoGenarateID();
        }

        private void dgvStudentUpdateDelete_DoubleClick(object sender, EventArgs e)
        {
            this.txtActualStudentID.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[0].Value.ToString();
            this.txtUpdateStudentName.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[1].Value.ToString();
            this.txtUpdateStudentAge.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[2].Value.ToString();
            this.txtUpdateGaurdian.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[3].Value.ToString();
            this.txtUpdateStudentNumber.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[4].Value.ToString();
            this.txtUpdateStudentMail.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[5].Value.ToString();
            this.txtUpdateStudentAddress.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[6].Value.ToString();
            this.txtUpdateStudentJoinDate.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[7].Value.ToString();
            this.txtUpdateStudentEndDate.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[8].Value.ToString();
            this.txtUpdateStudentFees.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[9].Value.ToString();
            this.txtUpdateStudentPassword.Text = this.dgvStudentUpdateDelete.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnStudentUpdateInfo_Click(object sender, EventArgs e)
        {
            this.SqlQurey2 = @"select * from studentinfo;";
            Ds2 = this.Da2.ExecuteQuery(SqlQurey2);
            this.dgvStudentUpdateDelete.AutoGenerateColumns = false;
            this.dgvStudentUpdateDelete.DataSource = Ds2.Tables[0];
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            this.SqlQurey2 = @"select* from studentinfo where id = '" + this.txtStudentSearch.Text + "';";
            Ds2 = this.Da2.ExecuteQuery(SqlQurey2);
            this.dgvStudentUpdateDelete.AutoGenerateColumns = false;
            this.dgvStudentUpdateDelete.DataSource = Ds2.Tables[0];
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string id = this.dgvStudentUpdateDelete.CurrentRow.Cells[0].Value.ToString();
                string name = this.dgvStudentUpdateDelete.CurrentRow.Cells[1].Value.ToString();
                this.SqlQurey2 = @"delete from studentinfo where id='" + id + "';";
                int row = Da2.ExecuteUpdateQuery(SqlQurey2);
                if (row == 1)
                {
                    MessageBox.Show(name + " has been Successfully Remove");

                }
                else
                {
                    MessageBox.Show("Fail Delate Operation ");
                }
                MessageBox.Show(id);
            }

            catch (Exception exc)

            {
                MessageBox.Show("Error " + exc.Message.ToString());
            }
        }

        

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool decision = this.InvalidToInsertStudent();
                if (decision)
                {
                    this.SqlQurey2 = @"select* from studentinfo where id = '" + this.txtActualStudentID.Text + "';";
                    DataTable dt = this.Da2.ExecuteQueryTable(this.SqlQurey2);

                    if (dt.Rows.Count == 1)
                    {
                        //Update operation
                        this.SqlQurey2 = @"update studentinfo
                                         set name ='"+this.txtUpdateStudentName.Text+@"',
                                         age = "+this.txtUpdateStudentAge.Text+@",
                                         gaurdian_name='"+this.txtUpdateGaurdian.Text+@"',
                                         number='"+this.txtUpdateStudentNumber.Text+@"',
                                         email='"+this.txtUpdateStudentMail.Text+@"',
                                         address='"+this.txtUpdateStudentAddress.Text+@"',
                                         join_date='"+this.txtUpdateStudentJoinDate.Text+@"',
                                         end_date='"+this.txtUpdateStudentEndDate.Text+@"',
                                         fee="+this.txtUpdateStudentFees.Text+@",
                                         password='"+this.txtUpdateStudentPassword.Text+@"'
                                         where id ='"+this.txtActualStudentID.Text+"';";
                        int row = this.Da2.ExecuteUpdateQuery(SqlQurey2);
                        if (row == 1)
                        {
                            MessageBox.Show("Student Data Update Successfull");
                            this.txtActualStudentID.Text = "";
                            this.txtAdminPass.Text = "";
                            this.txtAdminName.Text = "";
                            this.txtUpdateStudentName.Text = "";
                            this.txtUpdateStudentAge.Text = "";
                            this.txtUpdateGaurdian.Text = "";
                            this.txtUpdateStudentNumber.Text = "";
                            this.txtUpdateStudentMail.Text = "";
                            this.txtUpdateStudentAddress.Text = "";
                            this.txtUpdateStudentJoinDate.Text = "";
                            this.txtUpdateStudentEndDate.Text = "";
                            this.txtUpdateStudentFees.Text = "";
                            this.txtUpdateStudentPassword.Text = ""; 
                            
                        }
                        else
                        {
                            MessageBox.Show("Admin Data Update Error");
                        }
                    }
                    else if (dt.Rows.Count == 0)
                    {


                        //AlreadyInsert Inserted Data
                        
                        {
                            MessageBox.Show("This Student Data Already Inserted ");
                        }


                    }


                }

                else
                {
                    MessageBox.Show("Please insert All the values");
                }
            }


            catch (Exception exc)
            {
                MessageBox.Show(" Insert all The Values properly " + exc.Message.ToString());

            }
        }

        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            tcAdministration.Visible = true;
            tcAdministration.SelectedIndex = 3;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        private void btnTeacherUpdateDetails(object sender, EventArgs e)
        {
            this.SqlQurey2 = @"select * from teachertable;";
            Ds2 = this.Da2.ExecuteQuery(SqlQurey2);
            this.dvgTeacherUpdateDelete.AutoGenerateColumns = false;
            this.dvgTeacherUpdateDelete.DataSource = Ds2.Tables[0];
        }

        private void btnTeacherDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string id = this.dvgTeacherUpdateDelete.CurrentRow.Cells[0].Value.ToString();
                string name = this.dvgTeacherUpdateDelete.CurrentRow.Cells[1].Value.ToString();
                this.SqlQurey2 = @"delete from teachertable where id='" + id + "';";
                int row = Da2.ExecuteUpdateQuery(SqlQurey2);
                if (row == 1)
                {
                    MessageBox.Show(name + " has been Successfully Remove");

                }
                else
                {
                    MessageBox.Show("Fail Delate Operation ");
                }
                MessageBox.Show(id);
            }

            catch (Exception exc)

            {
                MessageBox.Show("Error " + exc.Message.ToString());
            }
        }

        private void btnTeacherSearch_Click(object sender, EventArgs e)
        {
            this.SqlQurey2 = @"select* from teachertable where id = '" + this.txtTeacherSearch.Text + "';";
            Ds2 = this.Da2.ExecuteQuery(SqlQurey2);
            this.dvgTeacherUpdateDelete.AutoGenerateColumns = false;
            this.dvgTeacherUpdateDelete.DataSource = Ds2.Tables[0];
        }

        private void btnTeacherUpdateData_Click(object sender, EventArgs e)
        {
            try
            {
                bool decision = this.InvalidToInsertTeacher();
                if (decision)
                {
                    this.SqlQurey2 = @"select* from teachertable where id = '" + this.txtTeacherId.Text + "';";
                    DataTable dt = this.Da2.ExecuteQueryTable(this.SqlQurey2);

                    if (dt.Rows.Count == 1)
                    {
                        //Update operation
                        this.SqlQurey2 = @"update teachertable
                                         set name ='" + this.txtTeacherName.Text + @"',
                                         age = " + this.txtTeacherAge.Text + @",
                                         gaurdian_name='" + this.txtGaurdianName.Text + @"',
                                         number='" + this.txtTeacherNumber.Text + @"',
                                         email='" + this.txtEmail.Text + @"',
                                         address='" + this.txtAddress.Text + @"',
                                          join_date='" + this.txtTeacherAdmissionDate.Text + @"',
                                        fee=" + this.txtFees.Text + @",
                                         password='" + this.txtPassword.Text + @"'
                                         where id ='" + this.txtTeacherId.Text+ "';";
                        int row = this.Da2.ExecuteUpdateQuery(SqlQurey2);
                        if (row == 1)
                        {
                            MessageBox.Show("Teacher Data Update Successfull");
                            this.txtTeacherId.Text = "";
                            this.txtAdminPass.Text = "";
                            this.txtAdminName.Text = "";
                            this.txtTeacherName.Text = "";
                            this.txtUpdateStudentAge.Text = "";
                            this.txtGaurdianName.Text = "";
                            this.txtTeacherNumber.Text = "";
                            this.txtEmail.Text = "";
                            this.txtAddress.Text = "";
                            this.txtUpdateStudentJoinDate.Text = "";
                            this.txtUpdateStudentEndDate.Text = "";
                            this.txtUpdateStudentFees.Text = "";
                            this.txtUpdateStudentPassword.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Admin Data Update Error");
                        }
                    }
                    else if (dt.Rows.Count == 0)
                    {


                        //AlreadyInsert Inserted Data

                        {
                            MessageBox.Show("This Teacher Data Already Inserted ");
                        }


                    }


                }

                else
                {
                    MessageBox.Show("Please insert All the values");
                }
            }


            catch (Exception exc)
            {
                MessageBox.Show(" Insert all The Values properly " + exc.Message.ToString());

            }
        }
    }
}
