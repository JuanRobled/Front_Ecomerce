using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Front.Models;
using Microsoft.AspNetCore.Authorization;
namespace Front.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    [Authorize(AuthenticationSchemes = "MyCookieAuthenticationScheme")]
[AllowAnonymous]
    public IActionResult PaginaInicio()
{
    // Verifica si el usuario está autenticado antes de intentar obtener el nombre
    //if (User.Identity != null && User.Identity.IsAuthenticated)
    //{
    

        return View();
    //}
    //else
    //{
        // Si el usuario no está autenticado, redirige al inicio de sesión
    //    return RedirectToAction("InicioSesion", "InicioSesion");
    //}
}


}
