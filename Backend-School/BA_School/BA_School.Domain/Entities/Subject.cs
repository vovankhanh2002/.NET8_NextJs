namespace BA_School.Domain.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
