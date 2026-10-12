using Day2_MVC_EFCore_Assignment.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. إضافة الخدمات
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SchoolDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// 2. إعدادات مسار الطلب (Middleware Pipeline)
app.UseStaticFiles(); // ضروري لو هتحتاج ملفات CSS أو صور
app.UseRouting();     // تفعيل التوجيه

// هذا هو الجزء الذي كان ينقصك لتوجيه الرابط إلى الكنترولر الصحيح
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// 3. تشغيل التطبيق
app.Run();
