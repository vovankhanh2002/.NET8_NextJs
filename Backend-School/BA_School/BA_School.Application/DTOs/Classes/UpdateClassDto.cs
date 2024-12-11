using System.ComponentModel.DataAnnotations;
namespace BA_School.Application.DTOs.Classes
{
    public class UpdateClassDto:ClassBaseDto
    {
        [Required]
        public int Id { get; set; }
    }
}
