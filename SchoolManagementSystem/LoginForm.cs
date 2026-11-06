using System.Drawing.Drawing2D;

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

        // These two empty methods are needed because the designer file
        // already refers to them. Leave them here for now.
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
            var dashboard = new DashboardForm(txtUsername.Text.Trim());

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

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}