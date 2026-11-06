namespace SchoolManagementSystem
{
    public partial class TeacherManage : Form
    {
        private Button btnEditTeacher;
        public TeacherManage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm form = new AddTeacherForm();
            form.ShowDialog();
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}