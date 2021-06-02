using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoneShop.Bishnu.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Display order for Category must be greter than 0.")]
        [Display(Name ="Display Order")]
        public int DisplayOrder { get; set; }
    }
}
