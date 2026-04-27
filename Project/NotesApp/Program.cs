var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();   // ✅ IMPORTANT

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();   // ✅ IMPORTANT

app.Run();