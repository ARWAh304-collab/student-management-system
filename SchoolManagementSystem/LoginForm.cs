
using System;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            MakeLogoCircular();
        }

        private void MakeLogoCircular()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picLogo.Width, picLogo.Height);
            picLogo.Region = new Region(path);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter username and password.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            UserAccount? user = UserData.Users.FirstOrDefault(
                u => string.Equals(
                    u.Username,
                    username,
                    StringComparison.OrdinalIgnoreCase));

            if (user != null && UserData.VerifyPassword(user, password))
            {
                var dashboard = new DashboardForm(user.Username, user.Role);

                dashboard.FormClosed += (s, args) =>
                {
                    if (dashboard.LoggedOut)
                    {
                        txtPassword.Clear();
                        Show();
                    }
                    else
                    {
                        Close();
                    }
                };

                Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
