namespace BA_School.Domain.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Foreign key and Navigation property
        public int LessonId { get; set; }
        public Lesson? Lesson { get; set; }

        // Navigation property
        public ICollection<Result>? Results { get; set; }
    }

}
