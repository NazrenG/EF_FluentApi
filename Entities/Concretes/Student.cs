using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskk.Entities.Abstract;

namespace Taskk.Entities.Concretes
{
    public class Student : BaseEntity
    {
        public string LastName { get; set; }
        public int Term { get; set; }

        //foreign key
        public int GroupId { get; set; }

        //navigation prop
        public ICollection<S_Card> SCards { get; set; }
        public Group Group { get; set; }
    }
}
