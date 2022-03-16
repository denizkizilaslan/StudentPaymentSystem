using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class School
    {
        public School()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? DistrictId { get; set; }

        public virtual District District { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
