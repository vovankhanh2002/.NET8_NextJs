namespace BA_School.Domain.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Present { get; set; }

        // Foreign keys and Navigation properties
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public int LessonId { get; set; }
        public Lesson? Lesson { get; set; }
    }

}
