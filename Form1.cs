using Microsoft.Data.SqlClient;
using System.Data;
using Taskk.Entities.Concretes;
using Taskk.Repository.Concretes;

namespace Taskk
{
    public partial class Form1 : Form
    {
        private BaseRepository<Author> authors;
        private BaseRepository<Book> books;
        private BaseRepository<Category> category;
        private BaseRepository<Department> department;
        private BaseRepository<Faculty> faculties;
        private BaseRepository<Group> groups;
        private BaseRepository<Student> students;
        private BaseRepository<Taecher> teachers;
        private BaseRepository<Lib> libs;
        private BaseRepository<Press> press;
        private BaseRepository<Theme> theme;

        string cs = "Data Source=WIN-EFS54O4O7OC\\SQLEXPRESS;Initial Catalog=LibraryContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();

            authors = new BaseRepository<Author>();
            books = new BaseRepository<Book>();
            category = new BaseRepository<Category>();
            department = new BaseRepository<Department>();
            faculties = new BaseRepository<Faculty>();
            groups = new BaseRepository<Group>();
            students = new BaseRepository<Student>();
            teachers = new BaseRepository<Taecher>();
            libs = new BaseRepository<Lib>();
            press = new BaseRepository<Press>();
            theme = new BaseRepository<Theme>();
            libs = new BaseRepository<Lib>();

            Controls.Add(dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getAll_btn_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = authors.GetAll();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = books.GetAll();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = category.GetAll();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                dataGridView1.DataSource = department.GetAll();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                dataGridView1.DataSource = faculties.GetAll();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                dataGridView1.DataSource = groups.GetAll();
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                dataGridView1.DataSource = libs.GetAll();
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                dataGridView1.DataSource = press.GetAll();
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                dataGridView1.DataSource = students.GetAll();
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                dataGridView1.DataSource = teachers.GetAll();
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                dataGridView1.DataSource = theme.GetAll();
            }

        }

