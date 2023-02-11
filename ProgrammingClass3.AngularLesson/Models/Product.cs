using System.ComponentModel.DataAnnotations;

namespace ProgrammingClass3.AngularLesson.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
