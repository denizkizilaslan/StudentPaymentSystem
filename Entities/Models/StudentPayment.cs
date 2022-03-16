using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class StudentPayment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Total { get; set; }

        public virtual Student Student { get; set; }
    }
}
