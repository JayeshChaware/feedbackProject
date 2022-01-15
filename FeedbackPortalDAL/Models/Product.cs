using FeedbackPortalDAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackPortalDAL.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int ProductSubModelId { get; set; }
        public ProductSubModel ProductSubModel { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        
        [Required]
        public DateTime LaunchDate { get; set; }
        
        [Required]
        [MaxLength(1)]
        public int Warning { get; set; }
    

        
/*        [ForeignKey("ProductSubModelId")]
        public virtual ProductSubModel ProductSubModel { get; set; }
        
        [ForeignKey("UserId")]
        public virtual User User { get; set; }*/

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
