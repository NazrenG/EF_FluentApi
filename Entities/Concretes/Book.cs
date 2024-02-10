using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskk.Entities.Abstract;

namespace Taskk.Entities.Concretes
{
    public class Book : BaseEntity
    {
        public int Pages { get; set; }
        public int YearPress { get; set; }
        public string Comment { get; set; }
        public int Quantity { get; set; }

        //foreign key
        public int PressId { get; set; } 
        public int ThemeId { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; } 
        //navigation property
        public Press Press { get; set; }
        public Theme Theme { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public ICollection<T_Card> TCards { get; set; }
        public ICollection<S_Card> SCards { get; set; }

    }
}
