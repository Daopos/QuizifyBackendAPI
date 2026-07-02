using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifydBackend.Application.Exeption
{
    public class ConflictException : Exception
    {
        public int StatusCode => 409;
        public ConflictException(string message)
       : base(message)
        {
        }

    }
}
