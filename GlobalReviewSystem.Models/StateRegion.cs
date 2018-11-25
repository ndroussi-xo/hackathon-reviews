using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class StateRegion
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [MinLength(2), MaxLength(2), ForeignKey(nameof(Country))]
        public string CountryCode { get; set; }

        public virtual Country Country { get; set; }
    }
}
