using System.ComponentModel.DataAnnotations;

namespace ProgramminClass3.AngularLesson.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StingLenght(100)]
        public string Name { get; set; }

        [StringLenght(500)]
        public string Description { get; set; }
    }
}