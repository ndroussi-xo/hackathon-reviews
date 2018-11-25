using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class AppUser : IdentityUser
    {
        public virtual IList<Post> Posts { get; set; }
    }
}
