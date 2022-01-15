using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FeedbackPortalDAL.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(15)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(15)]
        public string LastName { get; set; }
        
        [Required]
        public Enum.Gender Gender { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string Email { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string Password { get; set; }
        
        [Required]
        public DateTime RegisterDate { get; set; }
        
        [Required]
        public Enum.Roles RoleId { get; set; }
        
        [Required]
        [MaxLength(1)]
        public int Warning { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Question> Questions { get; set; }

    }
}
