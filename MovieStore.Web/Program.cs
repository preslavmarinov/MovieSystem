using Microsoft.EntityFrameworkCore;
using MovieSystem.Data.Repositories;
using MovieSystem.Data.Repositories.Interfaces;
using MovieSystem.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.AddDbContext<MovieSystemContext>(c => 
{
    c.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IDirectorService, IDirectorService>();

builder.Services.AddScoped<IDirectorRepository, DirectorRepository>();

builder.Services.AddAutoMapper(typeof(MovieSystem.Web.AutoMapper.Mapper));
builder.Services.AddAutoMapper(typeof(MovieSystem.Data.AutoMapper.Mapper));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
