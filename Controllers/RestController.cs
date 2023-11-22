using Microsoft.AspNetCore.Mvc; // Para Controller y otros atributos de MVC
using Microsoft.AspNetCore.Http; // Para HttpContext (para gestionar sesiones)
using Front.Models;
public class RestController : Controller
{
    [HttpPost]
    public JsonResult VerificarSesion(Usuario credenciales)
    {
        // Lógica para verificar las credenciales
        // Devuelve un JsonResult con el resultado (éxito o fallo)
        return Json(new { success = true }); 
    }
}
