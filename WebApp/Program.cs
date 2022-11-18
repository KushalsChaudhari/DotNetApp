var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<IInterest , SI>();

var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
