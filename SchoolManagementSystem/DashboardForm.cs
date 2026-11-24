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
        private Panel pnlPie = null!;

        public DashboardForm(string username)
        {
            InitializeComponent();
            StyleSidebarButtons();
            lblWelcome.Text = "Welcome, " + username;
            lblWelcome.Left = pnlHeader.Width - lblWelcome.Width - 20;

            // GDI+ : bar chart paint event
            pnlChart.Paint += pnlChart_Paint;

            // create the pie panel next to the bar chart
            pnlPie = new Panel
            {
                BackColor = Color.White,
                Size = new Size(260, 300),
                Location = new Point(pnlChart.Right + 20, pnlChart.Top)
            };
            pnlChart.Parent!.Controls.Add(pnlPie);
            pnlPie.Paint += pnlPie_Paint;
        }

        private void StyleSidebarButtons()
        {
            var buttons = new[] { btnStudents, btnTeachers, btnClasses, btnUsers, btnLogout };

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
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            var classes = new Classesform();
            classes.ShowDialog();
        }

        private void btnUsers_Click(object? sender, EventArgs e)
        {
            var users = new frmUser();
            users.ShowDialog();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblStudentsCount.Text = "25";
            lblTeachersCount.Text = "8";
            lblClassesCount.Text = "6";
            lblAttendanceCount.Text = "20";
            pnlChart.Invalidate();
            pnlPie.Invalidate();
        }

        // ===== GDI+ : Bar Chart =====
        private void pnlChart_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int[] values =
            {
                int.TryParse(lblStudentsCount.Text, out var s) ? s : 0,
                int.TryParse(lblTeachersCount.Text, out var t) ? t : 0,
                int.TryParse(lblClassesCount.Text, out var c) ? c : 0,
                int.TryParse(lblAttendanceCount.Text, out var a) ? a : 0
            };
            string[] labels = { "Students", "Teachers", "Classes", "Attendance" };
            Color[] colors =
            {
                Color.FromArgb(26, 60, 142), Color.FromArgb(30, 155, 60),
                Color.FromArgb(26, 60, 142), Color.FromArgb(30, 155, 60)
            };

            int w = pnlChart.Width, h = pnlChart.Height;
            int left = 50, bottom = h - 40, top = 50;
            int max = Math.Max(values.Max(), 1);

            using var titleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            using var font = new Font("Segoe UI", 9);
            using var axisPen = new Pen(Color.Gray, 2);
            using var gridPen = new Pen(Color.LightGray, 1);
            using var titleBrush = new SolidBrush(Color.FromArgb(26, 60, 142));

            g.DrawString("School Overview", titleFont, titleBrush, 10, 10);

            for (int i = 0; i <= 4; i++)
            {
                int y = bottom - (bottom - top) * i / 4;
                g.DrawLine(gridPen, left, y, w - 20, y);
                g.DrawString((max * i / 4).ToString(), font, Brushes.Gray, 10, y - 8);
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
                g.FillRectangle(brush, x, bottom - barH, barW, barH);
                g.DrawString(values[i].ToString(), font, Brushes.Black, x + barW / 2 - 6, bottom - barH - 18);
                g.DrawString(labels[i], font, Brushes.Black, x - 2, bottom + 6);
            }
        }

        // ===== GDI+ : Pie Chart (Male / Female) =====
        private void pnlPie_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int male = 14, female = 11; // sample numbers
            int total = male + female;

            using var titleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            using var font = new Font("Segoe UI", 9);
            using var titleBrush = new SolidBrush(Color.FromArgb(26, 60, 142));
            using var maleBrush = new SolidBrush(Color.FromArgb(26, 60, 142));
            using var femaleBrush = new SolidBrush(Color.FromArgb(30, 155, 60));

            g.DrawString("Gender Distribution", titleFont, titleBrush, 10, 10);

            var rect = new Rectangle(40, 50, 180, 180);
            float maleAngle = 360f * male / total;
            g.FillPie(maleBrush, rect, 0, maleAngle);
            g.FillPie(femaleBrush, rect, maleAngle, 360f - maleAngle);

            g.FillRectangle(maleBrush, 40, 250, 14, 14);
            g.DrawString($"Male ({male})", font, Brushes.Black, 60, 248);
            g.FillRectangle(femaleBrush, 140, 250, 14, 14);
            g.DrawString($"Female ({female})", font, Brushes.Black, 160, 248);
        }
    }
}