using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuizifydBackend.Application.Exeption
{
    public class NotFoundException : Exception
    {
        public int StatusCode => 404;
        public NotFoundException(string message)
       : base(message)
        {
        }
    }
}
