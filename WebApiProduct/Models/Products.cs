using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiProduct.Models
{
    public class Products : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual Categories Category { get; set; }


    }
}