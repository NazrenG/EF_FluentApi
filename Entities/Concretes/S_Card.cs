﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskk.Entities.Concretes
{
    public class S_Card
    {
        public int Id { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }

        //foreign key
        public int StudentId { get; set; }
        public int LibId { get; set; }
        public int BookId { get; set; }
        //navigation property
        public Student Student { get; set; }
        public Lib Lib { get; set; }
        public Book Book { get; set; }
    }
}
