using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Students
    {
        public int Id { get; set; }
        [Required] public string LastName { get; set; } = string.Empty;
        [Required] public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Photo { get; set; }        
        public string? Group { get; set; } = string.Empty;
    }
}
