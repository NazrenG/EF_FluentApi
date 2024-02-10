using Taskk.Entities.Concretes;
using Taskk.Repository.Concretes;

namespace Taskk
{
    public partial class GroupForm : Form
    {
        public Group group;
        public BaseRepository<Group> repository;
        public GroupForm()
        {
            InitializeComponent();
            group = new Group();
            repository = new BaseRepository<Group>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            group.FacultyId=Convert.ToInt32(facultyIdTxt.Text);
            group.Name=firstTxt.Text.ToString();
            repository.Add(group);
            repository.Save();
            MessageBox.Show("Data Was Added!");
        }
    }
}
