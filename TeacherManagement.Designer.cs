namespace project_mod
{
    partial class TeacherManage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TopPanel = new Panel();
            lblPageTitle = new Label();
            lblSystemName = new Label();
            btnHome = new Button();
            LeftPanel = new Panel();
            btnResetFilters = new Button();
            btnAddTeacher = new Button();
            clbTeacherNames = new CheckedListBox();
            lblFilter = new Label();
            txtSearchTeacher = new TextBox();
            lblSearch = new Label();
            label2 = new Label();
            label1 = new Label();
            MainPanel = new Panel();
            label6 = new Label();
            flpTeachers = new FlowLayoutPanel();
            panel3 = new Panel();
            button7 = new Button();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            pictureBox4 = new PictureBox();
            button8 = new Button();
            button9 = new Button();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            pictureBox3 = new PictureBox();
            button5 = new Button();
            button6 = new Button();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            pnlTeacherCard = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnViewTeacher = new Button();
            lblSubjectValue = new Label();
            lblEmailValue = new Label();
            lblDepartmentValue = new Label();
            lblTeacherSubject = new Label();
            pictureBox1 = new PictureBox();
            btnEditTeacher = new Button();
            btnDeleteTeacher = new Button();
            lblTeacherEmail = new Label();
            lblTeacherDepartment = new Label();
            lblTeacherName = new Label();
            TopPanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            flpTeachers.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlTeacherCard.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(lblPageTitle);
            TopPanel.Controls.Add(lblSystemName);
            TopPanel.Controls.Add(btnHome);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1182, 50);
            TopPanel.TabIndex = 0;
            TopPanel.Paint += TopPanel_Paint;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Location = new Point(987, 18);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(158, 20);
            lblPageTitle.TabIndex = 2;
            lblPageTitle.Text = "Teachers Management";
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Location = new Point(516, 18);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(197, 20);
            lblSystemName.TabIndex = 1;
            lblSystemName.Text = "School Management System";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(48, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(80, 32);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(btnResetFilters);
            LeftPanel.Controls.Add(btnAddTeacher);
            LeftPanel.Controls.Add(clbTeacherNames);
            LeftPanel.Controls.Add(lblFilter);
            LeftPanel.Controls.Add(txtSearchTeacher);
            LeftPanel.Controls.Add(lblSearch);
            LeftPanel.Controls.Add(label2);
            LeftPanel.Controls.Add(label1);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 50);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(305, 653);
            LeftPanel.TabIndex = 1;
            // 
            // btnResetFilters
            // 
            btnResetFilters.ForeColor = Color.ForestGreen;
            btnResetFilters.Location = new Point(44, 365);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(170, 29);
            btnResetFilters.TabIndex = 7;
            btnResetFilters.Text = "Reset All Filters";
            btnResetFilters.UseVisualStyleBackColor = true;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.BackColor = Color.DarkGreen;
            btnAddTeacher.ForeColor = SystemColors.ButtonHighlight;
            btnAddTeacher.Location = new Point(27, 503);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(260, 45);
            btnAddTeacher.TabIndex = 6;
            btnAddTeacher.Text = "+ Add New Teacher";
            btnAddTeacher.UseVisualStyleBackColor = false;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // clbTeacherNames
            // 
            clbTeacherNames.BorderStyle = BorderStyle.None;
            clbTeacherNames.CheckOnClick = true;
            clbTeacherNames.ForeColor = Color.SeaGreen;
            clbTeacherNames.FormattingEnabled = true;
            clbTeacherNames.Items.AddRange(new object[] { "teacher1", "teacher2" });
            clbTeacherNames.Location = new Point(8, 205);
            clbTeacherNames.Name = "clbTeacherNames";
            clbTeacherNames.Size = new Size(260, 154);
            clbTeacherNames.TabIndex = 5;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilter.Location = new Point(27, 182);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(112, 20);
            lblFilter.TabIndex = 4;
            lblFilter.Text = "Filter by Name";
            // 
            // txtSearchTeacher
            // 
            txtSearchTeacher.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchTeacher.Location = new Point(8, 116);
            txtSearchTeacher.Multiline = true;
            txtSearchTeacher.Name = "txtSearchTeacher";
            txtSearchTeacher.PlaceholderText = "Search by teacher name";
            txtSearchTeacher.Size = new Size(260, 43);
            txtSearchTeacher.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(8, 84);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(105, 17);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search Teachers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(211, 20);
            label2.TabIndex = 1;
            label2.Text = "Search and filter teaching staff";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 0;
            label1.Text = "Teachers";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonHighlight;
            MainPanel.BorderStyle = BorderStyle.Fixed3D;
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(flpTeachers);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(305, 50);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(877, 653);
            MainPanel.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(306, 12);
            label6.Name = "label6";
            label6.Size = new Size(111, 21);
            label6.TabIndex = 6;
            label6.Text = "All teacher";
            // 
            // flpTeachers
            // 
            flpTeachers.AutoScroll = true;
            flpTeachers.Controls.Add(panel3);
            flpTeachers.Controls.Add(panel2);
            flpTeachers.Controls.Add(pnlTeacherCard);
            flpTeachers.Location = new Point(-2, 49);
            flpTeachers.Name = "flpTeachers";
            flpTeachers.Size = new Size(877, 602);
            flpTeachers.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(label24);
            panel3.Location = new Point(15, 15);
            panel3.Margin = new Padding(15);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 364);
            panel3.TabIndex = 12;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkGreen;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(106, 317);
            button7.Name = "button7";
            button7.Size = new Size(83, 29);
            button7.TabIndex = 11;
            button7.Text = "View";
            button7.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 242);
            label18.Name = "label18";
            label18.Size = new Size(100, 20);
            label18.TabIndex = 10;
            label18.Text = "Programming";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 173);
            label19.Name = "label19";
            label19.Size = new Size(103, 20);
            label19.TabIndex = 9;
            label19.Text = "Email Address";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(11, 115);
            label20.Name = "label20";
            label20.Size = new Size(129, 20);
            label20.TabIndex = 8;
            label20.Text = "Computer Science";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.Navy;
            label21.Location = new Point(12, 222);
            label21.Name = "label21";
            label21.Size = new Size(60, 20);
            label21.TabIndex = 7;
            label21.Text = "Subject";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(11, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 52);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkGreen;
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(12, 317);
            button8.Name = "button8";
            button8.Size = new Size(76, 29);
            button8.TabIndex = 5;
            button8.Text = "Edit";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Red;
            button9.Location = new Point(212, 317);
            button9.Name = "button9";
            button9.Size = new Size(86, 29);
            button9.TabIndex = 4;
            button9.Text = "Delete";
            button9.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Navy;
            label22.Location = new Point(11, 153);
            label22.Name = "label22";
            label22.Size = new Size(108, 20);
            label22.TabIndex = 2;
            label22.Text = "Email Address";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.Navy;
            label23.Location = new Point(11, 91);
            label23.Name = "label23";
            label23.Size = new Size(94, 20);
            label23.TabIndex = 1;
            label23.Text = "Department";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Navy;
            label24.Location = new Point(88, 29);
            label24.Name = "label24";
            label24.Size = new Size(109, 20);
            label24.TabIndex = 0;
            label24.Text = "Teacher Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label17);
            panel2.Location = new Point(377, 15);
            panel2.Margin = new Padding(15);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 364);
            panel2.TabIndex = 12;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGreen;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(106, 317);
            button4.Name = "button4";
            button4.Size = new Size(83, 29);
            button4.TabIndex = 11;
            button4.Text = "View";
            button4.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 242);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 10;
            label11.Text = "Programming";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 173);
            label12.Name = "label12";
            label12.Size = new Size(103, 20);
            label12.TabIndex = 9;
            label12.Text = "Email Address";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 115);
            label13.Name = "label13";
            label13.Size = new Size(129, 20);
            label13.TabIndex = 8;
            label13.Text = "Computer Science";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Navy;
            label14.Location = new Point(12, 222);
            label14.Name = "label14";
            label14.Size = new Size(60, 20);
            label14.TabIndex = 7;
            label14.Text = "Subject";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(11, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 52);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkGreen;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(12, 317);
            button5.Name = "button5";
            button5.Size = new Size(76, 29);
            button5.TabIndex = 5;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Location = new Point(212, 317);
            button6.Name = "button6";
            button6.Size = new Size(86, 29);
            button6.TabIndex = 4;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Navy;
            label15.Location = new Point(11, 153);
            label15.Name = "label15";
            label15.Size = new Size(108, 20);
            label15.TabIndex = 2;
            label15.Text = "Email Address";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Navy;
            label16.Location = new Point(11, 91);
            label16.Name = "label16";
            label16.Size = new Size(94, 20);
            label16.TabIndex = 1;
            label16.Text = "Department";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Navy;
            label17.Location = new Point(88, 29);
            label17.Name = "label17";
            label17.Size = new Size(109, 20);
            label17.TabIndex = 0;
            label17.Text = "Teacher Name";
            // 
            // pnlTeacherCard
            // 
            pnlTeacherCard.BackColor = Color.WhiteSmoke;
            pnlTeacherCard.BorderStyle = BorderStyle.FixedSingle;
            pnlTeacherCard.Controls.Add(panel1);
            pnlTeacherCard.Controls.Add(btnViewTeacher);
            pnlTeacherCard.Controls.Add(lblSubjectValue);
            pnlTeacherCard.Controls.Add(lblEmailValue);
            pnlTeacherCard.Controls.Add(lblDepartmentValue);
            pnlTeacherCard.Controls.Add(lblTeacherSubject);
            pnlTeacherCard.Controls.Add(pictureBox1);
            pnlTeacherCard.Controls.Add(btnEditTeacher);
            pnlTeacherCard.Controls.Add(btnDeleteTeacher);
            pnlTeacherCard.Controls.Add(lblTeacherEmail);
            pnlTeacherCard.Controls.Add(lblTeacherDepartment);
            pnlTeacherCard.Controls.Add(lblTeacherName);
            pnlTeacherCard.Location = new Point(15, 409);
            pnlTeacherCard.Margin = new Padding(15);
            pnlTeacherCard.Name = "pnlTeacherCard";
            pnlTeacherCard.Size = new Size(332, 364);
            pnlTeacherCard.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(15);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 364);
            panel1.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(106, 317);
            button1.Name = "button1";
            button1.Size = new Size(83, 29);
            button1.TabIndex = 11;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 242);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 10;
            label3.Text = "Programming";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 9;
            label4.Text = "Email Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 115);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 8;
            label5.Text = "Computer Science";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(12, 222);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 7;
            label7.Text = "Subject";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(11, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 52);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(12, 317);
            button2.Name = "button2";
            button2.Size = new Size(76, 29);
            button2.TabIndex = 5;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(212, 317);
            button3.Name = "button3";
            button3.Size = new Size(86, 29);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(11, 153);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 2;
            label8.Text = "Email Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(11, 91);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 1;
            label9.Text = "Department";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(88, 29);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 0;
            label10.Text = "Teacher Name";
            // 
            // btnViewTeacher
            // 
            btnViewTeacher.BackColor = Color.DarkGreen;
            btnViewTeacher.ForeColor = SystemColors.ButtonHighlight;
            btnViewTeacher.Location = new Point(106, 317);
            btnViewTeacher.Name = "btnViewTeacher";
            btnViewTeacher.Size = new Size(83, 29);
            btnViewTeacher.TabIndex = 11;
            btnViewTeacher.Text = "View";
            btnViewTeacher.UseVisualStyleBackColor = false;
            // 
            // lblSubjectValue
            // 
            lblSubjectValue.AutoSize = true;
            lblSubjectValue.Location = new Point(15, 242);
            lblSubjectValue.Name = "lblSubjectValue";
            lblSubjectValue.Size = new Size(100, 20);
            lblSubjectValue.TabIndex = 10;
            lblSubjectValue.Text = "Programming";
            // 
            // lblEmailValue
            // 
            lblEmailValue.AutoSize = true;
            lblEmailValue.Location = new Point(12, 173);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(103, 20);
            lblEmailValue.TabIndex = 9;
            lblEmailValue.Text = "Email Address";
            // 
            // lblDepartmentValue
            // 
            lblDepartmentValue.AutoSize = true;
            lblDepartmentValue.Location = new Point(11, 115);
            lblDepartmentValue.Name = "lblDepartmentValue";
            lblDepartmentValue.Size = new Size(129, 20);
            lblDepartmentValue.TabIndex = 8;
            lblDepartmentValue.Text = "Computer Science";
            // 
            // lblTeacherSubject
            // 
            lblTeacherSubject.AutoSize = true;
            lblTeacherSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacherSubject.ForeColor = Color.Navy;
            lblTeacherSubject.Location = new Point(12, 222);
            lblTeacherSubject.Name = "lblTeacherSubject";
            lblTeacherSubject.Size = new Size(60, 20);
            lblTeacherSubject.TabIndex = 7;
            lblTeacherSubject.Text = "Subject";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(11, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 52);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnEditTeacher
            // 
            btnEditTeacher.BackColor = Color.DarkGreen;
            btnEditTeacher.ForeColor = SystemColors.ButtonHighlight;
            btnEditTeacher.Location = new Point(12, 317);
            btnEditTeacher.Name = "btnEditTeacher";
            btnEditTeacher.Size = new Size(76, 29);
            btnEditTeacher.TabIndex = 5;
            btnEditTeacher.Text = "Edit";
            btnEditTeacher.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTeacher
            // 
            btnDeleteTeacher.BackColor = Color.Red;
            btnDeleteTeacher.Location = new Point(212, 317);
            btnDeleteTeacher.Name = "btnDeleteTeacher";
            btnDeleteTeacher.Size = new Size(86, 29);
            btnDeleteTeacher.TabIndex = 4;
            btnDeleteTeacher.Text = "Delete";
            btnDeleteTeacher.UseVisualStyleBackColor = false;
            // 
            // lblTeacherEmail
            // 
            lblTeacherEmail.AutoSize = true;
            lblTeacherEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacherEmail.ForeColor = Color.Navy;
            lblTeacherEmail.Location = new Point(11, 153);
            lblTeacherEmail.Name = "lblTeacherEmail";
            lblTeacherEmail.Size = new Size(108, 20);
            lblTeacherEmail.TabIndex = 2;
            lblTeacherEmail.Text = "Email Address";
            // 
            // lblTeacherDepartment
            // 
            lblTeacherDepartment.AutoSize = true;
            lblTeacherDepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacherDepartment.ForeColor = Color.Navy;
            lblTeacherDepartment.Location = new Point(11, 91);
            lblTeacherDepartment.Name = "lblTeacherDepartment";
            lblTeacherDepartment.Size = new Size(94, 20);
            lblTeacherDepartment.TabIndex = 1;
            lblTeacherDepartment.Text = "Department";
            // 
            // lblTeacherName
            // 
            lblTeacherName.AutoSize = true;
            lblTeacherName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacherName.ForeColor = Color.Navy;
            lblTeacherName.Location = new Point(88, 29);
            lblTeacherName.Name = "lblTeacherName";
            lblTeacherName.Size = new Size(109, 20);
            lblTeacherName.TabIndex = 0;
            lblTeacherName.Text = "Teacher Name";
            // 
            // TeacherManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 703);
            Controls.Add(MainPanel);
            Controls.Add(LeftPanel);
            Controls.Add(TopPanel);
            Name = "TeacherManage";
            Text = "Teachers Management";
            Load += Form1_Load;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            flpTeachers.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlTeacherCard.ResumeLayout(false);
            pnlTeacherCard.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel LeftPanel;
        private Panel MainPanel;
        private Label lblSystemName;
        private Button btnHome;
        private Label lblPageTitle;
        private Button btnResetFilters;
        private Button btnAddTeacher;
        private CheckedListBox clbTeacherNames;
        private Label lblFilter;
        private TextBox txtSearchTeacher;
        private Label lblSearch;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flpTeachers;
        private Panel pnlTeacherCard;
        private Label lblTeacherEmail;
        private Label lblTeacherDepartment;
        private Label lblTeacherName;
        private Label label6;
        private Button btnDeleteTeacher;
        private Label lblTeacherSubject;
        private PictureBox pictureBox1;
        private Label lblSubjectValue;
        private Label lblEmailValue;
        private Label lblDepartmentValue;
        private Button btnViewTeacher;
        private Panel panel3;
        private Button button7;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private PictureBox pictureBox4;
        private Button button8;
        private Button button9;
        private Label label22;
        private Label label23;
        private Label label24;
        private Panel panel2;
        private Button button4;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox3;
        private Button button5;
        private Button button6;
        private Label label15;
        private Label label16;
        private Label label17;
        private Panel panel1;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
