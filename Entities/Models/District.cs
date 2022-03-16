using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class District
    {
        public District()
        {
            Schools = new HashSet<School>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<School> Schools { get; set; }
    }
}
