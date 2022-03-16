using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class StudentDto
    {
        private int schoolId = 1;
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNumber { get; set; }
        public string StudentNumber { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public bool? Active { get; set; }

    }
}
