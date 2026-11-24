namespace SchoolManagementSystem
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();

            // ربط الأحداث بالكود (من غير ما نلمس الـ Designer)
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            dgvStudents.CellClick += dgvStudents_CellClick;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            // أعمدة الجدول
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

            // قيم الـ Class (كانت فاضية)
            if (cmbClass.Items.Count == 0)
                cmbClass.Items.AddRange(new object[] { "Class 1", "Class 2", "Class 3", "Class 4" });
        }

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
            if (cmbGender.SelectedIndex == -1 || cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender and class.");
                return;
            }

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (row.Cells[0].Value?.ToString() == txtId.Text.Trim())
                {
                    MessageBox.Show("This ID already exists.");
                    return;
                }
            }

            dgvStudents.Rows.Add(txtId.Text.Trim(), txtName.Text, txtPhone.Text,
                txtAddress.Text, dtpBirth.Value.ToShortDateString(),
                cmbGender.Text, cmbClass.Text);

            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Select a student from the table first.");
                return;
            }
            var r = dgvStudents.CurrentRow;
            r.Cells[1].Value = txtName.Text;
            r.Cells[2].Value = txtPhone.Text;
            r.Cells[3].Value = txtAddress.Text;
            r.Cells[4].Value = dtpBirth.Value.ToShortDateString();
            r.Cells[5].Value = cmbGender.Text;
            r.Cells[6].Value = cmbClass.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Select a student from the table first.");
                return;
            }
            if (MessageBox.Show("Delete this student?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvStudents.Rows.Remove(dgvStudents.CurrentRow);
                ClearFields();
            }
        }

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

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var r = dgvStudents.Rows[e.RowIndex];
            txtId.Text = r.Cells[0].Value?.ToString();
            txtName.Text = r.Cells[1].Value?.ToString();
            txtPhone.Text = r.Cells[2].Value?.ToString();
            txtAddress.Text = r.Cells[3].Value?.ToString();
            if (DateTime.TryParse(r.Cells[4].Value?.ToString(), out var d))
                dtpBirth.Value = d;
            cmbGender.Text = r.Cells[5].Value?.ToString();
            cmbClass.Text = r.Cells[6].Value?.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStudents.CurrentCell = null; // علشان نقدر نخفي الصف الحالي
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                bool match = row.Cells[1].Value?.ToString()
                    .Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ?? false;
                row.Visible = match || string.IsNullOrEmpty(txtSearch.Text);
            }
        }

        // الدوال دي لازم تفضل موجودة لأن الـ Designer بيشاور عليها
        private void txtId_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void lblAddress_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}