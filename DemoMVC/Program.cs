var builder = WebApplication.CreateBuilder(args);

// Đăng ký dịch vụ controller + view
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Cấu hình route mặc định
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
