using QuizifydBackend.Application;
using QuizifydBackend.Infrastructure;
using QuizifydBackend.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//register infrastructure dbcontext
builder.Services.AddDbContextInfra(builder.Configuration);

builder.Services.AddDIInfra();

builder.Services.AddDIApp();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/db-check", async (AppDbContext db) =>
{
    try
    {
        var canConnect = await db.Database.CanConnectAsync();
        return canConnect
            ? Results.Ok("Connected to Supabase!")
            : Results.Problem("Cannot connect to Supabase.");
    }
    catch (Exception ex)
    {
        return Results.Problem($"{ex.GetType().Name}: {ex.Message}\n{ex.InnerException?.Message}");
    }
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
