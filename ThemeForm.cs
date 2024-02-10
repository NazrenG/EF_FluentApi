using Taskk.Entities.Concretes;
using Taskk.Repository.Concretes;

namespace Taskk
{
    public partial class ThemeForm : Form
    {
        public Theme theme;
        public BaseRepository<Theme> baseRepository;

        public ThemeForm()
        {
            InitializeComponent();
            theme = new Theme();
            baseRepository = new BaseRepository<Theme>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            theme.Name = firstTxt.Text.ToString();
            baseRepository.Add(theme);
            baseRepository.Save();
            MessageBox.Show("Data was Added!");
        }
    }
}
