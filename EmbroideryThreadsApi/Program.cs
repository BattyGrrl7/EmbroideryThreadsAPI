var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// 1. Add the API Explorer service (required for minimal APIs and good practice)
builder.Services.AddEndpointsApiExplorer();

// 2. Add the Swagger generator service
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Embroidery Threads Conversion",
        Version = "v1",
        Description = "Documentation for all API endpoints."
    });
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi();
    // 1. Serves the generated Swagger JSON document (the OpenAPI specification)
    app.UseSwagger();

    // 2. Serves the Swagger UI (HTML, JS, CSS)
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
