using QuizifydBackend.Application.Exeption;

namespace QuizifydBackend.API.Middleware
{
    public class GlobalExceptionMiddleware
    {

        private readonly RequestDelegate _next;

        public GlobalExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (CustomException ex)
            {
                context.Response.StatusCode = ex.StatusCode;
                context.Response.ContentType = "application/json";

                await context.Response.WriteAsJsonAsync(new
                {
                    error = ex.Message,
                    status = ex.StatusCode,
                });
            }
        }

    }
}
