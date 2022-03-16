using Business.Abstract;
using Business.Validation.FluentValidation;
using Common.Aspects.Autofac.Validation;
using Common.Messages;
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
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        [ValidationAspect(typeof(StudentValidator), Priority = 1)]
        public ServiceResult<Student> Add(Student student)
        {
            _studentDal.Add(student);
            return new ServiceResult<Student>(true);
        }

        public ServiceResult<Student> GetStudent(int id)
        {
            Student student = _studentDal.Get(c => c.Id == id);
            if (student == null)
                return new ServiceResult<Student>(false, ResultMessage.notFoundStudent);
            else
                return new ServiceResult<Student>(student);
        }

        public ServiceResult<List<Student>> GetStudentList()
        {
            return new ServiceResult<List<Student>>(_studentDal.GetStudentList());
        }

        public ServiceResult<List<StudentsWithPaymentDto>> GetStudentsWithPayments()
        {
            return new ServiceResult<List<StudentsWithPaymentDto>>(_studentDal.GetStudentsWithPayments());
        }

        [ValidationAspect(typeof(StudentValidator), Priority = 1)]
        public ServiceResult<Student> Update(Student student)
        {
            return _studentDal.UpdateStudent(student);
        }

    }
}
