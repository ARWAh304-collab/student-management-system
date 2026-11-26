
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SchoolManagementSystem
{
    public partial class frmUser : Form
    {
        private readonly string currentUsername;
        private string selectedUserId = "";

        public frmUser() : this("")
        {
        }

        public frmUser(string loggedInUsername)
        {
            InitializeComponent();

            currentUsername = loggedInUsername;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            dgvStudents.CellClick += dgvUsers_CellClick;
            txtSearch.TextChanged += txtSearch_TextChanged;

            InitializeUserPage();
        }

        private void InitializeUserPage()
        {
            lblTitle.Text = "User Management";
            Text = "User Management";

            if (dgvStudents.Columns.Count == 0)
            {
                dgvStudents.Columns.Add("ID", "User ID");
                dgvStudents.Columns.Add("Username", "Username");
                dgvStudents.Columns.Add("Role", "Role");
                dgvStudents.Columns.Add("FullName", "Full Name");
            }

            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;

            cmbGender.Items.Clear();
            cmbGender.Items.Add("Admin");
            cmbGender.Items.Add("Teacher");
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;

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

            RefreshUsersGrid();
        }

        private void RefreshUsersGrid()
        {
            dgvStudents.Rows.Clear();

            foreach (UserAccount user in UserData.Users)
            {
                dgvStudents.Rows.Add(
                    user.Id,
                    user.Username,
                    user.Role,
                    user.FullName);
            }

            selectedUserId = "";
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            string id = txtUserId.Text.Trim();
            string username = txtUsername.Text.Trim();
            string fullName = textBox1.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirm.Text;
            string role = cmbGender.Text;

            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (role != "Admin" && role != "Teacher")
            {
                MessageBox.Show("Please select a valid role.");
                return;
            }

            if (!string.Equals(password, confirmPassword, StringComparison.Ordinal))
            {
                MessageBox.Show(
                    "The passwords are different. Please enter the same password in both fields.\n\n" +
                    "Password length: " + password.Length +
                    "\nConfirm Password length: " + confirmPassword.Length);

                txtConfirm.Clear();
                txtConfirm.Focus();
                return;
            }

            if (UserData.Users.Any(u =>
                u.Id.Equals(id, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("This User ID already exists.");
                return;
            }

            if (UserData.Users.Any(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("This username already exists.");
                return;
            }

            UserData.AddUser(id, username, fullName, role, password);

            RefreshUsersGrid();
            ClearFields();

            MessageBox.Show("User added successfully.");
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUserId))
            {
                MessageBox.Show("Select a user from the table first.");
                return;
            }

            UserAccount? user = UserData.Users.FirstOrDefault(
                u => u.Id == selectedUserId);

            if (user == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            string username = txtUsername.Text.Trim();
            string fullName = textBox1.Text.Trim();
            string role = cmbGender.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirm.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Username and Full Name are required.");
                return;
            }

            if (role != "Admin" && role != "Teacher")
            {
                MessageBox.Show("Please select a valid role.");
                return;
            }

            if (UserData.Users.Any(u =>
                u.Id != selectedUserId &&
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("This username already exists.");
                return;
            }

            if (!string.IsNullOrEmpty(password) ||
                !string.IsNullOrEmpty(confirmPassword))
            {
                if (string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(confirmPassword) ||
                    !string.Equals(password, confirmPassword, StringComparison.Ordinal))
                {
                    MessageBox.Show("Please enter the same new password in both fields.");
                    return;
                }
            }

            if (user.Username.Equals(
                currentUsername,
                StringComparison.OrdinalIgnoreCase) &&
                role != "Admin")
            {
                MessageBox.Show("You cannot change your own Admin role.");
                return;
            }

            user.Username = username;
            user.FullName = fullName;
            user.Role = role;

            if (!string.IsNullOrEmpty(password))
            {
                byte[] salt = RandomNumberGenerator.GetBytes(16);

                byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                    password,
                    salt,
                    100000,
                    HashAlgorithmName.SHA256,
                    32);

                user.PasswordSalt = salt;
                user.PasswordHash = hash;
            }

            RefreshUsersGrid();
            ClearFields();

            MessageBox.Show("User updated successfully.");
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUserId))
            {
                MessageBox.Show("Select a user from the table first.");
                return;
            }

            UserAccount? user = UserData.Users.FirstOrDefault(
                u => u.Id == selectedUserId);

            if (user == null)
                return;

            if (user.Username.Equals(
                currentUsername,
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot delete the account you are currently using.");
                return;
            }

            if (user.Role == "Admin" &&
                UserData.Users.Count(u => u.Role == "Admin") <= 1)
            {
                MessageBox.Show("You cannot delete the last Admin account.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Delete this user?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserData.Users.Remove(user);

                RefreshUsersGrid();
                ClearFields();

                MessageBox.Show("User deleted successfully.");
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
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

            selectedUserId = "";
            dgvStudents.ClearSelection();
        }

        private void dgvUsers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

            selectedUserId = row.Cells[0].Value?.ToString() ?? "";

            txtUserId.Text = selectedUserId;
            txtUsername.Text = row.Cells[1].Value?.ToString() ?? "";
            cmbGender.Text = row.Cells[2].Value?.ToString() ?? "";
            textBox1.Text = row.Cells[3].Value?.ToString() ?? "";

            txtPassword.Clear();
            txtConfirm.Clear();
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                string username = row.Cells[1].Value?.ToString() ?? "";

                row.Visible = username.Contains(
                    search,
                    StringComparison.OrdinalIgnoreCase);
            }

            selectedUserId = "";
        }

        private void label4_Click(object? sender, EventArgs e)
        {
        }

        private void frmUser_Load(object? sender, EventArgs e)
        {
        }
    }
}
