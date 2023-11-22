using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add HttpClient service
builder.Services.AddHttpClient("MyApiClient", client =>
{
    // Configuración del cliente HttpClient
    client.Timeout = TimeSpan.FromSeconds(30);
    // Otras configuraciones...
});

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Tiempo de inactividad de la sesión
    // Otras configuraciones...
});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie("MyCookieAuthenticationScheme", options =>
            {
            options.Cookie.Name = "MyCookie";
            options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
            });
void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{

    app.UseHttpsRedirection();

}
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.UseSession(); // Add this line to enable session

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
