using Microsoft.AspNetCore.Mvc;
using QuizifydBackend.Application.DTO.Blogs;
using QuizifydBackend.Application.IServices;

namespace QuizifydBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : Controller
    {

        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateupdateBlogDto blog)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            var newBlog = await _blogService.CreateBlog(blog);

            return Ok(newBlog);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogs()
        {

            var blogs = await _blogService.GetAllBlogs();

            return Ok(blogs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(Guid id)
        {
            var blog = await _blogService.GetBlogById(id);

            return Ok(blog);
        }
    }
}
