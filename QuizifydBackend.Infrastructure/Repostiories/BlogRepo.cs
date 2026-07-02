using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizifydBackend.Application.IRepositories;
using QuizifydBackend.Domain.Models;
using QuizifydBackend.Infrastructure.Data;


namespace QuizifydBackend.Infrastructure.Repostiories
{
    public class BlogRepo : IBlogRepo
    {

        private readonly AppDbContext _context;

        public BlogRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Blog> CreateBlog(Blog blog)
        {
            _context.Add(blog);
            await _context.SaveChangesAsync();

            return blog;
        }

        public async Task<Blog?> GetBlogById(Guid id)
        {
            return await _context.Blogs.SingleOrDefaultAsync(b => b.Id == id);
        }

        public async Task<IEnumerable<Blog>> GetAllBlogs()
        {
            return await _context.Blogs.ToListAsync();
        }

        public async Task<Blog> UpdateBlogById(Blog blog)
        {
            _context.Blogs.Update(blog);

            await _context.SaveChangesAsync();

            return blog;
        }

        public async Task<Guid> DeleteBlogById(Guid id)
        {
            await _context.Blogs.Where(b => b.Id == id).ExecuteDeleteAsync();

            return id;
        }

    }
}
