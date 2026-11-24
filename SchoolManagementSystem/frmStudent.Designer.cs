namespace SchoolManagementSystem
{
    partial class frmStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtId = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            lblPhone = new Label();
            lblAddress = new Label();
            txtName = new TextBox();
            lblName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpBirth = new DateTimePicker();
            cmbGender = new ComboBox();
            cmbClass = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            Search = new Label();
            txtSearch = new TextBox();
            dgvStudents = new DataGridView();
            pnlHeader = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.FromArgb(31, 58, 147);
            label1.Location = new Point(2, 100);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(86, 100);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(314, 27);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(86, 196);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(314, 27);
            txtPhone.TabIndex = 3;
            txtPhone.TextChanged += textBox1_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(86, 251);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(314, 27);
            txtAddress.TabIndex = 5;
            txtAddress.TextChanged += textBox2_TextChanged;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.ForeColor = Color.FromArgb(31, 58, 147);
            lblPhone.Location = new Point(2, 200);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.ForeColor = Color.FromArgb(31, 58, 147);
            lblAddress.Location = new Point(2, 250);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address";
            lblAddress.Click += lblAddress_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(86, 150);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(314, 27);
            txtName.TabIndex = 9;
            txtName.TextChanged += textBox4_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(31, 58, 147);
            lblName.Location = new Point(2, 150);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 20);
            lblName.TabIndex = 8;
            lblName.Text = "Full Name";
            lblName.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(31, 58, 147);
            label2.Location = new Point(461, 184);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 10;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(31, 58, 147);
            label3.Location = new Point(461, 121);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 11;
            label3.Text = "Birth Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(31, 58, 147);
            label4.Location = new Point(461, 239);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 12;
            label4.Text = "Class";
            // 
            // dtpBirth
            // 
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.Location = new Point(532, 121);
            dtpBirth.Margin = new Padding(3, 4, 3, 4);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(175, 27);
            dtpBirth.TabIndex = 14;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(532, 174);
            cmbGender.Margin = new Padding(3, 4, 3, 4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(96, 28);
            cmbGender.TabIndex = 15;
            // 
            // cmbClass
            // 
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(532, 235);
            cmbClass.Margin = new Padding(3, 4, 3, 4);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(96, 28);
            cmbClass.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(31, 58, 147);
            btnAdd.Location = new Point(34, 349);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(31, 58, 147);
            btnUpdate.Location = new Point(245, 349);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(46, 158, 79);
            btnDelete.Location = new Point(484, 349);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(46, 158, 79);
            btnClear.Location = new Point(719, 349);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.ForeColor = Color.FromArgb(31, 58, 147);
            Search.Location = new Point(12, 508);
            Search.Name = "Search";
            Search.Size = new Size(53, 20);
            Search.TabIndex = 21;
            Search.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(68, 509);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 27);
            txtSearch.TabIndex = 22;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(34, 544);
            dgvStudents.Margin = new Padding(3, 4, 3, 4);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.Height = 24;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(820, 150);
            dgvStudents.TabIndex = 23;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(31, 58, 147);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(882, 92);
            pnlHeader.TabIndex = 24;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(294, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(303, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Management";
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 816);
            Controls.Add(pnlHeader);
            Controls.Add(dgvStudents);
            Controls.Add(txtSearch);
            Controls.Add(Search);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbClass);
            Controls.Add(cmbGender);
            Controls.Add(dtpBirth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(txtId);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management";
            Load += frmStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
    }
}