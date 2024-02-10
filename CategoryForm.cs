using Taskk.Entities.Concretes;
using Taskk.Repository.Concretes;

namespace Taskk
{
    public partial class CategoryForm : Form
    {
        public Category category;
        public BaseRepository<Category> baseRepository;

        public CategoryForm()
        {
            InitializeComponent();
            category = new Category();
            baseRepository = new BaseRepository<Category>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            category.Name =firstTxt.Text.ToString();
            baseRepository.Add(category);
            baseRepository.Save();
            MessageBox.Show("Data was Added!");
        }
    }
}
