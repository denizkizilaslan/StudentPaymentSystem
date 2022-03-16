using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class StudentPaymentDto
    {
        public int StudentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Total { get; set; }
    }
}
