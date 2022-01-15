using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackPortalDAL.Models
{
    public class ProductSubModel
    {
        [Key]
        public int Id { get; set; }
        public int ProductModelId { get; set; }
        public ProductModel ProductModel { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        
        /*[ForeignKey("ProductModelId")]
        public virtual ProductModel ProductModel { get; set; }*/
        public virtual ICollection<Product> Products { get; set; }
    }
}