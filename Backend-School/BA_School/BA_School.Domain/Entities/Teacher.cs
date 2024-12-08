namespace BA_School.Domain.Entities
{
    public class Teacher
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
        public ICollection<Subject>? Subjects { get; set; }
        public ICollection<Lesson>? Lessons { get; set; }
        public ICollection<Class>? Classes { get; set; }
    }

}
