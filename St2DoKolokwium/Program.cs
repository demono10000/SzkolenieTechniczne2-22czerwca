using Microsoft.EntityFrameworkCore;
using St2DoKolokwium.Storage;
using St2DoKolokwium.Storage.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<UserContext>
    (options => options.UseInMemoryDatabase("UserDb"));
builder.Services.AddScoped<IUserService, UserLocalService>();

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
    pattern: "{controller=User}/{action=Index}/{id?}");

app.Run();
