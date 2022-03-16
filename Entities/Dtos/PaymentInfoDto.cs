using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
   public class PaymentInfoDto
    {
        public decimal PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
