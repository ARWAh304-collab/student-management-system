
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class TeacherManage : Form
    {
        private bool updatingFilterList = false;
        private bool resettingFilters = false;

        public TeacherManage()
        {
            InitializeComponent();

            LoadTeacherCards();

            txtSearchTeacher.TextChanged += txtSearchTeacher_TextChanged;
            clbTeacherNames.ItemCheck += clbTeacherNames_ItemCheck;
            btnResetFilters.Click += btnResetFilters_Click;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm form =
                new AddTeacherForm(AddTeacherForm.FormMode.Add);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTeacherCards();
            }
        }

        private void UpdateTeacherNameFilter()
        {
            List<string> selectedNames = new List<string>();

            foreach (var item in clbTeacherNames.CheckedItems)
            {
                selectedNames.Add(item.ToString()!);
            }

            updatingFilterList = true;

            clbTeacherNames.Items.Clear();

            foreach (TeacherInfo teacher in TeacherData.Teachers)
            {
                int index = clbTeacherNames.Items.Add(teacher.Name);

                if (selectedNames.Contains(teacher.Name))
                {
                    clbTeacherNames.SetItemChecked(index, true);
                }
            }

            updatingFilterList = false;
        }

        private void LoadTeacherCards()
        {
            Panel templateCard = panel3;

            flpTeachers.Controls.Clear();

            UpdateTeacherNameFilter();

            string searchText = txtSearchTeacher.Text.Trim();

            foreach (TeacherInfo teacher in TeacherData.Teachers)
            {
                // Search by teacher name
                if (!teacher.Name.Contains(
                    searchText, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                // Filter by selected teacher names
                if (clbTeacherNames.CheckedItems.Count > 0 &&
                    !clbTeacherNames.CheckedItems.Contains(teacher.Name))
                {
                    continue;
                }

                Panel card = (Panel)CloneControl(templateCard);

                FindControl(card, "label24").Text = teacher.Name;
                FindControl(card, "label20").Text = teacher.Department;
                FindControl(card, "label19").Text = teacher.Email;
                FindControl(card, "label18").Text = teacher.Subject;

                // Edit button
                Button btnEdit =
                    (Button)FindControl(card, "button8");

                btnEdit.Click += (s, e) =>
                {
                    AddTeacherForm form = new AddTeacherForm(
                        AddTeacherForm.FormMode.Edit, teacher);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadTeacherCards();
                    }
                };

                // View button
                Button btnView =
                    (Button)FindControl(card, "button7");

                btnView.Click += (s, e) =>
                {
                    AddTeacherForm form = new AddTeacherForm(
                        AddTeacherForm.FormMode.View, teacher);

                    form.ShowDialog();
                };

                // Delete button
                Button btnDelete =
                    (Button)FindControl(card, "button9");

                btnDelete.Click += (s, e) =>
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this teacher?",
                        "Delete Teacher",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        TeacherData.Teachers.Remove(teacher);
                        LoadTeacherCards();
                    }
                };

                flpTeachers.Controls.Add(card);
            }
        }

        // Teacher names filter event
        private void clbTeacherNames_ItemCheck(
            object sender, ItemCheckEventArgs e)
        {
            if (updatingFilterList || resettingFilters)
                return;

            BeginInvoke(new Action(() =>
            {
                LoadTeacherCards();
            }));
        }

        // Reset all filters
        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            resettingFilters = true;

            txtSearchTeacher.Clear();

            for (int i = 0; i < clbTeacherNames.Items.Count; i++)
            {
                clbTeacherNames.SetItemChecked(i, false);
            }

            resettingFilters = false;

            LoadTeacherCards();
        }

        // Copy the original card and its controls
        private Control CloneControl(Control original)
        {
            Control copy;

            if (original is Panel)
                copy = new Panel();
            else if (original is Label)
                copy = new Label();
            else if (original is Button)
                copy = new Button();
            else if (original is PictureBox)
                copy = new PictureBox();
            else
                copy = new Control();

            copy.Name = original.Name;
            copy.Text = original.Text;
            copy.Size = original.Size;
            copy.Location = original.Location;
            copy.BackColor = original.BackColor;
            copy.ForeColor = original.ForeColor;
            copy.Font = original.Font;
            copy.Margin = original.Margin;
            copy.Padding = original.Padding;
            copy.Anchor = original.Anchor;
            copy.Dock = original.Dock;
            copy.Visible = original.Visible;
            copy.Enabled = original.Enabled;

            if (original is Panel originalPanel &&
                copy is Panel copiedPanel)
            {
                copiedPanel.BorderStyle =
                    originalPanel.BorderStyle;
            }

            if (original is Label originalLabel &&
                copy is Label copiedLabel)
            {
                copiedLabel.AutoSize = originalLabel.AutoSize;
                copiedLabel.TextAlign = originalLabel.TextAlign;
            }

            if (original is Button originalButton &&
                copy is Button copiedButton)
            {
                copiedButton.FlatStyle = originalButton.FlatStyle;
                copiedButton.TextAlign = originalButton.TextAlign;
                copiedButton.UseVisualStyleBackColor =
                    originalButton.UseVisualStyleBackColor;

                copiedButton.FlatAppearance.BorderSize =
                    originalButton.FlatAppearance.BorderSize;

                copiedButton.FlatAppearance.BorderColor =
                    originalButton.FlatAppearance.BorderColor;
            }

            if (original is PictureBox originalPicture &&
                copy is PictureBox copiedPicture)
            {
                copiedPicture.Image = originalPicture.Image;
                copiedPicture.SizeMode = originalPicture.SizeMode;
                copiedPicture.BorderStyle =
                    originalPicture.BorderStyle;
            }

            foreach (Control child in original.Controls)
            {
                copy.Controls.Add(CloneControl(child));
            }

            return copy;
        }

        // Find a control inside the copied card
        private Control FindControl(Control parent, string name)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Name == name)
                    return control;

                Control found = FindControl(control, name);

                if (found != null)
                    return found;
            }

            return null!;
        }

        // Search TextBox event
        private void txtSearchTeacher_TextChanged(
            object sender, EventArgs e)
        {
            LoadTeacherCards();
        }

        // Designer event handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTeacherCards();
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
