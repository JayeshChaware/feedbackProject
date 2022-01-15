using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackPortalDAL.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]

        public string AnswerString { get; set; }

        [Required]
        public DateTime AnswerDate { get; set; }
        
        [Required]
        [MaxLength(1)]
        public int Warning { get; set; }
        
       /* [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }*/
    }
}
