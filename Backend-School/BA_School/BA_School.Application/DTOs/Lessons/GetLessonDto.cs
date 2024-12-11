using BA_School.Application.DTOs.Classes;
using BA_School.Application.DTOs.Students;
using BA_School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_School.Application.DTOs.Lessons
{
    public class GetLessonDto:LessonBaseDto
    {
        public GetStudentDto? Student { get; set; }
        public GetClassDto? Class { get; set; }
        //public GetSubjectDto? Subject { get; set; }
    }
}
