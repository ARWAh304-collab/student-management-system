
using System;
using System.Drawing.Drawing2D;
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

        // Clips the logo into a circle
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

        // Login Button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Check empty fields
            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Please enter username and password.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Check login information
            if (username == "admin" && password == "1234")
            {
                var dashboard = new DashboardForm(username);

                dashboard.FormClosed += (s, args) =>
                {
                    if (dashboard.LoggedOut)
                    {
                        txtPassword.Clear();
                        this.Show();
                    }
                    else
                    {
                        this.Close();
                    }
                };

                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        // Show / Hide Password
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
