using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class Form
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        public virtual IList<FormField> FormFields { get; set; }
    }
}
