using System.ComponentModel.DataAnnotations;

namespace CPW219_CRUD_Troubleshooting.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string Name { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }
    }
}
