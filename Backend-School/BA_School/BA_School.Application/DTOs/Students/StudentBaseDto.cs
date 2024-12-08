using BA_School.Domain.Entities;

namespace BA_School.Application.DTOs.Students
{
    public class StudentBaseDto
    {
        public string Username { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string BloodType { get; set; } = string.Empty;
        public string Sex { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime Birthday { get; set; }
        public int ParentId { get; set; }

        public int ClassId { get; set; }

        public int GradeId { get; set; }
    }
}
