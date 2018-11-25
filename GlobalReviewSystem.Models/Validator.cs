using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class Validator
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Type { get; set; }

        public IList<ValidatorProperty> Properties { get; set; }

        public virtual IList<Field> Fields { get; set; }
    }
}
