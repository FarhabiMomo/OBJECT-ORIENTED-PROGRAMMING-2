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
    public partial class ShowTeacherInfo : Form
    {
        Teacher teacherObj;
        Login loginObj;

        private DataAccess da1 = new DataAccess();
        private DataSet Ds2 { get; set; }
        private string sqlQurey1 { get; set; }
        private DataTable teacherData;
        private string className;

        public ShowTeacherInfo(Login l)
        {
            InitializeComponent();
            this.loginObj = l;
            this.sqlQurey1 = @"select * from teachertable where id='" + loginObj.txtUserID.Text + "';";
            Ds2 = this.da1.ExecuteQuery(sqlQurey1);
            this.teacherData = Ds2.Tables[0];
            this.className = teacherData.Rows[0].Field<string>(10).ToString();
        }

        private void btnTeacherInfo_Click(object sender, EventArgs e)
        {
            //this.sqlQurey1 = @"select * from teachertable where id='" + loginObj.txtUserID.Text + "';";
            //Ds2 = this.da1.ExecuteQuery(sqlQurey1);

            this.tcTeacherInfo.Visible = true;
            this.tcTeacherInfo.SelectedIndex = 0;
            //Show data using label
            this.teacherInfoTabControl.Visible = true;
            this.teacherInfoTabControl.SelectedIndex = 0;
            
            lblID.Text = teacherData.Rows[0].Field<string>(0).ToString();
            lblName.Text = teacherData.Rows[0].Field<string>(1).ToString();
            lblAge.Text = teacherData.Rows[0].Field<int>(2).ToString();
            lblNumber.Text = teacherData.Rows[0].Field<string>(3).ToString();
            lblAddress.Text = teacherData.Rows[0].Field<string>(4).ToString();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(teacherData.Rows[0].Field<string>(1).ToString());
            
            this.dgvShowInfo.AutoGenerateColumns = false;
            this.dgvShowInfo.DataSource = Ds2.Tables[0];
        }

        private void ShowTeacherInfo_Load(object sender, EventArgs e)
        {
             txtExample.Text = loginObj.txtUserID.Text;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            this.tcTeacherInfo.Visible = true;
            this.tcTeacherInfo.SelectedIndex = 1;
            //end_date = '" + this.txtTeacherFinishDate.Text + @"',

            //DataTable teacherData = Ds2.Tables[0];
            //string className = teacherData.Rows[0].Field<string>(10).ToString();

            string sqlQurey2 = @"select id, name from studentinfo where className='" + this.className + "';";
            Ds2 = this.da1.ExecuteQuery(sqlQurey2);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = Ds2.Tables[0];

        }
    }
}
