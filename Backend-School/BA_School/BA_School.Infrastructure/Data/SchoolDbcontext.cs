using BA_School.Domain.Entities;
using BA_School.Domain.Enum;
using Microsoft.EntityFrameworkCore;
namespace BA_School.Infrastructure.Data
{
    public class SchoolDbcontext: DbContext 
    {
        public SchoolDbcontext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Announcement> Announcements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Grades
            modelBuilder.Entity<Grade>().HasData(
                new Grade { Id = 1, Level = 1 },
                new Grade { Id = 2, Level = 2 },
                new Grade { Id = 3, Level = 3 },
                new Grade { Id = 4, Level = 4 }
            );

            // Seed Classes
            modelBuilder.Entity<Class>().HasData(
                new Class { Id = 1, Name = "Class A", SupervisorId = 1, Capacity = 30, GradeId = 1 },
                new Class { Id = 2, Name = "Class B", SupervisorId = 2, Capacity = 25, GradeId = 2 },
                new Class { Id = 3, Name = "Class C", SupervisorId = 1, Capacity = 20, GradeId = 3 },
                new Class { Id = 4, Name = "Class D", SupervisorId = 2, Capacity = 35, GradeId = 4 }
            );

            // Seed Students
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Username = "student1",
                    Name = "John",
                    Surname = "Doe",
                    Email = "john.doe@example.com",
                    Phone = "123456789",
                    Address = "123 Main St",
                    BloodType = "O",
                    Sex = UserSex.MALE.ToString(),
                    CreatedAt = DateTime.Now,
                    ParentId = 1,
                    ClassId = 1,
                    GradeId = 1,
                    Birthday = new DateTime(2005, 5, 20)
                },
                new Student
                {
                    Id = 2,
                    Username = "student2",
                    Name = "Jane",
                    Surname = "Smith",
                    Email = "jane.smith@example.com",
                    Phone = "987654321",
                    Address = "456 Elm St",
                    BloodType = "A",
                    Sex = UserSex.FEMALE.ToString(),
                    CreatedAt = DateTime.Now,
                    ParentId = 2,
                    ClassId = 2,
                    GradeId = 2,
                    Birthday = new DateTime(2006, 8, 15)
                },
                new Student
                {
                    Id = 3,
                    Username = "student3",
                    Name = "Sam",
                    Surname = "Wilson",
                    Email = "sam.wilson@example.com",
                    Phone = "111222333",
                    Address = "789 Oak St",
                    BloodType = "B",
                    Sex = UserSex.MALE.ToString(),
                    CreatedAt = DateTime.Now,
                    ParentId = 3,
                    ClassId = 3,
                    GradeId = 3,
                    Birthday = new DateTime(2007, 3, 10)
                }
            );

            // Seed Parents
            modelBuilder.Entity<Parent>().HasData(
                new Parent { Id = 1, Username = "parent1", Name = "Parent One", Surname = "Doe", Phone = "123456789", Address = "123 Main St" },
                new Parent { Id = 2, Username = "parent2", Name = "Parent Two", Surname = "Smith", Phone = "987654321", Address = "456 Elm St" },
                new Parent { Id = 3, Username = "parent3", Name = "Parent Three", Surname = "Wilson", Phone = "111222333", Address = "789 Oak St" }
            );

            // Seed Teachers
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    Id = 1,
                    Username = "teacher1",
                    Name = "Alice",
                    Surname = "Brown",
                    Email = "alice.brown@example.com",
                    Phone = "1122334455",
                    Address = "10 Maple Ave",
                    BloodType = "AB",
                    Sex = UserSex.FEMALE.ToString(),
                    CreatedAt = DateTime.Now,
                    Birthday = new DateTime(1985, 4, 10)
                },
                new Teacher
                {
                    Id = 2,
                    Username = "teacher2",
                    Name = "Bob",
                    Surname = "Johnson",
                    Email = "bob.johnson@example.com",
                    Phone = "2233445566",
                    Address = "20 Birch Lane",
                    BloodType = "O",
                    Sex = UserSex.MALE.ToString(),
                    CreatedAt = DateTime.Now,
                    Birthday = new DateTime(1980, 7, 15)
                }
            );

            // Seed Subjects
            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Mathematics" },
                new Subject { Id = 2, Name = "Science" },
                new Subject { Id = 3, Name = "History" },
                new Subject { Id = 4, Name = "English" }
            );

            // Seed Lessons
            modelBuilder.Entity<Lesson>().HasData(
                new Lesson
                {
                    Id = 1,
                    Name = "Math Lesson 1",
                    Day = DateTime.Now.ToString(),
                    StartTime = DateTime.Parse("2024-12-07T08:00:00"),
                    EndTime = DateTime.Parse("2024-12-07T10:00:00"),
                    SubjectId = 1,
                    ClassId = 1,
                    TeacherId = 1
                },
                new Lesson
                {
                    Id = 2,
                    Name = "Science Lesson 1",
                    Day = DateTime.Now.ToString(),
                    StartTime = DateTime.Parse("2024-12-08T09:00:00"),
                    EndTime = DateTime.Parse("2024-12-08T11:00:00"),
                    SubjectId = 2,
                    ClassId = 2,
                    TeacherId = 2
                }
            );

            // Seed Events
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Title = "Math Contest",
                    Description = "Annual Math Contest",
                    StartTime = DateTime.Parse("2024-12-20T09:00:00"),
                    EndTime = DateTime.Parse("2024-12-20T12:00:00"),
                    ClassId = 1
                },
                new Event
                {
                    Id = 2,
                    Title = "Science Fair",
                    Description = "Annual Science Fair",
                    StartTime = DateTime.Parse("2024-12-22T10:00:00"),
                    EndTime = DateTime.Parse("2024-12-22T14:00:00"),
                    ClassId = 2
                }
            );
        }

    }
}
