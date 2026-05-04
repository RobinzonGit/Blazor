using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Disciplines
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; } = string.Empty;

        public int Lessons { get; set; }
    }
}

