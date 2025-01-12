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

// app.Urls.Add("http://localhost:5017");
builder.WebHost.UseUrls("http://0.0.0.0:5017");

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
       context.Database.EnsureDeleted(); 
        context.Database.EnsureCreated(); 
        DbInitializer.Initialize(context); 
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
    opt.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://127.0.0.1:3000", "http://localhost:3000");
});


app.Run();

