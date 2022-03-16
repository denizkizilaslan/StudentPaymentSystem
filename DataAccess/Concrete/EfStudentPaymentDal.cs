using Common.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfStudentPaymentDal : EfEntityRepositoryBase<StudentPayment, AppDbContext>, IStudentPaymentDal

    {
        private readonly AppDbContext _context;
        public EfStudentPaymentDal()
        {
            _context = new AppDbContext();
        }
    }
}
