using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public byte[]? Photo { get; set; }   // Photo stored directly in DB
        public int? GroupId { get; set; }
        [ForeignKey(nameof(GroupId))]
        public virtual Groups? Group { get; set; }
    }
}