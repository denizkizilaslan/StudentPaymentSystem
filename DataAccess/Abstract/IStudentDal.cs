using Common.DataAccess;
using Common.Result;
using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IStudentDal : IEntityRepository<Student>
    {
        List<Student> GetStudentList();

        List<StudentsWithPaymentDto> GetStudentsWithPayments();
        ServiceResult<Student> UpdateStudent(Student student);

    }
}
