using System.ComponentModel.DataAnnotations;
namespace BA_School.Application.DTOs.Students
{
    public class UpdateStudentDto:StudentBaseDto
    {
        [Required]
        public int Id { get; set; }
    }
}
