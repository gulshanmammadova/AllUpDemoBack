using Microsoft.EntityFrameworkCore;
using P133Allup.DataAccessLayer;
using P133Allup.Interfaces;
using P133Allup.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
var app = builder.Build();
builder.Services.AddScoped<IlayoutService, LayoutService>();
app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();
