namespace BA_School.Domain.Entities
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }

        // Foreign key and Navigation property
        public int LessonId { get; set; }
        public Lesson? Lesson { get; set; }

        // Navigation property
        public ICollection<Result>? Results { get; set; }
    }

}
