using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskk.Entities.Abstract;

namespace Taskk.Entities.Concretes
{
    public class Press : BaseEntity
    {

        //navigation property
        public ICollection<Book> Books { get; set; }
    }
}
