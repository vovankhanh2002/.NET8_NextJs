using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_School.Application.Exceptions
{
    public class ItemNotFoundException(string message) : Exception(message)
    {

    }
}
