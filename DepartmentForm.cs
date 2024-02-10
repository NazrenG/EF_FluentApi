
using Taskk.Entities.Concretes;
using Taskk.Repository.Concretes;
namespace Taskk
{
    public partial class DepartmentForm : Form
    {
        public Department department;
        public BaseRepository<Department> departmentRepository;
        public DepartmentForm()
        {
            InitializeComponent();
            departmentRepository = new BaseRepository<Department>();
            department=new Department();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            department.Name=firstTxt.Text.ToString();
            departmentRepository.Add(department);
            departmentRepository.Save();
            MessageBox.Show("Data was Added!");
        }
    }
}
