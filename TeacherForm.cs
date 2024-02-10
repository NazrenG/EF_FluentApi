
using Taskk.Entities.Concretes;
using Taskk.Repository.Concretes;

namespace Taskk
{
    public partial class TeacherForm : Form
    {
        public Taecher taecher;
        public BaseRepository<Taecher> taecherRepository;   
        public TeacherForm()
        {
            InitializeComponent();
            taecher = new Taecher();
            taecherRepository = new BaseRepository<Taecher>();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            taecher.Name=firstTxt.Text.ToString();
            taecher.LastName=lastTxt.Text.ToString();
            taecher.DepartmentId=Convert.ToInt32(departmentIdTxt.Text);
            taecherRepository.Add(taecher);
            taecherRepository.Save();
            MessageBox.Show("Data was added!");
        }
    }
}
