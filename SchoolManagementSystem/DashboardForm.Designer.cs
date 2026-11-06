namespace SchoolManagementSystem
{
    partial class DashboardForm
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
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnAttendance = new Button();
            btnClasses = new Button();
            btnTeachers = new Button();
            btnStudents = new Button();
            lblSidebarTitle = new Label();
            pnlHeader = new Panel();
            lblWelcome = new Label();
            lblPageTitle = new Label();
            pnlCardStudents = new Panel();
            pnlCardAccent = new Panel();
            lblStudentsTitle = new Label();
            lblStudentsCount = new Label();
            pnlContent = new Panel();
            pnlCardAttendance = new Panel();
            panel4 = new Panel();
            lblAttendanceTitle = new Label();
            lblAttendanceCount = new Label();
            pnlCardClasses = new Panel();
            panel3 = new Panel();
            lblClassesTitle = new Label();
            lblClassesCount = new Label();
            pnlCardTeachers = new Panel();
            panel2 = new Panel();
            lblTeachersTitle = new Label();
            lblTeachersCount = new Label();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlCardStudents.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlCardAttendance.SuspendLayout();
            pnlCardClasses.SuspendLayout();
            pnlCardTeachers.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(26, 60, 142);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnAttendance);
            pnlSidebar.Controls.Add(btnClasses);
            pnlSidebar.Controls.Add(btnTeachers);
            pnlSidebar.Controls.Add(btnStudents);
            pnlSidebar.Controls.Add(lblSidebarTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 603);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 520);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(230, 50);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Cursor = Cursors.Hand;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(0, 270);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(230, 50);
            btnAttendance.TabIndex = 5;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = true;
            // 
            // btnClasses
            // 
            btnClasses.Cursor = Cursors.Hand;
            btnClasses.FlatAppearance.BorderSize = 0;
            btnClasses.FlatStyle = FlatStyle.Flat;
            btnClasses.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClasses.ForeColor = Color.White;
            btnClasses.Location = new Point(0, 220);
            btnClasses.Name = "btnClasses";
            btnClasses.Size = new Size(230, 50);
            btnClasses.TabIndex = 4;
            btnClasses.Text = "Classes";
            btnClasses.TextAlign = ContentAlignment.MiddleLeft;
            btnClasses.UseVisualStyleBackColor = true;
            btnClasses.Click += btnClasses_Click;
            // 
            // btnTeachers
            // 
            btnTeachers.Cursor = Cursors.Hand;
            btnTeachers.FlatAppearance.BorderSize = 0;
            btnTeachers.FlatStyle = FlatStyle.Flat;
            btnTeachers.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTeachers.ForeColor = Color.White;
            btnTeachers.Location = new Point(0, 170);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.Size = new Size(230, 50);
            btnTeachers.TabIndex = 3;
            btnTeachers.Text = "Teachers";
            btnTeachers.TextAlign = ContentAlignment.MiddleLeft;
            btnTeachers.UseVisualStyleBackColor = true;
            btnTeachers.Click += btnTeachers_Click;
            // 
            // btnStudents
            // 
            btnStudents.Cursor = Cursors.Hand;
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudents.ForeColor = Color.White;
            btnStudents.Location = new Point(0, 120);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(230, 50);
            btnStudents.TabIndex = 2;
            btnStudents.Text = "Students";
            btnStudents.TextAlign = ContentAlignment.MiddleLeft;
            btnStudents.UseVisualStyleBackColor = true;
            // 
            // lblSidebarTitle
            // 
            lblSidebarTitle.BackColor = Color.FromArgb(26, 60, 142);
            lblSidebarTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSidebarTitle.ForeColor = Color.White;
            lblSidebarTitle.Location = new Point(0, 24);
            lblSidebarTitle.Name = "lblSidebarTitle";
            lblSidebarTitle.Size = new Size(244, 60);
            lblSidebarTitle.TabIndex = 1;
            lblSidebarTitle.Text = "School Management";
            lblSidebarTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(250, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(832, 70);
            pnlHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(107, 114, 128);
            lblWelcome.Location = new Point(681, 24);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(139, 23);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Admin";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(26, 60, 142);
            lblPageTitle.Location = new Point(20, 15);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(171, 41);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            // 
            // pnlCardStudents
            // 
            pnlCardStudents.BackColor = Color.White;
            pnlCardStudents.Controls.Add(pnlCardAccent);
            pnlCardStudents.Controls.Add(lblStudentsTitle);
            pnlCardStudents.Controls.Add(lblStudentsCount);
            pnlCardStudents.Location = new Point(20, 20);
            pnlCardStudents.Name = "pnlCardStudents";
            pnlCardStudents.Size = new Size(180, 110);
            pnlCardStudents.TabIndex = 0;
            // 
            // pnlCardAccent
            // 
            pnlCardAccent.BackColor = Color.FromArgb(30, 155, 60);
            pnlCardAccent.Dock = DockStyle.Left;
            pnlCardAccent.Location = new Point(0, 0);
            pnlCardAccent.Name = "pnlCardAccent";
            pnlCardAccent.Size = new Size(6, 110);
            pnlCardAccent.TabIndex = 2;
            // 
            // lblStudentsTitle
            // 
            lblStudentsTitle.AutoSize = true;
            lblStudentsTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblStudentsTitle.Location = new Point(20, 65);
            lblStudentsTitle.Name = "lblStudentsTitle";
            lblStudentsTitle.Size = new Size(117, 23);
            lblStudentsTitle.TabIndex = 1;
            lblStudentsTitle.Text = "Total Students";
            // 
            // lblStudentsCount
            // 
            lblStudentsCount.AutoSize = true;
            lblStudentsCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentsCount.ForeColor = Color.FromArgb(26, 60, 142);
            lblStudentsCount.Location = new Point(20, 15);
            lblStudentsCount.Name = "lblStudentsCount";
            lblStudentsCount.Size = new Size(46, 54);
            lblStudentsCount.TabIndex = 0;
            lblStudentsCount.Text = "0";
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlCardAttendance);
            pnlContent.Controls.Add(pnlCardClasses);
            pnlContent.Controls.Add(pnlCardTeachers);
            pnlContent.Controls.Add(pnlCardStudents);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(250, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20);
            pnlContent.Size = new Size(832, 533);
            pnlContent.TabIndex = 2;
            // 
            // pnlCardAttendance
            // 
            pnlCardAttendance.BackColor = Color.White;
            pnlCardAttendance.Controls.Add(panel4);
            pnlCardAttendance.Controls.Add(lblAttendanceTitle);
            pnlCardAttendance.Controls.Add(lblAttendanceCount);
            pnlCardAttendance.Location = new Point(620, 20);
            pnlCardAttendance.Name = "pnlCardAttendance";
            pnlCardAttendance.Size = new Size(180, 110);
            pnlCardAttendance.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 155, 60);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(6, 110);
            panel4.TabIndex = 2;
            // 
            // lblAttendanceTitle
            // 
            lblAttendanceTitle.AutoSize = true;
            lblAttendanceTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAttendanceTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblAttendanceTitle.Location = new Point(20, 65);
            lblAttendanceTitle.Name = "lblAttendanceTitle";
            lblAttendanceTitle.Size = new Size(158, 23);
            lblAttendanceTitle.TabIndex = 1;
            lblAttendanceTitle.Text = "Today’s Attendance\t";
            // 
            // lblAttendanceCount
            // 
            lblAttendanceCount.AutoSize = true;
            lblAttendanceCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttendanceCount.ForeColor = Color.FromArgb(26, 60, 142);
            lblAttendanceCount.Location = new Point(20, 15);
            lblAttendanceCount.Name = "lblAttendanceCount";
            lblAttendanceCount.Size = new Size(46, 54);
            lblAttendanceCount.TabIndex = 0;
            lblAttendanceCount.Text = "0";
            // 
            // pnlCardClasses
            // 
            pnlCardClasses.BackColor = Color.White;
            pnlCardClasses.Controls.Add(panel3);
            pnlCardClasses.Controls.Add(lblClassesTitle);
            pnlCardClasses.Controls.Add(lblClassesCount);
            pnlCardClasses.Location = new Point(420, 20);
            pnlCardClasses.Name = "pnlCardClasses";
            pnlCardClasses.Size = new Size(180, 110);
            pnlCardClasses.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 155, 60);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(6, 110);
            panel3.TabIndex = 2;
            // 
            // lblClassesTitle
            // 
            lblClassesTitle.AutoSize = true;
            lblClassesTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassesTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblClassesTitle.Location = new Point(20, 65);
            lblClassesTitle.Name = "lblClassesTitle";
            lblClassesTitle.Size = new Size(105, 23);
            lblClassesTitle.TabIndex = 1;
            lblClassesTitle.Text = "Total Classes";
            // 
            // lblClassesCount
            // 
            lblClassesCount.AutoSize = true;
            lblClassesCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassesCount.ForeColor = Color.FromArgb(26, 60, 142);
            lblClassesCount.Location = new Point(20, 15);
            lblClassesCount.Name = "lblClassesCount";
            lblClassesCount.Size = new Size(46, 54);
            lblClassesCount.TabIndex = 0;
            lblClassesCount.Text = "0";
            // 
            // pnlCardTeachers
            // 
            pnlCardTeachers.BackColor = Color.White;
            pnlCardTeachers.Controls.Add(panel2);
            pnlCardTeachers.Controls.Add(lblTeachersTitle);
            pnlCardTeachers.Controls.Add(lblTeachersCount);
            pnlCardTeachers.Location = new Point(220, 20);
            pnlCardTeachers.Name = "pnlCardTeachers";
            pnlCardTeachers.Size = new Size(180, 110);
            pnlCardTeachers.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 155, 60);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 110);
            panel2.TabIndex = 2;
            // 
            // lblTeachersTitle
            // 
            lblTeachersTitle.AutoSize = true;
            lblTeachersTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeachersTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTeachersTitle.Location = new Point(20, 65);
            lblTeachersTitle.Name = "lblTeachersTitle";
            lblTeachersTitle.Size = new Size(116, 23);
            lblTeachersTitle.TabIndex = 1;
            lblTeachersTitle.Text = "Total Teachers";
            // 
            // lblTeachersCount
            // 
            lblTeachersCount.AutoSize = true;
            lblTeachersCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeachersCount.ForeColor = Color.FromArgb(26, 60, 142);
            lblTeachersCount.Location = new Point(20, 15);
            lblTeachersCount.Name = "lblTeachersCount";
            lblTeachersCount.Size = new Size(46, 54);
            lblTeachersCount.TabIndex = 0;
            lblTeachersCount.Text = "0";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(1082, 603);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "School Management System - Dashboard";
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCardStudents.ResumeLayout(false);
            pnlCardStudents.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlCardAttendance.ResumeLayout(false);
            pnlCardAttendance.PerformLayout();
            pnlCardClasses.ResumeLayout(false);
            pnlCardClasses.PerformLayout();
            pnlCardTeachers.ResumeLayout(false);
            pnlCardTeachers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblSidebarTitle;
        private Button btnStudents;
        private Button btnClasses;
        private Button btnTeachers;
        private Button btnLogout;
        private Button btnAttendance;
        private Panel pnlHeader;
        private Label lblWelcome;
        private Label lblPageTitle;
        private Panel pnlCardStudents;
        private Label lblStudentsTitle;
        private Label lblStudentsCount;
        private Panel pnlContent;
        private Panel pnlCardAccent;
        private Panel pnlCardClasses;
        private Panel panel3;
        private Label lblClassesTitle;
        private Label lblClassesCount;
        private Panel pnlCardTeachers;
        private Panel panel2;
        private Label lblTeachersTitle;
        private Label lblTeachersCount;
        private Panel pnlCardAttendance;
        private Panel panel4;
        private Label lblAttendanceTitle;
        private Label lblAttendanceCount;
    }
}