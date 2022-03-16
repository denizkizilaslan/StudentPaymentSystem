using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
   public class StudentsWithPaymentDto
    {
        public StudentsWithPaymentDto()
        {
            PaymentInfoDtos = new List<PaymentInfoDto>();
        }
        public int id { get; set; }
        public string    StudentNameSurname { get; set; }
        public string Tckn { get; set; }
        public List<PaymentInfoDto> PaymentInfoDtos { get; set; }
    }
}
