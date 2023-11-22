using Microsoft.AspNetCore.Mvc;

public class InicioController : Controller
{

    // Otras acciones del controlador...

    // Por ejemplo, una acción para la página de Acerca de
    public IActionResult AcercaDe()
    {
        return View();
    }
}