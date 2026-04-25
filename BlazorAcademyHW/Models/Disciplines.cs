using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Disciplines
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]

        public string Name { get; set; }

        public int of_lessons { get; set; }
    }
}

