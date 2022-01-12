
namespace StudentManagementSystem
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnFee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchFee = new System.Windows.Forms.Button();
            this.txtIdFee = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblfeeerror = new System.Windows.Forms.Label();
            this.lblfees = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlEducation = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpJoin = new System.Windows.Forms.DateTimePicker();
            this.btnSubmitStudentInfo = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmboxSelectDepartment = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlStudentInfo = new System.Windows.Forms.Panel();
            this.txtInputId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtGuardian = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcStudent = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvStudentsInfo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gaurdian_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.join_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAllInfo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlEducation.SuspendLayout();
            this.pnlStudentInfo.SuspendLayout();
            this.tcStudent.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAddStudent.Location = new System.Drawing.Point(87, 136);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(84, 82);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackColor = System.Drawing.Color.DarkViolet;
            this.btnSearchStudent.Location = new System.Drawing.Point(200, 136);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(84, 82);
            this.btnSearchStudent.TabIndex = 2;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnFee
            // 
            this.btnFee.BackColor = System.Drawing.Color.DarkViolet;
            this.btnFee.Location = new System.Drawing.Point(305, 136);
            this.btnFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(84, 82);
            this.btnFee.TabIndex = 3;
            this.btnFee.Text = "Fee";
            this.btnFee.UseVisualStyleBackColor = false;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Information";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.lblfeeerror);
            this.tabPage4.Controls.Add(this.lblfees);
            this.tabPage4.Controls.Add(this.label63);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(1335, 670);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Fee";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchFee);
            this.groupBox1.Controls.Add(this.txtIdFee);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(400, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(495, 104);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Fee";
            // 
            // btnSearchFee
            // 
            this.btnSearchFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchFee.Location = new System.Drawing.Point(340, 36);
            this.btnSearchFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchFee.Name = "btnSearchFee";
            this.btnSearchFee.Size = new System.Drawing.Size(101, 36);
            this.btnSearchFee.TabIndex = 2;
            this.btnSearchFee.Text = "Search";
            this.btnSearchFee.UseVisualStyleBackColor = true;
            // 
            // txtIdFee
            // 
            this.txtIdFee.Location = new System.Drawing.Point(177, 41);
            this.txtIdFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdFee.Name = "txtIdFee";
            this.txtIdFee.Size = new System.Drawing.Size(126, 25);
            this.txtIdFee.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Student ID :";
            // 
            // lblfeeerror
            // 
            this.lblfeeerror.AutoSize = true;
            this.lblfeeerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeeerror.ForeColor = System.Drawing.Color.Red;
            this.lblfeeerror.Location = new System.Drawing.Point(932, 102);
            this.lblfeeerror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfeeerror.Name = "lblfeeerror";
            this.lblfeeerror.Size = new System.Drawing.Size(0, 25);
            this.lblfeeerror.TabIndex = 28;
            // 
            // lblfees
            // 
            this.lblfees.AutoSize = true;
            this.lblfees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfees.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblfees.Location = new System.Drawing.Point(557, 175);
            this.lblfees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfees.Name = "lblfees";
            this.lblfees.Size = new System.Drawing.Size(0, 26);
            this.lblfees.TabIndex = 27;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label63.Location = new System.Drawing.Point(440, 24);
            this.label63.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(431, 66);
            this.label63.TabIndex = 24;
            this.label63.Text = "Student Fees";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.Controls.Add(this.pnlEducation);
            this.tabPage1.Controls.Add(this.pnlStudentInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1335, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Student";
            // 
            // pnlEducation
            // 
            this.pnlEducation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEducation.Controls.Add(this.txtPassword);
            this.pnlEducation.Controls.Add(this.label17);
            this.pnlEducation.Controls.Add(this.dtpEnd);
            this.pnlEducation.Controls.Add(this.label10);
            this.pnlEducation.Controls.Add(this.label9);
            this.pnlEducation.Controls.Add(this.dtpJoin);
            this.pnlEducation.Controls.Add(this.btnSubmitStudentInfo);
            this.pnlEducation.Controls.Add(this.label14);
            this.pnlEducation.Controls.Add(this.txtFees);
            this.pnlEducation.Controls.Add(this.label13);
            this.pnlEducation.Controls.Add(this.cmboxSelectDepartment);
            this.pnlEducation.Controls.Add(this.label11);
            this.pnlEducation.Location = new System.Drawing.Point(691, 36);
            this.pnlEducation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEducation.Name = "pnlEducation";
            this.pnlEducation.Size = new System.Drawing.Size(592, 531);
            this.pnlEducation.TabIndex = 1;
            this.pnlEducation.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(171, 422);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(136, 30);
            this.txtPassword.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label17.Location = new System.Drawing.Point(22, 422);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 25);
            this.label17.TabIndex = 27;
            this.label17.Text = "Password";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(171, 340);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(342, 25);
            this.dtpEnd.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Location = new System.Drawing.Point(22, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Location = new System.Drawing.Point(22, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Join Date:";
            // 
            // dtpJoin
            // 
            this.dtpJoin.CustomFormat = "yyyy-MM-dd";
            this.dtpJoin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoin.Location = new System.Drawing.Point(171, 251);
            this.dtpJoin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpJoin.Name = "dtpJoin";
            this.dtpJoin.Size = new System.Drawing.Size(342, 25);
            this.dtpJoin.TabIndex = 23;
            // 
            // btnSubmitStudentInfo
            // 
            this.btnSubmitStudentInfo.Location = new System.Drawing.Point(429, 462);
            this.btnSubmitStudentInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmitStudentInfo.Name = "btnSubmitStudentInfo";
            this.btnSubmitStudentInfo.Size = new System.Drawing.Size(84, 35);
            this.btnSubmitStudentInfo.TabIndex = 22;
            this.btnSubmitStudentInfo.Text = "Submit";
            this.btnSubmitStudentInfo.UseVisualStyleBackColor = true;
            this.btnSubmitStudentInfo.Click += new System.EventHandler(this.btnSubmitStudentInfo_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label14.Location = new System.Drawing.Point(20, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 25);
            this.label14.TabIndex = 10;
            this.label14.Text = "Class Fees";
            // 
            // txtFees
            // 
            this.txtFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.Location = new System.Drawing.Point(171, 122);
            this.txtFees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(136, 30);
            this.txtFees.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(-1, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 22);
            this.label13.TabIndex = 7;
            this.label13.Text = "Education Details";
            // 
            // cmboxSelectDepartment
            // 
            this.cmboxSelectDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxSelectDepartment.FormattingEnabled = true;
            this.cmboxSelectDepartment.Items.AddRange(new object[] {
            "one ",
            "two",
            "three",
            "four",
            "five"});
            this.cmboxSelectDepartment.Location = new System.Drawing.Point(171, 49);
            this.cmboxSelectDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboxSelectDepartment.Name = "cmboxSelectDepartment";
            this.cmboxSelectDepartment.Size = new System.Drawing.Size(136, 33);
            this.cmboxSelectDepartment.TabIndex = 6;
            this.cmboxSelectDepartment.Text = "    Select";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Location = new System.Drawing.Point(22, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Class";
            // 
            // pnlStudentInfo
            // 
            this.pnlStudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudentInfo.Controls.Add(this.txtInputId);
            this.pnlStudentInfo.Controls.Add(this.label16);
            this.pnlStudentInfo.Controls.Add(this.btnNext);
            this.pnlStudentInfo.Controls.Add(this.txtEmail);
            this.pnlStudentInfo.Controls.Add(this.label8);
            this.pnlStudentInfo.Controls.Add(this.txtAddress);
            this.pnlStudentInfo.Controls.Add(this.txtNumber);
            this.pnlStudentInfo.Controls.Add(this.txtGuardian);
            this.pnlStudentInfo.Controls.Add(this.txtAge);
            this.pnlStudentInfo.Controls.Add(this.txtStudentName);
            this.pnlStudentInfo.Controls.Add(this.label7);
            this.pnlStudentInfo.Controls.Add(this.label6);
            this.pnlStudentInfo.Controls.Add(this.label5);
            this.pnlStudentInfo.Controls.Add(this.label4);
            this.pnlStudentInfo.Controls.Add(this.label3);
            this.pnlStudentInfo.Controls.Add(this.label2);
            this.pnlStudentInfo.Location = new System.Drawing.Point(7, 36);
            this.pnlStudentInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStudentInfo.Name = "pnlStudentInfo";
            this.pnlStudentInfo.Size = new System.Drawing.Size(649, 531);
            this.pnlStudentInfo.TabIndex = 0;
            // 
            // txtInputId
            // 
            this.txtInputId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtInputId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputId.Location = new System.Drawing.Point(125, 59);
            this.txtInputId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInputId.Name = "txtInputId";
            this.txtInputId.ReadOnly = true;
            this.txtInputId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInputId.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputId.Size = new System.Drawing.Size(185, 35);
            this.txtInputId.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label16.Location = new System.Drawing.Point(8, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 25);
            this.label16.TabIndex = 14;
            this.label16.Text = "ID :";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(528, 462);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 35);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(126, 334);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(381, 35);
            this.txtEmail.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Location = new System.Drawing.Point(8, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 50);
            this.label8.TabIndex = 11;
            this.label8.Text = "Gauardian\r\nName :";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(126, 399);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(381, 98);
            this.txtAddress.TabIndex = 10;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(126, 275);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(213, 35);
            this.txtNumber.TabIndex = 9;
            // 
            // txtGuardian
            // 
            this.txtGuardian.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGuardian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardian.Location = new System.Drawing.Point(137, 198);
            this.txtGuardian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGuardian.Name = "txtGuardian";
            this.txtGuardian.Size = new System.Drawing.Size(239, 35);
            this.txtGuardian.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(470, 65);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(84, 35);
            this.txtAge.TabIndex = 7;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(126, 122);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStudentName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStudentName.Size = new System.Drawing.Size(214, 35);
            this.txtStudentName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Location = new System.Drawing.Point(388, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Age :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(3, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(8, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(3, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student\'s Personal Information";
            // 
            // tcStudent
            // 
            this.tcStudent.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tcStudent.Controls.Add(this.tabPage1);
            this.tcStudent.Controls.Add(this.tabPage3);
            this.tcStudent.Controls.Add(this.tabPage4);
            this.tcStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcStudent.Location = new System.Drawing.Point(14, 290);
            this.tcStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcStudent.Name = "tcStudent";
            this.tcStudent.SelectedIndex = 0;
            this.tcStudent.Size = new System.Drawing.Size(1343, 706);
            this.tcStudent.TabIndex = 7;
            this.tcStudent.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage3.Controls.Add(this.dgvStudentsInfo);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(1335, 670);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search Student";
            // 
            // dgvStudentsInfo
            // 
            this.dgvStudentsInfo.AllowUserToAddRows = false;
            this.dgvStudentsInfo.AllowUserToDeleteRows = false;
            this.dgvStudentsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.age,
            this.gaurdian_name,
            this.number,
            this.join_date,
            this.end_date,
            this.fee,
            this.password});
            this.dgvStudentsInfo.Location = new System.Drawing.Point(45, 256);
            this.dgvStudentsInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStudentsInfo.Name = "dgvStudentsInfo";
            this.dgvStudentsInfo.ReadOnly = true;
            this.dgvStudentsInfo.RowHeadersWidth = 51;
            this.dgvStudentsInfo.RowTemplate.Height = 24;
            this.dgvStudentsInfo.Size = new System.Drawing.Size(1202, 380);
            this.dgvStudentsInfo.TabIndex = 18;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Student ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Student Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // gaurdian_name
            // 
            this.gaurdian_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gaurdian_name.DataPropertyName = "gaurdian_name";
            this.gaurdian_name.HeaderText = "Gaurdian Name";
            this.gaurdian_name.MinimumWidth = 6;
            this.gaurdian_name.Name = "gaurdian_name";
            this.gaurdian_name.ReadOnly = true;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number.DataPropertyName = "name";
            this.number.HeaderText = "Student Number";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // join_date
            // 
            this.join_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.join_date.DataPropertyName = "join_date";
            this.join_date.HeaderText = "Admission Date";
            this.join_date.MinimumWidth = 6;
            this.join_date.Name = "join_date";
            this.join_date.ReadOnly = true;
            // 
            // end_date
            // 
            this.end_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.end_date.DataPropertyName = "end_date";
            this.end_date.HeaderText = "Finish Date";
            this.end_date.MinimumWidth = 6;
            this.end_date.Name = "end_date";
            this.end_date.ReadOnly = true;
            // 
            // fee
            // 
            this.fee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fee.DataPropertyName = "fee";
            this.fee.HeaderText = "Fee";
            this.fee.MinimumWidth = 6;
            this.fee.Name = "fee";
            this.fee.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "User Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAllInfo);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(400, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(619, 138);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student\'s";
            // 
            // btnAllInfo
            // 
            this.btnAllInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAllInfo.Location = new System.Drawing.Point(425, 29);
            this.btnAllInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAllInfo.Name = "btnAllInfo";
            this.btnAllInfo.Size = new System.Drawing.Size(105, 92);
            this.btnAllInfo.TabIndex = 4;
            this.btnAllInfo.Text = "All Info";
            this.btnAllInfo.UseVisualStyleBackColor = true;
            this.btnAllInfo.Click += new System.EventHandler(this.btnAllInfo_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(310, 81);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(310, 29);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 41);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(152, 55);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(123, 28);
            this.txtId.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(26, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "Student ID :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label18.Location = new System.Drawing.Point(389, 19);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(517, 66);
            this.label18.TabIndex = 16;
            this.label18.Text = "student SEARCH";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 999);
            this.Controls.Add(this.tcStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFee);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.pnlEducation.ResumeLayout(false);
            this.pnlEducation.PerformLayout();
            this.pnlStudentInfo.ResumeLayout(false);
            this.pnlStudentInfo.PerformLayout();
            this.tcStudent.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlStudentInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtGuardian;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tcStudent;
        private System.Windows.Forms.Panel pnlEducation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmboxSelectDepartment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblfeeerror;
        private System.Windows.Forms.Label lblfees;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSubmitStudentInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchFee;
        private System.Windows.Forms.TextBox txtIdFee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpJoin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.DataGridView dgvStudentsInfo;
        private System.Windows.Forms.Button btnAllInfo;
        private System.Windows.Forms.TextBox txtInputId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gaurdian_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn join_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}