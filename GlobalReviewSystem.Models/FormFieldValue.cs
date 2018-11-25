using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class FormFieldValue
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Value { get; set; }

        [ForeignKey(nameof(Post))]
        public long PostId { get; set; }

        [ForeignKey(nameof(FormField))]
        public long FormFieldId { get; set; }

        public virtual Post Post { get; set; }

        public virtual FormField FormField { get; set; }
    }
}
