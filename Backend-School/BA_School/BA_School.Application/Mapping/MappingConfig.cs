using AutoMapper;
using BA_School.Application.DTOs.Attendances;
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

                CreateMap<Result, GetResultDto>();

            }
        }
    }
}
