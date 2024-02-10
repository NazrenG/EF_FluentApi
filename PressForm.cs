using Taskk.Entities.Concretes;
using Taskk.Repository.Concretes;

namespace Taskk
{
    public partial class PressForm : Form
    {
        public Press press;
        public BaseRepository<Press> pressRepository;

        public PressForm()
        {
            InitializeComponent();
            press=new Press();
            pressRepository=new BaseRepository<Press>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            press.Name = firstTxt.Text.ToString();
            pressRepository.Add(press);
            pressRepository.Save();
            MessageBox.Show("Data was Added!");
        }
    }
}
