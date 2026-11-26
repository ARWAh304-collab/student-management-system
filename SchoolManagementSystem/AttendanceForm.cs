
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AttendanceForm : Form
    {
        private DataTable attendanceTable = new DataTable();

        public AttendanceForm()
        {
            InitializeComponent();
            LoadAttendance();
        }

        private void AttendanceForm_Load(object? sender, EventArgs e)
        {
        }

        private void LoadAttendance()
        {
            attendanceTable = new DataTable();

            attendanceTable.Columns.Add("StudentID", typeof(string));
            attendanceTable.Columns.Add("StudentName", typeof(string));
            attendanceTable.Columns.Add("Class", typeof(string));
            attendanceTable.Columns.Add("Status", typeof(string));

            // Load actual students from StudentData
            foreach (StudentInfo student in StudentData.Students)
            {
                attendanceTable.Rows.Add(
                    student.ID,
                    student.Name,
                    student.Class,
                    "Not Marked"
                );
            }

            dgvAttendance.DataSource = attendanceTable;

            dgvAttendance.Columns["StudentID"].HeaderText = "Student ID";
            dgvAttendance.Columns["StudentName"].HeaderText = "Student Name";
            dgvAttendance.Columns["Class"].HeaderText = "Class";

            // Replace the normal Status column with a ComboBox
            dgvAttendance.Columns.Remove("Status");

            DataGridViewComboBoxColumn statusColumn =
                new DataGridViewComboBoxColumn();

            statusColumn.Name = "Status";
            statusColumn.HeaderText = "Attendance Status";
            statusColumn.DataPropertyName = "Status";

            statusColumn.Items.Add("Not Marked");
            statusColumn.Items.Add("Present");
            statusColumn.Items.Add("Absent");

            statusColumn.DisplayStyle =
                DataGridViewComboBoxDisplayStyle.ComboBox;

            dgvAttendance.Columns.Add(statusColumn);

            dgvAttendance.Columns["StudentID"].ReadOnly = true;
            dgvAttendance.Columns["StudentName"].ReadOnly = true;
            dgvAttendance.Columns["Class"].ReadOnly = true;

            dgvAttendance.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().Replace("'", "''");

            attendanceTable.DefaultView.RowFilter =
                $"StudentName LIKE '%{search}%'";
        }

        private void btnPresentAll_Click(object? sender, EventArgs e)
        {
            foreach (DataRow row in attendanceTable.Rows)
            {
                row["Status"] = "Present";
            }
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            dgvAttendance.EndEdit();

            AttendanceData.PresentCount = 0;
            AttendanceData.AbsentCount = 0;

            foreach (DataRow row in attendanceTable.Rows)
            {
                if (row["Status"].ToString() == "Present")
                {
                    AttendanceData.PresentCount++;
                }
                else if (row["Status"].ToString() == "Absent")
                {
                    AttendanceData.AbsentCount++;
                }
            }

            MessageBox.Show(
                "Attendance saved successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            foreach (DataRow row in attendanceTable.Rows)
            {
                row["Status"] = "Not Marked";
            }

            txtSearch.Clear();
        }

        private void dgvAttendance_CellContentClick(
            object? sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
