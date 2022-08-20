using System.ComponentModel.DataAnnotations;

namespace StudentCRUD.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [MaxLength(10)]
        public string Phone { get; set; }

        [Required]
        public string Semester { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }
    }
}
