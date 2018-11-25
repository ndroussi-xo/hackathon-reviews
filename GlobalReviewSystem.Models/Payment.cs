using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GlobalReviewSystem.Models
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string TransactionId { get; set; }

        [ForeignKey(nameof(Advertiser))]
        public virtual string AdvertiserId { get; set; }

        public virtual Advertiser Advertiser { get; set; }
    }
}
