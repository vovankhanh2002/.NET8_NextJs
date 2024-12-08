namespace BA_School.Domain.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }

        // Foreign key and Navigation property
        public int SupervisorId { get; set; }
        public Teacher? Supervisor { get; set; }

        public int GradeId { get; set; }
        public Grade? Grade { get; set; }

        // Navigation properties
        public ICollection<Lesson>? Lessons { get; set; }
        public ICollection<Student>? Students { get; set; }
        public ICollection<Event>? Events { get; set; }
        public ICollection<Announcement>? Announcements { get; set; }
    }

}
