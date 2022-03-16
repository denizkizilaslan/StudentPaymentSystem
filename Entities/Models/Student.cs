using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentPayments = new HashSet<StudentPayment>();
        }

        public int Id { get; set; }
        public int SchoolId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNumber { get; set; }
        public string StudentNumber { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public bool? Active { get; set; }

        public virtual School School { get; set; }
        public virtual ICollection<StudentPayment> StudentPayments { get; set; }
    }
}
