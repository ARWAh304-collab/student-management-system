namespace SchoolManagementSystem
{
    partial class AttendanceForm
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
            dgvAttendance = new DataGridView();
            pnlHeader = new Panel();
            label1 = new Label();
            pnlFilters = new Panel();
            txtSearch = new TextBox();
            label2 = new Label();
            dtpAttendanceDate = new DateTimePicker();
            lblDate = new Label();
            btnPresentAll = new Button();
            btnSave = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            pnlHeader.SuspendLayout();
            pnlFilters.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.WhiteSmoke;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(-2, 199);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(983, 385);
            dgvAttendance.TabIndex = 0;
            dgvAttendance.CellContentClick += dgvAttendance_CellContentClick;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 60, 142);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Location = new Point(-2, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(990, 83);
            pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(369, 24);
            label1.Name = "label1";
            label1.Size = new Size(171, 37);
            label1.TabIndex = 0;
            label1.Text = "Attendance ";
            // 
            // pnlFilters
            // 
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Controls.Add(label2);
            pnlFilters.Controls.Add(dtpAttendanceDate);
            pnlFilters.Controls.Add(lblDate);
            pnlFilters.Location = new Point(-2, 90);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(999, 93);
            pnlFilters.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(487, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(201, 27);
            txtSearch.TabIndex = 3;
            txtSearch.Click += txtSearch_TextChanged;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 15);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Search Student";
            // 
            // dtpAttendanceDate
            // 
            dtpAttendanceDate.Location = new Point(30, 38);
            dtpAttendanceDate.Name = "dtpAttendanceDate";
            dtpAttendanceDate.Size = new Size(250, 27);
            dtpAttendanceDate.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(14, 15);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(121, 20);
            lblDate.TabIndex = 0;
            lblDate.Text = "Attendance Date";
            // 
            // btnPresentAll
            // 
            btnPresentAll.BackColor = Color.FromArgb(31, 58, 147);
            btnPresentAll.Location = new Point(400, 603);
            btnPresentAll.Name = "btnPresentAll";
            btnPresentAll.Size = new Size(138, 29);
            btnPresentAll.TabIndex = 3;
            btnPresentAll.Text = "Mark All Present";
            btnPresentAll.UseVisualStyleBackColor = false;
            btnPresentAll.Click += btnPresentAll_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(31, 58, 147);
            btnSave.Location = new Point(612, 603);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Attendance";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(46, 158, 79);
            btnClear.Location = new Point(815, 603);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(982, 653);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnPresentAll);
            Controls.Add(pnlFilters);
            Controls.Add(pnlHeader);
            Controls.Add(dgvAttendance);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AttendanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance Management";
            Load += AttendanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAttendance;
        private Panel pnlHeader;
        private Label label1;
        private Panel pnlFilters;
        private Label lblDate;
        private TextBox txtSearch;
        private Label label2;
        private DateTimePicker dtpAttendanceDate;
        private Button btnPresentAll;
        private Button btnSave;
        private Button btnClear;
    }
}