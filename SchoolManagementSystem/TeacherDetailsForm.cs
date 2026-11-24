
using System;
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

        public AddTeacherForm()
        {
            InitializeComponent();

            currentMode = FormMode.Add;

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
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
                this.Text = "Add New Teacher";
            }
            else if (currentMode == FormMode.Edit)
            {
                this.Text = "Edit Teacher";
                LoadTeacherData();
            }
            else if (currentMode == FormMode.View)
            {
                this.Text = "View Teacher";
                LoadTeacherData();
                SetFieldsReadOnly();
                btnSave.Visible = false;
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
        }

        private void SetFieldsReadOnly()
        {
            txtNewTeacherName.ReadOnly = true;
            txtNewPhone.ReadOnly = true;
            txtNewEmail.ReadOnly = true;
            txtNewSubject.ReadOnly = true;
            txtNewAddress.ReadOnly = true;
            txtNewDepartment.ReadOnly = true;

            btnUploadPhoto.Visible = false;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewTeacherName.Text))
            {
                MessageBox.Show("Please enter teacher name.");
                return;
            }

            if (currentMode == FormMode.Add)
            {
                TeacherInfo teacher = new TeacherInfo
                {
                    Name = txtNewTeacherName.Text,
                    Phone = txtNewPhone.Text,
                    Email = txtNewEmail.Text,
                    Subject = txtNewSubject.Text,
                    Address = txtNewAddress.Text,
                    Department = txtNewDepartment.Text
                };

                TeacherData.Teachers.Add(teacher);

                MessageBox.Show("Teacher added successfully!");
            }
            else if (currentMode == FormMode.Edit && selectedTeacher != null)
            {
                selectedTeacher.Name = txtNewTeacherName.Text;
                selectedTeacher.Phone = txtNewPhone.Text;
                selectedTeacher.Email = txtNewEmail.Text;
                selectedTeacher.Subject = txtNewSubject.Text;
                selectedTeacher.Address = txtNewAddress.Text;
                selectedTeacher.Department = txtNewDepartment.Text;

                MessageBox.Show("Teacher updated successfully!");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
