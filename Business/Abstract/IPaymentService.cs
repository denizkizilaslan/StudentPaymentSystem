using Common.Result;
using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        ServiceResult<StudentPayment> Add(StudentPayment studentPayment);
        ServiceResult<List<StudentPayment>> GetStudentsPayments();
        ServiceResult<List<StudentPayment>> GetStudentPayments(StudentDateRangeDto studentDateRangeDto);
    }
}
