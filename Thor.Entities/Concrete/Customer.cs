using System;
using System.Collections.Generic;
using System.Text;
using Thor.Core.Entities;

namespace Thor.Entities.Concrete
{
    public class Customer : IEntity
    {
        public long Id { get; set; }
        public DateTime CreateDateTime { get; set; }

        public string FullName { get; set; }
        public string Job { get; set; }
        public int Age { get; set; }
    }
}
