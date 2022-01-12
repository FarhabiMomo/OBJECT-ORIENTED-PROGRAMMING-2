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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        
        //this.cmboxDepartment.Items.Add(this.txtCreateDepartment.Text);



        

        private void combxCourseDuration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCreateDepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCourseFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string sql = "insert into course values('" + this.cmbClass.Text + "','" + this.cmb1.Text + "','" + this.cmb2.Text + "','" + this.cmb3.Text + "')";

            if (db.ExecuteUpdateQuery(sql) == 1)
            {
                MessageBox.Show("Course addedd successfully");
            }
        }


        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbClass.Text == "Class_1")
            {
                this.cmb1.Text = "Bangla";
                this.cmb2.Text = "English";
                this.cmb3.Text = "Math";
            }

            else if (this.cmbClass.Text == "Class_2")
            {
                this.cmb1.Text = "Science";
                this.cmb2.Text = "English";
                this.cmb3.Text = "Math";
            }

            else if (this.cmbClass.Text == "Class_3")
            {
                this.cmb1.Text = "Science";
                this.cmb2.Text = "Religion";
                this.cmb3.Text = "Math";
            }
        }

        private void Course_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Course_Load(object sender, EventArgs e)
        {

        }
    }
}
