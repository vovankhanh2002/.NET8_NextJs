using BA_School.Application.DTOs.Attendances;
using BA_School.Application.DTOs.Classes;
using BA_School.Application.DTOs.Results;

namespace BA_School.Application.DTOs.Students
{
    public class GetStudentDto:StudentBaseDto
    {
        public int Id { get; set; }

        public GetClassDto Class { get; set; }
        public ICollection<GetAttendanceDto>? Attendances { get; set; }
        public ICollection<GetResultDto>? Results { get; set; }
    }
}
