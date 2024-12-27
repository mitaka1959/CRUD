using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  CrudApi.Models{

    public class Product{
        [Key]
        public int Id{ get; set; }
        [Required]
        [MaxLength(100)]
        public required string Name{ get; set; }
        public decimal Price{ get; set; }
        [MaxLength(300)]
        public string? Description{ get; set; }
    }
}