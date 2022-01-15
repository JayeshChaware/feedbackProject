using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackPortalDAL.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        
        [Required]
        public Enum.StarRating Rating { get; set; }
        public string Comment { get; set; }
        
        [Required]
        public DateTime FeedbackDate { get; set; }
        
        [Required]
        [MaxLength(1)]
        public int Warning { get; set; }

       
       
    }
}
