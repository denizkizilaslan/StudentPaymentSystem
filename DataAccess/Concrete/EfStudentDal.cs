using Common.DataAccess.EntityFramework;
using Common.Result;
using DataAccess.Abstract;
using Entities.Dtos;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, AppDbContext>, IStudentDal
    {
        private readonly AppDbContext _context;
        public EfStudentDal()
        {
            _context = new AppDbContext();
        }
        public List<Student> GetStudentList()
        {
            return _context.Students.ToList();
        }

        public List<StudentsWithPaymentDto> GetStudentsWithPayments()
        {
            var result = _context.Students.Include(c => c.StudentPayments).Select(p => new StudentsWithPaymentDto
            {
                id = p.Id,
                StudentNameSurname = $"{p.Name} {p.Surname}",
                Tckn = p.TcNumber,
                PaymentInfoDtos = p.StudentPayments.Select(py => new PaymentInfoDto { PaymentAmount = py.Total, PaymentDate = py.PaymentDate }).ToList()
            }).ToList();
            return result;
        }

        public ServiceResult<Student> UpdateStudent(Student student)
        {
            var result = _context.Students.Where(c => c.Id == student.Id).FirstOrDefault();
            if (result != null)
            {
                result.Name = student.Name;
                //result.SchoolId = student.SchoolId;
                result.Surname = student.Surname;
                result.TcNumber = student.TcNumber;
                result.StudentNumber = student.StudentNumber;
                result.Adress = student.Adress;
                result.Phone = student.Phone;
                result.Active = student.Active;

                return new ServiceResult<Student>(true, "Güncelleme işlemi başarılı");
            }
            else
            {
                return new ServiceResult<Student>(false, "Öğrenci bulunamadı");
            }
        }
    }
}
