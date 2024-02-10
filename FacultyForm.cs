
using Taskk.Entities.Concretes;
using Taskk.Repository.Concretes;

namespace Taskk
{
    public partial class FacultyForm : Form
    {
        public Faculty faculty;
        public BaseRepository<Faculty> baseRepository;

        public FacultyForm()
        {
            InitializeComponent();
            faculty = new Faculty();
            baseRepository = new BaseRepository<Faculty>(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            faculty.Name = firstTxt.Text.ToString();
            baseRepository.Add(faculty);
            baseRepository.Save();
            MessageBox.Show("Data was Added!");
        }
    }
}
