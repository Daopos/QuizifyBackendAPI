using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizifydBackend.Application.DTO.Blogs;
using QuizifydBackend.Domain.Models;

namespace QuizifydBackend.Application.IServices
{
    public interface IBlogService
    {

        public Task<Blog> CreateBlog(CreateupdateBlogDto blog);

        public Task<Blog> UpdateBlog(CreateupdateBlogDto blog);

        public Task<Guid> DeleteBlogById(Guid id);

        public Task<Blog> GetAllBlogs();

        public Task<Blog> GetBlogById(Guid id);
    }
}
