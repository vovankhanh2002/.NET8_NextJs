namespace BA_School.Domain.Entities
{
    public class Result
    {
        public int Id { get; set; }
        public int Score { get; set; }

        // Foreign keys and Navigation properties
        public int? ExamId { get; set; }
        public Exam? Exam { get; set; }

        public int? AssignmentId { get; set; }
        public Assignment? Assignment { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }

}
