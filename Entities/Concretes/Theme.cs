using Taskk.Entities.Abstract;

namespace Taskk.Entities.Concretes
{
    public class Theme:BaseEntity
    {

        //navigation property
        public ICollection<Book> Books { get; set; }
    }
}
