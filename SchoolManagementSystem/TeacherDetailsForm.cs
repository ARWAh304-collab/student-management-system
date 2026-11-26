
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class AddTeacherForm : Form
    {
        public enum FormMode
        {
            Add,
            Edit,
            View
        }

        private FormMode currentMode;
        private TeacherInfo? selectedTeacher;
        private string selectedPhotoPath = "";

        public AddTeacherForm()
        {
            InitializeComponent();

            currentMode = FormMode.Add;

            this.Load -= AddTeacherForm_Load_1;
            this.Load += AddTeacherForm_Load_1;

            btnSave.Click -= btnSave_Click;
            btnSave.Click += btnSave_Click;

            btnCancel.Click -= btnCancel_Click;
            btnCancel.Click += btnCancel_Click;

            btnUploadPhoto.Click -= btnUploadPhoto_Click;
            btnUploadPhoto.Click += btnUploadPhoto_Click;

            txtNewPhone.KeyPress -= txtNewPhone_KeyPress;
            txtNewPhone.KeyPress += txtNewPhone_KeyPress;
        }

        public AddTeacherForm(FormMode mode, TeacherInfo? teacher = null)
            : this()
        {
            currentMode = mode;
            selectedTeacher = teacher;
        }

        private void AddTeacherForm_Load_1(object sender, EventArgs e)
        {
            if (currentMode == FormMode.Add)
            {
                Text = "Add New Teacher";
                lblTeacherFormTitle.Text = "Add New Teacher";

                btnSave.Visible = true;
                btnUploadPhoto.Visible = true;
                btnUploadPhoto.Enabled = true;
            }
            else if (currentMode == FormMode.Edit)
            {
                Text = "Edit Teacher";
                lblTeacherFormTitle.Text = "Edit Teacher";

                btnSave.Visible = true;
                btnUploadPhoto.Visible = true;
                btnUploadPhoto.Enabled = true;

                LoadTeacherData();
            }
            else if (currentMode == FormMode.View)
            {
                Text = "View Teacher";
                lblTeacherFormTitle.Text = "View Teacher";

                LoadTeacherData();
                SetFieldsReadOnly();

                btnSave.Visible = false;
                btnUploadPhoto.Visible = false;
            }
        }

        // Allow numbers only in phone field
        private void txtNewPhone_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LoadTeacherData()
        {
            if (selectedTeacher == null)
                return;

            txtNewTeacherName.Text = selectedTeacher.Name;
            txtNewPhone.Text = selectedTeacher.Phone;
            txtNewEmail.Text = selectedTeacher.Email;
            txtNewSubject.Text = selectedTeacher.Subject;
            txtNewAddress.Text = selectedTeacher.Address;
            txtNewDepartment.Text = selectedTeacher.Department;

            selectedPhotoPath = selectedTeacher.PhotoPath ?? "";

            LoadTeacherPhoto(selectedPhotoPath);
        }

        private void LoadTeacherPhoto(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
                return;

            try
            {
                byte[] imageBytes = File.ReadAllBytes(path);

                using (MemoryStream stream = new MemoryStream(imageBytes))
                using (Image image = Image.FromStream(stream))
                {
                    Image newImage = new Bitmap(image);

                    if (picTeacherPhoto.Image != null)
                    {
                        Image oldImage = picTeacherPhoto.Image;
                        picTeacherPhoto.Image = null;
                        oldImage.Dispose();
                    }

                    picTeacherPhoto.Image = newImage;
                    picTeacherPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load photo: " + ex.Message,
                    "Photo Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnUploadPhoto_Click(object? sender, EventArgs e)
        {
            if (currentMode == FormMode.View)
                return;

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Choose Teacher Photo";
                dialog.Filter =
                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                dialog.Multiselect = false;
                dialog.CheckFileExists = true;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    selectedPhotoPath = dialog.FileName;
                    LoadTeacherPhoto(selectedPhotoPath);
                }
            }
        }

        private void SetFieldsReadOnly()
        {
            txtNewTeacherName.ReadOnly = true;
            txtNewPhone.ReadOnly = true;
            txtNewEmail.ReadOnly = true;
            txtNewSubject.ReadOnly = true;
            txtNewAddress.ReadOnly = true;
            txtNewDepartment.ReadOnly = true;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            // Validate all text fields
            if (string.IsNullOrWhiteSpace(txtNewTeacherName.Text) ||
                string.IsNullOrWhiteSpace(txtNewPhone.Text) ||
                string.IsNullOrWhiteSpace(txtNewEmail.Text) ||
                string.IsNullOrWhiteSpace(txtNewSubject.Text) ||
                string.IsNullOrWhiteSpace(txtNewAddress.Text) ||
                string.IsNullOrWhiteSpace(txtNewDepartment.Text))
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validate phone contains digits only
            foreach (char digit in txtNewPhone.Text)
            {
                if (!char.IsDigit(digit))
                {
                    MessageBox.Show(
                        "Phone number must contain numbers only.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtNewPhone.Focus();
                    return;
                }
            }

            // A photo is required when adding a teacher.
            // In Edit mode, the existing photo can be kept.
            if (currentMode == FormMode.Add &&
                (string.IsNullOrWhiteSpace(selectedPhotoPath) ||
                 !File.Exists(selectedPhotoPath)))
            {
                MessageBox.Show(
                    "Please upload a teacher photo.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (currentMode == FormMode.Edit &&
                (string.IsNullOrWhiteSpace(selectedPhotoPath) ||
                 !File.Exists(selectedPhotoPath)))
            {
                MessageBox.Show(
                    "The teacher photo could not be found. Please upload a new photo.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (currentMode == FormMode.Add)
            {
                TeacherInfo teacher = new TeacherInfo
                {
                    Name = txtNewTeacherName.Text.Trim(),
                    Phone = txtNewPhone.Text.Trim(),
                    Email = txtNewEmail.Text.Trim(),
                    Subject = txtNewSubject.Text.Trim(),
                    Address = txtNewAddress.Text.Trim(),
                    Department = txtNewDepartment.Text.Trim(),
                    PhotoPath = selectedPhotoPath
                };

                TeacherData.Teachers.Add(teacher);

                MessageBox.Show(
                    "Teacher added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else if (currentMode == FormMode.Edit && selectedTeacher != null)
            {
                selectedTeacher.Name = txtNewTeacherName.Text.Trim();
                selectedTeacher.Phone = txtNewPhone.Text.Trim();
                selectedTeacher.Email = txtNewEmail.Text.Trim();
                selectedTeacher.Subject = txtNewSubject.Text.Trim();
                selectedTeacher.Address = txtNewAddress.Text.Trim();
                selectedTeacher.Department = txtNewDepartment.Text.Trim();

                // Keep old photo or save the newly selected photo
                selectedTeacher.PhotoPath = selectedPhotoPath;

                MessageBox.Show(
                    "Teacher updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (picTeacherPhoto.Image != null)
            {
                Image oldImage = picTeacherPhoto.Image;
                picTeacherPhoto.Image = null;
                oldImage.Dispose();
            }

            base.OnFormClosed(e);
        }
    }
}
