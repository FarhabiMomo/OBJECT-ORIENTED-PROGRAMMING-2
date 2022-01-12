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
    public partial class ShowStudentInfo : Form
    {
        Login ll1 ;
        Student ssss;

        private DataAccess da1 = new DataAccess();
        private DataSet Ds2 { get; set; }
        private string sqlQurey1 { get; set; }

        public ShowStudentInfo(Login l1)
        {
            InitializeComponent();
            this.ll1 = l1;
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            this.tcStudentInfo.Visible = true;
            this.tcStudentInfo.SelectedIndex = 0;
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            this.tcStudentInfo.Visible = true;
            this.tcStudentInfo.SelectedIndex = 1;
              
        }  

        private void btnShow_Click(object sender, EventArgs e)
        {
           
            this.sqlQurey1 = @"select * from studentinfo where id='"+ll1.txtUserID.Text+"';";
            Ds2 = this.da1.ExecuteQuery(sqlQurey1);
           this.dgvShowInfo.AutoGenerateColumns = false;
            this.dgvShowInfo.DataSource = Ds2.Tables[0];
        }

        private void ShowStudentInfo_Load(object sender, EventArgs e)
        {
            txtExample.Text = ll1.txtUserID.Text;
        }
    }
}
