using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FeedbackPortalDAL.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        public virtual ICollection<ProductSubModel> ProductSubModels { get; set; }

    }
}
