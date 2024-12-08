namespace BA_School.Domain.Entities
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        // Foreign key and Navigation property
        public int? ClassId { get; set; }
        public Class? Class { get; set; }
    }

}
