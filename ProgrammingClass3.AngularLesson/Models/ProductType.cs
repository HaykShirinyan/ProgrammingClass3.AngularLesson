using System.ComponentModel.DataAnnotations;

namespace ProgrammingClass3.AngularLesson.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(150)]
        public string Description { get; set; }
    }
}
