using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_School.Application.DTOs
{
    public record ServiceResponse(bool Flag = false, string Message = null!);
}
