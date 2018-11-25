using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public virtual IList<Product> Products { get; set; }
    }
}
