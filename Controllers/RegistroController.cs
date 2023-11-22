using Microsoft.AspNetCore.Mvc; // Para Controller y otros atributos de MVC
using Microsoft.AspNetCore.Http; // Para HttpContext (para gestionar sesiones)
using Front.Models;
public class RegistroController : Controller
{
    [HttpGet]
    public ActionResult Registro()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Registro(Usuario usuario)
    {
        // Lógica para guardar el usuario en la base de datos
        // Puedes usar Entity Framework u otro ORM para esto
        // Después de guardar, redirige al inicio de sesión
        return RedirectToAction("InicioSesion");
    }
}
