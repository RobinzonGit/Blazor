using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Groups
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; } = string.Empty;

        public string? Direction { get; set; } = string.Empty;
    }
}
