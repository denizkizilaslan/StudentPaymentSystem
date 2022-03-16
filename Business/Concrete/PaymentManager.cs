using Business.Abstract;
using Business.Validation.FluentValidation;
using Common.Aspects.Autofac.Validation;
using Common.Result;
using DataAccess.Abstract;
using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IStudentPaymentDal _studentPaymentDal;
        public PaymentManager(IStudentPaymentDal studentPaymentDal)
        {
            _studentPaymentDal = studentPaymentDal;
        }

        [ValidationAspect(typeof(PaymetValidator), Priority = 1)]
        public ServiceResult<StudentPayment> Add(StudentPayment studentPayment)
        {
            _studentPaymentDal.Add(studentPayment);
            return new ServiceResult<StudentPayment>(true);
        }

        public ServiceResult<List<StudentPayment>> GetStudentPayments(StudentDateRangeDto studentDateRangeDto)
        {
            return new ServiceResult<List<StudentPayment>>(_studentPaymentDal.GetList(c => c.StudentId == studentDateRangeDto.studentId && (c.PaymentDate > studentDateRangeDto.startDate && c.PaymentDate < studentDateRangeDto.endDate)).ToList());
        }

        public ServiceResult<List<StudentPayment>> GetStudentsPayments()
        {
            return new ServiceResult<List<StudentPayment>>(_studentPaymentDal.GetList().ToList());
        }
    }
}
