using System;

namespace FinanceControl.Domain.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? DeletionDate { get; set; } = null;
        public bool Active { get; set; }
    }
}
