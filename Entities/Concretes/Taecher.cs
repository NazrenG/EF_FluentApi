using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskk.Entities.Abstract;

namespace Taskk.Entities.Concretes
{
    public class Taecher:BaseEntity
    {
        public string LastName { get; set; }
        //foreign key
        public int DepartmentId { get; set; }
        //navigation prop
        public Department Department { get; set; }
        public ICollection<T_Card> TCards { get; set; }  
    }
}
