var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://localhost:7069");
builder.Services.AddRazorPages();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.Run();
