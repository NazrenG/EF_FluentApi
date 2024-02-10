
using Taskk.Entities.Concretes;
using Taskk.Repository.Concretes;

namespace Taskk
{
    public partial class StudentForm : Form
    {
        public Student student;
        public BaseRepository<Student> studentRepository;

        public StudentForm()
        {
            InitializeComponent();
            studentRepository = new BaseRepository<Student>();
            student=new Student();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student.Name=firstTxt.Text.ToString();
            student.LastName=lastTxt.Text.ToString();
            student.Term=Convert.ToInt32(termTxt.Text);
            student.GroupId=Convert.ToInt32(groupIdTxt.Text);
            studentRepository.Add(student);
            studentRepository.Save();
            MessageBox.Show("Data was Added!");
        }
    }
}
