using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackPortalDAL.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        
        [Required]
        public string QuestionString { get; set; }
  
        [Required]
        public DateTime QuestionDate { get; set; }
        
        [Required]
        [MaxLength(1)]
        public int Warning { get; set; }
 
/*        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }*/

        public virtual ICollection<Answer> Answers { get; set; }


    }
}
