namespace BA_School.Application.DTOs.Results
{
    public class ResultBaseDto
    {
        public int Id { get; set; }
        public int Score { get; set; }

        // Foreign keys and Navigation properties
        public int? ExamId { get; set; }

        public int? AssignmentId { get; set; }

        public int StudentId { get; set; }
    }

}
