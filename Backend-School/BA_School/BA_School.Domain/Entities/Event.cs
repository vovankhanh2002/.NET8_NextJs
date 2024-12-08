namespace BA_School.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Foreign key and Navigation property
        public int? ClassId { get; set; }
        public Class? Class { get; set; }
    }

}
