
using Taskk.Entities.Concretes;
using Taskk.Repository.Concretes;

namespace Taskk
{
    public partial class BookForm : Form
    {
        public Book book;
        public BaseRepository<Book> bookRepository;
        public BookForm()
        {
            InitializeComponent();
            bookRepository = new BaseRepository<Book>();
            book = new Book();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lastTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            book.Name=firstTxt.Text.ToString();
            book.Comment=commentTxt.Text.ToString();
            book.YearPress = Convert.ToInt32(yearTxt.Text);
            book.Quantity = Convert.ToInt32(quantityTxt.Text);
            book.PressId=Convert.ToInt32(pressTxt.Text);
            book.ThemeId=Convert.ToInt32(themeTxt.Text);
            book.AuthorId=Convert.ToInt32(authorTxt.Text);
            book.CategoryId=Convert.ToInt32(categoryTxt.Text);
            bookRepository.Add(book);
            bookRepository.Save();
            MessageBox.Show("Data was Added!");
        }
    }
}
