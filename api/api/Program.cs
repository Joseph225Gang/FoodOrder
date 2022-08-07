using api.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
IConfiguration Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true).Build();

builder.Services.AddDbContext<FoodContext>(options =>
     options.UseSqlServer(Configuration.GetConnectionString("food")));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());

app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "assets")),
    RequestPath = "/assets",
    EnableDirectoryBrowsing = true
});


app.UseAuthorization();

app.MapControllers();


app.MapGet("/GetMainDish", (FoodContext _db) => _db.MainDishes);
app.MapGet("/GetBeverage", (FoodContext _db) => _db.Beverages);
app.MapGet("/GetDessert", (FoodContext _db) => _db.Desserts);

app.UseStaticFiles();

app.Run();

