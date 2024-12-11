namespace BA_School.Application.DTOs.Lessons
{
    public class LessonBaseDto 
    {
        public string Name { get; set; } = string.Empty;
        public string Day { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Foreign keys and Navigation properties
        public int SubjectId { get; set; }

        public int ClassId { get; set; }

        public int TeacherId { get; set; }
    }
}
