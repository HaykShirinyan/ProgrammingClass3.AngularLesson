using System.ComponentModel.DataAnnotations;

namespace ProgrammingClass3.AngularLesson.DataTransferObjects
{
    public class UnitOfMeasureDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}