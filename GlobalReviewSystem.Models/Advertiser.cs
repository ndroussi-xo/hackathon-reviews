using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class Advertiser : AppUser
    {
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Credit { get; set; }

        public virtual IList<Advertisement> Advertisements { get; set; }
    }
}
