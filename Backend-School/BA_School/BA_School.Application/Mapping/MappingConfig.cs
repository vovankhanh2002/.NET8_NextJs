using AutoMapper;
using BA_School.Application.DTOs.Attendances;
using BA_School.Application.DTOs.Classes;
using BA_School.Application.DTOs.Lessons;
using BA_School.Application.DTOs.Results;
using BA_School.Application.DTOs.Students;
using BA_School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_School.Application.Mapping
{
    public class MappingConfig: Profile
    {
        public MappingConfig() 
        {
            {
                CreateMap<Student, GetStudentDto>();
                CreateMap<CreateStudentDto, Student>();
                CreateMap<UpdateStudentDto, Student>();

                CreateMap<Attendance, GetAttendanceDto>();
                CreateMap<CreateAttendanceDto, Attendance>();
                CreateMap<UpdateAttendanceDto, Attendance>();

                CreateMap<Result, GetResultDto>();
                CreateMap<CreateResultDto, Result>();
                CreateMap<UpdateResultDto, Result>();

                CreateMap<Class, GetClassDto>();
                CreateMap<CreateClassDto, Class>();
                CreateMap<UpdateClassDto, Class>();

                CreateMap<Lesson, GetLessonDto>();
                CreateMap<CreateLessonDto, Lesson>();
                CreateMap<UpdateLessonDto, Lesson>();
            }
        }
    }
}
