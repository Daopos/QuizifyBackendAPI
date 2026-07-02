using Microsoft.AspNetCore.Mvc;
using QuizifydBackend.Application.DTO.Blogs;
using QuizifydBackend.Application.IServices;

namespace QuizifydBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogConrtoller : Controller
    {

        private readonly IBlogService _blogService;

        public BlogConrtoller(IBlogService blogService)
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
    }
}
