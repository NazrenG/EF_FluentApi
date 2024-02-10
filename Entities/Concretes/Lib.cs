using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskk.Entities.Abstract;

namespace Taskk.Entities.Concretes
{
    public class Lib : BaseEntity
    {
        public string LastName { get; set; }

        //navigation prop
        public ICollection<T_Card> TCards { get; set; }
        public ICollection<S_Card> SCards { get; set; }
    }
}
