using Taskk.Entities.Abstract;

namespace Taskk.Entities.Concretes
{
    public class Author:BaseEntity
    {
        public string LastName { get; set; }
        //navigation property
        public ICollection<Book> Books { get; set; }
    }
}
