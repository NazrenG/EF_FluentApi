using Taskk.Entities.Concretes;
using Taskk.Repository.Concretes;

namespace Taskk
{
    public partial class LibForm : Form
    {
        public Lib lib;
        public BaseRepository<Lib> repository;
        public LibForm()
        {
            InitializeComponent();
            lib=new Lib();
            repository=new BaseRepository<Lib>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lib.Name = firstTxt.Text.ToString();
            lib.LastName = lastTxt.Text.ToString();
            repository.Add(lib);
            MessageBox.Show("Data was Added!");
            repository.Save();
        }
    }
}
