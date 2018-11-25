using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Company Company { get; set; }

        public virtual IList<Image> Images { get; set; }
    }
}
