namespace SchoolManagementSystem
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            dgvStudents.CellClick += dgvUsers_CellClick;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            // تغيير العنوان والنص
            lblTitle.Text = "User Management";
            Text = "User Management";

            // أعمدة الجدول
            if (dgvStudents.Columns.Count == 0)
            {
                dgvStudents.Columns.Add("ID", "User ID");
                dgvStudents.Columns.Add("Username", "Username");
                dgvStudents.Columns.Add("Role", "Role");
                dgvStudents.Columns.Add("FullName", "Full Name");
            }

            // ألوان الأزرار: Add وClear أخضر، Update وDelete أزرق
            btnAdd.BackColor = Color.FromArgb(46, 158, 79);
            btnClear.BackColor = Color.FromArgb(46, 158, 79);
            btnUpdate.BackColor = Color.FromArgb(31, 58, 147);
            btnDelete.BackColor = Color.FromArgb(31, 58, 147);
            foreach (var b in new[] { btnAdd, btnUpdate, btnDelete, btnClear })
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.ForeColor = Color.White;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text))
            {
                MessageBox.Show("Please enter the user ID.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username and password are required.");
                return;
            }
            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (row.Cells[0].Value?.ToString() == txtUserId.Text.Trim())
                {
                    MessageBox.Show("This User ID already exists.");
                    return;
                }
            }

            dgvStudents.Rows.Add(txtUserId.Text.Trim(), txtUsername.Text,
                cmbGender.Text, textBox1.Text);
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Select a user from the table first.");
                return;
            }
            var r = dgvStudents.CurrentRow;
            r.Cells[1].Value = txtUsername.Text;
            r.Cells[2].Value = cmbGender.Text;
            r.Cells[3].Value = textBox1.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Select a user from the table first.");
                return;
            }
            if (MessageBox.Show("Delete this user?", "Confirm",
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
            txtUserId.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirm.Clear();
            textBox1.Clear();
            cmbGender.SelectedIndex = -1;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var r = dgvStudents.Rows[e.RowIndex];
            txtUserId.Text = r.Cells[0].Value?.ToString();
            txtUsername.Text = r.Cells[1].Value?.ToString();
            cmbGender.Text = r.Cells[2].Value?.ToString();
            textBox1.Text = r.Cells[3].Value?.ToString();
            txtPassword.Clear();
            txtConfirm.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStudents.CurrentCell = null;
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                bool match = row.Cells[1].Value?.ToString()
                    .Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ?? false;
                row.Visible = match || string.IsNullOrEmpty(txtSearch.Text);
            }
        }

        // الدالة دي لازم تفضل لأن الـ Designer بيشاور عليها
        private void label4_Click(object sender, EventArgs e) { }
    }
}