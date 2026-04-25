using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Students
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]

        public string last_Name { get; set; }

        public string first_Nam { get; set; }

        public string middle_name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string photo { get; set; }

        public DateTime group { get; set; }
    }
}
