using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskk.Entities.Abstract;

namespace Taskk.Entities.Concretes
{
    public class Department : BaseEntity
    {
        public ICollection<Taecher> Taechers { get; set; }
    }
}
