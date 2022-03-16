using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models
{
    public partial class City
    {
        public City()
        {
            Districts = new HashSet<District>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
