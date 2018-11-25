using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class FormField
    {
        [Key]
        public long Id { get; set; }

        public string DisplayName { get; set; }

        public int Position { get; set; }

        public bool IsRequired { get; set; }

        public string Description { get; set; }

        public virtual IList<Validator> Validators { get; set; }

        public virtual Field Field { get; set; }

        public virtual Form Form { get; set; }
    }
}
