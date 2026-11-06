using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Classesform : Form
    {
        private DataTable classesTable;
        private int selectedClassID = 0;

        public Classesform()
        {
            InitializeComponent();

            // Bind events programmatically to ensure immediate execution
            this.dgvClasses.CellClick += new DataGridViewCellEventHandler(this.dgvClasses_CellClick);
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            // Bind instant search event handler
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);
        }

        private void Classesform_Load(object sender, EventArgs e)
        {
            LoadMockData();          // Load mock data for classes
            LoadMockTeachers();      // Load mock data for teachers combo box
        }

        // 1. Create mock classes data table and bind it to DataGridView
        private void LoadMockData()
        {
            classesTable = new DataTable();
            classesTable.Columns.Add("ClassID", typeof(int));
            classesTable.Columns.Add("ClassName", typeof(string));
            classesTable.Columns.Add("GradeLevel", typeof(string));
            classesTable.Columns.Add("TeacherName", typeof(string));

            // Add sample test rows for layout testing
            classesTable.Rows.Add(1, "Grade 10-A", "10", "Dr. Ahmed Khan");
            classesTable.Rows.Add(2, "Grade 11-B", "11", "Prof. Maria Silva");
            classesTable.Rows.Add(3, "Grade 12-A", "12", "Dr. Ahmed Khan");

            dgvClasses.DataSource = classesTable;
        }

        // 2. Populate teachers combo box with mock data
        private void LoadMockTeachers()
        {
            DataTable teachersTable = new DataTable();
            teachersTable.Columns.Add("TeacherID", typeof(int));
            teachersTable.Columns.Add("TeacherName", typeof(string));

            teachersTable.Rows.Add(1, "Dr. Ahmed Khan");
            teachersTable.Rows.Add(2, "Prof. Maria Silva");
            teachersTable.Rows.Add(3, "Prof. Maria Shan");

            cmbTeachers.DataSource = teachersTable;
            cmbTeachers.DisplayMember = "TeacherName";
            cmbTeachers.ValueMember = "TeacherID";
            cmbTeachers.SelectedIndex = -1;
        }

        // 3. Add button handler (adds directly to mock rows for testing)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClassName.Text) || string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("Please enter both the Class Name and Grade Level!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newId = classesTable.Rows.Count + 1;
            string teacher = cmbTeachers.Text != "" ? cmbTeachers.Text : "Not Assigned";

            classesTable.Rows.Add(newId, txtClassName.Text.Trim(), txtGrade.Text.Trim(), teacher);
            MessageBox.Show("Class added successfully (Mock Mode)!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        // Handle grid cell click event to accurately capture ClassID and populate fields
        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvClasses.Rows.Count)
            {
                DataGridViewRow row = dgvClasses.Rows[e.RowIndex];

                // Verify that the cell is not empty and not the new row placeholder (*)
                if (row.Cells["ClassID"].Value != null && row.Cells["ClassID"].Value != DBNull.Value)
                {
                    selectedClassID = Convert.ToInt32(row.Cells["ClassID"].Value);
                    txtClassName.Text = row.Cells["ClassName"].Value?.ToString() ?? "";
                    txtGrade.Text = row.Cells["GradeLevel"].Value?.ToString() ?? "";
                    cmbTeachers.Text = row.Cells["TeacherName"].Value?.ToString() ?? "";
                }
            }
        }

        // Mock update button handler
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedClassID == 0)
            {
                MessageBox.Show("Please select a class to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataRow row in classesTable.Rows)
            {
                if ((int)row["ClassID"] == selectedClassID)
                {
                    row["ClassName"] = txtClassName.Text.Trim();
                    row["GradeLevel"] = txtGrade.Text.Trim();
                    row["TeacherName"] = cmbTeachers.Text;
                    break;
                }
            }
            MessageBox.Show("Class updated successfully (Mock Mode)!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        // Mock delete button handler
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedClassID == 0)
            {
                MessageBox.Show("Please select a class to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = classesTable.Rows.Count - 1; i >= 0; i--)
            {
                if ((int)classesTable.Rows[i]["ClassID"] == selectedClassID)
                {
                    classesTable.Rows.RemoveAt(i);
                    break;
                }
            }
            MessageBox.Show("Class deleted successfully (Mock Mode)!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void ClearFields()
        {
            txtClassName.Clear();
            txtGrade.Clear();
            cmbTeachers.SelectedIndex = -1;
            selectedClassID = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Instant mock search filter handler
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (classesTable != null)
            {
                string filter = txtSearch.Text.Trim();
                if (filter == "")
                {
                    classesTable.DefaultView.RowFilter = "";
                }
                else
                {
                    classesTable.DefaultView.RowFilter = $"ClassName LIKE '%{filter}%' OR GradeLevel LIKE '%{filter}%' OR TeacherName LIKE '%{filter}%'";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void txtClassName_TextChanged(object sender, EventArgs e) { }
        private void txtGrade_TextChanged(object sender, EventArgs e) { }
    }
}