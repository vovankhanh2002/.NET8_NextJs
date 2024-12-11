using BA_School.Application.DTOs.Lessons;
using BA_School.Application.DTOs.Students;
namespace BA_School.Application.DTOs.Classes
{
    public class GetClassDto : ClassBaseDto
    {
        public ICollection<GetLessonDto>? Lessones { get; set; }
        public ICollection<GetStudentDto>? Students { get; set; }
        //public ICollection<GetEventDto>? Events { get; set; }
        //public ICollection<GetAnnouncementDto>? Announcements { get; set; }
    }
}
