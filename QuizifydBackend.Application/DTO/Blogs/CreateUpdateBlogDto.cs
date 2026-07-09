using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifydBackend.Application.DTO.Blogs
{
    public record CreateupdateBlogDto(string Title, string Description, string Category, string[]? Tags);
}
