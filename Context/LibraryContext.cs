using Microsoft.EntityFrameworkCore;
using Taskk.Configuration;
using Taskk.Entities.Concretes;

namespace Taskk.Context
{
    public class LibraryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=WIN-EFS54O4O7OC\\SQLEXPRESS;Initial Catalog=LibraryContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AuthorConfig());
            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new FacultyConfig());
            modelBuilder.ApplyConfiguration(new GroupConfig());
            modelBuilder.ApplyConfiguration(new LibConfig());
            modelBuilder.ApplyConfiguration(new S_CardConfig());
            modelBuilder.ApplyConfiguration(new T_CardConfig());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lib> Libs { get; set; }
        public DbSet<Press> Presses { get; set; }
        public DbSet<S_Card> S_Cards { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<T_Card> T_Cards { get; set; }
        public DbSet<Taecher> Taechers { get; set; }
        public DbSet<Theme> Themes { get; set; }
    }
}
