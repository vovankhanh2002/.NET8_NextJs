namespace BA_School.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }
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

        // Navigation properties
        public int ParentId { get; set; }
        public Parent? Parent { get; set; }

        public int ClassId { get; set; }
        public Class? Class { get; set; }

        public int GradeId { get; set; }
        public Grade? Grade { get; set; }

        public ICollection<Attendance>? Attendances { get; set; }
        public ICollection<Result>? Results { get; set; }
    }

}
