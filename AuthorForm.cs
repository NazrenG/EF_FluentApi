using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taskk.Entities.Concretes;
using Taskk.Repository.Concretes;

namespace Taskk
{
    public partial class AuthorForm : Form
    {
        public Author author;
        public BaseRepository<Author> repository;

        public AuthorForm()
        {
            InitializeComponent();
            author = new Author();
            repository = new BaseRepository<Author>();
        }
    

        private void AuthorForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            author.Name=firstTxt.Text.ToString();
            author.LastName=lastTxt.Text.ToString();
            repository.Add(author);
            MessageBox.Show("Data was Added!");
            repository.Save();

           


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lastTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
