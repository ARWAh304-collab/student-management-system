using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class DashboardForm : Form
    {
        public bool LoggedOut { get; private set; }

        public DashboardForm(string username)
        {
            InitializeComponent();
            StyleSidebarButtons();
            lblWelcome.Text = "Welcome, " + username;
            lblWelcome.Left = pnlHeader.Width - lblWelcome.Width - 20;
        }

        private void StyleSidebarButtons()
        {
            var buttons = new[] { btnStudents, btnTeachers, btnClasses, btnAttendance, btnLogout };

            foreach (var btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 82, 176);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 155, 60);
                btn.Cursor = Cursors.Hand;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?",
                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoggedOut = true;
                this.Close();
            }
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            var teachers = new TeacherManage();
            teachers.ShowDialog();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            var students = new frmStudent();
            students.ShowDialog();
        private void btnClasses_Click(object sender, EventArgs e)
        {
            var classes = new Classesform();
            classes.ShowDialog();
        }
    }
}