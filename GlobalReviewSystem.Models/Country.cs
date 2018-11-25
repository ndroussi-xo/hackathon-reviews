using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class Country
    {
        [MinLength(2), MaxLength(2), Key]
        public string Code { get; set; }

        public string Name { get; set; }

        public virtual IList<StateRegion> StatesOrRegions { get; set; }
    }
}
