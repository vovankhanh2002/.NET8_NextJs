using BA_School.Application.DTOs.Students;
using BA_School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BA_School.Application.DTOs.Results
{
    public class GetResultDto:ResultBaseDto
    {
        [Required]
        public int Id { get; set; }
        [JsonIgnore]
        public GetStudentDto? Student { get; set; }

    }
}
