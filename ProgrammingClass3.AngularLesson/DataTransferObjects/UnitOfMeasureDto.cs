using System.ComponentModel.DataAnnotations;

namespace ProgrammingClass3.AngularLesson.DataTransferObjects
{
    public class UnitOfMeasureDto
    {
        public int Id { get; set; }

        [Required]
        [StringLenght(100)]
        public string Name { get; set; }

        [StringLenght(500)]
        public string Description { get; set; }
    }
}