namespace BA_School.Domain.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Day { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Foreign keys and Navigation properties
        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }

        public int ClassId { get; set; }
        public Class? Class { get; set; }

        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        // Navigation properties
        public ICollection<Exam>? Exams { get; set; }
        public ICollection<Assignment>? Assignments { get; set; }
        public ICollection<Attendance>? Attendances { get; set; }
    }

}
