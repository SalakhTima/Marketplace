var builder = WebApplication.CreateBuilder();

builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Products}/{action=All}/{id?}");

app.Run();
