using System.ComponentModel.DataAnnotations;

namespace aspnetcorepostgres.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]  
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set;}
        [Required]
        public string LastNmae { get; set;}
        [Required]
        public string FullName => $"{FirstName} {MiddleName} {LastNmae}";
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }

    }
}
