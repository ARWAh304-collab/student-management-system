
using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            dgvStudents.CellClick += dgvStudents_CellClick;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            if (dgvStudents.Columns.Count == 0)
            {
                dgvStudents.Columns.Add("ID", "ID");
                dgvStudents.Columns.Add("Name", "Full Name");
                dgvStudents.Columns.Add("Phone", "Phone");
                dgvStudents.Columns.Add("Address", "Address");
                dgvStudents.Columns.Add("Birth", "Birth Date");
                dgvStudents.Columns.Add("Gender", "Gender");
                dgvStudents.Columns.Add("Class", "Class");
            }

            if (cmbClass.Items.Count == 0)
            {
                cmbClass.Items.AddRange(new object[]
                {
                    "Class 1", "Class 2", "Class 3", "Class 4"
                });
            }

            // Load saved students into the table
            dgvStudents.Rows.Clear();

            foreach (StudentInfo student in StudentData.Students)
            {
                dgvStudents.Rows.Add(
                    student.ID,
                    student.Name,
                    student.Phone,
                    student.Address,
                    student.Birth,
                    student.Gender,
                    student.Class
                );
            }
        }

        // Add Student
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter the student ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the student name.");
                return;
            }

            if (cmbGender.SelectedIndex == -1 ||
                cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender and class.");
                return;
            }

            string id = txtId.Text.Trim();

            foreach (StudentInfo student in StudentData.Students)
            {
                if (student.ID == id)
                {
                    MessageBox.Show("This ID already exists.");
                    return;
                }
            }

            StudentInfo newStudent = new StudentInfo
            {
                ID = id,
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                Birth = dtpBirth.Value.ToShortDateString(),
                Gender = cmbGender.Text,
                Class = cmbClass.Text
            };

            StudentData.Students.Add(newStudent);

            dgvStudents.Rows.Add(
                newStudent.ID,
                newStudent.Name,
                newStudent.Phone,
                newStudent.Address,
                newStudent.Birth,
                newStudent.Gender,
                newStudent.Class
            );

            ClearFields();
        }

        // Update Student
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null ||
                dgvStudents.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Select a student from the table first.");
                return;
            }

            string id = dgvStudents.CurrentRow.Cells[0].Value?.ToString() ?? "";

            StudentInfo? student = StudentData.Students.Find(s => s.ID == id);

            if (student == null)
                return;

            student.Name = txtName.Text.Trim();
            student.Phone = txtPhone.Text;
            student.Address = txtAddress.Text;
            student.Birth = dtpBirth.Value.ToShortDateString();
            student.Gender = cmbGender.Text;
            student.Class = cmbClass.Text;

            var r = dgvStudents.CurrentRow;

            r.Cells[1].Value = student.Name;
            r.Cells[2].Value = student.Phone;
            r.Cells[3].Value = student.Address;
            r.Cells[4].Value = student.Birth;
            r.Cells[5].Value = student.Gender;
            r.Cells[6].Value = student.Class;

            MessageBox.Show("Student updated successfully.");
        }

        // Delete Student
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null ||
                dgvStudents.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Select a student from the table first.");
                return;
            }

            if (MessageBox.Show(
                "Delete this student?",
                "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string id = dgvStudents.CurrentRow.Cells[0].Value?.ToString() ?? "";

                StudentInfo? student =
                    StudentData.Students.Find(s => s.ID == id);

                if (student != null)
                    StudentData.Students.Remove(student);

                dgvStudents.Rows.Remove(dgvStudents.CurrentRow);

                ClearFields();
            }
        }

        // Clear Fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            cmbGender.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;

            dtpBirth.Value = DateTime.Now;
        }

        // Select Student
        private void dgvStudents_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var r = dgvStudents.Rows[e.RowIndex];

            txtId.Text = r.Cells[0].Value?.ToString();
            txtName.Text = r.Cells[1].Value?.ToString();
            txtPhone.Text = r.Cells[2].Value?.ToString();
            txtAddress.Text = r.Cells[3].Value?.ToString();

            if (DateTime.TryParse(
                r.Cells[4].Value?.ToString(), out var d))
            {
                dtpBirth.Value = d;
            }

            cmbGender.Text = r.Cells[5].Value?.ToString();
            cmbClass.Text = r.Cells[6].Value?.ToString();
        }

        // Search Student
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStudents.CurrentCell = null;

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                bool match = row.Cells[1].Value?.ToString()
                    .Contains(
                        txtSearch.Text,
                        StringComparison.OrdinalIgnoreCase
                    ) ?? false;

                row.Visible = match || string.IsNullOrEmpty(txtSearch.Text);
            }
        }

        // Designer Events
        private void txtId_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void lblAddress_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}
