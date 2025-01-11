using API.Data;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

// builder.Services.AddOpenApi();
builder.Services.AddCors();

builder.Services.AddDbContext<PortfolioContext>(opt =>{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});


// Add services to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<PortfolioContext>();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
try{
    //    context.Database.EnsureDeleted(); // 删除数据库
    //     context.Database.EnsureCreated(); // 创建数据库架构
    //     DbInitializer.Initialize(context); // 初始化数据
}
catch(Exception ex){
    logger.LogError(ex, "A problem occurred during migration");
}

app.MapGet("/projects", async () =>
{
    return await context.Projects.ToListAsync();
})
.WithName("GetProjects");

app.UseCors(opt=>{
    opt.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
});


app.Run();

