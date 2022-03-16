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
    public interface IStudentService
    {
        ServiceResult<List<Student>> GetStudentList();
        ServiceResult<Student> GetStudent(int id);
        ServiceResult<Student> Add(Student student);
        ServiceResult<Student> Update(Student student);
        ServiceResult<List<StudentsWithPaymentDto>> GetStudentsWithPayments();
    }
}
