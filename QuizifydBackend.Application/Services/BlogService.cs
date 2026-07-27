using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizifydBackend.Application.DTO.Blogs;
using QuizifydBackend.Application.Exeption;
using QuizifydBackend.Application.IRepositories;
using QuizifydBackend.Application.IServices;
using QuizifydBackend.Domain.Models;

namespace QuizifydBackend.Application.Services
{
    public class BlogService : IBlogService
    {

        private readonly IBlogRepo _blogRepo;
        public BlogService(IBlogRepo blogRepo)
        {
            _blogRepo = blogRepo;
        }

        public async Task<Blog> CreateBlog(CreateupdateBlogDto blog)
        {

            try
            {
                var mapBlog = new Blog
                {
                    Title = blog.Title,
                    Description = blog.Description,
                    Category = blog.Category,
                    Tags = blog.Tags
                };

                var newBlog = await _blogRepo.CreateBlog(mapBlog);

                return newBlog;

            }
            catch (Exception ex)
            {
                throw new Exception("failed to create blog", ex);
            }

        }
        public Task<Blog> UpdateBlog(CreateupdateBlogDto blog)
        {
            throw new Exception();
        }

        public Task<Guid> DeleteBlogById(Guid id)
        {
            throw new Exception();

        }

        public async Task<IEnumerable<Blog>> GetAllBlogs()
        {

            return await _blogRepo.GetAllBlogs();
        }

        public async Task<Blog?> GetBlogById(Guid id)
        {

            var blog = await _blogRepo.GetBlogById(id);

            if (blog is null)
            {
                throw new NotFoundException("No Blog Found");
            }
            return blog;

        }
    }
}
