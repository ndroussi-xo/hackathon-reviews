using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Phone]
        public string Fax { get; set; }

        public string Address { get; set; }

        public string Zip { get; set; }

        public string City { get; set; }

        [ForeignKey(nameof(ParentCompany))]
        public Guid? ParentCompanyId { get; set; }

        public virtual Company ParentCompany { get; set; }

        public virtual IList<Company> Subsidiaries { get; set; }

        public virtual IList<Product> Products { get; set; }
    }
}
