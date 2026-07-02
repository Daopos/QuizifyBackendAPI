using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizifydBackend.Domain.Models;

namespace QuizifydBackend.Application.IRepositories
{
    public interface IBlogRepo
    {
        public Task<Blog> CreateBlog(Blog blog);

        public Task<Blog?> GetBlogById(Guid id);

        public Task<IEnumerable<Blog?>> GetAllBlogs();

        public Task<Blog> UpdateBlogById(Blog blog);

        public Task<Guid> DeleteBlogById(Guid id);
    }
}
