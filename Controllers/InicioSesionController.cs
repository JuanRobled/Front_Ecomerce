using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Front.Models;
using System.Threading.Tasks;
using System;

public class InicioSesionController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public InicioSesionController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet]
    public ActionResult InicioSesion()
    {
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> InicioSesion(Usuario credenciales)
    {
        try
        {
            // Puedes comentar la sección de código que realiza la llamada al servicio REST
            // y simular una verificación de sesión exitosa directamente

            //// Obtén la base address de tu aplicación
            //var baseAddress = new Uri($"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}");

            //// Crea un cliente HTTP y establece la base address
            //var httpClient = _httpClientFactory.CreateClient();
            //httpClient.BaseAddress = baseAddress;

            //// Llamada al servicio REST para verificar las credenciales
            //var respuestaServicio = await httpClient.PostAsJsonAsync("/Rest/VerificarSesion", credenciales);

            // Simular una verificación exitosa directamente
            // Comenta la sección anterior y descomenta las líneas siguientes
            // para ignorar las credenciales y siempre permitir el inicio de sesión

            //if (true) // Simpre es verdadero
            //{
                // Establece la sesión y redirige a la página de inicio
                HttpContext.Session.SetString("Nombre", credenciales.Nombre);
                return RedirectToAction("PaginaInicio", "Home");
            //}
            //else
            //{
            //    // De lo contrario, muestra un mensaje de error
            //    TempData["MensajeError"] = "Credenciales incorrectas";
            //    return RedirectToAction("PaginaInicio", "Home");
            //}
        }
        catch (Exception ex)
        {
            // Manejar la excepción según sea necesario
            TempData["MensajeError"] = "Error al procesar la solicitud";
            return RedirectToAction("InicioSesion");
        }
    }
}
