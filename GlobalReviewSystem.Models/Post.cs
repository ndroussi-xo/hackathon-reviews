using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class Post
    {
        public long Id { get; set; }

        public DateTime PostedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey(nameof(PostingUser))]
        public string UserId { get; set; }

        public virtual IList<FormFieldValue> FormFieldValues { get; set; }

        public virtual AppUser PostingUser { get; set; }
    }
}
