using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlazorAcademyHW.Models
{
    public class Teachers
    {
        public int Id { get; set; }
        [Required] public string LastName { get; set; } = string.Empty;
        [Required] public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public byte[]? PhotoData { get; set; }
        public DateTime WorkSince { get; set; }
        public int Rate { get; set; }

        [JsonIgnore]
        public virtual ICollection<TeacherDiscipline> TeacherDisciplines { get; set; } = new List<TeacherDiscipline>();
    }
}