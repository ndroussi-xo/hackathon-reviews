using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class ValidatorProperty
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string ParamType { get; set; }

        [ForeignKey(nameof(Validator))]
        public Guid ValidatorId { get; set; }

        public Validator Validator { get; set; }
    }
}
