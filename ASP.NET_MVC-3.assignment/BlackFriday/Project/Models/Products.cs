using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Products
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Név")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Gyártó")]
        public string Manufacturer { get; set; }

        [Required]
        [Display(Name = "Ár")]
        public int Price { get; set; }

        [Required]
        public int Multiplier { get; set; }

        [Required]
        [Display(Name = "Akciós ár")]
        public int BFPrice { get; set; }
    }
}
