using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Groups
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        public int Direction { get; set; }
    }
}
