using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskk.Entities.Abstract;

namespace Taskk.Entities.Concretes
{
    public class Faculty : BaseEntity
    {
        //navigation prop
        public ICollection<Group> Groups { get; set; }

    }
}
