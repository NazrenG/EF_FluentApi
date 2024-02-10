using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskk.Entities.Abstract;

namespace Taskk.Entities.Concretes
{
    public class Group : BaseEntity
    {
        //foreign key
        public int FacultyId { get; set; }

        //navigation prop
        public ICollection<Student> Students { get; set; }
        public Faculty Faculty { get; set; }
    }
}
