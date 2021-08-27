using System;

namespace Thor.Core.Entities
{
   public interface IEntity
    {
        public long Id { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
