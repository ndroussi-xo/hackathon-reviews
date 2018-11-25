using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class Advertisement
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool IsEnabled { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Credit { get; set; }

        [ForeignKey("Advertiser")]
        public string AdvertiserId { get; set; }

        public virtual AppUser Advertiser { get; set; }
    }
}
