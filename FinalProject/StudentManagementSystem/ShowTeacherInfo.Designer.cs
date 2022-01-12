
namespace StudentManagementSystem
{
    partial class ShowTeacherInfo
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
            this.tcTeacherInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvShowInfo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardian_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.join_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label63 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStudentInformation = new System.Windows.Forms.Label();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnTeacherInfo = new System.Windows.Forms.Button();
            this.teacherInfoTabControl = new System.Windows.Forms.TabControl();
            this.tabPageInformation = new System.Windows.Forms.TabPage();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageMarks = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tcTeacherInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.teacherInfoTabControl.SuspendLayout();
            this.tabPageInformation.SuspendLayout();
            this.tabPageMarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTeacherInfo
            // 
            this.tcTeacherInfo.Controls.Add(this.tabPage1);
            this.tcTeacherInfo.Controls.Add(this.tabPage2);
            this.tcTeacherInfo.Location = new System.Drawing.Point(219, 454);
            this.tcTeacherInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tcTeacherInfo.Name = "tcTeacherInfo";
            this.tcTeacherInfo.SelectedIndex = 0;
            this.tcTeacherInfo.Size = new System.Drawing.Size(1113, 548);
            this.tcTeacherInfo.TabIndex = 3;
            this.tcTeacherInfo.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.Controls.Add(this.txtExample);
            this.tabPage1.Controls.Add(this.btnShow);
            this.tabPage1.Controls.Add(this.dgvShowInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage1.Size = new System.Drawing.Size(1105, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            // 
            // txtExample
            // 
            this.txtExample.Location = new System.Drawing.Point(164, 29);
            this.txtExample.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtExample.Name = "txtExample";
            this.txtExample.Size = new System.Drawing.Size(224, 26);
            this.txtExample.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(16, 15);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(84, 55);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvShowInfo
            // 
            this.dgvShowInfo.AllowUserToAddRows = false;
            this.dgvShowInfo.AllowUserToDeleteRows = false;
            this.dgvShowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.age,
            this.number,
            this.address,
            this.guardian_name,
            this.join_date});
            this.dgvShowInfo.Location = new System.Drawing.Point(16, 195);
            this.dgvShowInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvShowInfo.Name = "dgvShowInfo";
            this.dgvShowInfo.ReadOnly = true;
            this.dgvShowInfo.RowHeadersWidth = 51;
            this.dgvShowInfo.RowTemplate.Height = 24;
            this.dgvShowInfo.Size = new System.Drawing.Size(1080, 282);
            this.dgvShowInfo.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Teacher ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
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
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "Number";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // guardian_name
            // 
            this.guardian_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.guardian_name.DataPropertyName = "gaurdian_name";
            this.guardian_name.HeaderText = "Parents";
            this.guardian_name.MinimumWidth = 6;
            this.guardian_name.Name = "guardian_name";
            this.guardian_name.ReadOnly = true;
            // 
            // join_date
            // 
            this.join_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.join_date.DataPropertyName = "join_date";
            this.join_date.HeaderText = "Admission Date";
            this.join_date.MinimumWidth = 6;
            this.join_date.Name = "join_date";
            this.join_date.ReadOnly = true;
            this.join_date.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Violet;
            this.tabPage2.Controls.Add(this.label63);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Size = new System.Drawing.Size(1105, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Marks";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label63.Location = new System.Drawing.Point(253, 72);
            this.label63.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(446, 66);
            this.label63.TabIndex = 31;
            this.label63.Text = "Show Student";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Mark});
            this.dataGridView1.Location = new System.Drawing.Point(10, 203);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 282);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Srudent ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Student Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Mark
            // 
            this.Mark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mark.HeaderText = "Mark";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStudentInformation);
            this.panel1.Controls.Add(this.btnMarks);
            this.panel1.Controls.Add(this.btnTeacherInfo);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 302);
            this.panel1.TabIndex = 2;
            // 
            // lblStudentInformation
            // 
            this.lblStudentInformation.AutoSize = true;
            this.lblStudentInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInformation.Location = new System.Drawing.Point(6, 0);
            this.lblStudentInformation.Name = "lblStudentInformation";
            this.lblStudentInformation.Size = new System.Drawing.Size(205, 25);
            this.lblStudentInformation.TabIndex = 3;
            this.lblStudentInformation.Text = "Teacher Information";
            // 
            // btnMarks
            // 
            this.btnMarks.Location = new System.Drawing.Point(20, 151);
            this.btnMarks.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(84, 80);
            this.btnMarks.TabIndex = 1;
            this.btnMarks.Text = "Add Student Mark";
            this.btnMarks.UseVisualStyleBackColor = true;
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // btnTeacherInfo
            // 
            this.btnTeacherInfo.Location = new System.Drawing.Point(20, 46);
            this.btnTeacherInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTeacherInfo.Name = "btnTeacherInfo";
            this.btnTeacherInfo.Size = new System.Drawing.Size(84, 80);
            this.btnTeacherInfo.TabIndex = 0;
            this.btnTeacherInfo.Text = "Info";
            this.btnTeacherInfo.UseVisualStyleBackColor = true;
            this.btnTeacherInfo.Click += new System.EventHandler(this.btnTeacherInfo_Click);
            // 
            // teacherInfoTabControl
            // 
            this.teacherInfoTabControl.Controls.Add(this.tabPageInformation);
            this.teacherInfoTabControl.Controls.Add(this.tabPageMarks);
            this.teacherInfoTabControl.Location = new System.Drawing.Point(422, 18);
            this.teacherInfoTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacherInfoTabControl.Name = "teacherInfoTabControl";
            this.teacherInfoTabControl.SelectedIndex = 0;
            this.teacherInfoTabControl.Size = new System.Drawing.Size(826, 372);
            this.teacherInfoTabControl.TabIndex = 4;
            this.teacherInfoTabControl.Visible = false;
            // 
            // tabPageInformation
            // 
            this.tabPageInformation.Controls.Add(this.lblNumber);
            this.tabPageInformation.Controls.Add(this.lblAddress);
            this.tabPageInformation.Controls.Add(this.label13);
            this.tabPageInformation.Controls.Add(this.label14);
            this.tabPageInformation.Controls.Add(this.lblAge);
            this.tabPageInformation.Controls.Add(this.label9);
            this.tabPageInformation.Controls.Add(this.lblID);
            this.tabPageInformation.Controls.Add(this.lblName);
            this.tabPageInformation.Controls.Add(this.label2);
            this.tabPageInformation.Controls.Add(this.label1);
            this.tabPageInformation.Location = new System.Drawing.Point(4, 29);
            this.tabPageInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageInformation.Name = "tabPageInformation";
            this.tabPageInformation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageInformation.Size = new System.Drawing.Size(818, 339);
            this.tabPageInformation.TabIndex = 0;
            this.tabPageInformation.Text = "Information";
            this.tabPageInformation.UseVisualStyleBackColor = true;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(159, 141);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(63, 20);
            this.lblNumber.TabIndex = 11;
            this.lblNumber.Text = "number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(159, 172);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 20);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(42, 141);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Nmuber";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(46, 172);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "address";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(159, 108);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Age";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(159, 43);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(154, 74);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPageMarks
            // 
            this.tabPageMarks.Controls.Add(this.label3);
            this.tabPageMarks.Controls.Add(this.label4);
            this.tabPageMarks.Controls.Add(this.label5);
            this.tabPageMarks.Controls.Add(this.label6);
            this.tabPageMarks.Location = new System.Drawing.Point(4, 29);
            this.tabPageMarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageMarks.Name = "tabPageMarks";
            this.tabPageMarks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageMarks.Size = new System.Drawing.Size(818, 339);
            this.tabPageMarks.TabIndex = 1;
            this.tabPageMarks.Text = "Marks";
            this.tabPageMarks.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // ShowTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1370, 1017);
            this.Controls.Add(this.teacherInfoTabControl);
            this.Controls.Add(this.tcTeacherInfo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ShowTeacherInfo";
            this.Text = "ShowTeacherInfo";
            this.Load += new System.EventHandler(this.ShowTeacherInfo_Load);
            this.tcTeacherInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.teacherInfoTabControl.ResumeLayout(false);
            this.tabPageInformation.ResumeLayout(false);
            this.tabPageInformation.PerformLayout();
            this.tabPageMarks.ResumeLayout(false);
            this.tabPageMarks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTeacherInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvShowInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStudentInformation;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnTeacherInfo;
        private System.Windows.Forms.TabControl teacherInfoTabControl;
        private System.Windows.Forms.TabPage tabPageInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageMarks;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardian_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn join_date;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
    }
}