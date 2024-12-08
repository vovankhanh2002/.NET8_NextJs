namespace BA_School.Domain.Entities
{
    public class Grade
    {
        public int Id { get; set; }
        public int Level { get; set; }

        // Navigation properties
        public ICollection<Student>? Students { get; set; }
        public ICollection<Class>? Classes { get; set; }
    }
}
