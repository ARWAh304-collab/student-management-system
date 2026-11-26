
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class DashboardForm : Form
    {
        public bool LoggedOut { get; private set; }

        private Panel pnlPie = null!;
        private readonly string currentRole;
        private readonly string currentUsername;

        public DashboardForm(string username)
            : this(username, "Admin")
        {
        }

        public DashboardForm(string username, string role)
        {
            InitializeComponent();

            currentRole = role;
            currentUsername = username;

            StyleSidebarButtons();
            ApplyRolePermissions();

            lblWelcome.Text = "Welcome, " + username;
            lblWelcome.Left = pnlHeader.Width - lblWelcome.Width - 20;

            pnlChart.Paint += pnlChart_Paint;

            pnlPie = new Panel
            {
                BackColor = Color.White,
                Size = new Size(260, 300),
                Location = new Point(pnlChart.Right + 20, pnlChart.Top)
            };

            pnlChart.Parent!.Controls.Add(pnlPie);
            pnlPie.Paint += pnlPie_Paint;
        }

        private bool IsAdmin()
        {
            return string.Equals(
                currentRole,
                "Admin",
                StringComparison.OrdinalIgnoreCase);
        }

        private void ApplyRolePermissions()
        {
            if (IsAdmin())
            {
                btnTeachers.Visible = true;
                btnUsers.Visible = true;
            }
            else
            {
                btnTeachers.Visible = false;
                btnUsers.Visible = false;
            }

            btnStudents.Visible = true;
            btnClasses.Visible = true;
            button1.Visible = true;
            btnLogout.Visible = true;
        }

        private void StyleSidebarButtons()
        {
            var buttons = new[]
            {
                btnStudents,
                btnTeachers,
                btnClasses,
                button1,
                btnUsers,
                btnLogout
            };

            foreach (var btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                btn.FlatAppearance.MouseOverBackColor =
                    Color.FromArgb(38, 82, 176);

                btn.FlatAppearance.MouseDownBackColor =
                    Color.FromArgb(30, 155, 60);

                btn.Cursor = Cursors.Hand;
            }
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoggedOut = true;
                Close();
            }
        }

        private void btnTeachers_Click(object? sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show(
                    "You do not have permission to access this page.");
                return;
            }

            var teachers = new TeacherManage();
            teachers.ShowDialog();

            RefreshDashboardData();
        }

        private void btnStudents_Click(object? sender, EventArgs e)
        {
            var students = new frmStudent();
            students.ShowDialog();

            RefreshDashboardData();
        }

        private void btnClasses_Click(object? sender, EventArgs e)
        {
            var classes = new Classesform();
            classes.ShowDialog();

            RefreshDashboardData();
        }

        private void btnAttendance_Click(object? sender, EventArgs e)
        {
            var attendance = new AttendanceForm();
            attendance.ShowDialog();

            RefreshDashboardData();
        }

        private void btnUsers_Click(object? sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                MessageBox.Show(
                    "You do not have permission to access User Management.");
                return;
            }

            var users = new frmUser(currentUsername);
            users.ShowDialog();
        }

        private void DashboardForm_Load(object? sender, EventArgs e)
        {
            RefreshDashboardData();
        }

        private void RefreshDashboardData()
        {
            lblStudentsCount.Text =
                StudentData.Students.Count.ToString();

            lblTeachersCount.Text =
                TeacherData.Teachers.Count.ToString();

            lblClassesCount.Text =
                ClassData.IsInitialized
                ? ClassData.ClassesTable.Rows.Count.ToString()
                : "0";

            lblAttendanceCount.Text =
                $"Present: {AttendanceData.PresentCount} | Absent: {AttendanceData.AbsentCount}";

            pnlChart.Invalidate();
            pnlPie.Invalidate();
        }

        // GDI+ Bar Chart
        private void pnlChart_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int attendanceTotal =
                AttendanceData.PresentCount + AttendanceData.AbsentCount;

            int[] values =
            {
                int.TryParse(lblStudentsCount.Text, out var s) ? s : 0,
                int.TryParse(lblTeachersCount.Text, out var t) ? t : 0,
                int.TryParse(lblClassesCount.Text, out var c) ? c : 0,
                attendanceTotal
            };

            string[] labels =
            {
                "Students",
                "Teachers",
                "Classes",
                "Attendance"
            };

            Color[] colors =
            {
                Color.FromArgb(26, 60, 142),
                Color.FromArgb(30, 155, 60),
                Color.FromArgb(26, 60, 142),
                Color.FromArgb(30, 155, 60)
            };

            int w = pnlChart.Width;
            int h = pnlChart.Height;

            int left = 50;
            int bottom = h - 40;
            int top = 50;

            int max = Math.Max(values.Max(), 1);

            using var titleFont =
                new Font("Segoe UI", 12, FontStyle.Bold);

            using var font = new Font("Segoe UI", 9);
            using var axisPen = new Pen(Color.Gray, 2);
            using var gridPen = new Pen(Color.LightGray, 1);

            using var titleBrush =
                new SolidBrush(Color.FromArgb(26, 60, 142));

            g.DrawString(
                "School Overview",
                titleFont,
                titleBrush,
                10,
                10);

            for (int i = 0; i <= 4; i++)
            {
                int y = bottom - (bottom - top) * i / 4;

                g.DrawLine(gridPen, left, y, w - 20, y);

                g.DrawString(
                    (max * i / 4).ToString(),
                    font,
                    Brushes.Gray,
                    10,
                    y - 8);
            }

            g.DrawLine(axisPen, left, top, left, bottom);
            g.DrawLine(axisPen, left, bottom, w - 20, bottom);

            int slot = (w - left - 20) / values.Length;
            int barW = slot - 30;

            for (int i = 0; i < values.Length; i++)
            {
                int barH = (bottom - top) * values[i] / max;
                int x = left + i * slot + 15;

                using var brush = new SolidBrush(colors[i]);

                g.FillRectangle(
                    brush,
                    x,
                    bottom - barH,
                    barW,
                    barH);

                g.DrawString(
                    values[i].ToString(),
                    font,
                    Brushes.Black,
                    x + barW / 2 - 6,
                    bottom - barH - 18);

                g.DrawString(
                    labels[i],
                    font,
                    Brushes.Black,
                    x - 2,
                    bottom + 6);
            }
        }

        // GDI+ Pie Chart
        private void pnlPie_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int male = StudentData.Students.Count(student =>
                string.Equals(
                    student.Gender,
                    "Male",
                    StringComparison.OrdinalIgnoreCase) ||
                student.Gender == "ذكر");

            int female = StudentData.Students.Count(student =>
                string.Equals(
                    student.Gender,
                    "Female",
                    StringComparison.OrdinalIgnoreCase) ||
                student.Gender == "أنثى");

            int total = male + female;

            using var titleFont =
                new Font("Segoe UI", 12, FontStyle.Bold);

            using var font = new Font("Segoe UI", 9);

            using var titleBrush =
                new SolidBrush(Color.FromArgb(26, 60, 142));

            using var maleBrush =
                new SolidBrush(Color.FromArgb(26, 60, 142));

            using var femaleBrush =
                new SolidBrush(Color.FromArgb(30, 155, 60));

            g.DrawString(
                "Gender Distribution",
                titleFont,
                titleBrush,
                10,
                10);

            if (total == 0)
            {
                g.DrawString(
                    "No student data",
                    font,
                    Brushes.Gray,
                    80,
                    130);

                return;
            }

            var rect = new Rectangle(40, 50, 180, 180);

            float maleAngle = 360f * male / total;

            if (male > 0)
                g.FillPie(maleBrush, rect, 0, maleAngle);

            if (female > 0)
            {
                g.FillPie(
                    femaleBrush,
                    rect,
                    maleAngle,
                    360f - maleAngle);
            }

            g.FillRectangle(maleBrush, 40, 250, 14, 14);

            g.DrawString(
                $"Male ({male})",
                font,
                Brushes.Black,
                60,
                248);

            g.FillRectangle(femaleBrush, 140, 250, 14, 14);

            g.DrawString(
                $"Female ({female})",
                font,
                Brushes.Black,
                160,
                248);
        }
    }
}
