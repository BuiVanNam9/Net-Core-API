var builder = WebApplication.CreateBuilder(args);

// Đăng ký dịch vụ controller
builder.Services.AddControllers();

var app = builder.Build();

// Cấu hình route mặc định
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HelloWorld}/{action=Index}/{id?}"
);

// KHÔNG cần app.MapControllers() nếu đã dùng MapControllerRoute
app.Run();
