using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class Image
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Alt { get; set; }

        [Url, Required]
        public string Url { get; set; }

        public bool IsDefault { get; set; }

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
