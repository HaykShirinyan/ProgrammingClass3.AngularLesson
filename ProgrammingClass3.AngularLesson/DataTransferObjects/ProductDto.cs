using System.ComponentModel.DataAnnotations;

namespace ProgrammingClass3.AngularLesson.DataTransferOgjects
{
    public class ProductDto
    {
        public int Id { get; set; }

        [Required]
        [StringLenght(100)]
        public string Name { get; set; }

        [StringLenght(500)]
        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}