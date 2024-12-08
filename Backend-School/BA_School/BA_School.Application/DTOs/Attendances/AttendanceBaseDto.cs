namespace BA_School.Application.DTOs.Attendances
{
    public class AttendanceBaseDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Present { get; set; }

        public int StudentId { get; set; }

        public int LessonId { get; set; }
    }
}
