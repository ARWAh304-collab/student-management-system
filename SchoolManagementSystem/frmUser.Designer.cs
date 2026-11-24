namespace SchoolManagementSystem
{
    partial class frmUser
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
            lblTitle = new Label();
            pnlHeader = new Panel();
            cmbGender = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            lblName = new Label();
            lblAddress = new Label();
            txtConfirm = new TextBox();
            lblPhone = new Label();
            txtPassword = new TextBox();
            txtUserId = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            Search = new Label();
            txtSearch = new TextBox();
            dgvStudents = new DataGridView();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(252, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(303, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Management";
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
            pnlHeader.TabIndex = 46;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Admin", "Teacher" });
            cmbGender.Location = new Point(539, 116);
            cmbGender.Margin = new Padding(3, 4, 3, 4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(96, 28);
            cmbGender.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(31, 58, 147);
            label4.Location = new Point(465, 162);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 35;
            label4.Text = "Full Name";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(31, 58, 147);
            label2.Location = new Point(465, 120);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 33;
            label2.Text = "Role";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(125, 162);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(314, 27);
            txtUsername.TabIndex = 32;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(31, 58, 147);
            lblName.Location = new Point(32, 166);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 20);
            lblName.TabIndex = 31;
            lblName.Text = "Username";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.ForeColor = Color.FromArgb(31, 58, 147);
            lblAddress.Location = new Point(10, 269);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(127, 20);
            lblAddress.TabIndex = 30;
            lblAddress.Text = "Confirm Password";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(125, 266);
            txtConfirm.Margin = new Padding(3, 4, 3, 4);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(314, 27);
            txtConfirm.TabIndex = 29;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.ForeColor = Color.FromArgb(31, 58, 147);
            lblPhone.Location = new Point(34, 221);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(70, 20);
            lblPhone.TabIndex = 28;
            lblPhone.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(125, 221);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(314, 27);
            txtPassword.TabIndex = 27;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(125, 112);
            txtUserId.Margin = new Padding(3, 4, 3, 4);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(314, 27);
            txtUserId.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.FromArgb(31, 58, 147);
            label1.Location = new Point(41, 116);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 25;
            label1.Text = "User ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(539, 162);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 27);
            textBox1.TabIndex = 47;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(31, 58, 147);
            btnAdd.Location = new Point(32, 342);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(46, 158, 79);
            btnClear.Location = new Point(719, 342);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 42;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(46, 158, 79);
            btnDelete.Location = new Point(486, 342);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(31, 58, 147);
            btnUpdate.Location = new Point(252, 342);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 40;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.ForeColor = Color.FromArgb(31, 58, 147);
            Search.Location = new Point(33, 490);
            Search.Name = "Search";
            Search.Size = new Size(53, 20);
            Search.TabIndex = 43;
            Search.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(89, 486);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 27);
            txtSearch.TabIndex = 44;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(10, 521);
            dgvStudents.Margin = new Padding(3, 4, 3, 4);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.Height = 24;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(820, 150);
            dgvStudents.TabIndex = 45;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 816);
            Controls.Add(textBox1);
            Controls.Add(pnlHeader);
            Controls.Add(dgvStudents);
            Controls.Add(txtSearch);
            Controls.Add(Search);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbGender);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(lblName);
            Controls.Add(lblAddress);
            Controls.Add(txtConfirm);
            Controls.Add(lblPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtUserId);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUser";
            Load += frmUser_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Label Search;
        private TextBox txtSearch;
        private DataGridView dgvStudents;
    }
}