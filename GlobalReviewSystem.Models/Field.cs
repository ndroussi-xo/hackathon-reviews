using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class Field
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public FieldType Type { get; set; }

        public virtual IList<Validator> Validators { get; set; }
    }
}
