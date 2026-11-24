namespace SchoolManagementSystem
{
    partial class Classesform
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classesform));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblClassName = new Label();
            txtClassName = new TextBox();
            txtGrade = new TextBox();
            lblGrade = new Label();
            lblTeacher = new Label();
            cmbTeachers = new ComboBox();
            btnAdd = new Button();
            imageList1 = new ImageList(components);
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvClasses = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassName.Location = new Point(11, 39);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(101, 20);
            lblClassName.TabIndex = 0;
            lblClassName.Text = "Class Name";
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(12, 68);
            txtClassName.Margin = new Padding(3, 4, 3, 4);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(153, 26);
            txtClassName.TabIndex = 1;
            txtClassName.TextChanged += txtClassName_TextChanged;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(214, 72);
            txtGrade.Margin = new Padding(3, 4, 3, 4);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(141, 26);
            txtGrade.TabIndex = 2;
            txtGrade.TextChanged += txtGrade_TextChanged;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrade.Location = new Point(210, 39);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(100, 20);
            lblGrade.TabIndex = 4;
            lblGrade.Text = "Grade Level";
            // 
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeacher.Location = new Point(404, 39);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(163, 20);
            lblTeacher.TabIndex = 5;
            lblTeacher.Text = "Teacher Assignment";
            // 
            // cmbTeachers
            // 
            cmbTeachers.FormattingEnabled = true;
            cmbTeachers.Location = new Point(408, 72);
            cmbTeachers.Margin = new Padding(3, 4, 3, 4);
            cmbTeachers.Name = "cmbTeachers";
            cmbTeachers.Size = new Size(188, 28);
            cmbTeachers.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(31, 58, 147);
            btnAdd.ImageIndex = 1;
            btnAdd.ImageList = imageList1;
            btnAdd.Location = new Point(183, 240);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 46);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "bin.png");
            imageList1.Images.SetKeyName(1, "add.png");
            imageList1.Images.SetKeyName(2, "clean.png");
            imageList1.Images.SetKeyName(3, "delete.png");
            imageList1.Images.SetKeyName(4, "update.png");
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(31, 58, 147);
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.ImageIndex = 4;
            btnUpdate.ImageList = imageList1;
            btnUpdate.Location = new Point(340, 240);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 46);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(30, 155, 60);
            btnDelete.ImageIndex = 0;
            btnDelete.ImageList = imageList1;
            btnDelete.Location = new Point(529, 240);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 41);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(30, 155, 60);
            btnClear.ImageIndex = 2;
            btnClear.ImageList = imageList1;
            btnClear.Location = new Point(707, 240);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 41);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button4_Click;
            // 
            // dgvClasses
            // 
            dgvClasses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClasses.BackgroundColor = Color.White;
            dgvClasses.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasses.EnableHeadersVisualStyles = false;
            dgvClasses.Location = new Point(9, 44);
            dgvClasses.Margin = new Padding(3, 4, 3, 4);
            dgvClasses.MultiSelect = false;
            dgvClasses.Name = "dgvClasses";
            dgvClasses.ReadOnly = true;
            dgvClasses.RowHeadersWidth = 51;
            dgvClasses.RowTemplate.Height = 25;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasses.Size = new Size(683, 244);
            dgvClasses.TabIndex = 11;
            dgvClasses.CellClick += dgvClasses_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 60, 142);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 81);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 81);
            label1.TabIndex = 14;
            label1.Text = "Class Management";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblClassName);
            groupBox1.Controls.Add(txtClassName);
            groupBox1.Controls.Add(txtGrade);
            groupBox1.Controls.Add(lblGrade);
            groupBox1.Controls.Add(cmbTeachers);
            groupBox1.Controls.Add(lblTeacher);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(186, 89);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(602, 125);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Class Details";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dgvClasses);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(179, 388);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(709, 310);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Class Records";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(441, 321);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(147, 25);
            txtSearch.TabIndex = 17;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(241, 321);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(176, 20);
            lblSearch.TabIndex = 18;
            lblSearch.Text = "Search Class / Grade:";
            // 
            // Classesform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 251);
            ClientSize = new Size(972, 712);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Classesform";
            Text = "School Management System - Class Management";
            Load += Classesform_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.ComboBox cmbTeachers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}