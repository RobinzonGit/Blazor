using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    //public class Students
    //{
    //    public int Id { get; set; }

    //    [Required(ErrorMessage = "Last Name is required")]
    //    //[Column("last_name")]
    //    public string LastName { get; set; }

    //    [Required(ErrorMessage = "First Name is required")]
    //    //[Column("first_Name")]
    //    public string FirstName { get; set; }

    //    //[Column("middle_name")]
    //    public string MiddleName { get; set; }

    //    //[Column("birth_date")]
    //    public DateTime DateOfBirth { get; set; }

    //    //[Column("email")]
    //    public string Email { get; set; }

    //    //[Column("phone")]
    //    public string Phone { get; set; }

    //    //[Column("photo")]
    //    public string Photo { get; set; }

    //    //[Column("rate")]
    //    public int Group { get; set; }
    //}

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