        private void remove_btn_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                var selectedAuthor = (Author)dataGridView1.SelectedRows[0].DataBoundItem;
                authors.Remove(selectedAuthor);
                authors.Save();
                MessageBox.Show("Data was removed!");


            }
            else if (comboBox1.SelectedIndex == 1)
            {
                var selected = (Book)dataGridView1.SelectedRows[0].DataBoundItem;
                books.Remove(selected);
                books.Save();
                MessageBox.Show("Data was removed!");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                var selected = (Category)dataGridView1.SelectedRows[0].DataBoundItem;
                category.Remove(selected);
                category.Save();
                MessageBox.Show("Data was removed!");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                var selected = (Department)dataGridView1.SelectedRows[0].DataBoundItem;
                department.Remove(selected);
                department.Save();
                MessageBox.Show("Data was removed!");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                var selected = (Faculty)dataGridView1.SelectedRows[0].DataBoundItem;
                faculties.Remove(selected);
                faculties.Save();
                MessageBox.Show("Data was removed!");
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                var selected = (Group)dataGridView1.SelectedRows[0].DataBoundItem;
                groups.Remove(selected);
                groups.Save();
                MessageBox.Show("Data was removed!");
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                var selected = (Lib)dataGridView1.SelectedRows[0].DataBoundItem;
                libs.Remove(selected);
                libs.Save();
                MessageBox.Show("Data was removed!");
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                var selected = (Press)dataGridView1.SelectedRows[0].DataBoundItem;
                press.Remove(selected);
                press.Save();
                MessageBox.Show("Data was removed!");
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                var selected = (Student)dataGridView1.SelectedRows[0].DataBoundItem;
                students.Remove(selected);
                students.Save();
                MessageBox.Show("Data was removed!");
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                var selected = (Taecher)dataGridView1.SelectedRows[0].DataBoundItem;
                teachers.Remove(selected);
                teachers.Save();
                MessageBox.Show("Data was removed!");
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                var selected = (Theme)dataGridView1.SelectedRows[0].DataBoundItem;
                theme.Remove(selected);
                theme.Save();
                MessageBox.Show("Data was removed!");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var selectedAuthor = (Author)dataGridView1.SelectedRows[0].DataBoundItem;
                authors.Update(selectedAuthor);
                authors.Save();
                MessageBox.Show("Data was updated!");


            }
            else if (comboBox1.SelectedIndex == 1)
            {
                var selected = (Book)dataGridView1.SelectedRows[0].DataBoundItem;
                books.Update(selected);
                books.Save();
                MessageBox.Show("Data was updated!");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                var selected = (Category)dataGridView1.SelectedRows[0].DataBoundItem;
                category.Update(selected);
                category.Save();
                MessageBox.Show("Data was updated!");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                var selected = (Department)dataGridView1.SelectedRows[0].DataBoundItem;
                department.Update(selected);
                department.Save();
                MessageBox.Show("Data was updated!");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                var selected = (Faculty)dataGridView1.SelectedRows[0].DataBoundItem;
                faculties.Update(selected);
                faculties.Save();
                MessageBox.Show("Data was updated!");
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                var selected = (Group)dataGridView1.SelectedRows[0].DataBoundItem;
                groups.Update(selected);
                groups.Save();
                MessageBox.Show("Data was updated!");
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                var selected = (Lib)dataGridView1.SelectedRows[0].DataBoundItem;
                libs.Update(selected);
                libs.Save();
                MessageBox.Show("Data was updated!");
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                var selected = (Press)dataGridView1.SelectedRows[0].DataBoundItem;
                press.Update(selected);
                press.Save();
                MessageBox.Show("Data was updated!");
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                var selected = (Student)dataGridView1.SelectedRows[0].DataBoundItem;
                students.Update(selected);
                students.Save();
                MessageBox.Show("Data was updated!");
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                var selected = (Taecher)dataGridView1.SelectedRows[0].DataBoundItem;
                teachers.Update(selected);
                teachers.Save();
                MessageBox.Show("Data was updated!");
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                var selected = (Theme)dataGridView1.SelectedRows[0].DataBoundItem;
                theme.Update(selected);
                theme.Save();
                MessageBox.Show("Data was updated!");
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                AuthorForm f = new AuthorForm();
                f.ShowDialog();


            }
            else if (comboBox1.SelectedIndex == 1)
            {
                BookForm f = new BookForm();
                f.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CategoryForm f = new CategoryForm();
                f.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                DepartmentForm f = new DepartmentForm();
                f.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                FacultyForm f = new FacultyForm();
                f.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                GroupForm f = new GroupForm();
                f.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                LibForm f = new LibForm();
                f.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                PressForm f = new PressForm();
                f.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                StudentForm f = new StudentForm();
                f.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                TeacherForm f = new TeacherForm();
                f.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                ThemeForm f = new ThemeForm();
                f.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open(); adapt = new SqlDataAdapter("select * from Authors", con);

            if (comboBox1.SelectedIndex == 0)  adapt = new SqlDataAdapter("select * from Authors", con);
            else if (comboBox1.SelectedIndex == 1)  adapt = new SqlDataAdapter("select * from Books", con);
            else if (comboBox1.SelectedIndex == 2) adapt = new SqlDataAdapter("select * from Categories", con);
            else if (comboBox1.SelectedIndex == 3) adapt = new SqlDataAdapter("select * from Departments", con);
            else if (comboBox1.SelectedIndex == 4) adapt = new SqlDataAdapter("select * from Faculties", con); 
            else if (comboBox1.SelectedIndex == 5) adapt = new SqlDataAdapter("select * from Groups", con);
            else if (comboBox1.SelectedIndex == 6) adapt = new SqlDataAdapter("select * from Libs", con);
            else if (comboBox1.SelectedIndex == 7) adapt = new SqlDataAdapter("select * from Presses", con);
            else if (comboBox1.SelectedIndex == 8) adapt = new SqlDataAdapter("select * from Students", con);
            else if (comboBox1.SelectedIndex == 9) adapt = new SqlDataAdapter("select * from Taechers", con);
            else if (comboBox1.SelectedIndex == 10) adapt = new SqlDataAdapter("select * from Themes", con);

            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Authors where FirstName like '" + textBox1.Text + "%'", con);

            if (comboBox1.SelectedIndex == 0) adapt = new SqlDataAdapter("select * from Authors where FirstName like '" + textBox1.Text + "%'", con);
            else if (comboBox1.SelectedIndex == 1) adapt = new SqlDataAdapter("select * from Books where Name like '" + textBox1.Text + "%'", con);
            else if (comboBox1.SelectedIndex == 2) adapt = new SqlDataAdapter("select * from Categories where Name like '" + textBox1.Text + "%'", con);
            else if (comboBox1.SelectedIndex == 3) adapt = new SqlDataAdapter("select * from Departments where Name like '" + textBox1.Text + "%'", con);
            else if (comboBox1.SelectedIndex == 4) adapt = new SqlDataAdapter("select * from Faculties where Name like '" + textBox1.Text + "%'", con);
            else if (comboBox1.SelectedIndex == 5) adapt = new SqlDataAdapter("select * from Groups where Name like '" + textBox1.Text + "%'", con);
            else if (comboBox1.SelectedIndex == 6) adapt = new SqlDataAdapter("select * from Libs where Name like '" + textBox1.Text + "%'", con);
            else if (comboBox1.SelectedIndex == 7) adapt = new SqlDataAdapter("select * from Presses where Name like '" + textBox1.Text + "%'", con);
            else if (comboBox1.SelectedIndex == 8) adapt = new SqlDataAdapter("select * from Students where Name like '" + textBox1.Text + "%'", con);
            else if (comboBox1.SelectedIndex == 9) adapt = new SqlDataAdapter("select * from Taechers where Name like '" + textBox1.Text + "%'", con);
            else if (comboBox1.SelectedIndex == 10) adapt = new SqlDataAdapter("select * from Themes where Name like '" + textBox1.Text + "%'", con);

            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}