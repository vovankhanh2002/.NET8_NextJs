namespace BA_School.Application.DTOs.Classes
{
    public class ClassBaseDto 
    {
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }

        // Foreign key and Navigation property
        public int SupervisorId { get; set; }

        public int GradeId { get; set; }
    }
}
